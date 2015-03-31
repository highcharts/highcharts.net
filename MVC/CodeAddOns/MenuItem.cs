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
	public partial class MenuItem
	{
		public MenuItem() {
            Text = "";
            OnClick = "";
		}

        /// <summary>
        /// The text of the menu item
        /// </summary>
        string Text { get; set; }

        /// <summary>
        /// OnClick javascript event to fire
        /// </summary>
        public string OnClick { get; set; }
	}
}