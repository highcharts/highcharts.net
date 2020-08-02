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
        private IJsonUpdateService UpdateService { get; set; }
        private ITypeService TypeService { get; set; }
        public IList<ApiItem> Items { get; private set; }

        public JsonParser(string product, IFileService fileService, IFilterService filterService, IJsonUpdateService updateService, ITypeService typeService)
        {
            Items = new List<ApiItem>();

            Product = product;
            FileService = fileService;
            FilterService = filterService;
            UpdateService = updateService;
            TypeService = typeService;
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

                if (string.IsNullOrEmpty(apiItem.Defaults))
                {
                    JToken jDefault = meta.SelectToken("default", false);
                    if (jDefault != null)
                        apiItem.Defaults = jDefault.Value<string>();

                    if (apiItem.Defaults == "False" || apiItem.Defaults == "True")
                        apiItem.Defaults = apiItem.Defaults.First().ToString().ToLower() + apiItem.Defaults.Substring(1);
                }
            }

            if (string.IsNullOrWhiteSpace(apiItem.FullName))
                if (!string.IsNullOrWhiteSpace(apiItem.ParentFullName))
                    apiItem.FullName = apiItem.ParentFullName + "." + apiItem.Title;
                else
                    apiItem.FullName = apiItem.Title;

            UpdateService.UpdateProducts(apiItem);

            if (!apiItem.Products.Contains(Product) && apiItem.Products.Any())
                return;

            //Modification area

            if (FilterService.IsItemIgnored(apiItem.FullName))
                return;

            if (FilterService.IsValuesPropertyIgnored(apiItem.FullName))
                apiItem.Values.Clear();

            //remove this condition if bug in json will be fixed
            if (apiItem.FullName.StartsWith("plotOptions.column.marker"))
                return;

            //temp solution- only for 7.1.1 version
            //if (apiItem.FullName.Contains("plotOptions.series.dataLabels") && !apiItem.Children.Any())
            //{
            //    apiItem.Children.Add(new ApiItem { FullName= "plotOptions.series.dataLabels.align", Title = "align", Values = new List<string> { "left", "center", "right"}, Types = new List<string> {"String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.allowOverlap", Title = "allowOverlap", Defaults = "false", Types = new List<string> { "Boolean" }, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.backgroundColor", Title = "backgroundColor", Defaults = "", Values = new List<string> { }, Types = new List<string> { "String"}, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.borderColor", Title = "borderColor", Types = new List<string> { "String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.borderRadius", Title = "borderRadius", Defaults = "0", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.borderWidth", Title = "borderWidth", Defaults = "0", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.className", Title = "className", Types = new List<string> { "String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.color", Title = "color", Types = new List<string> { "String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.crop", Title = "crop", Defaults = "true",  Types = new List<string> { "Boolean" }, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.defer", Title = "defer", Defaults = "true", Types = new List<string> { "Boolean" }, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.enabled", Title = "enabled", Defaults = "false", Types = new List<string> { "Boolean" }, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem
            //    {
            //        FullName = "plotOptions.series.dataLabels.filter",
            //        Title = "filter", Types = new List<string> { "*" }, ReturnType = "*", Children = new List<ApiItem>
            //    {
            //        new ApiItem{ FullName= "plotOptions.series.dataLabels.filter.operator", Title = "operator", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true },
            //        new ApiItem{ FullName= "plotOptions.series.dataLabels.filter.property", Title = "property", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true  },
            //        new ApiItem{ FullName= "plotOptions.series.dataLabels.filter.value", Title = "value", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true  }
            //    },
            //        IsParent = true
            //    });

            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.format", Title = "format", Types = new List<string> { "String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.formatter", Title = "formatter", Types = new List<string> { "function" }, ReturnType = "function", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.inside", Title = "inside", Types = new List<string> { "Boolean"}, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.overflow", Title = "overflow", Defaults = "justify", Values = new List<string> { "allow", "justify"}, Types = new List<string> {"String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.padding", Title = "padding", Defaults = "0", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.rotation", Title = "rotation", Defaults = "0", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.shadow", Title = "shadow", Defaults = "false", Types = new List<string> { "Boolean" }, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.shape", Title = "shape", Defaults = "square", Types = new List<string> { "String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem
            //    {
            //        FullName = "plotOptions.series.dataLabels.style",
            //        Defaults = "{\"color\": \"contrast\", \"fontSize\": \"11px\", \"fontWeight\": \"bold\", \"textOutline\": \"1px contrast\" }",
            //        Title = "style",
            //        Types = new List<string> { "Object" },
            //        ReturnType = "Object",
            //        Children = new List<ApiItem>
            //    {
            //        new ApiItem { FullName = "plotOptions.series.dataLabels.style.color", Title = "color", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true  },
            //        new ApiItem { FullName = "plotOptions.series.dataLabels.style.fontSize", Title = "fontSize", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true  },
            //        new ApiItem { FullName = "plotOptions.series.dataLabels.style.fontWeight", Title = "fontWeight", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true  },
            //        new ApiItem { FullName = "plotOptions.series.dataLabels.style.textOutline", Title = "textOutline", Types = new List<string>{ "String" }, ReturnType = "String", IsParent = true  }
            //    }
            //    });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.useHTML", Title = "useHTML", Defaults = "false", Types = new List<string> { "Boolean" }, ReturnType = "Boolean", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.verticalAlign", Title = "verticalAlign", Values = new List<string> { "top", "middle", "bottom" }, Types = new List<string> { "String" }, ReturnType = "String", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.x", Title = "x", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.y", Title = "y", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //    apiItem.Children.Add(new ApiItem { FullName = "plotOptions.series.dataLabels.zIndex", Title = "zIndex", Defaults = "6", Types = new List<string> { "Number" }, ReturnType = "Number", IsParent = true });
            //}

            UpdateService.UpdateCSSObject(apiItem);
            UpdateService.Update(apiItem);

            TypeService.SetReturnType(apiItem);

            //if (apiItem.FullName.Equals("series.funnel3d.data") || apiItem.FullName.Equals("series.pyramid3d.data"))
            //    apiItem.Extends.Clear();




            ////////////////////////end of modification area

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

                //Remove garbage without the name of the element
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
