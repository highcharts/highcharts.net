using Newtonsoft.Json;
using System.Collections;
using System;

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

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Text)) h.Add("text", Text);
            if (!String.IsNullOrEmpty(OnClick)) { h.Add("onclick", OnClick); Highcharts.AddFunction("onclick", OnClick); }

            return h;
        }

        internal override string ToJSON()
        {
            return JsonConvert.SerializeObject(ToHashtable());
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return ToHashtable().Count > 0;
        }   
	}
}