using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			AnnotationsOptions = AnnotationsOptions_DefaultValue = new NavigationAnnotationsOptions();
			Bindings = Bindings_DefaultValue = new NavigationBindings();
			BindingsClassName = BindingsClassName_DefaultValue = "highcharts-bindings-container";
			ButtonOptions = ButtonOptions_DefaultValue = new NavigationButtonOptions();
			Events = Events_DefaultValue = new NavigationEvents();
			MenuItemHoverStyle = MenuItemHoverStyle_DefaultValue = new NavigationMenuItemHoverStyle();
			MenuItemStyle = MenuItemStyle_DefaultValue = new NavigationMenuItemStyle();
			MenuStyle = MenuStyle_DefaultValue = new NavigationMenuStyle();
			
		}	
		

		/// <summary>
		/// Additional options to be merged into all annotations.
		/// </summary>
		public NavigationAnnotationsOptions AnnotationsOptions { get; set; }
		private NavigationAnnotationsOptions AnnotationsOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Bindings definitions for custom HTML buttons. Each binding implementssimple event-driven interface:- `className`: classname used to bind event to- `init`: initial event, fired on button click- `start`: fired on first click on a chart- `steps`: array of sequential events fired one after another on each  of users clicks- `end`: last event to be called after last step event
		/// </summary>
		public NavigationBindings Bindings { get; set; }
		private NavigationBindings Bindings_DefaultValue { get; set; }
		 

		/// <summary>
		/// A CSS class name where all bindings will be attached to. Multiplecharts on the same page should have separate class names to preventduplicating events.Default value of versions < 7.0.4 `highcharts-bindings-wrapper`
		/// </summary>
		public string BindingsClassName { get; set; }
		private string BindingsClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of options for buttons appearing in the exportingmodule.In styled mode, the buttons are styled with the`.highcharts-contextbutton` and `.highcharts-button-symbol` classes.
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Events to communicate between Stock Tools and custom GUI.
		/// </summary>
		public NavigationEvents Events { get; set; }
		private NavigationEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the hover state of the individual items within thepopup menu appearing by default when the export icon is clicked. Themenu items are rendered in HTML.
		/// </summary>
		public NavigationMenuItemHoverStyle MenuItemHoverStyle { get; set; }
		private NavigationMenuItemHoverStyle MenuItemHoverStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearingby default when the export icon is clicked. The menu items arerendered in HTML. Font size defaults to `11px` on desktop and `14px`on touch devices.
		/// </summary>
		public NavigationMenuItemStyle MenuItemStyle { get; set; }
		private NavigationMenuItemStyle MenuItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the popup menu appearing by default when the exporticon is clicked. This menu is rendered in HTML.
		/// </summary>
		public NavigationMenuStyle MenuStyle { get; set; }
		private NavigationMenuStyle MenuStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AnnotationsOptions != AnnotationsOptions_DefaultValue) h.Add("annotationsOptions",AnnotationsOptions);
			if (Bindings.IsDirty()) h.Add("bindings",Bindings.ToHashtable());
			if (BindingsClassName != BindingsClassName_DefaultValue) h.Add("bindingsClassName",BindingsClassName);
			if (ButtonOptions.IsDirty()) h.Add("buttonOptions",ButtonOptions.ToHashtable());
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (MenuItemHoverStyle.IsDirty()) h.Add("menuItemHoverStyle",MenuItemHoverStyle.ToHashtable());
			if (MenuItemStyle.IsDirty()) h.Add("menuItemStyle",MenuItemStyle.ToHashtable());
			if (MenuStyle.IsDirty()) h.Add("menuStyle",MenuStyle.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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