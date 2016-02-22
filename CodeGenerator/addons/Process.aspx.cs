using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class addons_Process : System.Web.UI.Page
{
    List<AddOnApiItem> allItems = new List<AddOnApiItem>();

    protected void Page_Load(object sender, EventArgs e)
    {
        string jsonAPI = File.ReadAllText(Server.MapPath("~/addons/api.txt"));
        var converter = new ExpandoObjectConverter();
        dynamic apiItems = JsonConvert.DeserializeObject<ExpandoObject>(jsonAPI, converter);

        ProcessItem(apiItems.definitions, null);

        foreach (AddOnApiItem item in allItems)
        {
            log.Text += String.Format("{0} : {1} : {2} <br/>",
                                            item.Title,
                                            item.ReturnType,
                                            item.FullName);
        }
    }

    private void ProcessItem(ExpandoObject item, string parent)
    {
        foreach (KeyValuePair<string, object> childItem in item)
        {
            AddOnApiItem apiItem = new AddOnApiItem(childItem, parent);
            allItems.Add(apiItem);

            if (apiItem.IsParent)
            {
                ProcessItem(((ExpandoObject)apiItem.ChildNode), apiItem.Title);
            }
        }
       
    }

    public class AddOnApiItem
    {
        public string FullName { get; set; }
        public string Title { get; set; }
        public string Parent { get; set; }
        public bool IsParent { get; set; }
        public string ReturnType { get; set; }
        public string Description { get; set; }
        public string Defaults { get; set; }
        public List<string> Values { get; set; }
        public bool Deprecated { get; set; }
        public ExpandoObject ChildNode { get; set; }

        public AddOnApiItem()
        {
            IsParent = false;
            Parent = null;
        }

        public AddOnApiItem(KeyValuePair<string, object> item, string parent)
            : this()
        {
            Title = item.Key;
            FullName = item.Key;
            Parent = parent;
            Deprecated = false;
            IsParent = false;


            foreach (KeyValuePair<string, object> property in (ExpandoObject)item.Value)
            {
                if (property.Key == "type")
                    ReturnType = property.Value as string;
                if (property.Key == "descriptionEN")
                    Description = property.Value as string;
                if (property.Key == "default")
                    Defaults = property.Value as string;
                if (property.Key == "applicable")
                    Values = property.Value as List<string>;
                if (property.Key == "properties")
                {
                    IsParent = true;
                    ChildNode = (ExpandoObject) property.Value;
                }
            }
        }
    }
}