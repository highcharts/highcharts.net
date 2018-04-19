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
	public partial class MapNavigationButtons  : BaseObject
	{
		public MapNavigationButtons()
		{
			ZoomIn = ZoomIn_DefaultValue = new MapNavigationButtonsZoomIn();
			ZoomOut = ZoomOut_DefaultValue = new MapNavigationButtonsZoomOut();
			
		}	
		

		/// <summary>
		/// Options for the zoom in button. Properties for the zoom in and zoom out buttons are inherited from <a href="#mapNavigation.buttonOptions">mapNavigation.buttonOptions</a>, while individual options can be overridden. By default, the <code>onclick</code>, <code>text</code> and <code>y</code> options are individual.
		/// </summary>
		public MapNavigationButtonsZoomIn ZoomIn { get; set; }
		private MapNavigationButtonsZoomIn ZoomIn_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the zoom out button. Properties for the zoom in and zoom out buttons are inherited from <a href="#mapNavigation.buttonOptions">mapNavigation.buttonOptions</a>, while individual options can be overridden. By default, the <code>onclick</code>, <code>text</code> and <code>y</code> options are individual.
		/// </summary>
		public MapNavigationButtonsZoomOut ZoomOut { get; set; }
		private MapNavigationButtonsZoomOut ZoomOut_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ZoomIn.IsDirty()) h.Add("zoomIn",ZoomIn.ToHashtable());
			if (ZoomOut.IsDirty()) h.Add("zoomOut",ZoomOut.ToHashtable());
			

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