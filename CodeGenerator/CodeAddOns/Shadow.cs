using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class Shadow
	{
		public Shadow() {
            Enabled = false;
            Color = "";
            OffsetX = 0;
            OffsetY = 0;
            Opacity = 0;
            Width = 0;
		}

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
        public decimal Opacity { get; set; }

        // <summary>
        /// The width of the shadow
        /// </summary>
        public int Width { get; set; }

        

	}
}