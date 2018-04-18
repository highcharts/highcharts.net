using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodeGenerator.Services.Objects;
using SourceCodeGenerator.Enums;

namespace SourceCodeGenerator.Services
{
    public class JsonUpdateService : IJsonUpdateService
    {
        private IDictionary<string, IList<UpdateInfo>> ItemsToUpdate;
        private IDictionary<string, IList<UpdateInfo>> ItemsToUpdateProducts;

        public JsonUpdateService()
        {
            ItemsToUpdate = new Dictionary<string, IList<UpdateInfo>>();
            ItemsToUpdateProducts = new Dictionary<string, IList<UpdateInfo>>();

            Add();
        }

        public void Update(ApiItem item)
        {
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
            }
        }

        private void Add()
        {
            ItemsToUpdate.Add("fontSize",new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("fontWeight", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("color", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("textOutline", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("cursor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("pointFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("millisecond", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("second", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("minute", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("hour", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("day", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("week", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("month", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("year", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("dateFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lineDelimiter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("chart.options3d.frame.visible", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("chart.options3d.frame.size", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("padding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
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
            ItemsToUpdate.Add("chart.pinchType", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "null" } });
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
            ItemsToUpdate.Add("plotOptions.pie", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Exclude, Value = "dataLabels" } });
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

            ItemsToUpdate.Add("plotOptions.arearange.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.threshold" } });
            ItemsToUpdate.Add("plotOptions.boxplot.threshold", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.threshold" } });

            ItemsToUpdate.Add("plotOptions.bubble.marker.lineColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Color" } });
            ItemsToUpdate.Add("plotOptions.bubble.marker.radius", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Extends, Value = "plotOptions.series.marker.radius" } });
            ItemsToUpdate.Add("yAxis.lineColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Color" } });
            ItemsToUpdate.Add("yAxis.min", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("yAxis.max", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

            ItemsToUpdate.Add("plotOptions.column.dataLabels.align", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "left" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "center" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "right" } });
            ItemsToUpdate.Add("plotOptions.column.dataLabels.verticalAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "top" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "middle" }, new UpdateInfo { Name = ApiPropertyName.Values, Value = "bottom" } });
            ItemsToUpdate.Add("plotOptions.column.dataLabels.y", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });

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
        }
    }

    public interface IJsonUpdateService
    {
        void Update(ApiItem item);
        void UpdateProducts(ApiItem item);
    }
}
