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
	public partial class Stop
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
	}
}