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
	public partial class DemaSeriesDragDropGuideBoxDefault  : BaseObject
	{
		public DemaSeriesDragDropGuideBoxDefault()
		{
			ClassName = ClassName_DefaultValue = "highcharts-drag-box-default";
			Color = Color_DefaultValue = "rgba(0, 0, 0, 0.1)";
			Cursor = Cursor_DefaultValue = "move";
			LineColor = LineColor_DefaultValue = "#888";
			LineWidth = LineWidth_DefaultValue = 1;
			ZIndex = ZIndex_DefaultValue = 900;
			
		}	
		

		/// <summary>
		/// CSS class name of the guide box in this state. Defaults to`highcharts-drag-box-default`.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Guide box fill color.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Guide box cursor.
		/// </summary>
		public string Cursor { get; set; }
		private string Cursor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the border around the guide box.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the line around the guide box.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Guide box zIndex.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Cursor != Cursor_DefaultValue) h.Add("cursor",Cursor);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

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