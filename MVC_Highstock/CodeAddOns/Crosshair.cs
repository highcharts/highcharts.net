using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
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
            return new JavaScriptSerializer().Serialize(ToHashtable());
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return ToHashtable().Count > 0;
        }  
	}
}