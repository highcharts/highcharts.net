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
			Area = Area_DefaultValue = new PlotOptionsArea();
			Arearange = Arearange_DefaultValue = new PlotOptionsArearange();
			Areaspline = Areaspline_DefaultValue = new PlotOptionsAreaspline();
			Areasplinerange = Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
			Atr = Atr_DefaultValue = new PlotOptionsAtr();
			Bb = Bb_DefaultValue = new PlotOptionsBb();
			Bubble = Bubble_DefaultValue = new PlotOptionsBubble();
			Candlestick = Candlestick_DefaultValue = new PlotOptionsCandlestick();
			Cci = Cci_DefaultValue = new PlotOptionsCci();
			Cmf = Cmf_DefaultValue = new PlotOptionsCmf();
			Column = Column_DefaultValue = new PlotOptionsColumn();
			Columnrange = Columnrange_DefaultValue = new PlotOptionsColumnrange();
			Ema = Ema_DefaultValue = new PlotOptionsEma();
			Errorbar = Errorbar_DefaultValue = new PlotOptionsErrorbar();
			Flags = Flags_DefaultValue = new PlotOptionsFlags();
			Ikh = Ikh_DefaultValue = new PlotOptionsIkh();
			Line = Line_DefaultValue = new PlotOptionsLine();
			Macd = Macd_DefaultValue = new PlotOptionsMacd();
			Mfi = Mfi_DefaultValue = new PlotOptionsMfi();
			Momentum = Momentum_DefaultValue = new PlotOptionsMomentum();
			Ohlc = Ohlc_DefaultValue = new PlotOptionsOhlc();
			Pivotpoints = Pivotpoints_DefaultValue = new PlotOptionsPivotpoints();
			Polygon = Polygon_DefaultValue = new PlotOptionsPolygon();
			Priceenvelopes = Priceenvelopes_DefaultValue = new PlotOptionsPriceenvelopes();
			Psar = Psar_DefaultValue = new PlotOptionsPsar();
			Roc = Roc_DefaultValue = new PlotOptionsRoc();
			Rsi = Rsi_DefaultValue = new PlotOptionsRsi();
			Scatter = Scatter_DefaultValue = new PlotOptionsScatter();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			Sma = Sma_DefaultValue = new PlotOptionsSma();
			Spline = Spline_DefaultValue = new PlotOptionsSpline();
			Stochastic = Stochastic_DefaultValue = new PlotOptionsStochastic();
			Streamgraph = Streamgraph_DefaultValue = new PlotOptionsStreamgraph();
			Vbp = Vbp_DefaultValue = new PlotOptionsVbp();
			Vector = Vector_DefaultValue = new PlotOptionsVector();
			Vwap = Vwap_DefaultValue = new PlotOptionsVwap();
			Windbarb = Windbarb_DefaultValue = new PlotOptionsWindbarb();
			Wma = Wma_DefaultValue = new PlotOptionsWma();
			Xrange = Xrange_DefaultValue = new PlotOptionsXrange();
			Zigzag = Zigzag_DefaultValue = new PlotOptionsZigzag();
			
		}	
		

		/// <summary>
		/// Accumulation Distribution (AD). This series requires `linkedTo` option tobe set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `ad` series are defined in [plotOptions.ad](plotOptions.ad).3. Options for one single series are given in[the series instance array](series.ad).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ad: {            // shared options for all ad series        }    },    series: [{        // specific options for this series instance        type: 'ad'    }]});</pre>            
		/// </summary>
		public PlotOptionsAd Ad { get; set; }
		private PlotOptionsAd Ad_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area series type.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `area` series are defined in [plotOptions.area](plotOptions.area).3. Options for one single series are given in[the series instance array](series.area).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        area: {            // shared options for all area series        }    },    series: [{        // specific options for this series instance        type: 'area'    }]});</pre>            
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area range series is a carteseian series with higher and lower valuesfor each point along an X axis, where the area between the values is shaded.Requires `highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `arearange` series are defined in [plotOptions.arearange](plotOptions.arearange).3. Options for one single series are given in[the series instance array](series.arearange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        arearange: {            // shared options for all arearange series        }    },    series: [{        // specific options for this series instance        type: 'arearange'    }]});</pre>            
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline series is an area series where the graph between the pointsis smoothed into a spline.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `areaspline` series are defined in [plotOptions.areaspline](plotOptions.areaspline).3. Options for one single series are given in[the series instance array](series.areaspline).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areaspline: {            // shared options for all areaspline series        }    },    series: [{        // specific options for this series instance        type: 'areaspline'    }]});</pre>            
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline. Requires`highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `areasplinerange` series are defined in [plotOptions.areasplinerange](plotOptions.areasplinerange).3. Options for one single series are given in[the series instance array](series.areasplinerange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areasplinerange: {            // shared options for all areasplinerange series        }    },    series: [{        // specific options for this series instance        type: 'areasplinerange'    }]});</pre>            
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Average true range indicator (ATR). This series requires `linkedTo`option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `atr` series are defined in [plotOptions.atr](plotOptions.atr).3. Options for one single series are given in[the series instance array](series.atr).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        atr: {            // shared options for all atr series        }    },    series: [{        // specific options for this series instance        type: 'atr'    }]});</pre>            
		/// </summary>
		public PlotOptionsAtr Atr { get; set; }
		private PlotOptionsAtr Atr_DefaultValue { get; set; }
		 

		/// <summary>
		/// Bollinger bands (BB). This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `bb` series are defined in [plotOptions.bb](plotOptions.bb).3. Options for one single series are given in[the series instance array](series.bb).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bb: {            // shared options for all bb series        }    },    series: [{        // specific options for this series instance        type: 'bb'    }]});</pre>            
		/// </summary>
		public PlotOptionsBb Bb { get; set; }
		private PlotOptionsBb Bb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each point rendersan X, Y and Z value. Each points is drawn as a bubble where the positionalong the X and Y axes mark the X and Y values, and the size of the bubblerelates to the Z value. Requires `highcharts-more.js`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `bubble` series are defined in [plotOptions.bubble](plotOptions.bubble).3. Options for one single series are given in[the series instance array](series.bubble).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bubble: {            // shared options for all bubble series        }    },    series: [{        // specific options for this series instance        type: 'bubble'    }]});</pre>            
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// A candlestick chart is a style of financial chart used to describe pricemovements over time.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `candlestick` series are defined in [plotOptions.candlestick](plotOptions.candlestick).3. Options for one single series are given in[the series instance array](series.candlestick).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        candlestick: {            // shared options for all candlestick series        }    },    series: [{        // specific options for this series instance        type: 'candlestick'    }]});</pre>            
		/// </summary>
		public PlotOptionsCandlestick Candlestick { get; set; }
		private PlotOptionsCandlestick Candlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Commodity Channel Index (CCI). This series requires `linkedTo` option tobe set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `cci` series are defined in [plotOptions.cci](plotOptions.cci).3. Options for one single series are given in[the series instance array](series.cci).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cci: {            // shared options for all cci series        }    },    series: [{        // specific options for this series instance        type: 'cci'    }]});</pre>            
		/// </summary>
		public PlotOptionsCci Cci { get; set; }
		private PlotOptionsCci Cci_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chaikin Money Flow indicator (cmf).Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `cmf` series are defined in [plotOptions.cmf](plotOptions.cmf).3. Options for one single series are given in[the series instance array](series.cmf).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cmf: {            // shared options for all cmf series        }    },    series: [{        // specific options for this series instance        type: 'cmf'    }]});</pre>            
		/// </summary>
		public PlotOptionsCmf Cmf { get; set; }
		private PlotOptionsCmf Cmf_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column series display one column per value along an X axis.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `column` series are defined in [plotOptions.column](plotOptions.column).3. Options for one single series are given in[the series instance array](series.column).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        column: {            // shared options for all column series        }    },    series: [{        // specific options for this series instance        type: 'column'    }]});</pre>            
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lowerY values along an X axis. Requires `highcharts-more.js`. To displayhorizontal bars, set [chart.inverted](#chart.inverted) to `true`.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `columnrange` series are defined in [plotOptions.columnrange](plotOptions.columnrange).3. Options for one single series are given in[the series instance array](series.columnrange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnrange: {            // shared options for all columnrange series        }    },    series: [{        // specific options for this series instance        type: 'columnrange'    }]});</pre>            
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exponential moving average indicator (EMA). This series requires the`linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `ema` series are defined in [plotOptions.ema](plotOptions.ema).3. Options for one single series are given in[the series instance array](series.ema).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ema: {            // shared options for all ema series        }    },    series: [{        // specific options for this series instance        type: 'ema'    }]});</pre>            
		/// </summary>
		public PlotOptionsEma Ema { get; set; }
		private PlotOptionsEma Ema_DefaultValue { get; set; }
		 

		/// <summary>
		/// Error bars are a graphical representation of the variability of data and areused on graphs to indicate the error, or uncertainty in a reportedmeasurement.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `errorbar` series are defined in [plotOptions.errorbar](plotOptions.errorbar).3. Options for one single series are given in[the series instance array](series.errorbar).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        errorbar: {            // shared options for all errorbar series        }    },    series: [{        // specific options for this series instance        type: 'errorbar'    }]});</pre>            
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Flags are used to mark events in stock charts. They can be added on thetimeline, or attached to a specific series.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `flags` series are defined in [plotOptions.flags](plotOptions.flags).3. Options for one single series are given in[the series instance array](series.flags).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        flags: {            // shared options for all flags series        }    },    series: [{        // specific options for this series instance        type: 'flags'    }]});</pre>            
		/// </summary>
		public PlotOptionsFlags Flags { get; set; }
		private PlotOptionsFlags Flags_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ichimoku Kinko Hyo (IKH). This series requires `linkedTo` option to beset.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `ikh` series are defined in [plotOptions.ikh](plotOptions.ikh).3. Options for one single series are given in[the series instance array](series.ikh).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ikh: {            // shared options for all ikh series        }    },    series: [{        // specific options for this series instance        type: 'ikh'    }]});</pre>            
		/// </summary>
		public PlotOptionsIkh Ikh { get; set; }
		private PlotOptionsIkh Ikh_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line series displays information as a series of data points connected bystraight line segments.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `line` series are defined in [plotOptions.line](plotOptions.line).3. Options for one single series are given in[the series instance array](series.line).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});</pre>            
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// Moving Average Convergence Divergence (MACD). This series requires`linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `macd` series are defined in [plotOptions.macd](plotOptions.macd).3. Options for one single series are given in[the series instance array](series.macd).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        macd: {            // shared options for all macd series        }    },    series: [{        // specific options for this series instance        type: 'macd'    }]});</pre>            
		/// </summary>
		public PlotOptionsMacd Macd { get; set; }
		private PlotOptionsMacd Macd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Money Flow Index. This series requires `linkedTo` option to be set andshould be loaded after the `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `mfi` series are defined in [plotOptions.mfi](plotOptions.mfi).3. Options for one single series are given in[the series instance array](series.mfi).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        mfi: {            // shared options for all mfi series        }    },    series: [{        // specific options for this series instance        type: 'mfi'    }]});</pre>            
		/// </summary>
		public PlotOptionsMfi Mfi { get; set; }
		private PlotOptionsMfi Mfi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Momentum. This series requires `linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `momentum` series are defined in [plotOptions.momentum](plotOptions.momentum).3. Options for one single series are given in[the series instance array](series.momentum).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        momentum: {            // shared options for all momentum series        }    },    series: [{        // specific options for this series instance        type: 'momentum'    }]});</pre>            
		/// </summary>
		public PlotOptionsMomentum Momentum { get; set; }
		private PlotOptionsMomentum Momentum_DefaultValue { get; set; }
		 

		/// <summary>
		/// An OHLC chart is a style of financial chart used to describe pricemovements over time. It displays open, high, low and close values per datapoint.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `ohlc` series are defined in [plotOptions.ohlc](plotOptions.ohlc).3. Options for one single series are given in[the series instance array](series.ohlc).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ohlc: {            // shared options for all ohlc series        }    },    series: [{        // specific options for this series instance        type: 'ohlc'    }]});</pre>            
		/// </summary>
		public PlotOptionsOhlc Ohlc { get; set; }
		private PlotOptionsOhlc Ohlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pivot points indicator. This series requires the `linkedTo` option to beset and should be loaded after `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `pivotpoints` series are defined in [plotOptions.pivotpoints](plotOptions.pivotpoints).3. Options for one single series are given in[the series instance array](series.pivotpoints).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pivotpoints: {            // shared options for all pivotpoints series        }    },    series: [{        // specific options for this series instance        type: 'pivotpoints'    }]});</pre>            
		/// </summary>
		public PlotOptionsPivotpoints Pivotpoints { get; set; }
		private PlotOptionsPivotpoints Pivotpoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the `color` option, andstroke is applied through `lineWidth` and `lineColor` options. Requiresthe `highcharts-more.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `polygon` series are defined in [plotOptions.polygon](plotOptions.polygon).3. Options for one single series are given in[the series instance array](series.polygon).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        polygon: {            // shared options for all polygon series        }    },    series: [{        // specific options for this series instance        type: 'polygon'    }]});</pre>            
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// Price envelopes indicator based on [SMA](#plotOptions.sma) calculations.This series requires the `linkedTo` option to be set and should be loadedafter the `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `priceenvelopes` series are defined in [plotOptions.priceenvelopes](plotOptions.priceenvelopes).3. Options for one single series are given in[the series instance array](series.priceenvelopes).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        priceenvelopes: {            // shared options for all priceenvelopes series        }    },    series: [{        // specific options for this series instance        type: 'priceenvelopes'    }]});</pre>            
		/// </summary>
		public PlotOptionsPriceenvelopes Priceenvelopes { get; set; }
		private PlotOptionsPriceenvelopes Priceenvelopes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Parabolic SAR. This series requires `linkedTo`option to be set and should be loadedafter `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `psar` series are defined in [plotOptions.psar](plotOptions.psar).3. Options for one single series are given in[the series instance array](series.psar).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        psar: {            // shared options for all psar series        }    },    series: [{        // specific options for this series instance        type: 'psar'    }]});</pre>            
		/// </summary>
		public PlotOptionsPsar Psar { get; set; }
		private PlotOptionsPsar Psar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rate of change indicator (ROC). The indicator value for each pointis defined as:`(C - Cn) / Cn * 100`where: `C` is the close value of the point of the same x in thelinked series and `Cn` is the close value of the point `n` periodsago. `n` is set through [period](#plotOptions.roc.params.period).This series requires `linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `roc` series are defined in [plotOptions.roc](plotOptions.roc).3. Options for one single series are given in[the series instance array](series.roc).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        roc: {            // shared options for all roc series        }    },    series: [{        // specific options for this series instance        type: 'roc'    }]});</pre>            
		/// </summary>
		public PlotOptionsRoc Roc { get; set; }
		private PlotOptionsRoc Roc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Relative strength index (RSI) technical indicator. This seriesrequires the `linkedTo` option to be set and should be loaded afterthe `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `rsi` series are defined in [plotOptions.rsi](plotOptions.rsi).3. Options for one single series are given in[the series instance array](series.rsi).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        rsi: {            // shared options for all rsi series        }    },    series: [{        // specific options for this series instance        type: 'rsi'    }]});</pre>            
		/// </summary>
		public PlotOptionsRsi Rsi { get; set; }
		private PlotOptionsRsi Rsi_DefaultValue { get; set; }
		 

		/// <summary>
		/// A scatter plot uses cartesian coordinates to display values for two variablesfor a set of data.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `scatter` series are defined in [plotOptions.scatter](plotOptions.scatter).3. Options for one single series are given in[the series instance array](series.scatter).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter: {            // shared options for all scatter series        }    },    series: [{        // specific options for this series instance        type: 'scatter'    }]});</pre>            
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// General options for all series types.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `line` series are defined in [plotOptions.line](plotOptions.line).3. Options for one single series are given in[the series instance array](series.line).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});</pre>            
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// Simple moving average indicator (SMA). This series requires `linkedTo`option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `sma` series are defined in [plotOptions.sma](plotOptions.sma).3. Options for one single series are given in[the series instance array](series.sma).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sma: {            // shared options for all sma series        }    },    series: [{        // specific options for this series instance        type: 'sma'    }]});</pre>            
		/// </summary>
		public PlotOptionsSma Sma { get; set; }
		private PlotOptionsSma Sma_DefaultValue { get; set; }
		 

		/// <summary>
		/// A spline series is a special type of line series, where the segments betweenthe data points are smoothed.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `spline` series are defined in [plotOptions.spline](plotOptions.spline).3. Options for one single series are given in[the series instance array](series.spline).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        spline: {            // shared options for all spline series        }    },    series: [{        // specific options for this series instance        type: 'spline'    }]});</pre>            
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// Stochastic oscillator. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` file.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `stochastic` series are defined in [plotOptions.stochastic](plotOptions.stochastic).3. Options for one single series are given in[the series instance array](series.stochastic).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        stochastic: {            // shared options for all stochastic series        }    },    series: [{        // specific options for this series instance        type: 'stochastic'    }]});</pre>            
		/// </summary>
		public PlotOptionsStochastic Stochastic { get; set; }
		private PlotOptionsStochastic Stochastic_DefaultValue { get; set; }
		 

		/// <summary>
		/// A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `streamgraph` series are defined in [plotOptions.streamgraph](plotOptions.streamgraph).3. Options for one single series are given in[the series instance array](series.streamgraph).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        streamgraph: {            // shared options for all streamgraph series        }    },    series: [{        // specific options for this series instance        type: 'streamgraph'    }]});</pre>            
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		private PlotOptionsStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume By Price indicator.This series requires `linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `vbp` series are defined in [plotOptions.vbp](plotOptions.vbp).3. Options for one single series are given in[the series instance array](series.vbp).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vbp: {            // shared options for all vbp series        }    },    series: [{        // specific options for this series instance        type: 'vbp'    }]});</pre>            
		/// </summary>
		public PlotOptionsVbp Vbp { get; set; }
		private PlotOptionsVbp Vbp_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vector plot is a type of cartesian chart where each point has an X and Yposition, a length and a direction. Vectors are drawn as arrows.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `vector` series are defined in [plotOptions.vector](plotOptions.vector).3. Options for one single series are given in[the series instance array](series.vector).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vector: {            // shared options for all vector series        }    },    series: [{        // specific options for this series instance        type: 'vector'    }]});</pre>            
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		private PlotOptionsVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume Weighted Average Price indicator.This series requires `linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `vwap` series are defined in [plotOptions.vwap](plotOptions.vwap).3. Options for one single series are given in[the series instance array](series.vwap).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vwap: {            // shared options for all vwap series        }    },    series: [{        // specific options for this series instance        type: 'vwap'    }]});</pre>            
		/// </summary>
		public PlotOptionsVwap Vwap { get; set; }
		private PlotOptionsVwap Vwap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wind barbs are a convenient way to represent wind speed and direction in onegraphical form. Wind direction is given by the stem direction, and wind speedby the number and shape of barbs.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `windbarb` series are defined in [plotOptions.windbarb](plotOptions.windbarb).3. Options for one single series are given in[the series instance array](series.windbarb).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        windbarb: {            // shared options for all windbarb series        }    },    series: [{        // specific options for this series instance        type: 'windbarb'    }]});</pre>            
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		private PlotOptionsWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// Weighted moving average indicator (WMA). This series requires `linkedTo`option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `wma` series are defined in [plotOptions.wma](plotOptions.wma).3. Options for one single series are given in[the series instance array](series.wma).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        wma: {            // shared options for all wma series        }    },    series: [{        // specific options for this series instance        type: 'wma'    }]});</pre>            
		/// </summary>
		public PlotOptionsWma Wma { get; set; }
		private PlotOptionsWma Wma_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X-range series displays ranges on the X axis, typically time intervalswith a start and end date.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `xrange` series are defined in [plotOptions.xrange](plotOptions.xrange).3. Options for one single series are given in[the series instance array](series.xrange).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        xrange: {            // shared options for all xrange series        }    },    series: [{        // specific options for this series instance        type: 'xrange'    }]});</pre>            
		/// </summary>
		public PlotOptionsXrange Xrange { get; set; }
		private PlotOptionsXrange Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Zig Zag indicator.This series requires `linkedTo` option to be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the [plotOptions.series](plotOptions.series)object. 2. Options for all `zigzag` series are defined in [plotOptions.zigzag](plotOptions.zigzag).3. Options for one single series are given in[the series instance array](series.zigzag).<pre>Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        zigzag: {            // shared options for all zigzag series        }    },    series: [{        // specific options for this series instance        type: 'zigzag'    }]});</pre>            
		/// </summary>
		public PlotOptionsZigzag Zigzag { get; set; }
		private PlotOptionsZigzag Zigzag_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Ad.IsDirty()) h.Add("ad",Ad.ToHashtable());
			if (Area.IsDirty()) h.Add("area",Area.ToHashtable());
			if (Arearange.IsDirty()) h.Add("arearange",Arearange.ToHashtable());
			if (Areaspline.IsDirty()) h.Add("areaspline",Areaspline.ToHashtable());
			if (Areasplinerange.IsDirty()) h.Add("areasplinerange",Areasplinerange.ToHashtable());
			if (Atr.IsDirty()) h.Add("atr",Atr.ToHashtable());
			if (Bb.IsDirty()) h.Add("bb",Bb.ToHashtable());
			if (Bubble.IsDirty()) h.Add("bubble",Bubble.ToHashtable());
			if (Candlestick.IsDirty()) h.Add("candlestick",Candlestick.ToHashtable());
			if (Cci.IsDirty()) h.Add("cci",Cci.ToHashtable());
			if (Cmf.IsDirty()) h.Add("cmf",Cmf.ToHashtable());
			if (Column.IsDirty()) h.Add("column",Column.ToHashtable());
			if (Columnrange.IsDirty()) h.Add("columnrange",Columnrange.ToHashtable());
			if (Ema.IsDirty()) h.Add("ema",Ema.ToHashtable());
			if (Errorbar.IsDirty()) h.Add("errorbar",Errorbar.ToHashtable());
			if (Flags.IsDirty()) h.Add("flags",Flags.ToHashtable());
			if (Ikh.IsDirty()) h.Add("ikh",Ikh.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Macd.IsDirty()) h.Add("macd",Macd.ToHashtable());
			if (Mfi.IsDirty()) h.Add("mfi",Mfi.ToHashtable());
			if (Momentum.IsDirty()) h.Add("momentum",Momentum.ToHashtable());
			if (Ohlc.IsDirty()) h.Add("ohlc",Ohlc.ToHashtable());
			if (Pivotpoints.IsDirty()) h.Add("pivotpoints",Pivotpoints.ToHashtable());
			if (Polygon.IsDirty()) h.Add("polygon",Polygon.ToHashtable());
			if (Priceenvelopes.IsDirty()) h.Add("priceenvelopes",Priceenvelopes.ToHashtable());
			if (Psar.IsDirty()) h.Add("psar",Psar.ToHashtable());
			if (Roc.IsDirty()) h.Add("roc",Roc.ToHashtable());
			if (Rsi.IsDirty()) h.Add("rsi",Rsi.ToHashtable());
			if (Scatter.IsDirty()) h.Add("scatter",Scatter.ToHashtable());
			if (Series.IsDirty()) h.Add("series",Series.ToHashtable());
			if (Sma.IsDirty()) h.Add("sma",Sma.ToHashtable());
			if (Spline.IsDirty()) h.Add("spline",Spline.ToHashtable());
			if (Stochastic.IsDirty()) h.Add("stochastic",Stochastic.ToHashtable());
			if (Streamgraph.IsDirty()) h.Add("streamgraph",Streamgraph.ToHashtable());
			if (Vbp.IsDirty()) h.Add("vbp",Vbp.ToHashtable());
			if (Vector.IsDirty()) h.Add("vector",Vector.ToHashtable());
			if (Vwap.IsDirty()) h.Add("vwap",Vwap.ToHashtable());
			if (Windbarb.IsDirty()) h.Add("windbarb",Windbarb.ToHashtable());
			if (Wma.IsDirty()) h.Add("wma",Wma.ToHashtable());
			if (Xrange.IsDirty()) h.Add("xrange",Xrange.ToHashtable());
			if (Zigzag.IsDirty()) h.Add("zigzag",Zigzag.ToHashtable());
			

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