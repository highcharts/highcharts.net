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
	public partial class Highcharts  : BaseObject
	{
		public Highcharts()
		{
			Option = Option_DefaultValue = new Option();
			Timeline = Timeline_DefaultValue = new Timeline();
			Title = Title_DefaultValue = new Title();
			Toolbox = Toolbox_DefaultValue = new Toolbox();
			Tooltip = Tooltip_DefaultValue = new Tooltip();
			Legend = Legend_DefaultValue = new Legend();
			DataRange = DataRange_DefaultValue = new DataRange();
			DataZoom = DataZoom_DefaultValue = new DataZoom();
			RoamController = RoamController_DefaultValue = new RoamController();
			Grid = Grid_DefaultValue = new Grid();
			Axis = Axis_DefaultValue = "";
			AxisItem = AxisItem_DefaultValue = new AxisItem();
			AxisAxisLine = AxisAxisLine_DefaultValue = new AxisAxisLine();
			AxisAxisTick = AxisAxisTick_DefaultValue = new AxisAxisTick();
			AxisAxisLabel = AxisAxisLabel_DefaultValue = new AxisAxisLabel();
			AxisSplitLine = AxisSplitLine_DefaultValue = new AxisSplitLine();
			AxisSplitArea = AxisSplitArea_DefaultValue = new AxisSplitArea();
			Polar = Polar_DefaultValue = new Polar();
			Series = Series_DefaultValue = new List<Series>();
			SeriesItem = SeriesItem_DefaultValue = new SeriesItem();
			MarkPoint = MarkPoint_DefaultValue = new MarkPoint();
			MarkLine = MarkLine_DefaultValue = new MarkLine();
			ItemStyle = ItemStyle_DefaultValue = new ItemStyle();
			ItemStyleItem = ItemStyleItem_DefaultValue = new ItemStyleItem();
			ItemStyleLabel = ItemStyleLabel_DefaultValue = new ItemStyleLabel();
			ItemStyleLabelLine = ItemStyleLabelLine_DefaultValue = new ItemStyleLabelLine();
			LineStyle = LineStyle_DefaultValue = new LineStyle();
			AreaStyle = AreaStyle_DefaultValue = new AreaStyle();
			ChordStyle = ChordStyle_DefaultValue = new ChordStyle();
			NodeStyle = NodeStyle_DefaultValue = new NodeStyle();
			LinkStyle = LinkStyle_DefaultValue = new LinkStyle();
			LinkStyleItem = LinkStyleItem_DefaultValue = new LinkStyleItem();
			TextStyle = TextStyle_DefaultValue = new TextStyle();
			LoadingOption = LoadingOption_DefaultValue = new LoadingOption();
			NoDataLoadingOption = NoDataLoadingOption_DefaultValue = new NoDataLoadingOption();
			DataCategories = DataCategories_DefaultValue = new DataCategories();
			DataNodeData = DataNodeData_DefaultValue = new DataNodeData();
			DataGraphLinks = DataGraphLinks_DefaultValue = new DataGraphLinks();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Option Option { get; set; }
		private Option Option_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Timeline Timeline { get; set; }
		private Timeline Timeline_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Title Title { get; set; }
		private Title Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Toolbox Toolbox { get; set; }
		private Toolbox Toolbox_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Tooltip Tooltip { get; set; }
		private Tooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Legend Legend { get; set; }
		private Legend Legend_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DataRange DataRange { get; set; }
		private DataRange DataRange_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DataZoom DataZoom { get; set; }
		private DataZoom DataZoom_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public RoamController RoamController { get; set; }
		private RoamController RoamController_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Grid Grid { get; set; }
		private Grid Grid_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Array Axis { get; set; }
		private Array Axis_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AxisItem AxisItem { get; set; }
		private AxisItem AxisItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AxisAxisLine AxisAxisLine { get; set; }
		private AxisAxisLine AxisAxisLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AxisAxisTick AxisAxisTick { get; set; }
		private AxisAxisTick AxisAxisTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AxisAxisLabel AxisAxisLabel { get; set; }
		private AxisAxisLabel AxisAxisLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AxisSplitLine AxisSplitLine { get; set; }
		private AxisSplitLine AxisSplitLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AxisSplitArea AxisSplitArea { get; set; }
		private AxisSplitArea AxisSplitArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Polar Polar { get; set; }
		private Polar Polar_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriesItem SeriesItem { get; set; }
		private SeriesItem SeriesItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public MarkPoint MarkPoint { get; set; }
		private MarkPoint MarkPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public MarkLine MarkLine { get; set; }
		private MarkLine MarkLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// item style
		/// </summary>
		public ItemStyle ItemStyle { get; set; }
		private ItemStyle ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ItemStyleItem ItemStyleItem { get; set; }
		private ItemStyleItem ItemStyleItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ItemStyleLabel ItemStyleLabel { get; set; }
		private ItemStyleLabel ItemStyleLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ItemStyleLabelLine ItemStyleLabelLine { get; set; }
		private ItemStyleLabelLine ItemStyleLabelLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LineStyle LineStyle { get; set; }
		private LineStyle LineStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AreaStyle AreaStyle { get; set; }
		private AreaStyle AreaStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChordStyle ChordStyle { get; set; }
		private ChordStyle ChordStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NodeStyle NodeStyle { get; set; }
		private NodeStyle NodeStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LinkStyle LinkStyle { get; set; }
		private LinkStyle LinkStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LinkStyleItem LinkStyleItem { get; set; }
		private LinkStyleItem LinkStyleItem_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public TextStyle TextStyle { get; set; }
		private TextStyle TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LoadingOption LoadingOption { get; set; }
		private LoadingOption LoadingOption_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NoDataLoadingOption NoDataLoadingOption { get; set; }
		private NoDataLoadingOption NoDataLoadingOption_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DataCategories DataCategories { get; set; }
		private DataCategories DataCategories_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DataNodeData DataNodeData { get; set; }
		private DataNodeData DataNodeData_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DataGraphLinks DataGraphLinks { get; set; }
		private DataGraphLinks DataGraphLinks_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Option.IsDirty()) h.Add("option",Option.ToHashtable());
			if (Timeline.IsDirty()) h.Add("timeline",Timeline.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Toolbox.IsDirty()) h.Add("toolbox",Toolbox.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Legend.IsDirty()) h.Add("legend",Legend.ToHashtable());
			if (DataRange.IsDirty()) h.Add("dataRange",DataRange.ToHashtable());
			if (DataZoom.IsDirty()) h.Add("dataZoom",DataZoom.ToHashtable());
			if (RoamController.IsDirty()) h.Add("roamController",RoamController.ToHashtable());
			if (Grid.IsDirty()) h.Add("grid",Grid.ToHashtable());
			if (Axis != Axis_DefaultValue) h.Add("axis",Axis);
			if (AxisItem.IsDirty()) h.Add("axisItem",AxisItem.ToHashtable());
			if (AxisAxisLine.IsDirty()) h.Add("axisAxisLine",AxisAxisLine.ToHashtable());
			if (AxisAxisTick.IsDirty()) h.Add("axisAxisTick",AxisAxisTick.ToHashtable());
			if (AxisAxisLabel.IsDirty()) h.Add("axisAxisLabel",AxisAxisLabel.ToHashtable());
			if (AxisSplitLine.IsDirty()) h.Add("axisSplitLine",AxisSplitLine.ToHashtable());
			if (AxisSplitArea.IsDirty()) h.Add("axisSplitArea",AxisSplitArea.ToHashtable());
			if (Polar.IsDirty()) h.Add("polar",Polar.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (SeriesItem.IsDirty()) h.Add("seriesItem",SeriesItem.ToHashtable());
			if (MarkPoint.IsDirty()) h.Add("markPoint",MarkPoint.ToHashtable());
			if (MarkLine.IsDirty()) h.Add("markLine",MarkLine.ToHashtable());
			if (ItemStyle.IsDirty()) h.Add("itemStyle",ItemStyle.ToHashtable());
			if (ItemStyleItem.IsDirty()) h.Add("itemStyleItem",ItemStyleItem.ToHashtable());
			if (ItemStyleLabel.IsDirty()) h.Add("itemStyleLabel",ItemStyleLabel.ToHashtable());
			if (ItemStyleLabelLine.IsDirty()) h.Add("itemStyleLabelLine",ItemStyleLabelLine.ToHashtable());
			if (LineStyle.IsDirty()) h.Add("lineStyle",LineStyle.ToHashtable());
			if (AreaStyle.IsDirty()) h.Add("areaStyle",AreaStyle.ToHashtable());
			if (ChordStyle.IsDirty()) h.Add("chordStyle",ChordStyle.ToHashtable());
			if (NodeStyle.IsDirty()) h.Add("nodeStyle",NodeStyle.ToHashtable());
			if (LinkStyle.IsDirty()) h.Add("linkStyle",LinkStyle.ToHashtable());
			if (LinkStyleItem.IsDirty()) h.Add("linkStyleItem",LinkStyleItem.ToHashtable());
			if (TextStyle.IsDirty()) h.Add("textStyle",TextStyle.ToHashtable());
			if (LoadingOption.IsDirty()) h.Add("loadingOption",LoadingOption.ToHashtable());
			if (NoDataLoadingOption.IsDirty()) h.Add("noDataLoadingOption",NoDataLoadingOption.ToHashtable());
			if (DataCategories.IsDirty()) h.Add("dataCategories",DataCategories.ToHashtable());
			if (DataNodeData.IsDirty()) h.Add("dataNodeData",DataNodeData.ToHashtable());
			if (DataGraphLinks.IsDirty()) h.Add("dataGraphLinks",DataGraphLinks.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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