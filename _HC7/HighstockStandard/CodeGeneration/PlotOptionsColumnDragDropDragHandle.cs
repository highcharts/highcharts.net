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
	public partial class PlotOptionsColumnDragDropDragHandle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnDragDropDragHandle()
		{
			Cursor = Cursor_DefaultValue = "";
			PathFormatter = PathFormatter_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The mouse cursor to use for the drag handles. By default this isintelligently switching between `ew-resize` and `ns-resize` depending onthe direction the point is being dragged.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to define the SVG path to use for the drag handles. Takesthe point as argument. Should return an SVG path in array format. TheSVG path is automatically positioned on the point.
		/// </summary>
		public string PathFormatter { get; set; }
		private string PathFormatter_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (PathFormatter != PathFormatter_DefaultValue) { h.Add("pathFormatter",PathFormatter); highstock.AddFunction("pathFormatter", PathFormatter); }  
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}