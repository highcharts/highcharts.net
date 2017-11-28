using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodeGenerator.Services;



namespace SourceCodeGenerator.Parser
{
    public class JsonParser : IJsonParser
    {
        private string Product { get; set; }
        private IFileService FileService { get; set; }
        public IList<ApiItem> Items { get; private set; }

        public JsonParser(string product, IFileService fileService)
        {
            Items = new List<ApiItem>();

            Product = product;
            FileService = fileService;
        }

        public List<ApiItem> Get()
        {
            GetObjectFromJsonFile();
            ProcessObjects();

            return Items.ToList();
        }

        private void GetObjectFromJsonFile()
        {
            JObject jObject = JObject.Parse(FileService.GetJsonContent());

            foreach (var item in jObject.Properties())
            {
                if (string.IsNullOrWhiteSpace(item.Name) || item.Name == "_meta")
                    continue;

                //usunąć tego if'a
                //if(item.Name == "plotOptions")
                    CreateApiItem(item.Name, item.Value);
            }
        }

        private void ProcessObjects()
        {
            int index = 0;
            var item = Items[index];
            bool isAnyExtendsToDo = false;
            while (true)
            {
                item.Extends.Remove(item.FullName);

                List<string> extendsTmpList = new List<string>(item.Extends.Select(p => string.Copy(p)));

                foreach (var extends in extendsTmpList)
                {
                    var sourceItem = Items.Where(p => p.FullName == extends)?.FirstOrDefault();

                    //it's missing or not generated yet
                    if (sourceItem == null)
                        continue;

                    if (sourceItem.Extends.Any())
                    {
                        isAnyExtendsToDo = true;
                        continue;
                    }

                    CopyObjects(item, sourceItem);
                    item.Extends.Remove(extends);
                }

                if (index == Items.Count - 1)
                {
                    if(isAnyExtendsToDo)
                    {
                        isAnyExtendsToDo = false;
                        index = 0;
                        item = Items[index];
                        continue;
                    }

                    break;
                }

                item = Items[++index];
            }

            Console.WriteLine("Items.Count = " + Items.Count);
        }

        private void CopyObjects(ApiItem item, ApiItem sourceItem)
        {
            var itemsToCopy = Items.Where(p => p.FullName.StartsWith(sourceItem.FullName + ".") &&
            !item.Exclude.Any(q => 
            {
                var name = p.FullName.Replace(sourceItem.FullName + ".","");
                return q == name.Split('.')[0];
            })).ToList();

            int counter = 0;
            if (sourceItem.FullName == "series")
            {
                var itemsToRemove = itemsToCopy.Where(p => p.Extends.Contains("series")).ToList();
                                
                foreach(var removeItem in itemsToRemove)
                    itemsToCopy.RemoveAll(p => p.FullName.StartsWith(removeItem.FullName));
            }

            foreach (var copy in itemsToCopy)
            {
                var newItem = copy.Clone();

                newItem.Parent = item.FullName;
                newItem.FullName = item.FullName + "." + copy.FullName.Replace(sourceItem.FullName + ".", "");

                Items.Add(newItem);

                //Console.WriteLine(newItem.FullName);
            }
        }

        private void CreateApiItem(string name, JToken item, bool isParent = false, string parent = null)
        {
            ApiItem apiItem = new ApiItem();
            apiItem.IsParent = isParent;
            apiItem.Parent = parent;
            apiItem.Title = name;

            //przenieść to niżej - doclet powinien być pierwszy ze względu na products
            JToken meta = item.SelectToken("meta", false);
            if (meta != null)
            {
                JToken jFullname = meta.SelectToken("fullname", false);
                if (jFullname != null)
                    apiItem.FullName = jFullname.Value<string>();

                JToken jName = meta.SelectToken("name", false);
                if (jName != null)
                    apiItem.Title = jName.Value<string>();

                JToken jDefault = meta.SelectToken("default", false);
                if (jDefault != null)
                    apiItem.Defaults = jDefault.Value<string>();
            }

            if (string.IsNullOrWhiteSpace(apiItem.FullName))
                if (!string.IsNullOrWhiteSpace(apiItem.Parent))
                    apiItem.FullName = apiItem.Parent + "." + apiItem.Title;
                else
                    apiItem.FullName = apiItem.Title;


            JToken doclet = item.SelectToken("doclet", false);
            if (doclet != null)
            {
                JToken jProducts = doclet.SelectToken("products", false);
                if (jProducts != null)
                    apiItem.Products = jProducts.Select(t => (string)t).ToList();

                if (!apiItem.Products.Contains(Product) && apiItem.Products.Any())
                    return;

                JToken jDescription = doclet.SelectToken("description", false);
                if (jDescription != null)
                    apiItem.Description = jDescription.Value<string>();
                
                JToken jExtends = doclet.SelectToken("extends", false);
                if (jExtends != null)
                {
                    apiItem.Extends = jExtends.Value<string>().Replace("{", "").Replace("}", "").Split(',').ToList();

                    //if (apiItem.Extends.Contains("series"))
                    //    apiItem.Extends.Remove("series");
                }

                JToken jSince = doclet.SelectToken("since", false);
                if (jSince != null)
                    apiItem.Since = jSince.Value<string>();

                JToken jDeprecated = doclet.SelectToken("deprecated", false);
                if (jDeprecated != null)
                    apiItem.Deprecated = jDeprecated.Value<bool>();

                JToken jDefault = doclet.SelectToken("defaultvalue", false);
                if (jDefault != null)
                    apiItem.Defaults = jDefault.Value<string>();

                JToken jExclude = doclet.SelectToken("exclude", false);
                if (jExclude != null)
                    apiItem.Exclude = jExclude.Select(t => (string)t).ToList();

                JToken jType = doclet.SelectToken("type", false);
                if (jType != null)
                {
                    JToken jNames = jType.SelectToken("names");
                    apiItem.Types = jNames.Select(t => (string)t).ToList();

                    //tylko testowo
                    apiItem.ReturnType = apiItem.Types[0];
                }
            }

            

            Items.Add(apiItem);
            //Console.WriteLine(apiItem.Title + ": "+apiItem.FullName);

            JToken children = item.SelectToken("children", false);
            if (children == null)
                return;

            if(children.Any())
                apiItem.HasChildren = true;

            foreach (var child in children)
            {
                var childName = ((JProperty)child).Name;

                //Remove garbage without a name of the element
                if (string.IsNullOrWhiteSpace(childName))
                    continue;

                CreateApiItem(childName, child.First, true, apiItem.FullName);
            }
        }
    }
}
