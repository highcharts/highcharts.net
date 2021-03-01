Updates in JS libraries affect the Highcharts.NET and Highstock.NET. Review first: https://www.highcharts.com/documentation/changelog
# 8.2.2.3
Fix Animation and PointPlacement

#Version 8.2.2.2
Fix Opacity, YAxisLabels, MenuItem, functions

#Version 8.1.2.4
Fix States objects

#Version 8.0.0.3
Serial key is no required.

#Version 8.0.0.2
Fix events

#Version 8.0.0.1
Fix YAxisLabels

#Version 7.2.1.1
Performance improvements

#Version 7.2.0.2
Add serial key management for .NET Core

#Version 7.1.3.1
Fix multiple the same type events bug

#Version 7.1.2.2
Fix PlotOptionsGaugeDataLabels

#Version 7.1.1.2
Add solution to pass serial key as argument in constructor of HigchartsRenderer or HighstockRenderer.

#Version 7.1.1.1
Move to .NET Standard. Please note that upgrading the wrapper to version 7.1.1.1 may require some changes in your application. Please see http://dotnet.highcharts.com/Highcharts/Demo/Docs?section=UpgradeToStandard for more details.

# Version 7.0.3.10
Please be aware that keys format has been changed with 7.0.3.10. You may need a different key to run our product after an update to 7.0.3.10 or newer. Please contact us at support@highcharts.com

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
- Columnpyramid, Cylinder, Networkgraph, Packedbubble, Venn, Abands, Ao, Apo, Aroonoscillator, Aroon, Chaikin, Dema, Dpo, Keltnerchannels, Linearregressionangle, Natr, Pc, Ppo, Supertrend, Tema, Trix, Williamsr

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

