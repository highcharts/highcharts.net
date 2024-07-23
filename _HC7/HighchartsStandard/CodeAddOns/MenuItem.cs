using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
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

        internal override Hashtable ToHashtable(Highcharts highcharts)
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Text)) h.Add("text", Text);
            if (!String.IsNullOrEmpty(OnClick)) { h.Add("onclick", OnClick); highcharts.AddFunction("onclick", OnClick); }

            return h;
        }
	}
}