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
	public partial class Stop : BaseObject, IObjectList
	{
		public Stop() {
            Position = 0;
            Color = "";
		}

        /// <summary>
        /// The text of the menu item
        /// </summary>
        public double Position { get; set; }

        /// <summary>
        /// OnClick javascript event to fire
        /// </summary>
        public string Color { get; set; }

        internal override Hashtable ToHashtable(ref Highcharts highcharts)
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Color)) h.Add("color", Color);
            if (Position != 0) h.Add("position", Position);

            return h;
        }

        internal override string ToJSON(ref Highcharts highcharts)
        {
            return JsonConvert.SerializeObject(ToHashtable(ref highcharts));
        }

        public List<object> ToList()
        {
            if (!string.IsNullOrWhiteSpace(Color))
                return new List<object> { Position, Color };

            return new List<object>();
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty(ref Highcharts highcharts)
        {
            return ToHashtable(ref highcharts).Count > 0;
        }   
	}
}