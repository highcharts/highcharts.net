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
	public partial class PlotOptionsWindbarb  : BaseObject
	{
		public PlotOptionsWindbarb()
		{
			LineWidth = LineWidth_DefaultValue = 2;
			OnSeries = OnSeries_DefaultValue = null;
			States = States_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			VectorLength = VectorLength_DefaultValue = 20;
			YOffset = YOffset_DefaultValue = -20;
			LineWidth = LineWidth_DefaultValue = 2;
			OnSeries = OnSeries_DefaultValue = "";
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			LineWidthPlus = LineWidthPlus_DefaultValue = 0;
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = <b>{series.name}</b>: {point.value} ({point.beaufort})<br/>;
			VectorLength = VectorLength_DefaultValue = 20;
			YOffset = YOffset_DefaultValue = -20;
			
		}	
		

		/// <summary>
		/// The line width of the wind barb symbols.
		/// </summary>
		public PlotOptionsWindbarbLineWidth LineWidth { get; set; }
		private PlotOptionsWindbarbLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of another series in the chart that the wind barbs are projectedon. When `null`, the wind symbols are drawn on the X axis, but offsetup or down by the `yOffset` setting.
		/// </summary>
		public string OnSeries { get; set; }
		private string OnSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWindbarbStates States { get; set; }
		private PlotOptionsWindbarbStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWindbarbTooltip Tooltip { get; set; }
		private PlotOptionsWindbarbTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel length of the stems.
		/// </summary>
		public PlotOptionsWindbarbVectorLength VectorLength { get; set; }
		private PlotOptionsWindbarbVectorLength VectorLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset from the cartesian position, in pixels. The default valuemakes sure the symbols don't overlap the X axis when `onSeries` is`null`, and that they don't overlap the linked series when `onSeries` isgiven.
		/// </summary>
		public PlotOptionsWindbarbYOffset YOffset { get; set; }
		private PlotOptionsWindbarbYOffset YOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the wind barb symbols.
		/// </summary>
		public PlotOptionsWindbarbLineWidth LineWidth { get; set; }
		private PlotOptionsWindbarbLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of another series in the chart that the wind barbs are projectedon. When `null`, the wind symbols are drawn on the X axis, but offsetup or down by the `yOffset` setting.
		/// </summary>
		public string OnSeries { get; set; }
		private string OnSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWindbarbStates States { get; set; }
		private PlotOptionsWindbarbStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWindbarbHover Hover { get; set; }
		private PlotOptionsWindbarbHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWindbarbLineWidthPlus LineWidthPlus { get; set; }
		private PlotOptionsWindbarbLineWidthPlus LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWindbarbTooltip Tooltip { get; set; }
		private PlotOptionsWindbarbTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default point format for the wind barb tooltip. Note the `point.beaufort` property that refers to the Beaufort wind scale. Thenames can be internationalized by modifying`Highcharts.seriesTypes.windbarb.prototype.beaufortNames`.
		/// </summary>
		public PlotOptionsWindbarbPointFormat PointFormat { get; set; }
		private PlotOptionsWindbarbPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel length of the stems.
		/// </summary>
		public PlotOptionsWindbarbVectorLength VectorLength { get; set; }
		private PlotOptionsWindbarbVectorLength VectorLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset from the cartesian position, in pixels. The default valuemakes sure the symbols don't overlap the X axis when `onSeries` is`null`, and that they don't overlap the linked series when `onSeries` isgiven.
		/// </summary>
		public PlotOptionsWindbarbYOffset YOffset { get; set; }
		private PlotOptionsWindbarbYOffset YOffset_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (OnSeries != OnSeries_DefaultValue) h.Add("onSeries",OnSeries);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (VectorLength != VectorLength_DefaultValue) h.Add("vectorLength",VectorLength);
			if (YOffset != YOffset_DefaultValue) h.Add("yOffset",YOffset);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (OnSeries != OnSeries_DefaultValue) h.Add("onSeries",OnSeries);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (VectorLength != VectorLength_DefaultValue) h.Add("vectorLength",VectorLength);
			if (YOffset != YOffset_DefaultValue) h.Add("yOffset",YOffset);
			

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