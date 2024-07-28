using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Navigation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Navigation()
		{
		}	
		

		/// <summary>
		/// Additional options to be merged into all annotations.
		/// </summary>
		public NavigationAnnotationsOptions AnnotationsOptions { get; set; }
		 

		/// <summary>
		/// Bindings definitions for custom HTML buttons. Each binding implementssimple event-driven interface:- `className`: classname used to bind event to- `init`: initial event, fired on button click- `start`: fired on first click on a chart- `steps`: array of sequential events fired one after another on each  of users clicks- `end`: last event to be called after last step event
		/// </summary>
		public NavigationBindings Bindings { get; set; }
		 

		/// <summary>
		/// A CSS class name where all bindings will be attached to. Multiplecharts on the same page should have separate class names to preventduplicating events.Default value of versions < 7.0.4 `highcharts-bindings-wrapper`
		/// </summary>
		public string BindingsClassName { get; set; }
		 

		/// <summary>
		/// A collection of options for buttons appearing in the exportingmodule.In styled mode, the buttons are styled with the`.highcharts-contextbutton` and `.highcharts-button-symbol` classes.
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		 

		/// <summary>
		/// Events to communicate between Stock Tools and custom GUI.
		/// </summary>
		public NavigationEvents Events { get; set; }
		 

		/// <summary>
		/// Path where Highcharts will look for icons. Change this to use iconsfrom a different server.
		/// </summary>
		public string IconsURL { get; set; }
		 

		/// <summary>
		/// CSS styles for the hover state of the individual items within thepopup menu appearing by default when the export icon is clicked. Themenu items are rendered in HTML.
		/// </summary>
		public Hashtable MenuItemHoverStyle { get; set; }
		 

		/// <summary>
		/// CSS styles for the individual items within the popup menu appearingby default when the export icon is clicked. The menu items arerendered in HTML. Font size defaults to `11px` on desktop and `14px`on touch devices.
		/// </summary>
		public Hashtable MenuItemStyle { get; set; }
		 

		/// <summary>
		/// CSS styles for the popup menu appearing by default when the exporticon is clicked. This menu is rendered in HTML.
		/// </summary>
		public Hashtable MenuStyle { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AnnotationsOptions != null) h.Add("annotationsOptions",AnnotationsOptions.ToHashtable(highstock));
			if (Bindings != null) h.Add("bindings",Bindings.ToHashtable(highstock));
			if (BindingsClassName != null) h.Add("bindingsClassName",BindingsClassName);
			if (ButtonOptions != null) h.Add("buttonOptions",ButtonOptions.ToHashtable(highstock));
			if (Events != null) h.Add("events",Events.ToHashtable(highstock));
			if (IconsURL != null) h.Add("iconsURL",IconsURL);
			if (MenuItemHoverStyle != null) h.Add("menuItemHoverStyle",MenuItemHoverStyle);
			if (MenuItemStyle != null) h.Add("menuItemStyle",MenuItemStyle);
			if (MenuStyle != null) h.Add("menuStyle",MenuStyle);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}