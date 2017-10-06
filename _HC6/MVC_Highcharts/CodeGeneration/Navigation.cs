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
			MenuStyle = MenuStyle_DefaultValue = new NavigationMenuStyle();
			MenuItemStyle = MenuItemStyle_DefaultValue = new NavigationMenuItemStyle();
			MenuItemHoverStyle = MenuItemHoverStyle_DefaultValue = new NavigationMenuItemHoverStyle();
			
		}	
		

		/// <summary>
		/// <p>A collection of options for buttons appearing in the exporting module.</p><p>In styled mode, the buttons are styled with the <code>.highcharts-contextbutton</code> and <code>.highcharts-button-symbol</code> class.</p>
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the popup menu appearing by default when the exporticon is clicked. This menu is rendered in HTML.</p>
		/// </summary>
		public NavigationMenuStyle MenuStyle { get; set; }
		private NavigationMenuStyle MenuStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the individual items within the popup menu appearingby default when the export icon is clicked. The menu items are renderedin HTML.</p>
		/// </summary>
		public NavigationMenuItemStyle MenuItemStyle { get; set; }
		private NavigationMenuItemStyle MenuItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the hover state of the individual items within thepopup menu appearing by default when the export icon is clicked. The menu items are rendered in HTML.</p>
		/// </summary>
		public NavigationMenuItemHoverStyle MenuItemHoverStyle { get; set; }
		private NavigationMenuItemHoverStyle MenuItemHoverStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ButtonOptions.IsDirty()) h.Add("buttonOptions",ButtonOptions.ToHashtable());
			if (MenuStyle.IsDirty()) h.Add("menuStyle",MenuStyle.ToHashtable());
			if (MenuItemStyle.IsDirty()) h.Add("menuItemStyle",MenuItemStyle.ToHashtable());
			if (MenuItemHoverStyle.IsDirty()) h.Add("menuItemHoverStyle",MenuItemHoverStyle.ToHashtable());
			

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