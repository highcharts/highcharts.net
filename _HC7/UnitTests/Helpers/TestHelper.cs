using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace HcTests.Helpers
{
    public static class TestHelper
    {
    //    public static PlotOptionsSeries GetPlotOptions(Highcharts hc)
    //    {
    //        switch(hc.Chart.Type)
    //        {

				////case ChartType.Abands:
				////	return hc.PlotOptions.abands;
				////case ChartType.Ad:
				////	return hc.PlotOptions.ad;
				////case ChartType.Ao:
				////	return hc.PlotOptions.ao;
				////case ChartType.Apo:
				////	return hc.PlotOptions.apo;
				//case ChartType.Area:
				//	return hc.PlotOptions.Area;
				//case ChartType.Arearange:
				//	return hc.PlotOptions.Arearange;
				//case ChartType.Areaspline:
				//	return hc.PlotOptions.Areaspline;
				//case ChartType.Areasplinerange:
				//	return hc.PlotOptions.Areasplinerange;
				////case ChartType.Aroon:
				////	return hc.PlotOptions.aroon;
				////case ChartType.Aroonoscillator:
				////	return hc.PlotOptions.aroonoscillator;
				////case ChartType.Atr:
				////	return hc.PlotOptions.atr;
				//case ChartType.Bar:
				//	return hc.PlotOptions.Bar;
				////case ChartType.Bb:
				////	return hc.PlotOptions.bb;
				////case ChartType.Belicurve:
				////	return hc.PlotOptions.balicurve;
				//case ChartType.Boxplot:
				//	return hc.PlotOptions.Boxplot;
				//case ChartType.Bubble:
				//	return hc.PlotOptions.Bubble;
				//case ChartType.Bullet:
				//	return hc.PlotOptions.Bullet;
				////case ChartType.Candlestick:
				////	return hc.PlotOptions.candlestick;
				////case ChartType.Cci:
				////	return hc.PlotOptions.cci;
				////case ChartType.Chaikin:
				////	return hc.PlotOptions.chaikin;
				////case ChartType.Cmf:
				////	return hc.PlotOptions.cmf;
				//case ChartType.Column:
				//	return hc.PlotOptions.Column;
				//case ChartType.Columnpyramid:
				//	return hc.PlotOptions.Columnpyramid;
				//case ChartType.Columnrange:
				//	return hc.PlotOptions.Columnrange;
				//case ChartType.Cylinder:
				//	return hc.PlotOptions.Cylinder;
				////case ChartType.Dema:
				////	return hc.PlotOptions.dema;
				//case ChartType.Dependencywheel:
				//	return hc.PlotOptions.Dependencywheel;
				////case ChartType.Dpo:
				////	return hc.PlotOptions.dpo;
				////case ChartType.Dumbbell:
				////	return hc.PlotOptions.Dumbbell;
				////case ChartType.Ema:
				////	return hc.PlotOptions.ema;
				//case ChartType.Errorbar:
				//	return hc.PlotOptions.Errorbar;
				////case ChartType.Flags:
				////	return hc.PlotOptions.flags;
				//case ChartType.Funnel:
				//	return hc.PlotOptions.Funnel;
				//case ChartType.Funnel3d:
				//	return hc.PlotOptions.Funnel3d;
				////case ChartType.Gantt:
				////	return hc.PlotOptions.gantt;
				//case ChartType.Gauge:
				//	return hc.PlotOptions.Gauge;
				//case ChartType.Heatmap:
				//	return hc.PlotOptions.Heatmap;
				//case ChartType.Histogram:
				//	return hc.PlotOptions.Histogram;
				////case ChartType.Id:
				////	return hc.PlotOptions.id;
				////case ChartType.Ikh:
				////	return hc.PlotOptions.ikh;
				////case ChartType.Index:
				////	return hc.PlotOptions.index;
				//case ChartType.Item:
				//	return hc.PlotOptions.Item;
				////case ChartType.Keltnerchannels:
				////	return hc.PlotOptions.keltnerchannels;
				////case ChartType.Legendindex:
				////	return hc.PlotOptions.legendIndex;
				//case ChartType.Line:
				//	return hc.PlotOptions.Line;
				////case ChartType.Linearregression:
				////	return hc.PlotOptions.linearregression;
				////case ChartType.Linearregressiongle:
				////	return hc.PlotOptions.linearregressiongle;
				////case ChartType.Linearregressionintercept:
				////	return hc.PlotOptions.linearregressionintercept:
				////case ChartType.Linearregressionslope:
				////	return hc.PlotOptions.linearregressionslope;
				//case ChartType.Lollipop:
				//	return hc.PlotOptions.Lollipop;
				////case ChartType.Macd:
				////	return hc.PlotOptions.macd;
				////case ChartType.Map:
				////	return hc.PlotOptions.map;
				////case ChartType.MapData:
				////	return hc.PlotOptions.mapdata;
				////case ChartType.Mapbubble:
				////	return hc.PlotOptions.mapbubble;
				////case ChartType.Mapline:
				////	return hc.PlotOptions.mapline;
				////case ChartType.Mappoint:
				////	return hc.PlotOptions.mappoint;
				////case ChartType.Mfi:
				////	return hc.PlotOptions.mfi;
				////case ChartType.Momentum:
				////	return hc.PlotOptions.momentum;
				////case ChartType.Name:
				////	return hc.PlotOptions.name;
				////case ChartType.Natr:
				////	return hc.PlotOptions.natr;
				//case ChartType.Networkgraph:
				//	return hc.PlotOptions.Networkgraph;
				////case ChartType.Ohlc:
				////	return hc.PlotOptions.ohlc;
				//case ChartType.Organization:
				//	return hc.PlotOptions.Organization;
				//case ChartType.Packedbubble:
				//	return hc.PlotOptions.Packedbubble;
				//case ChartType.Pareto:
				//	return hc.PlotOptions.Pareto;
				////case ChartType.Pc:
				////	return hc.PlotOptions.pc;
				//case ChartType.Pie:
				//	return hc.PlotOptions.Pie;
				////case ChartType.Pivotpoints:
				////	return hc.PlotOptions.pivotpoints;
				//case ChartType.Polygon:
				//	return hc.PlotOptions.Polygon;
				////case ChartType.Ppo:
				////	return hc.PlotOptions.ppo;
				////case ChartType.Priceenvelopes:
				////	return hc.PlotOptions.priceenvelops;
				////case ChartType.Psar:
				////	return hc.PlotOptions.psar;
				//case ChartType.Pyramid:
				//	return hc.PlotOptions.Pyramid;
				////case ChartType.Roc:
				////	return hc.PlotOptions.roc;
				////case ChartType.Rsi:
				////	return hc.PlotOptions.rsi;
				//case ChartType.Sankey:
				//	return hc.PlotOptions.Sankey;
				//case ChartType.Scatter:
				//	return hc.PlotOptions.Scatter;
				//case ChartType.Scatter3d:
				//	return hc.PlotOptions.Scatter3d;
				////case ChartType.Slowstochastic:
				////	return hc.PlotOptions.slowstochastic;
				////case ChartType.Sma:
				////	return hc.PlotOptions.sma;
				//case ChartType.Solidgauge:
				//	return hc.PlotOptions.Solidgauge;
				//case ChartType.Spline:
				//	return hc.PlotOptions.Spline;
				////case ChartType.Stack:
				////	return hc.PlotOptions.stack;
				////case ChartType.Stochastic:
				////	return hc.PlotOptions.stochastic;
				////case ChartType.Streamgraph:
				//	return hc.PlotOptions.Streamgraph;
				//case ChartType.Sunburst:
				//	return hc.PlotOptions.Sunburst;
				////case ChartType.Supertrend:
				////	return hc.PlotOptions.Supertrend;
				////case ChartType.Tema:
				////	return hc.PlotOptions.tema;
				//case ChartType.Tilemap:
				//	return hc.PlotOptions.Tilemap;
				//case ChartType.Timeline:
				//	return hc.PlotOptions.Timeline;
				//case ChartType.Treemap:
				//	return hc.PlotOptions.Treemap;
				////case ChartType.Trendline:
				////	return hc.PlotOptions.trendline;
				////case ChartType.Trix:
				////	return hc.PlotOptions.trix;
				//case ChartType.Variablepie:
				//	return hc.PlotOptions.Variablepie;
				//case ChartType.Variwide:
				//	return hc.PlotOptions.Variwide;
				////case ChartType.Vbp:
				////	return hc.PlotOptions.vbp;
				//case ChartType.Vector:
				//	return hc.PlotOptions.Vector;
				//case ChartType.Venn:
				//	return hc.PlotOptions.Venn;
				////case ChartType.Vwap:
				////	return hc.PlotOptions.vwap;
				//case ChartType.Waterfall:
				//	return hc.PlotOptions.Waterfall;
				////case ChartType.Williamsr:
				////	return hc.PlotOptions.williamsr;
				//case ChartType.Windbarb:
				//	return hc.PlotOptions.Windbarb;
				////case ChartType.Wma:
				////	return hc.PlotOptions.wma;
				//case ChartType.Wordcloud:
				//	return hc.PlotOptions.Wordcloud;
				//case ChartType.Xrange:
				//	return hc.PlotOptions.Xrange;
				////case ChartType.Zigzag:
				////	return hc.PlotOptions.zigzag;


				//default:
    //                return hc.PlotOptions.Line;
    //        }
    //    }

		public static string GetJsonLeadingPath(IEnumerable<string> properties)
        {
			StringBuilder sb = new StringBuilder();
			sb.Append($"\"");
			sb.Append(properties.Aggregate((p, q) => p = $"{p}\":{{\"{q}"));
			sb.Append($"\":{{");

			return sb.ToString();
        }

		public static string GetJsonTrailingString(IEnumerable<string> properties)
        {
			return new string('}', properties.Count());
        }

		public static string GetPropertyString(string name, double value)
        {
			return string.Format(CultureInfo.InvariantCulture, "\"{0}\":{1:N1}", name, value).Replace(",", "");
		}

		public static string GetPropertyString(string name, string value)
        {
			return $"\"{name}\":\"{value}\"";
		}

		public static string GetPropertyString(string name, bool value)
        {
			return $"\"{name}\":{value.ToString().ToLower()}";
        }



    }
}
