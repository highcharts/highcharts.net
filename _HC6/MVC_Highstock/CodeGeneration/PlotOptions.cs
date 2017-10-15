using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptions  : BaseObject
	{
		public PlotOptions()
		{
			Ad = Ad_DefaultValue = new PlotOptionsAd();
			Atr = Atr_DefaultValue = new PlotOptionsAtr();
			Bb = Bb_DefaultValue = new PlotOptionsBb();
			Cci = Cci_DefaultValue = new PlotOptionsCci();
			Cmf = Cmf_DefaultValue = new PlotOptionsCmf();
			Ema = Ema_DefaultValue = new PlotOptionsEma();
			Ikh = Ikh_DefaultValue = new PlotOptionsIkh();
			Sma = Sma_DefaultValue = new PlotOptionsSma();
			Macd = Macd_DefaultValue = new PlotOptionsMacd();
			Mfi = Mfi_DefaultValue = new PlotOptionsMfi();
			Momentum = Momentum_DefaultValue = new PlotOptionsMomentum();
			Pivotpoints = Pivotpoints_DefaultValue = new PlotOptionsPivotpoints();
			Priceenvelopes = Priceenvelopes_DefaultValue = new PlotOptionsPriceenvelopes();
			Psar = Psar_DefaultValue = new PlotOptionsPsar();
			Roc = Roc_DefaultValue = new PlotOptionsRoc();
			Rsi = Rsi_DefaultValue = new PlotOptionsRsi();
			Stochastic = Stochastic_DefaultValue = new PlotOptionsStochastic();
			Vbp = Vbp_DefaultValue = new PlotOptionsVbp();
			Vwap = Vwap_DefaultValue = new PlotOptionsVwap();
			Wma = Wma_DefaultValue = new PlotOptionsWma();
			Zigzag = Zigzag_DefaultValue = new PlotOptionsZigzag();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			Streamgraph = Streamgraph_DefaultValue = new PlotOptionsStreamgraph();
			Vector = Vector_DefaultValue = new PlotOptionsVector();
			Windbarb = Windbarb_DefaultValue = new PlotOptionsWindbarb();
			Area = Area_DefaultValue = new PlotOptionsArea();
			Areaspline = Areaspline_DefaultValue = new PlotOptionsAreaspline();
			Candlestick = Candlestick_DefaultValue = new PlotOptionsCandlestick();
			Column = Column_DefaultValue = new PlotOptionsColumn();
			Flags = Flags_DefaultValue = new PlotOptionsFlags();
			Ohlc = Ohlc_DefaultValue = new PlotOptionsOhlc();
			Scatter = Scatter_DefaultValue = new PlotOptionsScatter();
			Line = Line_DefaultValue = new PlotOptionsLine();
			Spline = Spline_DefaultValue = new PlotOptionsSpline();
			Arearange = Arearange_DefaultValue = new PlotOptionsArearange();
			Areasplinerange = Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
			Bubble = Bubble_DefaultValue = new PlotOptionsBubble();
			Columnrange = Columnrange_DefaultValue = new PlotOptionsColumnrange();
			Errorbar = Errorbar_DefaultValue = new PlotOptionsErrorbar();
			Polygon = Polygon_DefaultValue = new PlotOptionsPolygon();
			
		}	
		

		/// <summary>
		/// <p>Accumulation Distribution (AD). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsAd Ad { get; set; }
		private PlotOptionsAd Ad_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Average true range indicator (ATR). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsAtr Atr { get; set; }
		private PlotOptionsAtr Atr_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Bollinger bands (BB). This series requires <code>linkedTo</code>option to be set and should be loaded after <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsBb Bb { get; set; }
		private PlotOptionsBb Bb_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Commodity Channel Index (CCI). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsCci Cci { get; set; }
		private PlotOptionsCci Cci_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Chaikin Money Flow indicator (cmf).</p>
		/// </summary>
		public PlotOptionsCmf Cmf { get; set; }
		private PlotOptionsCmf Cmf_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Exponential moving average indicator (EMA). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsEma Ema { get; set; }
		private PlotOptionsEma Ema_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Ichimoku Kinko Hyo (IKH). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsIkh Ikh { get; set; }
		private PlotOptionsIkh Ikh_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Simple moving average indicator (SMA). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsSma Sma { get; set; }
		private PlotOptionsSma Sma_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Moving Average Convergence Divergence (MACD). This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsMacd Macd { get; set; }
		private PlotOptionsMacd Macd_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Money Flow Index. This series requires <code>linkedTo</code>option to be set and should be loaded after <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsMfi Mfi { get; set; }
		private PlotOptionsMfi Mfi_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Momentum. This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsMomentum Momentum { get; set; }
		private PlotOptionsMomentum Momentum_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pivot points indicator. This series requires <code>linkedTo</code>option to be set and should be loaded after <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsPivotpoints Pivotpoints { get; set; }
		private PlotOptionsPivotpoints Pivotpoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Price envelopes indicator based on <a href="#plotOptions.sma">SMA</a> calculations. This series requires <code>linkedTo</code>option to be set and should be loaded after <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsPriceenvelopes Priceenvelopes { get; set; }
		private PlotOptionsPriceenvelopes Priceenvelopes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Parabolic SAR. This series requires <code>linkedTo</code>option to be set and should be loadedafter <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsPsar Psar { get; set; }
		private PlotOptionsPsar Psar_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Rate of change indicator (ROC). The indicator value for each pointis defined as:</p><p><code>(C - Cn) / Cn * 100</code></p><p>where: <code>C</code> is the close value of the point of the same x in thelinked series and <code>Cn</code> is the close value of the point <code>n</code> periodsago. <code>n</code> is set through <a href="#plotOptions.roc.params.period">period</a>.</p><p>This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsRoc Roc { get; set; }
		private PlotOptionsRoc Roc_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Relative strength index (RSI) technical indicator. This series requires <code>linkedTo</code>option to be set and should be loaded after <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsRsi Rsi { get; set; }
		private PlotOptionsRsi Rsi_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Stochastic oscillator. This series requires <code>linkedTo</code>option to be set and should be loaded after <code>stock/indicators/indicators.js</code> file.</p>
		/// </summary>
		public PlotOptionsStochastic Stochastic { get; set; }
		private PlotOptionsStochastic Stochastic_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Volume By Price indicator.</p><p>This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsVbp Vbp { get; set; }
		private PlotOptionsVbp Vbp_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Volume Weighted Average Price indicator.</p><p>This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsVwap Vwap { get; set; }
		private PlotOptionsVwap Vwap_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Weighted moving average indicator (WMA). This series requires <code>linkedTo</code>option to be set.</p>
		/// </summary>
		public PlotOptionsWma Wma { get; set; }
		private PlotOptionsWma Wma_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Zig Zag indicator.</p><p>This series requires <code>linkedTo</code> option to be set.</p>
		/// </summary>
		public PlotOptionsZigzag Zigzag { get; set; }
		private PlotOptionsZigzag Zigzag_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General options for all series types.</p>
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.</p>
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		private PlotOptionsStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A vector plot is a type of cartesian chart where each point has an X and Yposition, a length and a direction. Vectors are drawn as arrows.</p>
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		private PlotOptionsVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Wind barbs are a convenient way to represent wind speed and direction in onegraphical form. Wind direction is given by the stem direction, and wind speedby the number and shape of barbs.</p>
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		private PlotOptionsWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area series type.</p>
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area spline series is an area series where the graph between the pointsis smoothed into a spline.</p>
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A candlestick chart is a style of financial chart used to describe pricemovements over time.</p>
		/// </summary>
		public PlotOptionsCandlestick Candlestick { get; set; }
		private PlotOptionsCandlestick Candlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Column series display one column per value along an X axis.</p>
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Flags are used to mark events in stock charts. They can be added on thetimeline, or attached to a specific series.</p>
		/// </summary>
		public PlotOptionsFlags Flags { get; set; }
		private PlotOptionsFlags Flags_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An OHLC chart is a style of financial chart used to describe pricemovements over time. It displays open, high, low and close values per datapoint.</p>
		/// </summary>
		public PlotOptionsOhlc Ohlc { get; set; }
		private PlotOptionsOhlc Ohlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A scatter plot uses cartesian coordinates to display values for two variablesfor a set of data.</p>
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A line series displays information as a series of data points connected bystraight line segments.</p>
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A spline series is a special type of line series, where the segments betweenthe data points are smoothed.</p>
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area range series is a carteseian series with higher and lower valuesfor each point along an X axis, where the area between the values is shaded.Requires <code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline. Requires<code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A bubble series is a three dimensional series type where each point rendersan X, Y and Z value. Each points is drawn as a bubble where the positionalong the X and Y axes mark the X and Y values, and the size of the bubblerelates to the Z value. Requires <code>highcharts-more.js</code>.</p>
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The column range is a cartesian series type with higher and lowerY values along an X axis. Requires <code>highcharts-more.js</code>. To displayhorizontal bars, set <a href="#chart.inverted">chart.inverted</a> to <code>true</code>.</p>
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Error bars are a graphical representation of the variability of data and areused on graphs to indicate the error, or uncertainty in a reportedmeasurement.</p>
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the <code>color</code> option, andstroke is applied through <code>lineWidth</code> and <code>lineColor</code> options. Requiresthe <code>highcharts-more.js</code> file.</p>
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Ad.IsDirty()) h.Add("ad",Ad.ToHashtable());
			if (Atr.IsDirty()) h.Add("atr",Atr.ToHashtable());
			if (Bb.IsDirty()) h.Add("bb",Bb.ToHashtable());
			if (Cci.IsDirty()) h.Add("cci",Cci.ToHashtable());
			if (Cmf.IsDirty()) h.Add("cmf",Cmf.ToHashtable());
			if (Ema.IsDirty()) h.Add("ema",Ema.ToHashtable());
			if (Ikh.IsDirty()) h.Add("ikh",Ikh.ToHashtable());
			if (Sma.IsDirty()) h.Add("sma",Sma.ToHashtable());
			if (Macd.IsDirty()) h.Add("macd",Macd.ToHashtable());
			if (Mfi.IsDirty()) h.Add("mfi",Mfi.ToHashtable());
			if (Momentum.IsDirty()) h.Add("momentum",Momentum.ToHashtable());
			if (Pivotpoints.IsDirty()) h.Add("pivotpoints",Pivotpoints.ToHashtable());
			if (Priceenvelopes.IsDirty()) h.Add("priceenvelopes",Priceenvelopes.ToHashtable());
			if (Psar.IsDirty()) h.Add("psar",Psar.ToHashtable());
			if (Roc.IsDirty()) h.Add("roc",Roc.ToHashtable());
			if (Rsi.IsDirty()) h.Add("rsi",Rsi.ToHashtable());
			if (Stochastic.IsDirty()) h.Add("stochastic",Stochastic.ToHashtable());
			if (Vbp.IsDirty()) h.Add("vbp",Vbp.ToHashtable());
			if (Vwap.IsDirty()) h.Add("vwap",Vwap.ToHashtable());
			if (Wma.IsDirty()) h.Add("wma",Wma.ToHashtable());
			if (Zigzag.IsDirty()) h.Add("zigzag",Zigzag.ToHashtable());
			if (Series.IsDirty()) h.Add("series",Series.ToHashtable());
			if (Streamgraph.IsDirty()) h.Add("streamgraph",Streamgraph.ToHashtable());
			if (Vector.IsDirty()) h.Add("vector",Vector.ToHashtable());
			if (Windbarb.IsDirty()) h.Add("windbarb",Windbarb.ToHashtable());
			if (Area.IsDirty()) h.Add("area",Area.ToHashtable());
			if (Areaspline.IsDirty()) h.Add("areaspline",Areaspline.ToHashtable());
			if (Candlestick.IsDirty()) h.Add("candlestick",Candlestick.ToHashtable());
			if (Column.IsDirty()) h.Add("column",Column.ToHashtable());
			if (Flags.IsDirty()) h.Add("flags",Flags.ToHashtable());
			if (Ohlc.IsDirty()) h.Add("ohlc",Ohlc.ToHashtable());
			if (Scatter.IsDirty()) h.Add("scatter",Scatter.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Spline.IsDirty()) h.Add("spline",Spline.ToHashtable());
			if (Arearange.IsDirty()) h.Add("arearange",Arearange.ToHashtable());
			if (Areasplinerange.IsDirty()) h.Add("areasplinerange",Areasplinerange.ToHashtable());
			if (Bubble.IsDirty()) h.Add("bubble",Bubble.ToHashtable());
			if (Columnrange.IsDirty()) h.Add("columnrange",Columnrange.ToHashtable());
			if (Errorbar.IsDirty()) h.Add("errorbar",Errorbar.ToHashtable());
			if (Polygon.IsDirty()) h.Add("polygon",Polygon.ToHashtable());
			

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