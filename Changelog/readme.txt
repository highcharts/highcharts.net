Updates in JS libraries affect the Highcharts.NET and Highstock.NET. Review first: https://www.highcharts.com/documentation/changelog

# Version 7.0.1

Updates:
- ChartOptions3d.ViewDistance = 25 instead of 100

Add:
- Id to Annotations
- TooltipHeaderShape to series
- Chart.DisplayErrors
- Lang.Navigation
- Chart.DisplayErrors
- Chart.StyledMode
- Land.Navigation
- Legend.BubbleLegend
- Navigation.Bindings
- Navigation.BindingsClassName
- Navigation.Events
- PlotOptions.Columnpyramid
- PlotOptions.Cylinder
- PlotOptions.Networkgraph
- PlotOptions.Packedbubble
- PlotOptions.Venn

# Version 6.2.0

Updates:
- AccessibilityKeyboardNavigation.Mode - enum instead of string
- *Overflow - 'Allow' instead of "None"
- Chart.DefaultSeriesType - string instead of enum
- ChartParallelAxesDateTimeLabelFormats, XAxisDateTimeLabelFormats
- DrilldownDrillUpButtonPosition.Align - enum instead of string

Add:
- AnimationBool, BorderColor, BorderWidth, Clip, DragDrop to *Series
- DragDrop, PointWidth to *SeriesData
- Drag, DragStart, Drop to *SeriesDataEvents and *SeriesPointEvents
- ZoomKey to Chart
- MaxStaggerLines, OverflowBool to *AxesLabels
- TextAlign to ChartParallelAxesTitle


# Version 6.1.1
New:
- CandleStickSeriesPointValKey, OhlcSeriesPointValKey, PlotOptionsCandlestickPointValKey, PlotOptionsOhlcPointValKey, RangeSelectorVerticalAlign
- Outside property inside *Tooltip classes
- ReversedStacks property inside ColorAxis, XAxis, ZAxis, NavigatorXAxis
- LegendLayout.Proximate
- PlotOptionsSunburstDataLabelsRotationMode.Auto

# Version 6.1.0
Fixes:
- PlotOptionsFunnelDataLabelsStyle
- Data.EnablePolling
Add:
- MacdSeriesMacdLineZone
- MacdSeriesSignalLineZone
- PlotOptionsMacdMacdLineZone
- PlotOptionsMacdSignalLineZone
- Categories to XAxis and YAxis for Highstock

# Version 6.0.7
New classes:
- AccessibilityKeyboardNavigation
- *StatesSelect
- *StatesNormal
- LangAccessibility
- PlotOptionsArearangeThreshold, PlotOptionsBoxplotThreshold
- PlotOptionsBubbleMarkerRadius
- PlotOptionsSankeyDataLablesFormat
- *LevelSize for Sunburst
- PlotOptionsTilemapStatesHoverHaloAttributes
- Time
- WordcloudseriesDataLabels
- XrangeSeriesDataPartialFill
- FunnelSeriesDataLabelsAlign
New enums:
- FunnelSeriesDataLabelsAlign
- PieSeriesDataLabelsAlign
- PlotOptionsSunburstDataLabelsRotationMode
- PlotOptionsSunburstLevelSizeUnit
- PlotOptionsSunburstLevelsLevelSizeUnit
- PyramidSeriesDataLabelsAlign
- SunburstSeriesDataLabelsAlign
- SunburstSeriesLevelSizeUnit
- SunburstSeriesLevelsLevelSizeUnit
- VariablepieSeriesDataLabelsAlign
- WordcloudSeriesDataLabelsAlign
- WordcloudSeriesDataLabelsOverflow
- WordcloudSeriesDataLabelsVerticalAlign
Fixes:
- YAxis.Min, YAxis.Max, YAxis.LineColor
- XRangeSeriesData
- Defs
- SankeySeriesNodes
- WordcloudSeriesDataLabels
- Drilldown
- RangeSelectorButton
- IkhSeries, MacdSeries
- NavigatorXAxis, NavigatorYAxis

