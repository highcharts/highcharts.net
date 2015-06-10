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

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(BackgroundColor)) h.Add("backgroundColor", BackgroundColor);
            if (!String.IsNullOrEmpty(BorderColor)) h.Add("borderColor", BorderColor);
            if (InnerWidth != 0) h.Add("innerWidth", InnerWidth);
            if (OuterWidth != 0) h.Add("outerWidth", OuterWidth);
            if (BorderWidth != 0) h.Add("borderWidth", BorderWidth);

            return h;
        }

        internal override object ToJSON()
        {
            Hashtable h = ToHashtable();
            if (h.Count > 0)
                return h;
            //return new JavaScriptSerializer().Serialize(ToHashtable());
            else
                return Enabled;
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return (Enabled != true || ToHashtable().Count > 0);
        }

        

	}
}