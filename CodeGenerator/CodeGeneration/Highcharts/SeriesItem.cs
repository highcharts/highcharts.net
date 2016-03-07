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
	public partial class SeriesItem  : BaseObject
	{
		public SeriesItem()
		{
			Type = Type_DefaultValue = "";
			Name = Name_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			Clickable = Clickable_DefaultValue = null;
			ItemStyle = ItemStyle_DefaultValue = "";
			Data = Data_DefaultValue = new List<SeriesItemData>();
			Stack = Stack_DefaultValue = null;
			XAxisIndex = XAxisIndex_DefaultValue = "";
			YAxisIndex = YAxisIndex_DefaultValue = null;
			BarGap = BarGap_DefaultValue = 30%;
			BarCategoryGap = BarCategoryGap_DefaultValue = 20%;
			BarMinHeight = BarMinHeight_DefaultValue = null;
			BarWidth = BarWidth_DefaultValue = "";
			BarMaxWidth = BarMaxWidth_DefaultValue = "";
			Symbol = Symbol_DefaultValue = "";
			SymbolSize = SymbolSize_DefaultValue = "";
			SymbolRotate = SymbolRotate_DefaultValue = "";
			ShowAllSymbol = ShowAllSymbol_DefaultValue = null;
			Smooth = Smooth_DefaultValue = null;
			DataFilter = DataFilter_DefaultValue = "";
			Large = Large_DefaultValue = "";
			LargeThreshold = LargeThreshold_DefaultValue = null;
			LegendHoverLink = LegendHoverLink_DefaultValue = "";
			Center = Center_DefaultValue = new string[] { null, null };
			Radius = Radius_DefaultValue = "";
			StartAngle = StartAngle_DefaultValue = "";
			MinAngle = MinAngle_DefaultValue = null;
			ClockWise = ClockWise_DefaultValue = "";
			RoseType = RoseType_DefaultValue = null;
			SelectedOffset = SelectedOffset_DefaultValue = null;
			SelectedMode = SelectedMode_DefaultValue = "";
			PolarIndex = PolarIndex_DefaultValue = null;
			MapType = MapType_DefaultValue = china;
			Hoverable = Hoverable_DefaultValue = null;
			DataRangeHoverLink = DataRangeHoverLink_DefaultValue = null;
			MapLocation = MapLocation_DefaultValue = null;
			MapValueCalculation = MapValueCalculation_DefaultValue = sum;
			MapValuePrecision = MapValuePrecision_DefaultValue = null;
			ShowLegendSymbol = ShowLegendSymbol_DefaultValue = null;
			Roam = Roam_DefaultValue = "";
			ScaleLimit = ScaleLimit_DefaultValue = null;
			NameMap = NameMap_DefaultValue = null;
			TextFixed = TextFixed_DefaultValue = null;
			GeoCoord = GeoCoord_DefaultValue = null;
			Categories = Categories_DefaultValue = "";
			Links = Links_DefaultValue = "";
			Matrix = Matrix_DefaultValue = "";
			Size = Size_DefaultValue = "";
			MinRadius = MinRadius_DefaultValue = "";
			MaxRadius = MaxRadius_DefaultValue = "";
			LinkSymbol = LinkSymbol_DefaultValue = none;
			LinkSymbolSize = LinkSymbolSize_DefaultValue = null;
			Scaling = Scaling_DefaultValue = null;
			Gravity = Gravity_DefaultValue = null;
			Draggable = Draggable_DefaultValue = null;
			UseWorker = UseWorker_DefaultValue = null;
			Steps = Steps_DefaultValue = null;
			RibbonType = RibbonType_DefaultValue = null;
			ShowScale = ShowScale_DefaultValue = null;
			ShowScaleText = ShowScaleText_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			Sort = Sort_DefaultValue = "";
			SortSub = SortSub_DefaultValue = none;
			EndAngle = EndAngle_DefaultValue = null;
			Min = Min_DefaultValue = "";
			Max = Max_DefaultValue = "";
			SplitNumber = SplitNumber_DefaultValue = null;
			AxisLine = AxisLine_DefaultValue = new SeriesItemAxisLine();
			AxisTick = AxisTick_DefaultValue = new SeriesItemAxisTick();
			AxisLabel = AxisLabel_DefaultValue = null;
			SplitLine = SplitLine_DefaultValue = new SeriesItemSplitLine();
			Pointer = Pointer_DefaultValue = new SeriesItemPointer();
			Title = Title_DefaultValue = new SeriesItemTitle();
			Detail = Detail_DefaultValue = new SeriesItemDetail();
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			X2 = X2_DefaultValue = null;
			Y2 = Y2_DefaultValue = null;
			Width = Width_DefaultValue = null;
			Height = Height_DefaultValue = null;
			FunnelAlign = FunnelAlign_DefaultValue = center;
			MinSize = MinSize_DefaultValue = 0%;
			MaxSize = MaxSize_DefaultValue = 100%;
			Gap = Gap_DefaultValue = null;
			Weight = Weight_DefaultValue = null;
			Root = Root_DefaultValue = "";
			RootLocation = RootLocation_DefaultValue = "";
			LayerPadding = LayerPadding_DefaultValue = null;
			NodePadding = NodePadding_DefaultValue = null;
			Orient = Orient_DefaultValue = vertical;
			Direction = Direction_DefaultValue = "";
			TextRotation = TextRotation_DefaultValue = null;
			AutoSize = AutoSize_DefaultValue = null;
			Nodes = Nodes_DefaultValue = "";
			BlurSize = BlurSize_DefaultValue = null;
			GradientColors = GradientColors_DefaultValue = null;
			MinAlpha = MinAlpha_DefaultValue = null;
			ValueScale = ValueScale_DefaultValue = null;
			Opacity = Opacity_DefaultValue = null;
			Heatmap = Heatmap_DefaultValue = new SeriesItemHeatmap();
			MarkPoint = MarkPoint_DefaultValue = null;
			MarkLine = MarkLine_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public  Type { get; set; }
		private  Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// name of series. if the legend is enabled, the value will be indexed to legend.data.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// style of the tooltip. Applicable to this series only. If unspecified, use option.tooltip (See <a href="#tooltip" title="">tooltip</a>), a small "hover box" with detailed information about the item being hovered over.
		/// </summary>
		public Object Tooltip { get; set; }
		private Object Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies data graphic clickable or not, default to true, recommend to false when you do not have a click event handler.
		/// </summary>
		public boolean Clickable { get; set; }
		private boolean Clickable_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  ItemStyle { get; set; }
		private  ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<SeriesItemData> Data { get; set; }
		private List<SeriesItemData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// name of the stack, USELESS in irregular line|bar. It is used in stacked charts with multiple groups of data. For example, stack:'group1' means to stack the values of the data whose stack value is 'group1' in the series array.
		/// </summary>
		public string Stack { get; set; }
		private string Stack_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  XAxisIndex { get; set; }
		private  XAxisIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <a href="#yAxis" title="">yAxis</a> the index of the axis array. Specifies the vertical axis that the data series uses.
		/// </summary>
		public number YAxisIndex { get; set; }
		private number YAxisIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// the distance between each bar. Defaults to  barWidth * 30%. Can also set to be a fixed value.
		/// </summary>
		public string BarGap { get; set; }
		private string BarGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// the distance between each bar cetegory. Defaults to  barCategoryWidth * 20%. Can also set to be a fixed value.
		/// </summary>
		public string BarCategoryGap { get; set; }
		private string BarCategoryGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum height for the bar. Used to prevent tiny item values from affecting interaction.
		/// </summary>
		public number BarMinHeight { get; set; }
		private number BarMinHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// the width of the bar/ candlestick. Adaptive when not specified.
		/// </summary>
		public number BarWidth { get; set; }
		private number BarWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// the maximum width of the bar ( candlestick ). Adaptive when not specified.
		/// </summary>
		public number BarMaxWidth { get; set; }
		private number BarMaxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  SymbolSize { get; set; }
		private  SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  SymbolRotate { get; set; }
		private  SymbolRotate_DefaultValue { get; set; }
		 

		/// <summary>
		/// By default, a symbol will show only when its corresponding axis label does. set it to true if you need to show all the symbols.
		/// </summary>
		public boolean ShowAllSymbol { get; set; }
		private boolean ShowAllSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// smoothed line, while smooth is true, lineStyle.type can not be dashed.
		/// </summary>
		public boolean Smooth { get; set; }
		private boolean Smooth_DefaultValue { get; set; }
		 

		/// <summary>
		/// ECharts will optimize for the situation when data number is much larger than viewport width. It will filter the data showed in one pixel width. And this option is for data filtering strategy.<br>                            Options: 'nearest', 'min', 'max', 'average'.
		/// </summary>
		public boolean DataFilter { get; set; }
		private boolean DataFilter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Large { get; set; }
		private  Large_DefaultValue { get; set; }
		 

		/// <summary>
		/// the threshold of large scale scatter anto-switch. Valid when set to true.
		/// </summary>
		public number LargeThreshold { get; set; }
		private number LargeThreshold_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  LegendHoverLink { get; set; }
		private  LegendHoverLink_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public new string[] Center { get; set; }
		private new string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Radius { get; set; }
		private  Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  StartAngle { get; set; }
		private  StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The minimum angle for the pie. Used to prevent tiny item values from affecting interaction.
		/// </summary>
		public number MinAngle { get; set; }
		private number MinAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  ClockWise { get; set; }
		private  ClockWise_DefaultValue { get; set; }
		 

		/// <summary>
		/// >Nightingale's rose diagram. 'radius' | 'area'
		/// </summary>
		public string RoseType { get; set; }
		private string RoseType_DefaultValue { get; set; }
		 

		/// <summary>
		/// Offset of the sector when selected.
		/// </summary>
		public number SelectedOffset { get; set; }
		private number SelectedOffset_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  SelectedMode { get; set; }
		private  SelectedMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// polar coordinates index.
		/// </summary>
		public number PolarIndex { get; set; }
		private number PolarIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// map type, including World Map, China Map, Map of China Provinces & Cities. For the mapType of China Provinces & Cities, just use simplified Chinese.                                <br>??, ??, ???, ??, ??, ???, ??, ??, ??, ??, ??,                                <br>??, ??, ??, ??, ??, ??, ??, ??, ??, ??, ??, ??,                                <br>??, ??, ??, ??, ??, ??, ??, ??, ??, ??, ??'                                <br>Supports sub-region mode, which develops sub-region maps from the main map types. The format is 'main map type | sub-region name', like                                <br>'world|Brazil', 'china|??'. See <a href="./example/map8.html#-en" target="_blank">example �</a>
		/// </summary>
		public string MapType { get; set; }
		private string MapType_DefaultValue { get; set; }
		 

		/// <summary>
		/// Non-numerical display (eg: only used to display markPoints and markLines). Set it to false to turn off regional hover highlight.
		/// </summary>
		public boolean Hoverable { get; set; }
		private boolean Hoverable_DefaultValue { get; set; }
		 

		/// <summary>
		/// enables dataRange hover link to the chart
		/// </summary>
		public boolean DataRangeHoverLink { get; set; }
		private boolean DataRangeHoverLink_DefaultValue { get; set; }
		 

		/// <summary>
		/// Map location. x, y, width, height are configurable. Valid values for x and y are 'top', 'bottom', 'left', 'right', 'center', or absolute pixel value. Width and height can be set in pixel values. If any parameter is null, it will be adaptive in accordance with other parameters.
		/// </summary>
		public Object MapLocation { get; set; }
		private Object MapLocation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Calculation of map value. Defaults to sum. Valid values are: 'sum' | 'average'
		/// </summary>
		public string MapValueCalculation { get; set; }
		private string MapValueCalculation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decimal precision of map value calculation. Valid when mapValueCalculation is set to average. Defaults to rounding.If decimal precision is needed, set an integer greater than 0.
		/// </summary>
		public number MapValuePrecision { get; set; }
		private number MapValuePrecision_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of show legend symbol (small dots symbolizing different series). Valid when there is a legend.
		/// </summary>
		public boolean ShowLegendSymbol { get; set; }
		private boolean ShowLegendSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Roam { get; set; }
		private  Roam_DefaultValue { get; set; }
		 

		/// <summary>
		/// Controls the limit of wheel zoom. You can specify {max:number, min:number}, max is magnification coefficient, whose valid value should be greater than 1; min is reduction coefficient, whose valid value should be less than 1.
		/// </summary>
		public Object ScaleLimit { get; set; }
		private Object ScaleLimit_DefaultValue { get; set; }
		 

		/// <summary>
		/// name mapping of the custom region, like {'China' : '??'}.
		/// </summary>
		public Object NameMap { get; set; }
		private Object NameMap_DefaultValue { get; set; }
		 

		/// <summary>
		/// fixed location of the name text of a region in px. When the value is positive, move to the lower left; When the value is negative, move to the upper right. Such as {'China' : [10, -10]}.
		/// </summary>
		public Object TextFixed { get; set; }
		private Object TextFixed_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies the location of the name text of a region by absolute latitude and longitude. For example, {'Islands':[113.95, 22.26]}: the name of Hong Kong's Islands District is located at 22.26�N and 113.95�E.
		/// </summary>
		public Object GeoCoord { get; set; }
		private Object GeoCoord_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Categories { get; set; }
		private  Categories_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Links { get; set; }
		private  Links_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Matrix { get; set; }
		private  Matrix_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Size { get; set; }
		private  Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  MinRadius { get; set; }
		private  MinRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  MaxRadius { get; set; }
		private  MaxRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// symbol of force's link. Can be specified as 'arrow'.
		/// </summary>
		public string LinkSymbol { get; set; }
		private string LinkSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// the size of force's link symbol.
		/// </summary>
		public Array LinkSymbolSize { get; set; }
		private Array LinkSymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// layout scaling factor, not entirely accurate, achieves similar effect with the layout size.
		/// </summary>
		public number Scaling { get; set; }
		private number Scaling_DefaultValue { get; set; }
		 

		/// <summary>
		/// centripetal force coefficient. The greater the coefficient, the closer the node is to the center.
		/// </summary>
		public number Gravity { get; set; }
		private number Gravity_DefaultValue { get; set; }
		 

		/// <summary>
		/// specifies whether the node is draggable.
		/// </summary>
		public boolean Draggable { get; set; }
		private boolean Draggable_DefaultValue { get; set; }
		 

		/// <summary>
		/// specifies whether to put layout calculation into web worker when the browser supports web worker.
		/// </summary>
		public boolean UseWorker { get; set; }
		private boolean UseWorker_DefaultValue { get; set; }
		 

		/// <summary>
		/// the number of iterations of each frame layout calculation. Since it takes much more time to render each frame than layout, so when using web worker you can increase the value of steps to balance the two, so as to achieve optimum efficiency.
		/// </summary>
		public number Steps { get; set; }
		private number Steps_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chord with ribbon type is drawed with sector and ribbon shapes. Each ribbon can represent the weight of edge with the size of two ends. Chord without ribbon type is drawed with symbols and bezier curves. Which can't represent edge weight.
		/// </summary>
		public boolean RibbonType { get; set; }
		private boolean RibbonType_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the scale will be showed. Only available if ribbonType is true
		/// </summary>
		public boolean ShowScale { get; set; }
		private boolean ShowScale_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the scale text will be showed. Only available if ribbonType is true
		/// </summary>
		public boolean ShowScaleText { get; set; }
		private boolean ShowScaleText_DefaultValue { get; set; }
		 

		/// <summary>
		/// the distance between each sector (in degrees).
		/// </summary>
		public number Padding { get; set; }
		private number Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Sort { get; set; }
		private  Sort_DefaultValue { get; set; }
		 

		/// <summary>
		/// Data sorting (chord). Can be one of none, ascending, descending.
		/// </summary>
		public string SortSub { get; set; }
		private string SortSub_DefaultValue { get; set; }
		 

		/// <summary>
		/// end angle. Valid range is: [-360,360], ensure that startAngle - endAngle is positive.
		/// </summary>
		public number EndAngle { get; set; }
		private number EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Min { get; set; }
		private  Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public  Max { get; set; }
		private  Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of segments. Defaults to 10.
		/// </summary>
		public number SplitNumber { get; set; }
		private number SplitNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// axis line. Defaults to show.
		/// </summary>
		public SeriesItemAxisLine AxisLine { get; set; }
		private SeriesItemAxisLine AxisLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// axis tick. Defaults to show. 
		/// </summary>
		public SeriesItemAxisTick AxisTick { get; set; }
		private SeriesItemAxisTick AxisTick_DefaultValue { get; set; }
		 

		/// <summary>
		/// axis label.                                <br><br>The property "formatter" controls axisLabel formatting;                                <br><br>The property "textStyle" controls text style for axisLabel.
		/// </summary>
		public Object AxisLabel { get; set; }
		private Object AxisLabel_DefaultValue { get; set; }
		 

		/// <summary>
		/// split line. Defaults to show. 
		/// </summary>
		public SeriesItemSplitLine SplitLine { get; set; }
		private SeriesItemSplitLine SplitLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// pointer style 
		/// </summary>
		public SeriesItemPointer Pointer { get; set; }
		private SeriesItemPointer Pointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// title of gauge
		/// </summary>
		public SeriesItemTitle Title { get; set; }
		private SeriesItemTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// detail of gauge
		/// </summary>
		public SeriesItemDetail Detail { get; set; }
		private SeriesItemDetail Detail_DefaultValue { get; set; }
		 

		/// <summary>
		/// Abscissa on the upper left corner of the grid. In px, or in percent (string) such as '50%' (horizontal center of the display area).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ordinate on the upper left corner of the grid. In px, or in percent (string) such as '50%' (vertical center of the display area).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Abscissa on the lower right corner of the grid. In px, or in percent (string) such as '50%' (horizontal center of the display area).
		/// </summary>
		public string X2 { get; set; }
		private string X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ordinate on the lower right corner of the grid. In px, or in percent (string) such as '50%' (vertical center of the display area).
		/// </summary>
		public string Y2 { get; set; }
		private string Y2_DefaultValue { get; set; }
		 

		/// <summary>
		/// The total width, defaults to the drawing area's total width - x - x2, in px, ignore x2 after specifying height. Can also be set in percent (string), such as '50%' (half the width of the display area).
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The total height, defaults to the drawing area's total height - y - y2, in px, ignore y2 after specifying height. Can also be set in percent (string), such as '50%' (half the height of the display area).
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal layout style, default to 'center', other option can be: 'left' | 'right' | 'center'
		/// </summary>
		public string FunnelAlign { get; set; }
		private string FunnelAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The proportion of the minimum value 'min' to the total width. If the symbol of required min is not sharp triangle, you can set minSize to achieve it.
		/// </summary>
		public string MinSize { get; set; }
		private string MinSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The proportion of the maximum value 'max' to the total width.
		/// </summary>
		public string MaxSize { get; set; }
		private string MaxSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance between data symbols.
		/// </summary>
		public number Gap { get; set; }
		private number Gap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies the weight of this event's series.
		/// </summary>
		public number Weight { get; set; }
		private number Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// Name of root node
		/// </summary>
		public string Root { get; set; }
		private string Root_DefaultValue { get; set; }
		 

		/// <summary>
		/// coordinate of the location of the root, in pixels, percent or keywords.                                <pre>{    x: 'center' | 'left' | 'right' | 'x%' | {number},    y: 'center' | 'top' | 'bottom' | 'y%' | {number}}</pre>
		/// </summary>
		public Object RootLocation { get; set; }
		private Object RootLocation_DefaultValue { get; set; }
		 

		/// <summary>
		/// padding of layers
		/// </summary>
		public number LayerPadding { get; set; }
		private number LayerPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// padding of brothers
		/// </summary>
		public number NodePadding { get; set; }
		private number NodePadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// direction of the tree, 'vertical' | 'horizontal' | 'radial'
		/// </summary>
		public string Orient { get; set; }
		private string Orient_DefaultValue { get; set; }
		 

		/// <summary>
		/// to inverse the direction of the tree, can be: 'inverse'
		/// </summary>
		public string Direction { get; set; }
		private string Direction_DefaultValue { get; set; }
		 

		/// <summary>
		/// List of optional text rotation. In default it has two options: horizontal(0) and vertical(90).
		/// </summary>
		public Array TextRotation { get; set; }
		private Array TextRotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// If enable text size auto calculation. It is recommand to enable to have a better result.
		/// </summary>
		public Object AutoSize { get; set; }
		private Object AutoSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Array Nodes { get; set; }
		private Array Nodes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Blur size of a data point.
		/// </summary>
		public number BlurSize { get; set; }
		private number BlurSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// It could be an array of offset and color like [{ offset: 0.2, color: 'blue' }, { offset 0.8, color: 'cyan' }] or an array of color strings like ['blue', 'cyan', 'lime', 'yellow', 'red'], with which the color will transform evenly.
		/// </summary>
		public Array GradientColors { get; set; }
		private Array GradientColors_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the unified value is less than minAlpha, it will be set to minAlpha to ensure small data value can also be visible on the chart.
		/// </summary>
		public number MinAlpha { get; set; }
		private number MinAlpha_DefaultValue { get; set; }
		 

		/// <summary>
		/// All data values will multiply this value.
		/// </summary>
		public number ValueScale { get; set; }
		private number ValueScale_DefaultValue { get; set; }
		 

		/// <summary>
		/// Opacity of the heatmap.
		/// </summary>
		public number Opacity { get; set; }
		private number Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Heatmap overlaid on map, measured by longitude and latitude. see <a target="_blank" href="./example/heatmap_map.html">heatmap on map</a>
		/// </summary>
		public SeriesItemHeatmap Heatmap { get; set; }
		private SeriesItemHeatmap Heatmap_DefaultValue { get; set; }
		 

		/// <summary>
		/// markPoint.
		/// </summary>
		public Object MarkPoint { get; set; }
		private Object MarkPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// markLine.
		/// </summary>
		public Object MarkLine { get; set; }
		private Object MarkLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// The second grade cascading control, In the same canvas (zlevel), the higher z the closer to the top.
		/// </summary>
		public number Z { get; set; }
		private number Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// The first grade cascading control. Every zlevel will be allocated to a independent canvas, charts and components with the same zlevel will be rendered in the same canvas. The higher zlevel the closer to the top. More canvas dom will need more memory and performance, so never set too many zlevel. Most of the time, the second grade cascading control 'z' is recommended.
		/// </summary>
		public number Zlevel { get; set; }
		private number Zlevel_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Type != Type_DefaultValue) h.Add("type",Type);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Tooltip != Tooltip_DefaultValue) h.Add("tooltip",Tooltip);
			if (Clickable != Clickable_DefaultValue) h.Add("clickable",Clickable);
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			if (Stack != Stack_DefaultValue) h.Add("stack",Stack);
			if (XAxisIndex != XAxisIndex_DefaultValue) h.Add("xAxisIndex",XAxisIndex);
			if (YAxisIndex != YAxisIndex_DefaultValue) h.Add("yAxisIndex",YAxisIndex);
			if (BarGap != BarGap_DefaultValue) h.Add("barGap",BarGap);
			if (BarCategoryGap != BarCategoryGap_DefaultValue) h.Add("barCategoryGap",BarCategoryGap);
			if (BarMinHeight != BarMinHeight_DefaultValue) h.Add("barMinHeight",BarMinHeight);
			if (BarWidth != BarWidth_DefaultValue) h.Add("barWidth",BarWidth);
			if (BarMaxWidth != BarMaxWidth_DefaultValue) h.Add("barMaxWidth",BarMaxWidth);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (SymbolRotate != SymbolRotate_DefaultValue) h.Add("symbolRotate",SymbolRotate);
			if (ShowAllSymbol != ShowAllSymbol_DefaultValue) h.Add("showAllSymbol",ShowAllSymbol);
			if (Smooth != Smooth_DefaultValue) h.Add("smooth",Smooth);
			if (DataFilter != DataFilter_DefaultValue) h.Add("dataFilter",DataFilter);
			if (Large != Large_DefaultValue) h.Add("large",Large);
			if (LargeThreshold != LargeThreshold_DefaultValue) h.Add("largeThreshold",LargeThreshold);
			if (LegendHoverLink != LegendHoverLink_DefaultValue) h.Add("legendHoverLink",LegendHoverLink);
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (MinAngle != MinAngle_DefaultValue) h.Add("minAngle",MinAngle);
			if (ClockWise != ClockWise_DefaultValue) h.Add("clockWise",ClockWise);
			if (RoseType != RoseType_DefaultValue) h.Add("roseType",RoseType);
			if (SelectedOffset != SelectedOffset_DefaultValue) h.Add("selectedOffset",SelectedOffset);
			if (SelectedMode != SelectedMode_DefaultValue) h.Add("selectedMode",SelectedMode);
			if (PolarIndex != PolarIndex_DefaultValue) h.Add("polarIndex",PolarIndex);
			if (MapType != MapType_DefaultValue) h.Add("mapType",MapType);
			if (Hoverable != Hoverable_DefaultValue) h.Add("hoverable",Hoverable);
			if (DataRangeHoverLink != DataRangeHoverLink_DefaultValue) h.Add("dataRangeHoverLink",DataRangeHoverLink);
			if (MapLocation != MapLocation_DefaultValue) h.Add("mapLocation",MapLocation);
			if (MapValueCalculation != MapValueCalculation_DefaultValue) h.Add("mapValueCalculation",MapValueCalculation);
			if (MapValuePrecision != MapValuePrecision_DefaultValue) h.Add("mapValuePrecision",MapValuePrecision);
			if (ShowLegendSymbol != ShowLegendSymbol_DefaultValue) h.Add("showLegendSymbol",ShowLegendSymbol);
			if (Roam != Roam_DefaultValue) h.Add("roam",Roam);
			if (ScaleLimit != ScaleLimit_DefaultValue) h.Add("scaleLimit",ScaleLimit);
			if (NameMap != NameMap_DefaultValue) h.Add("nameMap",NameMap);
			if (TextFixed != TextFixed_DefaultValue) h.Add("textFixed",TextFixed);
			if (GeoCoord != GeoCoord_DefaultValue) h.Add("geoCoord",GeoCoord);
			if (Categories != Categories_DefaultValue) h.Add("categories",Categories);
			if (Links != Links_DefaultValue) h.Add("links",Links);
			if (Matrix != Matrix_DefaultValue) h.Add("matrix",Matrix);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (MinRadius != MinRadius_DefaultValue) h.Add("minRadius",MinRadius);
			if (MaxRadius != MaxRadius_DefaultValue) h.Add("maxRadius",MaxRadius);
			if (LinkSymbol != LinkSymbol_DefaultValue) h.Add("linkSymbol",LinkSymbol);
			if (LinkSymbolSize != LinkSymbolSize_DefaultValue) h.Add("linkSymbolSize",LinkSymbolSize);
			if (Scaling != Scaling_DefaultValue) h.Add("scaling",Scaling);
			if (Gravity != Gravity_DefaultValue) h.Add("gravity",Gravity);
			if (Draggable != Draggable_DefaultValue) h.Add("draggable",Draggable);
			if (UseWorker != UseWorker_DefaultValue) h.Add("useWorker",UseWorker);
			if (Steps != Steps_DefaultValue) h.Add("steps",Steps);
			if (RibbonType != RibbonType_DefaultValue) h.Add("ribbonType",RibbonType);
			if (ShowScale != ShowScale_DefaultValue) h.Add("showScale",ShowScale);
			if (ShowScaleText != ShowScaleText_DefaultValue) h.Add("showScaleText",ShowScaleText);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Sort != Sort_DefaultValue) h.Add("sort",Sort);
			if (SortSub != SortSub_DefaultValue) h.Add("sortSub",SortSub);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (SplitNumber != SplitNumber_DefaultValue) h.Add("splitNumber",SplitNumber);
			if (AxisLine.IsDirty()) h.Add("axisLine",AxisLine.ToHashtable());
			if (AxisTick.IsDirty()) h.Add("axisTick",AxisTick.ToHashtable());
			if (AxisLabel != AxisLabel_DefaultValue) h.Add("axisLabel",AxisLabel);
			if (SplitLine.IsDirty()) h.Add("splitLine",SplitLine.ToHashtable());
			if (Pointer.IsDirty()) h.Add("pointer",Pointer.ToHashtable());
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Detail.IsDirty()) h.Add("detail",Detail.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			if (Y2 != Y2_DefaultValue) h.Add("y2",Y2);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (FunnelAlign != FunnelAlign_DefaultValue) h.Add("funnelAlign",FunnelAlign);
			if (MinSize != MinSize_DefaultValue) h.Add("minSize",MinSize);
			if (MaxSize != MaxSize_DefaultValue) h.Add("maxSize",MaxSize);
			if (Gap != Gap_DefaultValue) h.Add("gap",Gap);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (Root != Root_DefaultValue) h.Add("root",Root);
			if (RootLocation != RootLocation_DefaultValue) h.Add("rootLocation",RootLocation);
			if (LayerPadding != LayerPadding_DefaultValue) h.Add("layerPadding",LayerPadding);
			if (NodePadding != NodePadding_DefaultValue) h.Add("nodePadding",NodePadding);
			if (Orient != Orient_DefaultValue) h.Add("orient",Orient);
			if (Direction != Direction_DefaultValue) h.Add("direction",Direction);
			if (TextRotation != TextRotation_DefaultValue) h.Add("textRotation",TextRotation);
			if (AutoSize != AutoSize_DefaultValue) h.Add("autoSize",AutoSize);
			if (Nodes != Nodes_DefaultValue) h.Add("nodes",Nodes);
			if (BlurSize != BlurSize_DefaultValue) h.Add("blurSize",BlurSize);
			if (GradientColors != GradientColors_DefaultValue) h.Add("gradientColors",GradientColors);
			if (MinAlpha != MinAlpha_DefaultValue) h.Add("minAlpha",MinAlpha);
			if (ValueScale != ValueScale_DefaultValue) h.Add("valueScale",ValueScale);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Heatmap.IsDirty()) h.Add("heatmap",Heatmap.ToHashtable());
			if (MarkPoint != MarkPoint_DefaultValue) h.Add("markPoint",MarkPoint);
			if (MarkLine != MarkLine_DefaultValue) h.Add("markLine",MarkLine);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			

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