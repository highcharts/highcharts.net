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
	public partial class Crosshair : BaseObject
	{
		public Crosshair() {
            XAxis = false;
            YAxis = false;
		}

        /// <summary>
        /// Set to true to show crosshair to the X Axis
        /// </summary>
        public bool XAxis { get; set; }

        /// <summary>
        /// Set to true to show crosshair for the Y Axis
        /// </summary>
        public bool YAxis { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (XAxis) h.Add("xAxis", XAxis);
            if (YAxis) h.Add("yAxis", YAxis);

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