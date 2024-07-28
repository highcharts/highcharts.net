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
	public partial class AnnotationsMeasureTypeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsMeasureTypeOptions()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureTypeOptionsBackground Background { get; set; }
		 

		/// <summary>
		/// Configure a crosshair that is horizontally placed in middle ofrectangle.
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairX CrosshairX { get; set; }
		 

		/// <summary>
		/// Configure a crosshair that is vertically placed in middle ofrectangle.
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairY CrosshairY { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureTypeOptionsLabel Label { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsMeasureTypeOptionsLine Line { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsMeasureTypeOptionsPoints> Points { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can resize by dragging themouse. Can be one of x, y or xy.
		/// </summary>
		public string SelectType { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to.It refers to either the axis id or the index of the axisin the xAxis array.
		/// </summary>
		public string XAxis { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to.It refers to either the axis id or the index of the axisin the yAxis array.
		/// </summary>
		public string YAxis { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Background != null) h.Add("background",Background.ToHashtable(highstock));
			if (CrosshairX != null) h.Add("crosshairX",CrosshairX.ToHashtable(highstock));
			if (CrosshairY != null) h.Add("crosshairY",CrosshairY.ToHashtable(highstock));
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
			if (Line != null) h.Add("line",Line.ToHashtable(highstock));
			if (Points != null) h.Add("points", HashifyList(highstock,Points));
			if (SelectType != null) h.Add("selectType",SelectType);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (YAxis != null) h.Add("yAxis",YAxis);
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