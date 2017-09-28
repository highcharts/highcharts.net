using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class MapNavigation  : BaseObject
	{
		public MapNavigation()
		{
			ButtonOptions = ButtonOptions_DefaultValue = new MapNavigationButtonOptions();
			Buttons = Buttons_DefaultValue = new MapNavigationButtons();
			EnableButtons = EnableButtons_DefaultValue = null;
			EnableDoubleClickZoom = EnableDoubleClickZoom_DefaultValue = "";
			EnableDoubleClickZoomTo = EnableDoubleClickZoomTo_DefaultValue = false;
			EnableMouseWheelZoom = EnableMouseWheelZoom_DefaultValue = "";
			EnableTouchZoom = EnableTouchZoom_DefaultValue = "";
			Enabled = Enabled_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// General options for the map navigation buttons. Individual options can be given from the <a href="#mapNavigation.buttons">mapNavigation.buttons</a> option set.
		/// </summary>
		public MapNavigationButtonOptions ButtonOptions { get; set; }
		private MapNavigationButtonOptions ButtonOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The individual buttons for the map navigation. This usually includes the zoom in and zoom out buttons. Properties for each button is inherited from <a href="#mapNavigation.buttonOptions">mapNavigation.buttonOptions</a>, while individual options can be overridden. But default, the <code>onclick</code>, <code>text</code> and <code>y</code> options are individual.
		/// </summary>
		public MapNavigationButtons Buttons { get; set; }
		private MapNavigationButtons Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable navigation buttons. By default it inherits the <a href="#mapNavigation.enabled">enabled</a> setting.
		/// </summary>
		public bool? EnableButtons { get; set; }
		private bool? EnableButtons_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming in on an area on double clicking in the map. By default it inherits the <a href="#mapNavigation.enabled">enabled</a> setting.
		/// </summary>
		public bool? EnableDoubleClickZoom { get; set; }
		private bool? EnableDoubleClickZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to zoom in on an area when that area is double clicked.
		/// </summary>
		public bool? EnableDoubleClickZoomTo { get; set; }
		private bool? EnableDoubleClickZoomTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enables zooming by mouse wheel. By default it inherits the <a href="#mapNavigation.enabled">enabled</a> setting.
		/// </summary>
		public bool? EnableMouseWheelZoom { get; set; }
		private bool? EnableMouseWheelZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable multitouch zooming. Note that if the chart covers the viewport, this prevents the user from using multitouch and touchdrag on the web page, so you should make sure the user is not trapped inside the chart. By default it inherits the <a href="#mapNavigation.enabled">enabled</a> setting.
		/// </summary>
		public bool? EnableTouchZoom { get; set; }
		private bool? EnableTouchZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to enable map navigation. The default is not to enable navigation, as many choropleth maps are simple and don't need it. Additionally, when touch zoom and mousewheel zoom is enabled, it breaks the default behaviour of these interactions in the website, and the implementer should be aware of this.</p><p>Individual interactions can be enabled separately, namely buttons, multitouch zoom, double click zoom, double click zoom to element and mousewheel zoom.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ButtonOptions.IsDirty()) h.Add("buttonOptions",ButtonOptions.ToHashtable());
			if (Buttons.IsDirty()) h.Add("buttons",Buttons.ToHashtable());
			if (EnableButtons != EnableButtons_DefaultValue) h.Add("enableButtons",EnableButtons);
			if (EnableDoubleClickZoom != EnableDoubleClickZoom_DefaultValue) h.Add("enableDoubleClickZoom",EnableDoubleClickZoom);
			if (EnableDoubleClickZoomTo != EnableDoubleClickZoomTo_DefaultValue) h.Add("enableDoubleClickZoomTo",EnableDoubleClickZoomTo);
			if (EnableMouseWheelZoom != EnableMouseWheelZoom_DefaultValue) h.Add("enableMouseWheelZoom",EnableMouseWheelZoom);
			if (EnableTouchZoom != EnableTouchZoom_DefaultValue) h.Add("enableTouchZoom",EnableTouchZoom);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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