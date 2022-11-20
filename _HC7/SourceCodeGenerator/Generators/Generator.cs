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
        protected abstract List<ApiItem> MultiplyObjects(IList<ApiItem> items);
        protected abstract void UpdateDefaultsForHighcharts(ApiItem apiItem);
        protected abstract List<ApiItem> GetChildrenFromBaseClasses(ApiItem item);
        protected abstract ApiItem FindApiItem(string baseClassFullName, ApiItem item);
        protected abstract ApiItem FindApiItemInTree(string baseClassFullName, IList<ApiItem> items);
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
        protected abstract void GenerateClassesForLevel(IList<ApiItem> items, int level = 0);
        protected abstract List<ApiItem> GetChildren(ApiItem item);
        protected abstract void InitEnumMappings();
        protected abstract void InitTypeMappings();
        protected abstract void InitPropertyTypeMappings();
        protected abstract void InitPropertyInitMappings();
        protected abstract void InitLists();
        protected abstract void InitSeriesMappings();
        protected abstract void InitExcludedProperties();
        protected abstract void InitCustomProperties();
        protected abstract string FirstCharToUpper(string input);
        protected abstract string FirstCharToLower(string input);
        protected abstract string GetJSName(string name, string suffix);
        protected abstract string MapDefaultValue(ApiItem item);
    }
}
