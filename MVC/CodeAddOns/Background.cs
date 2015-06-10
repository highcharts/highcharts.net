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
	public partial class Background : BaseObject
	{

        //>innerWidth</code>, <code>outerWidth</code>, <code>borderWidth</code>, <code>borderColor</code>.

		public Background() {
            BackgroundColor = "";
            InnerWidth = 0;
            OuterWidth = 0;
            BorderWidth = 0;
            BorderColor = "";
		}

        /// <summary>
        /// backgroundColor (can be solid or gradient)
        /// </summary>
        string BackgroundColor { get; set; }

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

        

	}
}