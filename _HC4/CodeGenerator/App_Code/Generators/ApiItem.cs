﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

public class ApiItem
{
    public ApiItem()
    {
        Parent = null;
        Description = "";
        Parents = new List<string>();
    }

    public ApiItem(Dictionary<string, object> item)
        : this()
    {
        object outValue;
        List<string> parents = new List<string>();

        if (item.TryGetValue("parent", out outValue))
        {
            if (item["parent"] != null)
            {
                parents = item["parent"].ToString().Split('-').OfType<string>().ToList();
            }
        }

        Title = item["title"].ToString();
        FullName = item["fullname"].ToString();
        IsParent = (bool)item["isParent"];

        if (item.TryGetValue("parent", out outValue))
            Parent = item["parent"] as string;
        if (item.TryGetValue("deprecated", out outValue))
            Deprecated = item["deprecated"] == null ? false : (bool)item["deprecated"];
        if (item.TryGetValue("returnType", out outValue))
            ReturnType = item["returnType"] as string;
        if (item.TryGetValue("description", out outValue))
            Description = (String.IsNullOrEmpty(item["description"] as string)) ? "" : item["description"] as string;
        if (item.TryGetValue("defaults", out outValue))
            Defaults = item["defaults"] == null ? null : item["defaults"] as string;
        if (item.TryGetValue("values", out outValue))
        {
            JavaScriptSerializer js = new JavaScriptSerializer();
            try
            {
                Values = js.Deserialize<List<string>>(item["values"] as string);
            }
            catch (Exception e)
            {

            }
        }

        if (FullName == "plotOptions.treemap.borderColor")
            ReturnType = "Color";
        if (FullName == "series<treemap>.borderColor")
            ReturnType = "Color";

    }

    public string FullName { get; set; }
    public string Title { get; set; }
    public string Parent { get; set; }
    public bool IsParent { get; set; }
    public string ReturnType { get; set; }
    public string Description { get; set; }
    public string Defaults { get; set; }
    public List<string> Values { get; set; }
    public bool Deprecated { get; set; }

    // auxialiary and no part of the API
    public List<string> Parents { get; set; }
}