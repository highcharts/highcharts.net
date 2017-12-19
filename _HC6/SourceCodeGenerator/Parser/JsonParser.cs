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
        private IFilterService FilterService { get; set; }
        public IList<ApiItem> Items { get; private set; }

        public JsonParser(string product, IFileService fileService, IFilterService filterService)
        {
            Items = new List<ApiItem>();

            Product = product;
            FileService = fileService;
            FilterService = filterService;
        }

        public List<ApiItem> Get()
        {
            GetObjectFromJsonFile();
            return Items.ToList();
        }

        private void GetObjectFromJsonFile()
        {
            JObject jObject = JObject.Parse(FileService.GetJsonContent());

            foreach (var item in jObject.Properties())
            {
                if (string.IsNullOrWhiteSpace(item.Name) || item.Name == "_meta")
                    continue;

                CreateApiItem(item.Name, item.Value);
            }
        }

        private void CreateApiItem(string name, JToken item, bool isParent = false, ApiItem parent = null)
        {
            ApiItem apiItem = new ApiItem();
            apiItem.IsParent = isParent;
            apiItem.ParentFullName = parent?.FullName;
            apiItem.Parent = parent;
            apiItem.Title = name;

            JToken doclet = item.SelectToken("doclet", false);
            if (doclet != null)
            {
                JToken jProducts = doclet.SelectToken("products", false);
                if (jProducts != null)
                    apiItem.Products = jProducts.Select(t => (string)t).ToList();

                //pattern for products: products = parentProducts + (existingProducts - parentProducts)
                if (apiItem.Parent != null)
                {
                    apiItem.Parent.Products.ForEach(p => apiItem.Products.Remove(p));
                    apiItem.Products.AddRange(apiItem.Parent.Products);
                }

                if (!apiItem.Products.Contains(Product) && apiItem.Products.Any())
                    return;

                JToken jDescription = doclet.SelectToken("description", false);
                if (jDescription != null)
                    apiItem.Description = jDescription.Value<string>();

                JToken jExtends = doclet.SelectToken("extends", false);
                if (jExtends != null)
                    apiItem.Extends = jExtends.Value<string>().Replace("{", "").Replace("}", "").Split(',').ToList();

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

                JToken jValues = doclet.SelectToken("values", false);
                if (jValues != null)
                    apiItem.Values = GetValues(jValues.Value<string>());

                JToken jType = doclet.SelectToken("type", false);
                if (jType != null)
                {
                    JToken jNames = jType.SelectToken("names");
                    apiItem.Types = jNames.Select(t => (string)t).ToList();

                    //tylko testowo
                    apiItem.ReturnType = apiItem.Types[0];
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

            if (string.IsNullOrWhiteSpace(apiItem.FullName))
                if (!string.IsNullOrWhiteSpace(apiItem.ParentFullName))
                    apiItem.FullName = apiItem.ParentFullName + "." + apiItem.Title;
                else
                    apiItem.FullName = apiItem.Title;

            if (FilterService.IsItemIgnored(apiItem.FullName))
                return;

            if (FilterService.IsValuesPropertyIgnored(apiItem.FullName))
                apiItem.Values.Clear();

            //remove this condition if bug in json will be fixed
            if (apiItem.FullName.StartsWith("plotOptions.column.marker"))
                return;

            if (parent == null)
                Items.Add(apiItem);
            else
                parent.Children.Add(apiItem);

            JToken children = item.SelectToken("children", false);
            if (children == null)
                return;

            foreach (var child in children)
            {
                var childName = ((JProperty)child).Name;

                //Remove garbage without a name of the element
                if (string.IsNullOrWhiteSpace(childName))
                    continue;

                CreateApiItem(childName, child.First, true, apiItem);
            }
        }

        public List<string> GetValues(string values)
        {
            List<string> result = new List<string>();

            if (string.IsNullOrWhiteSpace(values))
                return result;

            var tab = values.Remove(values.Length - 1, 1).Remove(0, 1).Replace("\"", string.Empty).Replace("\r", string.Empty).Replace("\n", string.Empty).Replace(" ", string.Empty).Replace("-", "_").Split(',');

            foreach (var t in tab)
                result.Add(t);

            return result;
        }
    }
}
