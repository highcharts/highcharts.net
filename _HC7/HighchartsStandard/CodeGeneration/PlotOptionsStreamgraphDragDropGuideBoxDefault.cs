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
	public partial class PlotOptionsStreamgraphDragDropGuideBoxDefault  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsStreamgraphDragDropGuideBoxDefault()
		{
		}	
		

		/// <summary>
		/// CSS class name of the guide box in this state. Defaults to`highcharts-drag-box-default`.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Guide box fill color.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Guide box cursor.
		/// </summary>
		public string Cursor { get; set; }
		 

		/// <summary>
		/// Color of the border around the guide box.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// Width of the line around the guide box.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// Guide box zIndex.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (Cursor != null) h.Add("cursor",Cursor);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
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