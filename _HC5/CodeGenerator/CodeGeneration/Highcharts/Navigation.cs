using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Navigation  : BaseObject
	{
		public Navigation()
		{
			ButtonOptions = ButtonOptions_DefaultValue = new NavigationButtonOptions();
			MenuItemHoverStyle = MenuItemHoverStyle_DefaultValue = new Hashtable{{ "background", "#335cad"},{ "color", "#ffffff" }};
			MenuItemStyle = MenuItemStyle_DefaultValue = new Hashtable{{ "padding", "0.5em 1em"},{ "color", "#333333"},{ "background", "none" }};
			MenuStyle = MenuStyle_DefaultValue = new Hashtable{{ "border", "1px solid #999999"},{ "background", "#ffffff"},{ "padding", "5px 0" }};
			
		}	
		

		/// <summary>
		/// <p>A collection of options for buttons appearing in the exporting module.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the buttons are styled with the <code>.highcharts-contextbutton</code> and <code>.highcharts-button-symbol</code> class.</p>
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the hover state of the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML.
		/// </summary>
		public Hashtable MenuItemHoverStyle { get; set; }
		private Hashtable MenuItemHoverStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML.
		/// </summary>
		public Hashtable MenuItemStyle { get; set; }
		private Hashtable MenuItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the popup menu appearing by default when the export icon is clicked. This menu is rendered in HTML.
		/// </summary>
		public Hashtable MenuStyle { get; set; }
		private Hashtable MenuStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ButtonOptions.IsDirty()) h.Add("buttonOptions",ButtonOptions.ToHashtable());
			if (MenuItemHoverStyle != MenuItemHoverStyle_DefaultValue) h.Add("menuItemHoverStyle",MenuItemHoverStyle);
			if (MenuItemStyle != MenuItemStyle_DefaultValue) h.Add("menuItemStyle",MenuItemStyle);
			if (MenuStyle != MenuStyle_DefaultValue) h.Add("menuStyle",MenuStyle);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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