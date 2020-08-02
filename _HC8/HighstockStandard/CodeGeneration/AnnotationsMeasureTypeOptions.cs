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
			Background = Background_DefaultValue = new AnnotationsMeasureTypeOptionsBackground();
			CrosshairX = CrosshairX_DefaultValue = new AnnotationsMeasureTypeOptionsCrosshairX();
			CrosshairY = CrosshairY_DefaultValue = new AnnotationsMeasureTypeOptionsCrosshairY();
			Label = Label_DefaultValue = new AnnotationsMeasureTypeOptionsLabel();
			Line = Line_DefaultValue = new AnnotationsMeasureTypeOptionsLine();
			Points = Points_DefaultValue = new AnnotationsMeasureTypeOptionsPoints();
			SelectType = SelectType_DefaultValue = "xy";
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Background { get; set; }
		private string Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure a crosshair that is horizontally placed in middle ofrectangle.
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairX CrosshairX { get; set; }
		private AnnotationsMeasureTypeOptionsCrosshairX CrosshairX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Configure a crosshair that is vertically placed in middle ofrectangle.
		/// </summary>
		public AnnotationsMeasureTypeOptionsCrosshairY CrosshairY { get; set; }
		private AnnotationsMeasureTypeOptionsCrosshairY CrosshairY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureTypeOptionsLabel Label { get; set; }
		private AnnotationsMeasureTypeOptionsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsMeasureTypeOptionsLine Line { get; set; }
		private AnnotationsMeasureTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureTypeOptionsPoints Points { get; set; }
		private AnnotationsMeasureTypeOptionsPoints Points_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides in what dimensions the user can resize by dragging themouse. Can be one of x, y or xy.
		/// </summary>
		public string SelectType { get; set; }
		private string SelectType_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to.It refers to either the axis id or the index of the axisin the xAxis array.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to.It refers to either the axis id or the index of the axisin the yAxis array.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Background.IsDirty()) h.Add("background",Background.ToHashtable());
			if (CrosshairX.IsDirty()) h.Add("crosshairX",CrosshairX.ToHashtable());
			if (CrosshairY.IsDirty()) h.Add("crosshairY",CrosshairY.ToHashtable());
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(Points));
			if (SelectType != SelectType_DefaultValue) h.Add("selectType",SelectType);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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