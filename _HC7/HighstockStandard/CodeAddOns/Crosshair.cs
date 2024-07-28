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

        internal override Hashtable ToHashtable(Highstock highcharts)
        {
            Hashtable h = new Hashtable();

            if (XAxis) h.Add("xAxis", XAxis);
            if (YAxis) h.Add("yAxis", YAxis);

            return h;
        }
	}
}