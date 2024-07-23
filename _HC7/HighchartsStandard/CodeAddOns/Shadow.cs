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
	public partial class Shadow  : BaseObject
	{
        Hashtable h = new Hashtable();

        public Shadow() {
            Enabled = false;
            Color = "";
            OffsetX = 0;
            OffsetY = 0;
            Opacity = 0;
            Width = 0;
		}

        //deprecated - use ShadowBool instead
        /// <summary>
        /// If a shadow with default values should be enabled
        /// </summary>
        public bool Enabled { get; set; }

		/// <summary>
		/// The Color of the Shadow
		/// </summary>
		public string Color { get; set; } 

		/// <summary>
		/// The OffsetX  the shadow
		/// </summary>
		public int OffsetX { get; set; }

        /// <summary>
        /// The OffsetX of the shadow
        /// </summary>
        public int OffsetY { get; set; }

        /// <summary>
        /// The opacity of the shadow
        /// </summary>
        public double Opacity { get; set; }

        // <summary>
        /// The width of the shadow
        /// </summary>
        public int Width { get; set; }

        internal override Hashtable ToHashtable(Highcharts highcharts)
        {
            if (h.Count > 0)
                return h;

            if (!String.IsNullOrEmpty(Color)) h.Add("color", Color);
            if (OffsetX != 0) h.Add("offsetX", OffsetX);
            if (OffsetY != 0) h.Add("offsetY", OffsetY);
            if (Opacity != 0) h.Add("opacity", Opacity);
            if (Width != 0) h.Add("width", Width);

            return h;
        }
	}
}