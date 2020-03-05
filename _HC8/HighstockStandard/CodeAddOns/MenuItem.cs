using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class MenuItem : BaseObject
	{
		public MenuItem() {
            Text = "";
            OnClick = "";
		}

        /// <summary>
        /// The text of the menu item
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// OnClick javascript event to fire
        /// </summary>
        public string OnClick { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Text)) h.Add("text", Text);
            if (!String.IsNullOrEmpty(OnClick)) { h.Add("onclick", OnClick); Highstock.AddFunction("MenuItemOnClick.onclick", OnClick); }

            return h;
        }

        internal override string ToJSON()
        {
            Hashtable h = ToHashtable();

            if (h.Count > 0)
                return JsonConvert.SerializeObject(ToHashtable());
            else
                return "";
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return ToHashtable().Count > 0;
        }   
	}
}