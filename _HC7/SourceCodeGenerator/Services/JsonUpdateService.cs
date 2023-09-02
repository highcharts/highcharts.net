using System.Collections.Generic;
using System.Linq;
using SourceCodeGenerator.Services.Objects;
using SourceCodeGenerator.Enums;
using System;

namespace SourceCodeGenerator.Services
{
    public class JsonUpdateService : IJsonUpdateService
    {
        private IDictionary<string, IList<UpdateInfo>> ItemsToUpdate;
        private IDictionary<string, IList<UpdateInfo>> ItemsToUpdateProducts;
        private IDictionary<string, IList<ApiItem>> ChildrenToAdd;

        public JsonUpdateService()
        {
            ItemsToUpdate = new Dictionary<string, IList<UpdateInfo>>();
            ItemsToUpdateProducts = new Dictionary<string, IList<UpdateInfo>>();
            ChildrenToAdd = new Dictionary<string, IList<ApiItem>>();

            Add();
            
        }

        public void Update(ApiItem item)
        {
            if (ChildrenToAdd.ContainsKey(item.FullName))
                foreach (var child in ChildrenToAdd[item.FullName])
                    item.Children.Add(child);

            //title
            if(ItemsToUpdate.ContainsKey(item.Title))
            {
                foreach (var info in ItemsToUpdate[item.Title])
                    UpdateProperty(item, info);
            }

            //fullname
            if (ItemsToUpdate.ContainsKey(item.FullName))
            {
                foreach (var info in ItemsToUpdate[item.FullName])
                    UpdateProperty(item, info);
            }

            AddDefaultNull(item);
            Delete(item);
            SetSmallBooleanDefaults(item);
        }

        public void UpdateProducts(ApiItem item)
        {
            if (string.IsNullOrWhiteSpace(item.FullName))
                return;

            if (ItemsToUpdateProducts.ContainsKey(item.FullName))
            {
                foreach (var info in ItemsToUpdateProducts[item.FullName])
                    UpdateProperty(item, info);
            }
        }

        public void UpdateCSSObject(ApiItem item)
        {
            if (item.FullName.ToLower().EndsWith("style") || item.ReturnType.Contains("Highcharts.Dictionary.<*>") || item.Types.Contains("Highcharts.Dictionary.<*>"))
            {
                item.Types.Clear();
                item.Defaults = string.Empty;
                item.Types.Add(TypeService.CSSRawType);
                item.ReturnType = TypeService.CSSRawType;
            }
        }

        private void UpdateProperty(ApiItem item, UpdateInfo info)
        {
            switch(info.Name)
            {
                case ApiPropertyName.ReturnType:
                    item.ReturnType = info.Value;
                    break;
                case ApiPropertyName.Values:
                    item.Values.Add(info.Value);
                    break;
                case ApiPropertyName.Exclude:
                    item.Exclude.Add(info.Value);
                    break;
                case ApiPropertyName.Extends:
                    item.Extends.Add(info.Value);
                    break;
                case ApiPropertyName.Products:
                    item.Products.Add(info.Value);
                    break;
                case ApiPropertyName.Default:
                    item.Defaults = info.Value;
                    break;
            }
        }

        private void AddDefaultNull(ApiItem item)
        {
            if (item.Values.Any() && string.IsNullOrEmpty(item.Defaults))
                item.Values.Insert(0, "null");
        }

        private void Add()
        {
            ItemsToUpdate.Add("fontSize", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("fontWeight", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("color", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("textOutline", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("cursor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("pointFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("dateFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lineDelimiter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("chart.options3d.frame.visible", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("chart.options3d.frame.size", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            //ItemsToUpdate.Add("padding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("background", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("transition", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.bullet.targetOptions.height", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.bullet.targetOptions.borderWidth", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("borderColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.downloadCSV", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.downloadXLS", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.viewData", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("legend.itemCheckboxStyle.width", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("legend.itemCheckboxStyle.height", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("loading.labelStyle.top", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("loading.style.backgroundColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("loading.style.opacity", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("loading.style.textAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("navigation.menuStyle.border", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("headerFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("followPointer", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("nodeFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.columnrange.marker", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("xAxis.minPadding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("xAxis.maxPadding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("yAxis.minPadding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("yAxis.maxPadding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("yAxis", new List<UpdateInfo>()
                {
                    new UpdateInfo { Name = ApiPropertyName.Exclude, Value = "endOnTick" },
                    new UpdateInfo { Name = ApiPropertyName.Exclude, Value = "startOnTick" },
                    new UpdateInfo { Name = ApiPropertyName.Exclude, Value = "plotBands" }
                });
            ItemsToUpdate.Add("pane.background.backgroundColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("pane.size", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("pane.background.innerRadius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("pane.background.outerRadius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("yAxis.plotBands.innerRadius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("yAxis.plotBands.outerRadius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.treemap.levels.dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.treemap.dataLabels" } });
            //ItemsToUpdate.Add("dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });

            //remove after double type solution will be implemented
            ItemsToUpdate.Add("crosshair", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.series.dataLabels.filter.value", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("annotations.labels.point", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("annotations.shapes.point", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("global.useUTC", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("global.getTimezoneOffset", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("global.timezone", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("global.timezoneOffset", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.ikh.tenkanLine", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.ikh.kijunLine", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.ikh.chikouLine", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.ikh.senkouSpan", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.ikh.senkouSpanA", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.ikh.senkouSpanB", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.macd.signalLine", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.macd.macdLine", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("yAxis.top", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("yAxis.height", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });

            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.arearange", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.areasplinerange", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.boxplot", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.bubble", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.columnrange", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.errorbar", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.funnel", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.pyramid", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.accessibility.seriesTypeDescriptions.waterfall", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });

            ItemsToUpdate.Add("rangeSelector.buttons.dataGrouping", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.dataGrouping" } });

            ItemsToUpdateProducts.Add("drilldown.activeAxisLabelStyle", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });
            ItemsToUpdateProducts.Add("drilldown.activeDataLabelStyle", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });
            ItemsToUpdateProducts.Add("drilldown.allowPointDrilldown", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });
            ItemsToUpdateProducts.Add("drilldown.animation", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });
            ItemsToUpdateProducts.Add("drilldown.drillUpButton", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });
            ItemsToUpdateProducts.Add("drilldown.series", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });

            ItemsToUpdate.Add("series.line.data.dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.dataLabels" } });

            ItemsToUpdate.Add("series.bar.states.hover", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.hover" } });
            ItemsToUpdate.Add("series.bar.states.select", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.select" } });
            ItemsToUpdate.Add("series.bullet.states.hover", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.hover" } });
            ItemsToUpdate.Add("series.bullet.states.select", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.select" } });
            ItemsToUpdate.Add("series.column.states.hover", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.hover" } });
            ItemsToUpdate.Add("series.column.states.select", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.select" } });
            ItemsToUpdate.Add("series.columnrange.states.hover", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.hover" } });
            ItemsToUpdate.Add("series.columnrange.states.select", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.select" } });
            ItemsToUpdate.Add("plotOptions.funnel.states.hover", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.hover" } });
            ItemsToUpdate.Add("plotOptions.columnrange.states.hover", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.states.hover" } });

            ItemsToUpdate.Add("series.funnel.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("series.pie.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.funnel.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.heatmap.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.pie.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.pyramid.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.sankey.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.sunburst.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.treemap.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.variablepie.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.xrange.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("plotOptions.bubble.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("series.pyramid.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("series.sunburst.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("series.variablepie.dataLabels.formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });

            ItemsToUpdate.Add("plotOptions.bubble.marker.lineColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Color" } });
            ItemsToUpdate.Add("plotOptions.bubble.marker.radius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.marker.radius" } });
            ItemsToUpdate.Add("yAxis.lineColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Color" } });
            ItemsToUpdate.Add("yAxis.min", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("yAxis.max", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

            //ItemsToUpdate.Add("plotOptions.column.dataLabels.align", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            //ItemsToUpdate.Add("plotOptions.column.dataLabels.verticalAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "top" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "middle" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "bottom" } });
            //ItemsToUpdate.Add("plotOptions.column.dataLabels.y", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

            ItemsToUpdate.Add("plotOptions.columnrange.pointRange", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.sankey.dataLabels.format", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.dataLabels.format" } });

            ItemsToUpdate.Add("series.sankey.nodes.column", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

            ItemsToUpdate.Add("yAxis.opposite", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("plotOptions.sunburst.levels.dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.sunburst.dataLabels" } });
            ItemsToUpdate.Add("plotOptions.sunburst.levels.levelSize", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.sunburst.levelSize" } });
            ItemsToUpdate.Add("series.sunburst.levels.dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "series.sunburst.dataLabels" } });
            ItemsToUpdate.Add("series.sunburst.levels.levelSize", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "series.sunburst.levelSize" } });

            ItemsToUpdate.Add("plotOptions.bb.topLine.styles.lineColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Color" } });
            ItemsToUpdate.Add("series.bb.topLine.styles.lineColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Color" } });

            ItemsToUpdate.Add("navigator.yAxis.title.text", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.candlestick.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.flags.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.ohlc.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.macd.dataGrouping", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });

            ItemsToUpdate.Add("data.enablePolling", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("plotOptions.macd.signalLine.zones", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.zones" } });
            ItemsToUpdate.Add("plotOptions.macd.macdLine.zones", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.zones" } });

            ItemsToUpdate.Add("plotOptions.series.cursor", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "null" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "default" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "none" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "help" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "pointer" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "crosshair" } });
            ItemsToUpdate.Add("dashStyle", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "Solid" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "ShortDash" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "ShortDot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "ShortDashDot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "ShortDashDotDot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Dot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Dash" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "LongDash" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "DashDot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "LongDashDot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "LongDashDotDot" } });

            ItemsToUpdate.Add("legend.layout", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "horizontal" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "vertical" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "proximate" } });
            ItemsToUpdate.Add("series.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "null" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "line" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "spline" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "column" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "area" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "areaspline" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "pie" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "arearange" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "areasplinerange" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "boxplot" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "bubble" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "columnrange" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "errorbar" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "funnel" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "gauge" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "scatter" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "waterfall" } });

            ItemsToUpdate.Add("plotOptions.series.borderWidth", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Types, Value = "Number" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "0" } });

            ItemsToUpdate.Add("verticalAlign", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "top" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "middle" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "bottom" } });
            ItemsToUpdate.Add("align", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            ItemsToUpdate.Add("plotOptions.series.linecap", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "round" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "square" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "round" } });

            ItemsToUpdate.Add("initialPositionRadius", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("lineColor", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("fillColor", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.item.rows", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.series.marker.states.inactive.opacity", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("accessibility.keyboardNavigation.order", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Array.<string>" } });
            ItemsToUpdate.Add("annotations.crookedLine.controlPointOptions.positioner", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.tunnel.typeOptions.heightControlPoint.positioner", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.events.add", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.events.afterUpdate", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.events.remove", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.fibonacci.typeOptions.backgroundColors", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Array.<string>" } });
            ItemsToUpdate.Add("annotations.measure.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.measure.typeOptions.background.stroke", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("exporting.accessibility.enabled", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("legend.accessibility.enabled", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("legend.accessibility.keyboardNavigation.enabled", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("legend.labelFormatter", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("annotations.fibonacci.typeOptions.lineColors", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Array.<string>" } });

            ItemsToUpdate.Add("annotations.crookedLine.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.elliottWave.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.fibonacci.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.infinityLine.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.pitchfork.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.tunnel.controlPointOptions.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("annotations.tunnel.typeOptions.heightControlPoint.events.drag", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });

            ItemsToUpdateProducts.Add("xAxis.categories", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });
            ItemsToUpdateProducts.Add("yAxis.categories", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Products, Value = "highstock" } });

            ItemsToUpdate.Add("series.networkgraph.nodes.dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "series.networkgraph.dataLabels" } });
            ItemsToUpdate.Add("series.organization.nodes.dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "series.organization.dataLabels" } });

            ItemsToUpdate.Add("plotOptions.packedbubble.layoutAlgorithm.initialPositionRadius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("clusterFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("stockTools.gui.iconsURL", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });

            ItemsToUpdate.Add("enabled", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("lineWidth", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("lineWidthPlus", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

            ItemsToUpdate.Add("series.funnel3d", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "series" } });
            ItemsToUpdate.Add("series.pyramid3d", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "series" } });

            ItemsToUpdate.Add("fillOpacity", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("opacity", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

            ItemsToUpdate.Add("backgroundColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("shape", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("formatter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "function" } });
            ItemsToUpdate.Add("borderRadius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("staggerLines", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("xAxisUnit", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            
            ChildrenToAdd.Add("series.ohlc.data", new List<ApiItem>() { new ApiItem { Title = "close", FullName = "series.ohlc.data.close", ReturnType = "Number" } });

            ItemsToUpdate.Add("legend.enabled", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Default, Value = "null" } });
            ItemsToUpdate.Add("overflow", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "allow" } });

            ItemsToUpdate.Add("position", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            ItemsToUpdate.Add("xAxis.title.textAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            ItemsToUpdate.Add("xAxis.plotBands.label.textAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            ItemsToUpdate.Add("xAxis.plotLines.label.textAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            ItemsToUpdate.Add("yAxis.stackLabels.textAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });

            ItemsToUpdate.Add("plotOptions.arearange.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.boxplot.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            
            ItemsToUpdate.Add("plotOptions.organization.link.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "Default" }, new UpdateInfo { Name = ApiPropertyName.Values, Value= "Default" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Curved" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Straight" } });
            ItemsToUpdate.Add("plotOptions.treegraph.link.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "Curved" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Default" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Curved" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "Straight" } });

            ItemsToUpdate.Add("plotOptions.series.label.maxFontSize", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Default, Value = "null" } });
            ItemsToUpdate.Add("plotOptions.series.label.minFontSize", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Default, Value = "null" } });

            ItemsToUpdate.Add("annotations.fibonacciTimeZones.typeOptions.points", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value= "Object" } });
            ItemsToUpdate.Add("annotations.timeCycles.typeOptions.points", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });

            ItemsToUpdate.Add("lang.accessibility.resetZoomButton", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });

            ItemsToUpdate.Add("sonification.globalContextTracks.valueMapFunction", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "linear" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "logarithmic" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "linear" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" } });
            ItemsToUpdate.Add("sonification.defaultInstrumentOptions.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "instrument" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "speech" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "instrument" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" } });
            ItemsToUpdate.Add("sonification.defaultSpeechOptions.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "instrument" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "speech" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "speech" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" } });
            ItemsToUpdate.Add("sonification.pointGrouping.algorithm", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "minimax" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "first" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "last" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "middle" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "firstlast" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "minimax" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" } });
            ItemsToUpdate.Add("sonification.order", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "sequential" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "simultaneous" }, new UpdateInfo { Name = ApiPropertyName.Default, Value = "sequential" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Enum" } });
            ItemsToUpdate.Add("series.organization.dataLabels.linkTextPath", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.organization.dataLabels.linkTextPath" } });
            ItemsToUpdate.Add("series.organization.nodes.dataLabels.linkTextPath", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.organization.dataLabels.linkTextPath" } });
            ItemsToUpdate.Add("sonification.defaultInstrumentOptions.activeWhen", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("sonification.defaultInstrumentOptions.mapping.pitch.scale", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Default, Value = "new List<double>()" } });
            ItemsToUpdate.Add("plotOptions.columnrange.borderRadius", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("annotations.crookedLine.labelOptions", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });

            ItemsToUpdate.Add("plotOptions.series.boostBlending", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "add" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "multiply" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "darken" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.series.pointIntervalUnit", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "day" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "month" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "year" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.series.stacking", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "normal" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "overlap" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "percent" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "stream" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.series.step", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" }, new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("operator", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" }});
            ItemsToUpdate.Add("plotOptions.networkgraph.layoutAlgorithm.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.packedbubble.layoutAlgorithm.type", new List<UpdateInfo> { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
        }

        public void Delete(ApiItem item)
        {
            if (item.FullName == "chart.renderTo")
                item.Types.Remove("Object");

            if (item.FullName == "plotOptions.series.dataGrouping.approximation")
                item.Types.Remove("function");

            if (item.FullName == "chart.options3d.frame.bottom.visible" || item.FullName == "plotOptions.histogram.binsNumber")
                item.Values.Clear();

            if (item.FullName == "series.stack")
                item.Types.Remove("*");

            if (item.FullName == "plotOptions.packedbubble.layoutAlgorithm.initialPositionRadius" || item.FullName.Equals("plotOptions.treegraph.dataLabels.linkTextPath"))
                item.Extends.Clear();
        }

        private void SetSmallBooleanDefaults(ApiItem item)
        {
            if (item.Defaults == bool.FalseString || item.Defaults == bool.TrueString)
                item.Defaults = item.Defaults.ToLower();
        }

        private IList<ApiItem> GetItemsFromDefaultValue(ApiItem item)
        {
            var defaults = item.Defaults.Trim(new char[] { '{', '}' });
            var children = defaults.Split(',');

            var list = new List<ApiItem>();
            foreach (var child in children)
            {
                var values = child.Split(':');

                if (values.Length < 2)
                    continue;

                var title = GetCleanValue(values[0]);
                var value = GetCleanValue(values[1]);

                double resultDouble;
                if(double.TryParse(value, out resultDouble))
                    list.Add(new ApiItem { ReturnType = TypeService.NumberType, FullName = title, Title = title, Defaults = value, IsParent = true });
                else
                {
                    bool resultBool;
                    if(bool.TryParse(value, out resultBool))
                        list.Add(new ApiItem { ReturnType = TypeService.BoolType, FullName = title, Title = title, Defaults = value, IsParent = true });
                    else
                        list.Add(new ApiItem { ReturnType = TypeService.StringType, FullName = title, Title = title, Defaults = value, IsParent = true });
                }
            }

            return list;
        }

        private string GetCleanValue(string item)
        {
            return item.Trim('"', ' ');
        }
    }

    public interface IJsonUpdateService
    {
        void Update(ApiItem item);
        void UpdateProducts(ApiItem item);
        void UpdateCSSObject(ApiItem item);
    }
}
