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
	public partial class PlotOptionsXrange  : BaseObject
	{
		public PlotOptionsXrange()
		{
			ColorByPoint = ColorByPoint_DefaultValue = True;
			Tooltip = Tooltip_DefaultValue = null;
			BorderRadius = BorderRadius_DefaultValue = 3;
			PartialFill = PartialFill_DefaultValue = null;
			Data = Data_DefaultValue = new List<PlotOptionsXrangeData>();
			ColorByPoint = ColorByPoint_DefaultValue = True;
			DataLabels = DataLabels_DefaultValue = "";
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Inside = Inside_DefaultValue = True;
			Formatter = Formatter_DefaultValue = "";
			Tooltip = Tooltip_DefaultValue = "";
			HeaderFormat = HeaderFormat_DefaultValue = <span style="font-size: 0.85em">{point.x} - {point.x2}</span><br/>;
			PointFormat = PointFormat_DefaultValue = <span style="color:{point.color}">●</span> {series.name}: <b>{point.yCategory}</b><br/>;
			BorderRadius = BorderRadius_DefaultValue = 3;
			PartialFill = PartialFill_DefaultValue = "";
			Fill = Fill_DefaultValue = "";
			X2 = X2_DefaultValue = null;
			PartialFill = PartialFill_DefaultValue = "";
			Amount = Amount_DefaultValue = null;
			Fill = Fill_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// In an X-range series, this option makes all points of the same Y-axiscategory the same color.
		/// </summary>
		public PlotOptionsXrangeColorByPoint ColorByPoint { get; set; }
		private PlotOptionsXrangeColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeTooltip Tooltip { get; set; }
		private PlotOptionsXrangeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeBorderRadius BorderRadius { get; set; }
		private PlotOptionsXrangeBorderRadius BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public PlotOptionsXrangePartialFill PartialFill { get; set; }
		private PlotOptionsXrangePartialFill PartialFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<PlotOptionsXrangeData> Data { get; set; }
		private List<PlotOptionsXrangeData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// In an X-range series, this option makes all points of the same Y-axiscategory the same color.
		/// </summary>
		public PlotOptionsXrangeColorByPoint ColorByPoint { get; set; }
		private PlotOptionsXrangeColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeDataLabels DataLabels { get; set; }
		private PlotOptionsXrangeDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsXrangeVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeInside Inside { get; set; }
		private PlotOptionsXrangeInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default formatter for X-range data labels displays the percentageof the partial fill amount.
		/// </summary>
		public PlotOptionsXrangeFormatter Formatter { get; set; }
		private PlotOptionsXrangeFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeTooltip Tooltip { get; set; }
		private PlotOptionsXrangeTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeHeaderFormat HeaderFormat { get; set; }
		private PlotOptionsXrangeHeaderFormat HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangePointFormat PointFormat { get; set; }
		private PlotOptionsXrangePointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeBorderRadius BorderRadius { get; set; }
		private PlotOptionsXrangeBorderRadius BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public PlotOptionsXrangePartialFill PartialFill { get; set; }
		private PlotOptionsXrangePartialFill PartialFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color to be used for partial fills. Defaults to a darker shadeof the point color.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending X value of the range point.
		/// </summary>
		public double? X2 { get; set; }
		private double? X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public PlotOptionsXrangePartialFill PartialFill { get; set; }
		private PlotOptionsXrangePartialFill PartialFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The amount of the X-range point to be filled. Values can be 0-1 and are converted to percentages in the default data label formatter.
		/// </summary>
		public double? Amount { get; set; }
		private double? Amount_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color to be used for partial fills. Defaults to a darker shadeof the point color.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (PartialFill.IsDirty()) h.Add("partialFill",PartialFill.ToHashtable());
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (PartialFill.IsDirty()) h.Add("partialFill",PartialFill.ToHashtable());
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			if (PartialFill.IsDirty()) h.Add("partialFill",PartialFill.ToHashtable());
			if (Amount != Amount_DefaultValue) h.Add("amount",Amount);
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			

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