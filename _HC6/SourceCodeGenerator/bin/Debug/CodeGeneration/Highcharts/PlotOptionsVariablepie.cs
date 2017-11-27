using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsVariablepie  : BaseObject
	{
		public PlotOptionsVariablepie()
		{
			MinPointSize = MinPointSize_DefaultValue = "10%";
			MaxPointSize = MaxPointSize_DefaultValue = "100%";
			ZMin = ZMin_DefaultValue = null;
			ZMax = ZMax_DefaultValue = null;
			SizeBy = SizeBy_DefaultValue = "area";
			Tooltip = Tooltip_DefaultValue = null;
			MinPointSize = MinPointSize_DefaultValue = "10%";
			MaxPointSize = MaxPointSize_DefaultValue = "100%";
			ZMin = ZMin_DefaultValue = null;
			ZMax = ZMax_DefaultValue = null;
			SizeBy = SizeBy_DefaultValue = "area";
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = <span style="color:{point.color}">●</span> {series.name}<br/>Value: {point.y}<br/>Size: {point.z}<br/>;
			
		}	
		

		/// <summary>
		/// The minimum size of the points' radius related to chart's `plotArea`.If a number is set, it applies in pixels.
		/// </summary>
		public string MinPointSize { get; set; }
		private string MinPointSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum size of the points' radius related to chart's `plotArea`.If a number is set, it applies in pixels.
		/// </summary>
		public string MaxPointSize { get; set; }
		private string MaxPointSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum possible z value for the point's radius calculation. If the point's Z value is smaller than zMin, the slice will be drawnaccording to the zMin value.
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum possible z value for the point's radius calculation. Ifthe point's Z value is bigger than zMax, the slice will be drawnaccording to the zMax value
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the pie slice's value should be represented by the area or the radius of the slice. Can be either `area` or `radius`. Thedefault, `area`, corresponds best to the human perception of the sizeof each pie slice.
		/// </summary>
		public string SizeBy { get; set; }
		private string SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVariablepieTooltip Tooltip { get; set; }
		private PlotOptionsVariablepieTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum size of the points' radius related to chart's `plotArea`.If a number is set, it applies in pixels.
		/// </summary>
		public string MinPointSize { get; set; }
		private string MinPointSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum size of the points' radius related to chart's `plotArea`.If a number is set, it applies in pixels.
		/// </summary>
		public string MaxPointSize { get; set; }
		private string MaxPointSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum possible z value for the point's radius calculation. If the point's Z value is smaller than zMin, the slice will be drawnaccording to the zMin value.
		/// </summary>
		public double? ZMin { get; set; }
		private double? ZMin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The maximum possible z value for the point's radius calculation. Ifthe point's Z value is bigger than zMax, the slice will be drawnaccording to the zMax value
		/// </summary>
		public double? ZMax { get; set; }
		private double? ZMax_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the pie slice's value should be represented by the area or the radius of the slice. Can be either `area` or `radius`. Thedefault, `area`, corresponds best to the human perception of the sizeof each pie slice.
		/// </summary>
		public string SizeBy { get; set; }
		private string SizeBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVariablepieTooltip Tooltip { get; set; }
		private PlotOptionsVariablepieTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVariablepiePointFormat PointFormat { get; set; }
		private PlotOptionsVariablepiePointFormat PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (MinPointSize != MinPointSize_DefaultValue) h.Add("minPointSize",MinPointSize);
			if (MaxPointSize != MaxPointSize_DefaultValue) h.Add("maxPointSize",MaxPointSize);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy",SizeBy);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (MinPointSize != MinPointSize_DefaultValue) h.Add("minPointSize",MinPointSize);
			if (MaxPointSize != MaxPointSize_DefaultValue) h.Add("maxPointSize",MaxPointSize);
			if (ZMin != ZMin_DefaultValue) h.Add("zMin",ZMin);
			if (ZMax != ZMax_DefaultValue) h.Add("zMax",ZMax);
			if (SizeBy != SizeBy_DefaultValue) h.Add("sizeBy",SizeBy);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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