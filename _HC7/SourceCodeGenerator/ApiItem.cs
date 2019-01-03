using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Script.Serialization;

public class ApiItem
{

    public string FullName { get; set; }
    public string Title { get; set; }
    public string ParentFullName { get; set; }
    public bool IsParent { get; set; }
    public string ReturnType { get; set; }

    public string Description { get; set; }
    public string Defaults { get; set; }
    public IList<string> Values { get; set; }
    public bool Deprecated { get; set; }
    public List<string> Products { get; set; }
    public IList<string> Types { get; set; }
    public IList<string> Extends { get; set; }
    public IList<string> Exclude { get; set; }
    public string Since { get; set; }
    public IList<ApiItem> Children { get; set; }
    public ApiItem Parent { get; set; }
    public string Suffix { get; set; }

    public ApiItem()
    {
        ParentFullName = null;
        ReturnType = string.Empty;
        Description = string.Empty;
        Values = new List<string>();
        Products = new List<string>();
        Types = new List<string>();
        Extends = new List<string>();
        Exclude = new List<string>();
        Children = new List<ApiItem>();
        Parent = null;
    }

    //public ApiItem(Dictionary<string, object> item)
    //    : this()
    //{
    //    object outValue;
    //    List<string> parents = new List<string>();

    //    if (item.TryGetValue("parent", out outValue))
    //    {
    //        if (item["parent"] != null)
    //        {
    //            parents = item["parent"].ToString().Split('-').OfType<string>().ToList();
    //        }
    //    }

    //    Title = item["title"].ToString();
    //    FullName = item["fullname"].ToString();
    //    IsParent = (bool)item["isParent"];

    //    if (item.TryGetValue("parent", out outValue))
    //        ParentFullName = item["parent"] as string;
    //    if (item.TryGetValue("deprecated", out outValue))
    //        Deprecated = item["deprecated"] == null ? false : (bool)item["deprecated"];
    //    if (item.TryGetValue("returnType", out outValue))
    //        ReturnType = item["returnType"] as string;
    //    if (item.TryGetValue("description", out outValue))
    //        Description = (String.IsNullOrEmpty(item["description"] as string)) ? "" : item["description"] as string;
    //    if (item.TryGetValue("defaults", out outValue))
    //        Defaults = item["defaults"] == null ? null : item["defaults"] as string;
    //    if (item.TryGetValue("values", out outValue))
    //    {
    //        JavaScriptSerializer js = new JavaScriptSerializer();
    //        try
    //        {
    //            Values = js.Deserialize<List<string>>(item["values"] as string);
    //        }
    //        catch (Exception e)
    //        {

    //        }
    //    }

    //    if (item.TryGetValue("products", out outValue))
    //    {
    //        JavaScriptSerializer js = new JavaScriptSerializer();
    //        try
    //        {
    //            var tmp = item["products"] as object[];
    //            Products = tmp.Cast<string>().ToList();
    //        }
    //        catch (Exception e)
    //        {

    //        }
    //    }

    //    if (FullName == "plotOptions.treemap.borderColor")
    //        ReturnType = "Color";
    //    if (FullName == "series<treemap>.borderColor")
    //        ReturnType = "Color";

    //}


    public ApiItem Clone()
    {
        var item = new ApiItem();

        item.FullName = string.IsNullOrWhiteSpace(FullName) ? string.Empty : string.Copy(FullName);
        item.Title = string.IsNullOrWhiteSpace(Title) ? string.Empty : string.Copy(Title);
        item.ParentFullName = string.IsNullOrWhiteSpace(ParentFullName) ? null : string.Copy(ParentFullName);
        item.IsParent = IsParent;
        item.ReturnType = string.IsNullOrWhiteSpace(ReturnType) ? string.Empty : string.Copy(ReturnType);
        item.Description = string.IsNullOrWhiteSpace(Description) ? string.Empty : string.Copy(Description);
        item.Defaults = string.IsNullOrWhiteSpace(Defaults) ? string.Empty : string.Copy(Defaults);
        item.Values = new List<string>(Values.Where(q => q != null).Select(p => string.Copy(p)));
        item.Deprecated = Deprecated;
        item.Products = new List<string>(Products.Select(p => string.Copy(p)));
        item.Types = new List<string>(Types.Select(p => string.Copy(p)));
        item.Extends = new List<string>(Extends.Select(p => string.Copy(p)));
        item.Exclude = new List<string>(Exclude.Select(p => string.Copy(p)));
        item.Since = string.IsNullOrWhiteSpace(Since) ? null : string.Copy(Since);
        item.Suffix = string.IsNullOrWhiteSpace(Suffix) ? null : string.Copy(Suffix);

        Children.ToList().ForEach(p => item.Children.Add(p.Clone()));

        return item;
    }
}