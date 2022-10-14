using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;
using Newtonsoft.Json;

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
        public string Text { get; set; }

        /// <summary>
        /// OnClick javascript event to fire
        /// </summary>
        public string OnClick { get; set; }

        internal override Hashtable ToHashtable(Highstock highstock)
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Text)) h.Add("text", Text);
            if (!String.IsNullOrEmpty(OnClick)) { h.Add("onclick", OnClick); highstock.AddFunction("onclick", OnClick); }

            return h;
        }

        internal override string ToJSON(Highstock highcharts)
        {
            return JsonConvert.SerializeObject(ToHashtable(highcharts));
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty(Highstock highcharts)
        {
            return ToHashtable(highcharts).Count > 0;
        }   
	}
}