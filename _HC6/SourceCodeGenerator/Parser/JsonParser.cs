using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace SourceCodeGenerator.Parser
{
    public class JsonParser
    {
        private string Product { get; set; }
        private string JsonFilePath { get; set; }
        public List<ApiItem> Items { get; private set; }

        public long missing { get; set; }
        public JsonParser(string product)
        {
            Product = product;
        }

        public JsonParser(string product, string jsonFilePath)
        {
            Items = new List<ApiItem>();

            Product = product;
            JsonFilePath = jsonFilePath;

            missing = 0;
        }

        public void GetObjectFromJsonFile()
        {
            JObject jObject = JObject.Parse(File.ReadAllText(JsonFilePath));

            foreach(var item in jObject.Properties())
            {
                if (string.IsNullOrWhiteSpace(item.Name) || item.Name == "_meta")
                    continue;

                CreateApiItem(item.Name, item.Value);
                //Console.WriteLine(item.Name);


            }

            //Console.WriteLine("Missing = " + missing);
            //Console.WriteLine("Items counter = " + Items.Count);
        }

        public void ProcessObjects()
        {
            
            int index = 0;
            var item = Items[index];
            while (true)
            {
                if (!string.IsNullOrWhiteSpace(item.Extends))
                {
                    IEnumerable<string> extendsTbl = item.Extends.Split(',').ToList();

                    foreach (var extends in extendsTbl)
                    {
                        var sourceItem = Items.Where(p => p.FullName == extends)?.FirstOrDefault();

                        if (sourceItem == null)
                            throw new Exception($"Missing item: {extends}");

                        if (!string.IsNullOrWhiteSpace(sourceItem.Extends))
                        {
                            item = sourceItem;
                            continue;
                        }

                        CopyObjects(item, sourceItem);
                        RemoveExtends(item, extends);
                    }
                }

                if (index == Items.Count - 1)
                    break;

                item = Items[++index];
            }
        }

        public void RemoveExtends(ApiItem item, string extends)
        {
            item.Extends = item.Extends.Replace(extends, "");

            if (string.IsNullOrEmpty(item.Extends))
                return;

            item.Extends.Replace(",,", ",");

            if (item.Extends.StartsWith(","))
                item.Extends.Remove(0, 1);

            if (item.Extends.EndsWith(","))
                item.Extends.Remove(item.Extends.Length - 1);
        }

        private void CopyObjects(ApiItem item, ApiItem sourceItem)
        {
            
            var itemsToCopy = Items.Where(p => p.FullName.StartsWith(sourceItem.FullName) && p.FullName.Length > sourceItem.FullName.Length && !item.Exclude.Any(q => q == p.Title)).ToList();
            //Console.WriteLine($"--------------------{itemsToCopy.Count}----------------------------");
            //Console.ReadLine();


            foreach (var copy in itemsToCopy)
            {
                var newItem = copy.Clone();

                newItem.Parent = item.FullName;
                newItem.FullName = item.FullName + "." + copy.Title;

                Items.Add(newItem);

                Console.WriteLine(newItem.FullName);
            }
        }

        private void CreateApiItem(string name, JToken item, bool isParent = false, string parent = "")
        {
            ApiItem apiItem = new ApiItem();
            apiItem.IsParent = isParent;
            apiItem.Parent = parent;
            apiItem.Title = name;

            JToken doclet = item.SelectToken("doclet", false);
            if(doclet != null)
            {
                JToken jProducts = doclet.SelectToken("products", false);
                if (jProducts != null)
                    apiItem.Products = jProducts.Select(t => (string)t).ToList();

                if (!apiItem.Products.Contains(Product) && apiItem.Products.Any())
                    return;

                JToken jDescription = doclet.SelectToken("description", false);
                if (jDescription != null)
                    apiItem.Description = jDescription.Value<string>();



                //Make extend IList<string> i poprawić poniższą logikę
                JToken jExtends = doclet.SelectToken("extends", false);
                if (jExtends != null)
                    apiItem.Extends = jExtends.Value<string>().Replace("{","").Replace("}","").Replace("series","").Replace(",,",",");

                if (!string.IsNullOrWhiteSpace(apiItem.Extends))
                {
                    if (apiItem.Extends.StartsWith(","))
                        apiItem.Extends.Remove(0, 1);

                    if (apiItem.Extends.EndsWith(","))
                        apiItem.Extends.Remove(apiItem.Extends.Length - 1);
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
                }
            }

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


            //if (apiItem.Products != null && !apiItem.Products.Any(p => p == Product))
            //    return;

            if (apiItem.FullName == null)
            {
                missing++;
            }

            if (string.IsNullOrWhiteSpace(apiItem.FullName))
                if (!string.IsNullOrWhiteSpace(apiItem.Parent))
                    apiItem.FullName = apiItem.Parent + "." + apiItem.Title;
                else
                    apiItem.FullName = apiItem.Title;

            Items.Add(apiItem);
            //Console.WriteLine(apiItem.Title + ": "+apiItem.FullName);

            JToken children = item.SelectToken("children", false);
            if (children == null)
                return;

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
