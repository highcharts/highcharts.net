using SourceCodeGenerator.Parser;
using SourceCodeGenerator.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Generators
{
    public abstract class Generator
    {
        protected const int PROPERTY_NESTED_LEVELS = 10; // currently max levels of nested properties is five

        protected abstract string RootClass { get; }

        protected List<ApiItem> _apiItems; // json api mappings will be stored here
        protected List<ApiItem> _previousVersionApiItems;
        protected StreamWriter _log; // general debug related txt log file
        protected Hashtable _typeMappings; // maps HighChart types to C# types, where possible
        protected Hashtable _propertyTypeMappings; // maps properties that need special type not reflected in the JSON
        protected Hashtable _propertyInitMappings; // maps properties that needs special initialization logic
        protected Hashtable _enumMappings; // maps enums values that do not complile (e.g. special characters like "-" or "/" to other types
        protected Hashtable _seriesMappings; // maps series names to series classes
        protected List<string> _lists; // a list of all List<T> properties - needs this to "Hashify" them, otherwise they will be serialized with capital letters
        protected List<string> _excludedProperties; // properties that do not need to be ported to the server-side wrapper
        protected List<string> _customProperties; // properties that need custom JSON mappings (Animation, Shadow, etc). Defined in the CodeAddOns folder.

        protected bool IsNETStandard;

        protected IJsonParser JsonParser { get; set; }
        protected IJsonParser PreviousVersionJsonParser { get; set; }
        protected IFileService FileService { get; set; }
        protected IMultiplicationService MultiplicationService { get; set; }
        protected IComparisonService ComparisonService { get; set; }

        public Generator(IJsonParser jsonParser, IJsonParser previousVersionJsonParser, IFileService fileService, IMultiplicationService multiplicationService, IComparisonService comparisonService)
        {
            _apiItems = new List<ApiItem>();
            _previousVersionApiItems = new List<ApiItem>();
            _typeMappings = new Hashtable();
            _propertyTypeMappings = new Hashtable();
            _propertyInitMappings = new Hashtable();
            _seriesMappings = new Hashtable();
            _enumMappings = new Hashtable();
            _excludedProperties = new List<string>();
            _customProperties = new List<string>();
            _lists = new List<string>();

            JsonParser = jsonParser;
            PreviousVersionJsonParser = previousVersionJsonParser;
            FileService = fileService;
            MultiplicationService = multiplicationService;
            ComparisonService = comparisonService;

            InitTypeMappings();
            InitPropertyTypeMappings();
            InitPropertyInitMappings();
            InitExcludedProperties();
            InitEnumMappings();
            InitCustomProperties();
            InitSeriesMappings();
            InitLists();
        }

        public abstract void GenerateCode(bool isNETStandard);
        protected abstract void ProcessApiItems(IList<ApiItem> items);
        protected List<ApiItem> MultiplyObjects(IList<ApiItem> items)
        {
            var apiClones = new List<ApiItem>();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].FullName.Contains("pointPlacement"))
                {
                    apiClones.Add(items[i]);
                    continue;
                }

                var clones = MultiplicationService.MultiplyObject(items[i]);

                if (clones.Any())
                    apiClones.AddRange(clones);
                else
                {
                    apiClones.Add(items[i]);

                    if (items[i].Children.Any())
                    {
                        var last = apiClones.Last();
                        last.Children = MultiplyObjects(items[i].Children);
                    }
                }
            }

            return apiClones;
        }
        protected abstract void UpdateDefaultsForHighcharts(ApiItem apiItem);
        protected List<ApiItem> GetChildrenFromBaseClasses(ApiItem item)
        {
            if (item == null)
                return new List<ApiItem>();

            var addedChildren = new List<ApiItem>();
            var finalChildren = new List<ApiItem>();

            foreach (var baseClassFullName in item?.Extends)
            {
                var baseClass = FindApiItem(baseClassFullName, item);

                //children for base class are not yet generated
                if (baseClass == null)
                {
                    List<string> parts = baseClassFullName.Split('.').ToList();
                    var baseClassTitle = parts[parts.Count - 1];
                    parts.RemoveAt(parts.Count - 1);
                    var baseClassParentFullName = string.Join(".", parts);
                    var baseClassParent = FindApiItem(baseClassParentFullName, item.Parent);

                    var baseClassParentChildren = GetChildrenFromBaseClasses(baseClassParent);
                    baseClass = baseClassParentChildren.Where(p => p.Title == baseClassTitle).FirstOrDefault();

                    if (baseClass == null)
                        return addedChildren;
                }

                

                //it's possible that next line may be needed (requires changes)
                //addedChildren.Where(p => baseClass.Children.Any(q => q.Title == p.Title)).ToList().ForEach(e => e.Children.AddRange(GetChildren(baseClass.Children.First(s => s.Title == e.Title)).Where(o => !e.Children.Any(u => o.Title == u.Title))));
                var childrenWithoutMerged = baseClass.Children.Where(p => !addedChildren.Any(q => q.Title == p.Title)).ToList();
                var baseClassChildrenToUseToOverride = baseClass.Children.Where(p => addedChildren.Any(q => q.Title == p.Title)).ToList();
                //tutaj powinna znajdować się pętla z GetChildren

                foreach (var baseElement in baseClassChildrenToUseToOverride)
                {
                    var child = item.Children.FirstOrDefault(p => p.Title == baseElement.Title);

                    if (child != null)
                    {
                        foreach (var element in baseElement.Children.Where(p => !child.Children.Any(x => x.Title == p.Title)).ToList())
                        {
                            var clone = element.Clone();
                            clone.ParentFullName = child.FullName;
                            clone.FullName = clone.ParentFullName + '.' + clone.Title;


                            //child.Children.Add(clone);
                            finalChildren.RemoveAll(p => p.Title == baseElement.Title);
                            addedChildren.Add(child);
                        }
                    }
                }

                if (baseClass.Extends.Any())
                    addedChildren.AddRange(GetChildrenFromBaseClasses(baseClass).Where(p => !baseClass.Exclude.Any(q => q == p.Title)));


                if (baseClass.FullName == "series")
                    addedChildren.AddRange(childrenWithoutMerged.Where(p => !p.Extends.Any(q => q == "series")));
                else
                    addedChildren.AddRange(childrenWithoutMerged);

                addedChildren = addedChildren.Where(p => !item.Exclude.Any(q => q == p.Title)).ToList();

                //var existingChildrenFromEarlierBaseClass = addedChildren.Where(p => !finalChildren.Any(q => q.Title ==  p.Title)).ToList();





                finalChildren.AddRange(addedChildren);
                addedChildren.Clear();
            }

            return finalChildren;
        }
        protected ApiItem FindApiItem(string baseClassFullName, ApiItem item)
        {
            if (item?.Parent != null)
            {
                if (item.Parent.FullName == baseClassFullName)
                    return item.Parent;

                var apiItem = item.Parent.Children.FirstOrDefault(p => p.FullName == baseClassFullName);

                if (apiItem != null)
                    return apiItem;
            }

            return FindApiItemInTree(baseClassFullName, _apiItems);
        }

        protected ApiItem FindApiItemInTree(string baseClassFullName, IList<ApiItem> items)
        {
            foreach (var item in items)
            {
                if (item.FullName == baseClassFullName)
                    return item;

                if (item.Children.Any())
                {
                    var result = FindApiItemInTree(baseClassFullName, item.Children);
                    if (result != null)
                        return result;
                }
            }

            return null;
        }

        protected abstract void GenerateClass(ApiItem item, List<ApiItem> children);
        protected abstract void GenerateEnum(ApiItem apiItem);
        protected abstract void AddDefaultsToEnum(ApiItem apiItem);
        protected abstract string GetDefaultValueForEnum(ApiItem item);
        protected abstract string GetClassNameFromItem(ApiItem item);
        protected abstract string GetPropertyName(ApiItem item);
        protected abstract string FormatProperty(string propertyTemplate, ApiItem child);
        protected abstract string GetPropertyReturnType(ApiItem child, string propertyName);
        protected abstract string FormatDefaultProperty(string propertyName, ApiItem child);
        protected abstract string FormatPropertyComparer(string propertyName, ApiItem child);
        protected void GenerateClassesForLevel(IList<ApiItem> items, int level = 0)
        {
            foreach (ApiItem item in items)
            {
                if (item.Children.Any() || item.Extends.Any())
                {
                    var children = GetChildren(item);

                    if (item.ParentFullName != null && item.ParentFullName.EndsWith("levels") && item.Title == "dataLabels")
                        continue;

                    if (item.FullName == "series")
                    {
                        var seriesChildren = item.Children.Where(p => !item.Exclude.Any(q => q == p.Title) && !p.Extends.Any(q => q == "series")).ToList();
                        GenerateClass(item, seriesChildren);
                    }
                    else
                        GenerateClass(item, children);

                    GenerateClassesForLevel(children, level + 1);
                }
            }
        }
        protected List<ApiItem> GetChildren(ApiItem item)
        {
            List<ApiItem> children;
            List<ApiItem> clones = new List<ApiItem>();

            if (item.Title == RootClass)
                children = _apiItems;
            else
            {
                children = item.Children.ToList();

                if (item.Extends.Any())
                {
                    var baseChildren = GetChildrenFromBaseClasses(item);


                    //podobna pętla (zamieniona na funkcję) powinna znajdować się w GetChildrenFromBaseClasses
                    foreach (var baseElement in baseChildren.Where(p => children.Any(x => x.Title == p.Title)))
                    {
                        var child = children.FirstOrDefault(p => p.Title == baseElement.Title);

                        if (child != null)
                        {
                            foreach (var element in baseElement.Children.Where(p => !child.Children.Any(x => x.Title == p.Title)).ToList())
                            {
                                var clone = element.Clone();
                                clone.ParentFullName = child.FullName;
                                clone.FullName = clone.ParentFullName + '.' + clone.Title;
                                child.Children.Add(clone);
                            }
                        }
                    }

                    children.AddRange(baseChildren.Where(p => !children.Any(x => x.Title == p.Title && (x.Suffix == p.Suffix || (string.IsNullOrEmpty(x.Suffix) && string.IsNullOrEmpty(p.Suffix))))));
                }
            }

            foreach (var child in children)
            {
                var clone = child.Clone();
                clone.Parent = item;
                clone.FullName = item.FullName + "." + child.Title;

                //ignored for multitypes
                var multipliedClones = MultiplicationService.MultiplyObject(clone);
                if (multipliedClones.Any() && !clone.FullName.Contains("pointPlacement"))
                    clones.AddRange(multipliedClones);
                else
                    clones.Add(clone);
            }

            return clones.OrderBy(p => p.Title).ToList();
        }
        protected abstract void InitEnumMappings();
        protected abstract void InitTypeMappings();
        protected abstract void InitPropertyTypeMappings();
        protected abstract void InitPropertyInitMappings();
        protected abstract void InitLists();
        protected abstract void InitSeriesMappings();
        protected abstract void InitExcludedProperties();
        protected abstract void InitCustomProperties();
        protected string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("String is empty");

            return input.First().ToString().ToUpper() + input.Substring(1);
        }
        protected string FirstCharToLower(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("String is empty");

            return input.First().ToString().ToLower() + input.Substring(1);
        }
        protected string GetJSName(string name, string suffix)
        {
            if (string.IsNullOrEmpty(suffix))
                return FirstCharToLower(name);

            return FirstCharToLower(name.Replace(suffix, ""));
        }
        protected abstract string MapDefaultValue(ApiItem item);
    }
}
