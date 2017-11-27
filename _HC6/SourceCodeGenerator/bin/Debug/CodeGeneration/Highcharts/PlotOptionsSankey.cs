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
	public partial class PlotOptionsSankey  : BaseObject
	{
		public PlotOptionsSankey()
		{
			ColorByPoint = ColorByPoint_DefaultValue = True;
			CurveFactor = CurveFactor_DefaultValue = 0.33;
			LinkOpacity = LinkOpacity_DefaultValue = 0.5;
			NodeWidth = NodeWidth_DefaultValue = 20;
			NodePadding = NodePadding_DefaultValue = 10;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			States = States_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			ColorByPoint = ColorByPoint_DefaultValue = True;
			CurveFactor = CurveFactor_DefaultValue = 0.33;
			DataLabels = DataLabels_DefaultValue = "";
			Enabled = Enabled_DefaultValue = True;
			BackgroundColor = BackgroundColor_DefaultValue = none;
			Crop = Crop_DefaultValue = False;
			NodeFormat = NodeFormat_DefaultValue = "";
			NodeFormatter = NodeFormatter_DefaultValue = "";
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			LinkOpacity = LinkOpacity_DefaultValue = 0.5;
			NodeWidth = NodeWidth_DefaultValue = 20;
			NodePadding = NodePadding_DefaultValue = 10;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			LinkOpacity = LinkOpacity_DefaultValue = 1;
			Tooltip = Tooltip_DefaultValue = "";
			FollowPointer = FollowPointer_DefaultValue = True;
			HeaderFormat = HeaderFormat_DefaultValue = <span class="highcharts-header">{series.name}</span><br/>;
			PointFormat = PointFormat_DefaultValue = {point.fromNode.name} → {point.toNode.name}: <b>{point.weight}</b><br/>;
			NodeFormat = NodeFormat_DefaultValue = {point.name}: <b>{point.sum}</b><br/>;
			NodeFormatter = NodeFormatter_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyColorByPoint ColorByPoint { get; set; }
		private PlotOptionsSankeyColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Higher numbers makes the links in a sankey diagram render more curved.A `curveFactor` of 0 makes the lines straight.
		/// </summary>
		public PlotOptionsSankeyCurveFactor CurveFactor { get; set; }
		private PlotOptionsSankeyCurveFactor CurveFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram.
		/// </summary>
		public PlotOptionsSankeyLinkOpacity LinkOpacity { get; set; }
		private PlotOptionsSankeyLinkOpacity LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of each node in a sankey diagram, or the height in casethe chart is inverted.
		/// </summary>
		public PlotOptionsSankeyNodeWidth NodeWidth { get; set; }
		private PlotOptionsSankeyNodeWidth NodeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The padding between nodes in a sankey diagram, in pixels.
		/// </summary>
		public PlotOptionsSankeyNodePadding NodePadding { get; set; }
		private PlotOptionsSankeyNodePadding NodePadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyShowInLegend ShowInLegend { get; set; }
		private PlotOptionsSankeyShowInLegend ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyStates States { get; set; }
		private PlotOptionsSankeyStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltip Tooltip { get; set; }
		private PlotOptionsSankeyTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyColorByPoint ColorByPoint { get; set; }
		private PlotOptionsSankeyColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Higher numbers makes the links in a sankey diagram render more curved.A `curveFactor` of 0 makes the lines straight.
		/// </summary>
		public PlotOptionsSankeyCurveFactor CurveFactor { get; set; }
		private PlotOptionsSankeyCurveFactor CurveFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the data labels appearing on top of the nodes and links. Forsankey charts, data labels are visible for the nodes by default, but hidden for links. This is controlled by modifying the `nodeFormat`, andthe `format` that applies to links and is an empty string by default.
		/// </summary>
		public PlotOptionsSankeyDataLabels DataLabels { get; set; }
		private PlotOptionsSankeyDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyEnabled Enabled { get; set; }
		private PlotOptionsSankeyEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyBackgroundColor BackgroundColor { get; set; }
		private PlotOptionsSankeyBackgroundColor BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyCrop Crop { get; set; }
		private PlotOptionsSankeyCrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what to show for _nodes_ in the sankey diagram. By default the `nodeFormatter` returns`{point.name}`.
		/// </summary>
		public string NodeFormat { get; set; }
		private string NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _nodes_ in the sankey diagram. The `nodeFormat` option takes precedence over the `nodeFormatter`.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what to show for _links_ in the sankey diagram. Defaults to an empty string returned from the `formatter`, in effect disabling the labels.
		/// </summary>
		public PlotOptionsSankeyFormat Format { get; set; }
		private PlotOptionsSankeyFormat Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback to format data labels for _links_ in the sankey diagram. The `format` option takes precedence over the `formatter`.
		/// </summary>
		public PlotOptionsSankeyFormatter Formatter { get; set; }
		private PlotOptionsSankeyFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyInside Inside { get; set; }
		private PlotOptionsSankeyInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram.
		/// </summary>
		public PlotOptionsSankeyLinkOpacity LinkOpacity { get; set; }
		private PlotOptionsSankeyLinkOpacity LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of each node in a sankey diagram, or the height in casethe chart is inverted.
		/// </summary>
		public PlotOptionsSankeyNodeWidth NodeWidth { get; set; }
		private PlotOptionsSankeyNodeWidth NodeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The padding between nodes in a sankey diagram, in pixels.
		/// </summary>
		public PlotOptionsSankeyNodePadding NodePadding { get; set; }
		private PlotOptionsSankeyNodePadding NodePadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyShowInLegend ShowInLegend { get; set; }
		private PlotOptionsSankeyShowInLegend ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyStates States { get; set; }
		private PlotOptionsSankeyStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyHover Hover { get; set; }
		private PlotOptionsSankeyHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram inhover mode.
		/// </summary>
		public PlotOptionsSankeyLinkOpacity LinkOpacity { get; set; }
		private PlotOptionsSankeyLinkOpacity LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltip Tooltip { get; set; }
		private PlotOptionsSankeyTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyFollowPointer FollowPointer { get; set; }
		private PlotOptionsSankeyFollowPointer FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyHeaderFormat HeaderFormat { get; set; }
		private PlotOptionsSankeyHeaderFormat HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyPointFormat PointFormat { get; set; }
		private PlotOptionsSankeyPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what to show for _nodes_ in tooltipof a sankey diagram series, as opposed to links.
		/// </summary>
		public PlotOptionsSankeyNodeFormat NodeFormat { get; set; }
		private PlotOptionsSankeyNodeFormat NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback for defining the format for _nodes_ in the sankey chart'stooltip, as opposed to links.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (CurveFactor != CurveFactor_DefaultValue) h.Add("curveFactor",CurveFactor);
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (NodeWidth != NodeWidth_DefaultValue) h.Add("nodeWidth",NodeWidth);
			if (NodePadding != NodePadding_DefaultValue) h.Add("nodePadding",NodePadding);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (CurveFactor != CurveFactor_DefaultValue) h.Add("curveFactor",CurveFactor);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) h.Add("nodeFormatter",NodeFormatter);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (NodeWidth != NodeWidth_DefaultValue) h.Add("nodeWidth",NodeWidth);
			if (NodePadding != NodePadding_DefaultValue) h.Add("nodePadding",NodePadding);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) h.Add("nodeFormatter",NodeFormatter);
			

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