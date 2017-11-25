using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Script.Serialization;

public class ApiItem
{
    public ApiItem()
    {
        Parent = null;
        Description = "";
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
    //        Parent = item["parent"] as string;
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

    public string FullName { get; set; }
    public string Title { get; set; }
    public string Parent { get; set; }
    public bool IsParent { get; set; }
    public string ReturnType { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
    public string Defaults { get; set; }
    public List<string> Values { get; set; } = new List<string>();
    public bool Deprecated { get; set; }
    public List<string> Products { get; set; } = new List<string>();
    public IList<string> Types { get; set; } = new List<string>();
    public IList<string> Extends { get; set; } = new List<string>();
    public IList<string> Exclude { get; set; } = new List<string>();
    public string Since { get; set; }
    public bool HasChildren { get; set; }

    public ApiItem Clone()
    {
        var item = new ApiItem();

        item.FullName = string.IsNullOrWhiteSpace(FullName) ? string.Empty : string.Copy(FullName);
        item.Title = string.IsNullOrWhiteSpace(Title) ? string.Empty : string.Copy(Title);
        item.Parent = string.IsNullOrWhiteSpace(Parent) ? null : string.Copy(Parent);
        item.IsParent = IsParent;
        item.ReturnType = string.IsNullOrWhiteSpace(ReturnType) ? string.Empty : string.Copy(ReturnType);
        item.Description = string.IsNullOrWhiteSpace(Description) ? string.Empty : string.Copy(Description);
        item.Defaults = string.IsNullOrWhiteSpace(Defaults) ? string.Empty : string.Copy(Defaults);
        item.Values = new List<string>(Values.Select(p => string.Copy(p)));
        item.Deprecated = Deprecated;
        item.Products = new List<string>(Products.Select(p => string.Copy(p)));
        item.Types = new List<string>(Types.Select(p => string.Copy(p)));
        item.Extends = new List<string>(Extends.Select(p => string.Copy(p)));
        item.Exclude = new List<string>(Exclude.Select(p => string.Copy(p)));
        item.Since = string.IsNullOrWhiteSpace(Since) ? null : string.Copy(Since);
        item.HasChildren = HasChildren;

        return item;
    }
}