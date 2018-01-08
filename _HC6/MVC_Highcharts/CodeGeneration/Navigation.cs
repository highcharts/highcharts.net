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
			MenuStyle = MenuStyle_DefaultValue = new Hashtable{{ "border", "1px solid #999999"},{ "background", "#ffffff"},{ "padding", "5px 0" }};
			MenuItemStyle = MenuItemStyle_DefaultValue = new Hashtable{{ "padding", "0.5em 1em"},{ "color", "#333333"},{ "background", "none" }};
			MenuItemHoverStyle = MenuItemHoverStyle_DefaultValue = new Hashtable{{ "background", "#335cad"},{ "color", "#ffffff" }};
			
		}	
		

		/// <summary>
		/// A collection of options for buttons appearing in the exporting module.In styled mode, the buttons are styled with the `.highcharts-contextbutton` and `.highcharts-button-symbol` class.
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the popup menu appearing by default when the exporticon is clicked. This menu is rendered in HTML.
		/// </summary>
		public Hashtable MenuStyle { get; set; }
		private Hashtable MenuStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearingby default when the export icon is clicked. The menu items are renderedin HTML.
		/// </summary>
		public Hashtable MenuItemStyle { get; set; }
		private Hashtable MenuItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the hover state of the individual items within thepopup menu appearing by default when the export icon is clicked. The menu items are rendered in HTML.
		/// </summary>
		public Hashtable MenuItemHoverStyle { get; set; }
		private Hashtable MenuItemHoverStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ButtonOptions.IsDirty()) h.Add("buttonOptions",ButtonOptions.ToHashtable());
			if (MenuStyle != MenuStyle_DefaultValue) h.Add("menuStyle",MenuStyle);
			if (MenuItemStyle != MenuItemStyle_DefaultValue) h.Add("menuItemStyle",MenuItemStyle);
			if (MenuItemHoverStyle != MenuItemHoverStyle_DefaultValue) h.Add("menuItemHoverStyle",MenuItemHoverStyle);
			

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