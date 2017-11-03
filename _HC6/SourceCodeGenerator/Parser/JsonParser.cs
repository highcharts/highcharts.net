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
        public JsonParser(string product)
        {
            Product = product;
        }

        public JsonParser(string product, string jsonFilePath)
        {
            Items = new List<ApiItem>();

            Product = product;
            JsonFilePath = jsonFilePath;
        }

        //public void GetJsonObjects()
        //{
        //    var objects = GetObjectFromJsonFile();

        //    //foreach (Dictionary<string, object> item in objects)
        //    //{
        //    //    ApiItem apiItem = new ApiItem(item);
        //    //    Items.Add(apiItem);
        //    //}
        //}

        public void GetObjectFromJsonFile()
        {
            JObject jObject = JObject.Parse(File.ReadAllText(JsonFilePath));

            foreach(var item in jObject.Properties())
            {
                if (string.IsNullOrWhiteSpace(item.Name) || item.Name == "_meta")
                    continue;

                CreateApiItem(item.Name, item.Value);
                Console.WriteLine(item.Name);


            }
        }

        private void CreateApiItem(string name, JToken item, bool isParent = false, string parent = "")
        {
            ApiItem apiItem = new ApiItem();
            apiItem.IsParent = isParent;
            apiItem.Parent = parent;
            apiItem.Title = name;

            JToken meta = item.SelectToken("meta", false);
            if(meta != null)
            {
                JToken jFullname = meta.SelectToken("fullname", false);
                if(jFullname != null)
                    apiItem.FullName = jFullname.Value<string>();

                JToken jName = meta.SelectToken("name", false);
                if(jName != null)
                    apiItem.Title = jName.Value<string>();

                JToken jDefault = meta.SelectToken("default", false);
                if(jDefault != null)
                    apiItem.Defaults = jDefault.Value<string>();
            }

            JToken doclet = item.SelectToken("doclet", false);
            if(doclet != null)
            {
                JToken jDescription = doclet.SelectToken("description", false);
                if (jDescription != null)
                    apiItem.Description = jDescription.Value<string>();

                JToken jExtends = meta.SelectToken("extends", false);
                if (jExtends != null)
                    apiItem.Extends = jExtends.Value<string>();

                JToken jSince = meta.SelectToken("since", false);
                if (jSince != null)
                    apiItem.Since = jSince.Value<string>();

                JToken jDeprecated = doclet.SelectToken("deprecated", false);
                if (jDeprecated != null)
                    apiItem.Deprecated = jDeprecated.Value<bool>();

                JToken jDefault = doclet.SelectToken("defaultvalue", false);
                if (jDefault != null)
                    apiItem.Defaults = jDefault.Value<string>();

                JToken jProducts = doclet.SelectToken("products", false);
                if (jProducts != null)
                    apiItem.Products = jProducts.Select(t => (string)t).ToList();

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

            if (apiItem.FullName == null)
            {
                int c = 7;
            }


            Items.Add(apiItem);
            Console.WriteLine(apiItem.Title + ": "+apiItem.FullName);

            JToken children = item.SelectToken("children", false);
            if (children == null)
                return;

            foreach (var child in children)
            {
                var childName = ((JProperty)child).Name;
                CreateApiItem(childName, child.First, true, apiItem.FullName);
            }
        }
    }
}
