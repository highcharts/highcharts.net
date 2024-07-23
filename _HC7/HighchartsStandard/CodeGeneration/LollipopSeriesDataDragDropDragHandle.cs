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
	public partial class LollipopSeriesDataDragDropDragHandle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LollipopSeriesDataDragDropDragHandle()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The class name of the drag handles. Defaults to `highcharts-drag-handle`.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// The fill color of the drag handles.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The line color of the drag handles.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// The line width for the drag handles.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// The z index for the drag handles.
		/// </summary>
		public double? ZIndex { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ClassName != null) h.Add("className",ClassName);
			if (Color != null) h.Add("color",Color);
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields.Count > 0)
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