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
	public partial class Background : BaseObject
	{

        //>innerWidth</code>, <code>outerWidth</code>, <code>borderWidth</code>, <code>borderColor</code>.

		public Background() {
            BackgroundColor = "";
            InnerWidth = 0;
            OuterWidth = 0;
            BorderWidth = 0;
            BorderColor = "";
            InnerRadius = "";
            OuterRadius = "";
            Shape = "";
		}

        /// <summary>
        /// InnerRadius
        /// </summary>
        public string Shape { get; set; }

        /// <summary>
        /// InnerRadius
        /// </summary>
        public string InnerRadius { get; set; }

        /// <summary>
        /// OuterRadius
        /// </summary>
        public string OuterRadius { get; set; }


        /// <summary>
        /// backgroundColor (can be solid or gradient)
        /// </summary>
        public string BackgroundColor { get; set; }

		/// <summary>
		/// InnerWidth
		/// </summary>
		public int InnerWidth { get; set; } 

		/// <summary>
		/// OuterWidth
		/// </summary>
		public int OuterWidth { get; set; }

        /// <summary>
        /// BorderWidth
        /// </summary>
        public int BorderWidth { get; set; }
       
        /// <summary>
        /// BorderColor
        /// </summary>
        public string BorderColor { get; set; }

        internal override Hashtable ToHashtable(Highcharts highcharts)
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(BackgroundColor)) h.Add("backgroundColor", BackgroundColor);
            if (!String.IsNullOrEmpty(BorderColor)) h.Add("borderColor", BorderColor);
            if (!String.IsNullOrEmpty(Shape)) h.Add("shape", Shape);
            if (!String.IsNullOrEmpty(InnerRadius)) h.Add("innerRadius", InnerRadius);
            if (!String.IsNullOrEmpty(OuterRadius)) h.Add("outerRadius", OuterRadius);
            if (InnerWidth != 0) h.Add("innerWidth", InnerWidth);
            if (OuterWidth != 0) h.Add("outerWidth", OuterWidth);
            if (BorderWidth != 0) h.Add("borderWidth", BorderWidth);

            return h;
        }
	}
}