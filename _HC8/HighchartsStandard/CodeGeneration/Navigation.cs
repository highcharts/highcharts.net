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
		Hashtable h = new Hashtable();

		public Navigation()
		{
			AnnotationsOptions = AnnotationsOptions_DefaultValue = new NavigationAnnotationsOptions();
			Bindings = Bindings_DefaultValue = new NavigationBindings();
			BindingsClassName = BindingsClassName_DefaultValue = "highcharts-bindings-container";
			Breadcrumbs = Breadcrumbs_DefaultValue = new NavigationBreadcrumbs();
			ButtonOptions = ButtonOptions_DefaultValue = new NavigationButtonOptions();
			Events = Events_DefaultValue = new NavigationEvents();
			IconsURL = IconsURL_DefaultValue = "";
			
			CustomFields = new Hashtable();
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
		/// Options for breadcrumbs. Breadcrumbs general options are defined in`navigation.breadcrumbs`. Specific options for drilldown are set in`drilldown.breadcrumbs` and for tree-like series traversing, in`plotOptions[series].breadcrumbs`.
		/// </summary>
		public NavigationBreadcrumbs Breadcrumbs { get; set; }
		private NavigationBreadcrumbs Breadcrumbs_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationButtonOptions ButtonOptions { get; set; }
		private NavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Events to communicate between Stock Tools and custom GUI.
		/// </summary>
		public NavigationEvents Events { get; set; }
		private NavigationEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// Path where Highcharts will look for icons. Change this to use iconsfrom a different server.
		/// </summary>
		public string IconsURL { get; set; }
		private string IconsURL_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AnnotationsOptions.IsDirty(ref highcharts)) h.Add("annotationsOptions",AnnotationsOptions.ToHashtable(ref highcharts));
			if (Bindings.IsDirty(ref highcharts)) h.Add("bindings",Bindings.ToHashtable(ref highcharts));
			if (BindingsClassName != BindingsClassName_DefaultValue) h.Add("bindingsClassName",BindingsClassName);
			if (Breadcrumbs.IsDirty(ref highcharts)) h.Add("breadcrumbs",Breadcrumbs.ToHashtable(ref highcharts));
			if (ButtonOptions.IsDirty(ref highcharts)) h.Add("buttonOptions",ButtonOptions.ToHashtable(ref highcharts));
			if (Events.IsDirty(ref highcharts)) h.Add("events",Events.ToHashtable(ref highcharts));
			if (IconsURL != IconsURL_DefaultValue) h.Add("iconsURL",IconsURL);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}