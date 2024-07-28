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
	public partial class PlotOptionsColumnDragDropDragHandle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsColumnDragDropDragHandle()
		{
		}	
		

		/// <summary>
		/// The mouse cursor to use for the drag handles. By default this isintelligently switching between `ew-resize` and `ns-resize` depending onthe direction the point is being dragged.
		/// </summary>
		public string Cursor { get; set; }
		 

		/// <summary>
		/// Function to define the SVG path to use for the drag handles. Takesthe point as argument. Should return an SVG path in array format. TheSVG path is automatically positioned on the point.
		/// </summary>
		public string PathFormatter { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Cursor != null) h.Add("cursor",Cursor);
			if (PathFormatter != null) { h.Add("pathFormatter",PathFormatter); highcharts.AddFunction("pathFormatter", PathFormatter); }  
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