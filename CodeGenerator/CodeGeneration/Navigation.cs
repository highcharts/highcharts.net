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
	public partial class Navigation  
	{
		public Navigation()
		{
			ButtonOptions = ButtonOptions_DefaultValue = new NavigationButtonOptions();
			MenuItemHoverStyle = MenuItemHoverStyle_DefaultValue = null;
			MenuItemStyle = MenuItemStyle_DefaultValue = null;
			MenuStyle = MenuStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A collection of options for buttons appearing in the exporting module.
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the hover state of the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to <pre>menuItemHoverStyle: {background: '#4572A5',color: '#FFFFFF'}</pre>
		/// </summary>
		public NameValueCollection MenuItemHoverStyle { get; set; }
		private NameValueCollection MenuItemHoverStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearing by  default when the export icon is clicked. The menu items are rendered in HTML. Defaults to <pre>menuItemStyle: {padding: '0 5px',background: NONE,color: '#303030'}</pre>
		/// </summary>
		public NameValueCollection MenuItemStyle { get; set; }
		private NameValueCollection MenuItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the popup menu appearing by default when the export icon is clicked. This menu is rendered in HTML. Defaults to <pre>menuStyle: {border: '1px solid #A0A0A0',background: '#FFFFFF'}</pre>
		/// </summary>
		public NameValueCollection MenuStyle { get; set; }
		private NameValueCollection MenuStyle_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ButtonOptions.IsDirty()) h.Add("buttonOptions",ButtonOptions.ToHashtable());
			if (MenuItemHoverStyle != MenuItemHoverStyle_DefaultValue) h.Add("menuItemHoverStyle",MenuItemHoverStyle);
			if (MenuItemStyle != MenuItemStyle_DefaultValue) h.Add("menuItemStyle",MenuItemStyle);
			if (MenuStyle != MenuStyle_DefaultValue) h.Add("menuStyle",MenuStyle);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}