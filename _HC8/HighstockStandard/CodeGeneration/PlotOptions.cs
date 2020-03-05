using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptions()
		{
			Abands = Abands_DefaultValue = new PlotOptionsAbands();
			Ad = Ad_DefaultValue = new PlotOptionsAd();
			Ao = Ao_DefaultValue = new PlotOptionsAo();
			Apo = Apo_DefaultValue = new PlotOptionsApo();
			Area = Area_DefaultValue = new PlotOptionsArea();
			Arearange = Arearange_DefaultValue = new PlotOptionsArearange();
			Areaspline = Areaspline_DefaultValue = new PlotOptionsAreaspline();
			Areasplinerange = Areasplinerange_DefaultValue = new PlotOptionsAreasplinerange();
			Aroon = Aroon_DefaultValue = new PlotOptionsAroon();
			Aroonoscillator = Aroonoscillator_DefaultValue = new PlotOptionsAroonoscillator();
			Atr = Atr_DefaultValue = new PlotOptionsAtr();
			Bb = Bb_DefaultValue = new PlotOptionsBb();
			Bubble = Bubble_DefaultValue = new PlotOptionsBubble();
			Candlestick = Candlestick_DefaultValue = new PlotOptionsCandlestick();
			Cci = Cci_DefaultValue = new PlotOptionsCci();
			Chaikin = Chaikin_DefaultValue = new PlotOptionsChaikin();
			Cmf = Cmf_DefaultValue = new PlotOptionsCmf();
			Column = Column_DefaultValue = new PlotOptionsColumn();
			Columnpyramid = Columnpyramid_DefaultValue = new PlotOptionsColumnpyramid();
			Columnrange = Columnrange_DefaultValue = new PlotOptionsColumnrange();
			Dema = Dema_DefaultValue = new PlotOptionsDema();
			Dpo = Dpo_DefaultValue = new PlotOptionsDpo();
			Dumbbell = Dumbbell_DefaultValue = new PlotOptionsDumbbell();
			Ema = Ema_DefaultValue = new PlotOptionsEma();
			Errorbar = Errorbar_DefaultValue = new PlotOptionsErrorbar();
			Flags = Flags_DefaultValue = new PlotOptionsFlags();
			Ikh = Ikh_DefaultValue = new PlotOptionsIkh();
			Keltnerchannels = Keltnerchannels_DefaultValue = new PlotOptionsKeltnerchannels();
			Line = Line_DefaultValue = new PlotOptionsLine();
			Linearregression = Linearregression_DefaultValue = new PlotOptionsLinearregression();
			Linearregressionangle = Linearregressionangle_DefaultValue = new PlotOptionsLinearregressionangle();
			Linearregressionintercept = Linearregressionintercept_DefaultValue = new PlotOptionsLinearregressionintercept();
			Linearregressionslope = Linearregressionslope_DefaultValue = new PlotOptionsLinearregressionslope();
			Lollipop = Lollipop_DefaultValue = new PlotOptionsLollipop();
			Macd = Macd_DefaultValue = new PlotOptionsMacd();
			Mfi = Mfi_DefaultValue = new PlotOptionsMfi();
			Momentum = Momentum_DefaultValue = new PlotOptionsMomentum();
			Natr = Natr_DefaultValue = new PlotOptionsNatr();
			Ohlc = Ohlc_DefaultValue = new PlotOptionsOhlc();
			PackedBubble = PackedBubble_DefaultValue = new PlotOptionsPackedBubble();
			Pc = Pc_DefaultValue = new PlotOptionsPc();
			Pivotpoints = Pivotpoints_DefaultValue = new PlotOptionsPivotpoints();
			Polygon = Polygon_DefaultValue = new PlotOptionsPolygon();
			Ppo = Ppo_DefaultValue = new PlotOptionsPpo();
			Priceenvelopes = Priceenvelopes_DefaultValue = new PlotOptionsPriceenvelopes();
			Psar = Psar_DefaultValue = new PlotOptionsPsar();
			Roc = Roc_DefaultValue = new PlotOptionsRoc();
			Rsi = Rsi_DefaultValue = new PlotOptionsRsi();
			Scatter = Scatter_DefaultValue = new PlotOptionsScatter();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			Slowstochastic = Slowstochastic_DefaultValue = new PlotOptionsSlowstochastic();
			Sma = Sma_DefaultValue = new PlotOptionsSma();
			Spline = Spline_DefaultValue = new PlotOptionsSpline();
			Stochastic = Stochastic_DefaultValue = new PlotOptionsStochastic();
			Streamgraph = Streamgraph_DefaultValue = new PlotOptionsStreamgraph();
			Supertrend = Supertrend_DefaultValue = new PlotOptionsSupertrend();
			Tema = Tema_DefaultValue = new PlotOptionsTema();
			Trendline = Trendline_DefaultValue = new PlotOptionsTrendline();
			Trix = Trix_DefaultValue = new PlotOptionsTrix();
			Vbp = Vbp_DefaultValue = new PlotOptionsVbp();
			Vector = Vector_DefaultValue = new PlotOptionsVector();
			Vwap = Vwap_DefaultValue = new PlotOptionsVwap();
			Williamsr = Williamsr_DefaultValue = new PlotOptionsWilliamsr();
			Windbarb = Windbarb_DefaultValue = new PlotOptionsWindbarb();
			Wma = Wma_DefaultValue = new PlotOptionsWma();
			Xrange = Xrange_DefaultValue = new PlotOptionsXrange();
			Zigzag = Zigzag_DefaultValue = new PlotOptionsZigzag();
			
		}	
		

		/// <summary>
		/// Acceleration bands (ABANDS). This series requires the `linkedTo` optionto be set and should be loaded after the`stock/indicators/indicators.js`.In TypeScript the [type](series.abands.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `abands` series are defined in   [plotOptions.abands](plotOptions.abands).3. Options for one single series are given in   [the series instance array](series.abands).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        abands: {            // shared options for all abands series        }    },    series: [{        // specific options for this series instance        type: 'abands'    }]});```            
		/// </summary>
		public PlotOptionsAbands Abands { get; set; }
		private PlotOptionsAbands Abands_DefaultValue { get; set; }
		 

		/// <summary>
		/// Accumulation Distribution (AD). This series requires `linkedTo` option tobe set.In TypeScript the [type](series.ad.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ad` series are defined in   [plotOptions.ad](plotOptions.ad).3. Options for one single series are given in   [the series instance array](series.ad).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ad: {            // shared options for all ad series        }    },    series: [{        // specific options for this series instance        type: 'ad'    }]});```            
		/// </summary>
		public PlotOptionsAd Ad { get; set; }
		private PlotOptionsAd Ad_DefaultValue { get; set; }
		 

		/// <summary>
		/// Awesome Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`In TypeScript the [type](series.ao.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ao` series are defined in   [plotOptions.ao](plotOptions.ao).3. Options for one single series are given in   [the series instance array](series.ao).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ao: {            // shared options for all ao series        }    },    series: [{        // specific options for this series instance        type: 'ao'    }]});```            
		/// </summary>
		public PlotOptionsAo Ao { get; set; }
		private PlotOptionsAo Ao_DefaultValue { get; set; }
		 

		/// <summary>
		/// Absolute Price Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`and `stock/indicators/ema.js`.In TypeScript the [type](series.apo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `apo` series are defined in   [plotOptions.apo](plotOptions.apo).3. Options for one single series are given in   [the series instance array](series.apo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        apo: {            // shared options for all apo series        }    },    series: [{        // specific options for this series instance        type: 'apo'    }]});```            
		/// </summary>
		public PlotOptionsApo Apo { get; set; }
		private PlotOptionsApo Apo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area series type.In TypeScript the [type](series.area.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `area` series are defined in   [plotOptions.area](plotOptions.area).3. Options for one single series are given in   [the series instance array](series.area).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        area: {            // shared options for all area series        }    },    series: [{        // specific options for this series instance        type: 'area'    }]});```            
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		private PlotOptionsArea Area_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area range series is a carteseian series with higher and lower values foreach point along an X axis, where the area between the values is shaded.In TypeScript the [type](series.arearange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `arearange` series are defined in   [plotOptions.arearange](plotOptions.arearange).3. Options for one single series are given in   [the series instance array](series.arearange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        arearange: {            // shared options for all arearange series        }    },    series: [{        // specific options for this series instance        type: 'arearange'    }]});```            
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		private PlotOptionsArearange Arearange_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline series is an area series where the graph between thepoints is smoothed into a spline.In TypeScript the [type](series.areaspline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `areaspline` series are defined in   [plotOptions.areaspline](plotOptions.areaspline).3. Options for one single series are given in   [the series instance array](series.areaspline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areaspline: {            // shared options for all areaspline series        }    },    series: [{        // specific options for this series instance        type: 'areaspline'    }]});```            
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		private PlotOptionsAreaspline Areaspline_DefaultValue { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline.In TypeScript the [type](series.areasplinerange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `areasplinerange` series are defined in   [plotOptions.areasplinerange](plotOptions.areasplinerange).3. Options for one single series are given in   [the series instance array](series.areasplinerange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areasplinerange: {            // shared options for all areasplinerange series        }    },    series: [{        // specific options for this series instance        type: 'areasplinerange'    }]});```            
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		private PlotOptionsAreasplinerange Areasplinerange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Aroon. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.aroon.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `aroon` series are defined in   [plotOptions.aroon](plotOptions.aroon).3. Options for one single series are given in   [the series instance array](series.aroon).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        aroon: {            // shared options for all aroon series        }    },    series: [{        // specific options for this series instance        type: 'aroon'    }]});```            
		/// </summary>
		public PlotOptionsAroon Aroon { get; set; }
		private PlotOptionsAroon Aroon_DefaultValue { get; set; }
		 

		/// <summary>
		/// Aroon Oscillator. This series requires the `linkedTo` option to be setand should be loaded after the `stock/indicators/indicators.js` and`stock/indicators/aroon.js`.In TypeScript the [type](series.aroonoscillator.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `aroonoscillator` series are defined in   [plotOptions.aroonoscillator](plotOptions.aroonoscillator).3. Options for one single series are given in   [the series instance array](series.aroonoscillator).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        aroonoscillator: {            // shared options for all aroonoscillator series        }    },    series: [{        // specific options for this series instance        type: 'aroonoscillator'    }]});```            
		/// </summary>
		public PlotOptionsAroonoscillator Aroonoscillator { get; set; }
		private PlotOptionsAroonoscillator Aroonoscillator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Average true range indicator (ATR). This series requires `linkedTo`option to be set.In TypeScript the [type](series.atr.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `atr` series are defined in   [plotOptions.atr](plotOptions.atr).3. Options for one single series are given in   [the series instance array](series.atr).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        atr: {            // shared options for all atr series        }    },    series: [{        // specific options for this series instance        type: 'atr'    }]});```            
		/// </summary>
		public PlotOptionsAtr Atr { get; set; }
		private PlotOptionsAtr Atr_DefaultValue { get; set; }
		 

		/// <summary>
		/// Bollinger bands (BB). This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.bb.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bb` series are defined in   [plotOptions.bb](plotOptions.bb).3. Options for one single series are given in   [the series instance array](series.bb).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bb: {            // shared options for all bb series        }    },    series: [{        // specific options for this series instance        type: 'bb'    }]});```            
		/// </summary>
		public PlotOptionsBb Bb { get; set; }
		private PlotOptionsBb Bb_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each point rendersan X, Y and Z value. Each points is drawn as a bubble where the positionalong the X and Y axes mark the X and Y values, and the size of the bubblerelates to the Z value.In TypeScript the [type](series.bubble.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bubble` series are defined in   [plotOptions.bubble](plotOptions.bubble).3. Options for one single series are given in   [the series instance array](series.bubble).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bubble: {            // shared options for all bubble series        }    },    series: [{        // specific options for this series instance        type: 'bubble'    }]});```            
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		private PlotOptionsBubble Bubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// A candlestick chart is a style of financial chart used to describe pricemovements over time.In TypeScript the [type](series.candlestick.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `candlestick` series are defined in   [plotOptions.candlestick](plotOptions.candlestick).3. Options for one single series are given in   [the series instance array](series.candlestick).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        candlestick: {            // shared options for all candlestick series        }    },    series: [{        // specific options for this series instance        type: 'candlestick'    }]});```            
		/// </summary>
		public PlotOptionsCandlestick Candlestick { get; set; }
		private PlotOptionsCandlestick Candlestick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Commodity Channel Index (CCI). This series requires `linkedTo` option tobe set.In TypeScript the [type](series.cci.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `cci` series are defined in   [plotOptions.cci](plotOptions.cci).3. Options for one single series are given in   [the series instance array](series.cci).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cci: {            // shared options for all cci series        }    },    series: [{        // specific options for this series instance        type: 'cci'    }]});```            
		/// </summary>
		public PlotOptionsCci Cci { get; set; }
		private PlotOptionsCci Cci_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chaikin Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`and `stock/indicators/ema.js`.In TypeScript the [type](series.chaikin.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `chaikin` series are defined in   [plotOptions.chaikin](plotOptions.chaikin).3. Options for one single series are given in   [the series instance array](series.chaikin).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        chaikin: {            // shared options for all chaikin series        }    },    series: [{        // specific options for this series instance        type: 'chaikin'    }]});```            
		/// </summary>
		public PlotOptionsChaikin Chaikin { get; set; }
		private PlotOptionsChaikin Chaikin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chaikin Money Flow indicator (cmf).In TypeScript the [type](series.cmf.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `cmf` series are defined in   [plotOptions.cmf](plotOptions.cmf).3. Options for one single series are given in   [the series instance array](series.cmf).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cmf: {            // shared options for all cmf series        }    },    series: [{        // specific options for this series instance        type: 'cmf'    }]});```            
		/// </summary>
		public PlotOptionsCmf Cmf { get; set; }
		private PlotOptionsCmf Cmf_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column series display one column per value along an X axis.In TypeScript the [type](series.column.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `column` series are defined in   [plotOptions.column](plotOptions.column).3. Options for one single series are given in   [the series instance array](series.column).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        column: {            // shared options for all column series        }    },    series: [{        // specific options for this series instance        type: 'column'    }]});```            
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		private PlotOptionsColumn Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// Column pyramid series display one pyramid per value along an X axis.To display horizontal pyramids, set [chart.inverted](#chart.inverted) to`true`.In TypeScript the [type](series.columnpyramid.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `columnpyramid` series are defined in   [plotOptions.columnpyramid](plotOptions.columnpyramid).3. Options for one single series are given in   [the series instance array](series.columnpyramid).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnpyramid: {            // shared options for all columnpyramid series        }    },    series: [{        // specific options for this series instance        type: 'columnpyramid'    }]});```            
		/// </summary>
		public PlotOptionsColumnpyramid Columnpyramid { get; set; }
		private PlotOptionsColumnpyramid Columnpyramid_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lowerY values along an X axis. To display horizontal bars, set[chart.inverted](#chart.inverted) to `true`.In TypeScript the [type](series.columnrange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `columnrange` series are defined in   [plotOptions.columnrange](plotOptions.columnrange).3. Options for one single series are given in   [the series instance array](series.columnrange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnrange: {            // shared options for all columnrange series        }    },    series: [{        // specific options for this series instance        type: 'columnrange'    }]});```            
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		private PlotOptionsColumnrange Columnrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Double exponential moving average (DEMA) indicator. This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js` and `stock/indicators/ema.js`.In TypeScript the [type](series.dema.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dema` series are defined in   [plotOptions.dema](plotOptions.dema).3. Options for one single series are given in   [the series instance array](series.dema).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dema: {            // shared options for all dema series        }    },    series: [{        // specific options for this series instance        type: 'dema'    }]});```            
		/// </summary>
		public PlotOptionsDema Dema { get; set; }
		private PlotOptionsDema Dema_DefaultValue { get; set; }
		 

		/// <summary>
		/// Detrended Price Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.dpo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dpo` series are defined in   [plotOptions.dpo](plotOptions.dpo).3. Options for one single series are given in   [the series instance array](series.dpo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dpo: {            // shared options for all dpo series        }    },    series: [{        // specific options for this series instance        type: 'dpo'    }]});```            
		/// </summary>
		public PlotOptionsDpo Dpo { get; set; }
		private PlotOptionsDpo Dpo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The dumbbell series is a cartesian series with higher and lower values foreach point along an X axis, connected with a line between the values.Requires `highcharts-more.js` and `modules/dumbbell.js`.In TypeScript the [type](series.dumbbell.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dumbbell` series are defined in   [plotOptions.dumbbell](plotOptions.dumbbell).3. Options for one single series are given in   [the series instance array](series.dumbbell).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dumbbell: {            // shared options for all dumbbell series        }    },    series: [{        // specific options for this series instance        type: 'dumbbell'    }]});```            
		/// </summary>
		public PlotOptionsDumbbell Dumbbell { get; set; }
		private PlotOptionsDumbbell Dumbbell_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exponential moving average indicator (EMA). This series requires the`linkedTo` option to be set.In TypeScript the [type](series.ema.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ema` series are defined in   [plotOptions.ema](plotOptions.ema).3. Options for one single series are given in   [the series instance array](series.ema).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ema: {            // shared options for all ema series        }    },    series: [{        // specific options for this series instance        type: 'ema'    }]});```            
		/// </summary>
		public PlotOptionsEma Ema { get; set; }
		private PlotOptionsEma Ema_DefaultValue { get; set; }
		 

		/// <summary>
		/// Error bars are a graphical representation of the variability of data and areused on graphs to indicate the error, or uncertainty in a reportedmeasurement.In TypeScript the [type](series.errorbar.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `errorbar` series are defined in   [plotOptions.errorbar](plotOptions.errorbar).3. Options for one single series are given in   [the series instance array](series.errorbar).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        errorbar: {            // shared options for all errorbar series        }    },    series: [{        // specific options for this series instance        type: 'errorbar'    }]});```            
		/// </summary>
		public PlotOptionsErrorbar Errorbar { get; set; }
		private PlotOptionsErrorbar Errorbar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Flags are used to mark events in stock charts. They can be added on thetimeline, or attached to a specific series.In TypeScript the [type](series.flags.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `flags` series are defined in   [plotOptions.flags](plotOptions.flags).3. Options for one single series are given in   [the series instance array](series.flags).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        flags: {            // shared options for all flags series        }    },    series: [{        // specific options for this series instance        type: 'flags'    }]});```            
		/// </summary>
		public PlotOptionsFlags Flags { get; set; }
		private PlotOptionsFlags Flags_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ichimoku Kinko Hyo (IKH). This series requires `linkedTo` option to beset.In TypeScript the [type](series.ikh.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ikh` series are defined in   [plotOptions.ikh](plotOptions.ikh).3. Options for one single series are given in   [the series instance array](series.ikh).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ikh: {            // shared options for all ikh series        }    },    series: [{        // specific options for this series instance        type: 'ikh'    }]});```            
		/// </summary>
		public PlotOptionsIkh Ikh { get; set; }
		private PlotOptionsIkh Ikh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Keltner Channels. This series requires the `linkedTo` option to be setand should be loaded after the `stock/indicators/indicators.js`,`stock/indicators/atr.js`, and `stock/ema/.js`.In TypeScript the [type](series.keltnerchannels.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `keltnerchannels` series are defined in   [plotOptions.keltnerchannels](plotOptions.keltnerchannels).3. Options for one single series are given in   [the series instance array](series.keltnerchannels).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        keltnerchannels: {            // shared options for all keltnerchannels series        }    },    series: [{        // specific options for this series instance        type: 'keltnerchannels'    }]});```            
		/// </summary>
		public PlotOptionsKeltnerchannels Keltnerchannels { get; set; }
		private PlotOptionsKeltnerchannels Keltnerchannels_DefaultValue { get; set; }
		 

		/// <summary>
		/// A line series displays information as a series of data points connected bystraight line segments.In TypeScript the [type](series.line.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `line` series are defined in   [plotOptions.line](plotOptions.line).3. Options for one single series are given in   [the series instance array](series.line).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});```            
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		private PlotOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear regression indicator. This series requires `linkedTo` option to beset.In TypeScript the [type](series.linearregression.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregression` series are defined in   [plotOptions.linearregression](plotOptions.linearregression).3. Options for one single series are given in   [the series instance array](series.linearregression).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregression: {            // shared options for all linearregression series        }    },    series: [{        // specific options for this series instance        type: 'linearregression'    }]});```            
		/// </summary>
		public PlotOptionsLinearregression Linearregression { get; set; }
		private PlotOptionsLinearregression Linearregression_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear regression angle indicator. This series requires `linkedTo`option to be set.In TypeScript the [type](series.linearregressionangle.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregressionangle` series are defined in   [plotOptions.linearregressionangle](plotOptions.linearregressionangle).3. Options for one single series are given in   [the series instance array](series.linearregressionangle).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregressionangle: {            // shared options for all linearregressionangle series        }    },    series: [{        // specific options for this series instance        type: 'linearregressionangle'    }]});```            
		/// </summary>
		public PlotOptionsLinearregressionangle Linearregressionangle { get; set; }
		private PlotOptionsLinearregressionangle Linearregressionangle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear regression intercept indicator. This series requires `linkedTo`option to be set.In TypeScript the [type](series.linearregressionintercept.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregressionintercept` series are defined in   [plotOptions.linearregressionintercept](plotOptions.linearregressionintercept).3. Options for one single series are given in   [the series instance array](series.linearregressionintercept).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregressionintercept: {            // shared options for all linearregressionintercept series        }    },    series: [{        // specific options for this series instance        type: 'linearregressionintercept'    }]});```            
		/// </summary>
		public PlotOptionsLinearregressionintercept Linearregressionintercept { get; set; }
		private PlotOptionsLinearregressionintercept Linearregressionintercept_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear regression slope indicator. This series requires `linkedTo`option to be set.In TypeScript the [type](series.linearregressionslope.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregressionslope` series are defined in   [plotOptions.linearregressionslope](plotOptions.linearregressionslope).3. Options for one single series are given in   [the series instance array](series.linearregressionslope).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregressionslope: {            // shared options for all linearregressionslope series        }    },    series: [{        // specific options for this series instance        type: 'linearregressionslope'    }]});```            
		/// </summary>
		public PlotOptionsLinearregressionslope Linearregressionslope { get; set; }
		private PlotOptionsLinearregressionslope Linearregressionslope_DefaultValue { get; set; }
		 

		/// <summary>
		/// The lollipop series is a carteseian series with a line anchored fromthe x axis and a dot at the end to mark the value.Requires `highcharts-more.js`, `modules/dumbbell.js` and`modules/lollipop.js`.In TypeScript the [type](series.lollipop.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `lollipop` series are defined in   [plotOptions.lollipop](plotOptions.lollipop).3. Options for one single series are given in   [the series instance array](series.lollipop).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        lollipop: {            // shared options for all lollipop series        }    },    series: [{        // specific options for this series instance        type: 'lollipop'    }]});```            
		/// </summary>
		public PlotOptionsLollipop Lollipop { get; set; }
		private PlotOptionsLollipop Lollipop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Moving Average Convergence Divergence (MACD). This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js` and `stock/indicators/ema.js`.In TypeScript the [type](series.macd.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `macd` series are defined in   [plotOptions.macd](plotOptions.macd).3. Options for one single series are given in   [the series instance array](series.macd).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        macd: {            // shared options for all macd series        }    },    series: [{        // specific options for this series instance        type: 'macd'    }]});```            
		/// </summary>
		public PlotOptionsMacd Macd { get; set; }
		private PlotOptionsMacd Macd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Money Flow Index. This series requires `linkedTo` option to be set andshould be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.mfi.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `mfi` series are defined in   [plotOptions.mfi](plotOptions.mfi).3. Options for one single series are given in   [the series instance array](series.mfi).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        mfi: {            // shared options for all mfi series        }    },    series: [{        // specific options for this series instance        type: 'mfi'    }]});```            
		/// </summary>
		public PlotOptionsMfi Mfi { get; set; }
		private PlotOptionsMfi Mfi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Momentum. This series requires `linkedTo` option to be set.In TypeScript the [type](series.momentum.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `momentum` series are defined in   [plotOptions.momentum](plotOptions.momentum).3. Options for one single series are given in   [the series instance array](series.momentum).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        momentum: {            // shared options for all momentum series        }    },    series: [{        // specific options for this series instance        type: 'momentum'    }]});```            
		/// </summary>
		public PlotOptionsMomentum Momentum { get; set; }
		private PlotOptionsMomentum Momentum_DefaultValue { get; set; }
		 

		/// <summary>
		/// Normalized average true range indicator (NATR). This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js` and `stock/indicators/atr.js`.In TypeScript the [type](series.natr.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `natr` series are defined in   [plotOptions.natr](plotOptions.natr).3. Options for one single series are given in   [the series instance array](series.natr).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        natr: {            // shared options for all natr series        }    },    series: [{        // specific options for this series instance        type: 'natr'    }]});```            
		/// </summary>
		public PlotOptionsNatr Natr { get; set; }
		private PlotOptionsNatr Natr_DefaultValue { get; set; }
		 

		/// <summary>
		/// An OHLC chart is a style of financial chart used to describe pricemovements over time. It displays open, high, low and close values perdata point.In TypeScript the [type](series.ohlc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ohlc` series are defined in   [plotOptions.ohlc](plotOptions.ohlc).3. Options for one single series are given in   [the series instance array](series.ohlc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ohlc: {            // shared options for all ohlc series        }    },    series: [{        // specific options for this series instance        type: 'ohlc'    }]});```            
		/// </summary>
		public PlotOptionsOhlc Ohlc { get; set; }
		private PlotOptionsOhlc Ohlc_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPackedBubble PackedBubble { get; set; }
		private PlotOptionsPackedBubble PackedBubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// Price channel (PC). This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.pc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pc` series are defined in   [plotOptions.pc](plotOptions.pc).3. Options for one single series are given in   [the series instance array](series.pc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pc: {            // shared options for all pc series        }    },    series: [{        // specific options for this series instance        type: 'pc'    }]});```            
		/// </summary>
		public PlotOptionsPc Pc { get; set; }
		private PlotOptionsPc Pc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pivot points indicator. This series requires the `linkedTo` option to beset and should be loaded after `stock/indicators/indicators.js` file.In TypeScript the [type](series.pivotpoints.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pivotpoints` series are defined in   [plotOptions.pivotpoints](plotOptions.pivotpoints).3. Options for one single series are given in   [the series instance array](series.pivotpoints).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pivotpoints: {            // shared options for all pivotpoints series        }    },    series: [{        // specific options for this series instance        type: 'pivotpoints'    }]});```            
		/// </summary>
		public PlotOptionsPivotpoints Pivotpoints { get; set; }
		private PlotOptionsPivotpoints Pivotpoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the `color` option, andstroke is applied through `lineWidth` and `lineColor` options.In TypeScript the [type](series.polygon.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `polygon` series are defined in   [plotOptions.polygon](plotOptions.polygon).3. Options for one single series are given in   [the series instance array](series.polygon).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        polygon: {            // shared options for all polygon series        }    },    series: [{        // specific options for this series instance        type: 'polygon'    }]});```            
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		private PlotOptionsPolygon Polygon_DefaultValue { get; set; }
		 

		/// <summary>
		/// Percentage Price Oscillator. This series requires the`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js` and `stock/indicators/ema.js`.In TypeScript the [type](series.ppo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ppo` series are defined in   [plotOptions.ppo](plotOptions.ppo).3. Options for one single series are given in   [the series instance array](series.ppo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ppo: {            // shared options for all ppo series        }    },    series: [{        // specific options for this series instance        type: 'ppo'    }]});```            
		/// </summary>
		public PlotOptionsPpo Ppo { get; set; }
		private PlotOptionsPpo Ppo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Price envelopes indicator based on [SMA](#plotOptions.sma) calculations.This series requires the `linkedTo` option to be set and should be loadedafter the `stock/indicators/indicators.js` file.In TypeScript the [type](series.priceenvelopes.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `priceenvelopes` series are defined in   [plotOptions.priceenvelopes](plotOptions.priceenvelopes).3. Options for one single series are given in   [the series instance array](series.priceenvelopes).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        priceenvelopes: {            // shared options for all priceenvelopes series        }    },    series: [{        // specific options for this series instance        type: 'priceenvelopes'    }]});```            
		/// </summary>
		public PlotOptionsPriceenvelopes Priceenvelopes { get; set; }
		private PlotOptionsPriceenvelopes Priceenvelopes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Parabolic SAR. This series requires `linkedTo`option to be set and should be loadedafter `stock/indicators/indicators.js` file.In TypeScript the [type](series.psar.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `psar` series are defined in   [plotOptions.psar](plotOptions.psar).3. Options for one single series are given in   [the series instance array](series.psar).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        psar: {            // shared options for all psar series        }    },    series: [{        // specific options for this series instance        type: 'psar'    }]});```            
		/// </summary>
		public PlotOptionsPsar Psar { get; set; }
		private PlotOptionsPsar Psar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rate of change indicator (ROC). The indicator value for each pointis defined as:`(C - Cn) / Cn * 100`where: `C` is the close value of the point of the same x in thelinked series and `Cn` is the close value of the point `n` periodsago. `n` is set through [period](#plotOptions.roc.params.period).This series requires `linkedTo` option to be set.In TypeScript the [type](series.roc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `roc` series are defined in   [plotOptions.roc](plotOptions.roc).3. Options for one single series are given in   [the series instance array](series.roc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        roc: {            // shared options for all roc series        }    },    series: [{        // specific options for this series instance        type: 'roc'    }]});```            
		/// </summary>
		public PlotOptionsRoc Roc { get; set; }
		private PlotOptionsRoc Roc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Relative strength index (RSI) technical indicator. This seriesrequires the `linkedTo` option to be set and should be loaded afterthe `stock/indicators/indicators.js` file.In TypeScript the [type](series.rsi.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `rsi` series are defined in   [plotOptions.rsi](plotOptions.rsi).3. Options for one single series are given in   [the series instance array](series.rsi).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        rsi: {            // shared options for all rsi series        }    },    series: [{        // specific options for this series instance        type: 'rsi'    }]});```            
		/// </summary>
		public PlotOptionsRsi Rsi { get; set; }
		private PlotOptionsRsi Rsi_DefaultValue { get; set; }
		 

		/// <summary>
		/// A scatter plot uses cartesian coordinates to display values for twovariables for a set of data.In TypeScript the [type](series.scatter.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `scatter` series are defined in   [plotOptions.scatter](plotOptions.scatter).3. Options for one single series are given in   [the series instance array](series.scatter).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter: {            // shared options for all scatter series        }    },    series: [{        // specific options for this series instance        type: 'scatter'    }]});```            
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		private PlotOptionsScatter Scatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// General options for all series types.In TypeScript the [type](series.line.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `line` series are defined in   [plotOptions.line](plotOptions.line).3. Options for one single series are given in   [the series instance array](series.line).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});```            
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		 

		/// <summary>
		/// Slow Stochastic oscillator. This series requires the `linkedTo` optionto be set and should be loaded after `stock/indicators/indicators.js`and `stock/indicators/stochastic.js` files.In TypeScript the [type](series.slowstochastic.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `slowstochastic` series are defined in   [plotOptions.slowstochastic](plotOptions.slowstochastic).3. Options for one single series are given in   [the series instance array](series.slowstochastic).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        slowstochastic: {            // shared options for all slowstochastic series        }    },    series: [{        // specific options for this series instance        type: 'slowstochastic'    }]});```            
		/// </summary>
		public PlotOptionsSlowstochastic Slowstochastic { get; set; }
		private PlotOptionsSlowstochastic Slowstochastic_DefaultValue { get; set; }
		 

		/// <summary>
		/// Simple moving average indicator (SMA). This series requires `linkedTo`option to be set.In TypeScript the [type](series.sma.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `sma` series are defined in   [plotOptions.sma](plotOptions.sma).3. Options for one single series are given in   [the series instance array](series.sma).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sma: {            // shared options for all sma series        }    },    series: [{        // specific options for this series instance        type: 'sma'    }]});```            
		/// </summary>
		public PlotOptionsSma Sma { get; set; }
		private PlotOptionsSma Sma_DefaultValue { get; set; }
		 

		/// <summary>
		/// A spline series is a special type of line series, where the segmentsbetween the data points are smoothed.In TypeScript the [type](series.spline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `spline` series are defined in   [plotOptions.spline](plotOptions.spline).3. Options for one single series are given in   [the series instance array](series.spline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        spline: {            // shared options for all spline series        }    },    series: [{        // specific options for this series instance        type: 'spline'    }]});```            
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		private PlotOptionsSpline Spline_DefaultValue { get; set; }
		 

		/// <summary>
		/// Stochastic oscillator. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.stochastic.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `stochastic` series are defined in   [plotOptions.stochastic](plotOptions.stochastic).3. Options for one single series are given in   [the series instance array](series.stochastic).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        stochastic: {            // shared options for all stochastic series        }    },    series: [{        // specific options for this series instance        type: 'stochastic'    }]});```            
		/// </summary>
		public PlotOptionsStochastic Stochastic { get; set; }
		private PlotOptionsStochastic Stochastic_DefaultValue { get; set; }
		 

		/// <summary>
		/// A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.In TypeScript the [type](series.streamgraph.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `streamgraph` series are defined in   [plotOptions.streamgraph](plotOptions.streamgraph).3. Options for one single series are given in   [the series instance array](series.streamgraph).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        streamgraph: {            // shared options for all streamgraph series        }    },    series: [{        // specific options for this series instance        type: 'streamgraph'    }]});```            
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		private PlotOptionsStreamgraph Streamgraph_DefaultValue { get; set; }
		 

		/// <summary>
		/// Supertrend indicator. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` and`stock/indicators/sma.js`.In TypeScript the [type](series.supertrend.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `supertrend` series are defined in   [plotOptions.supertrend](plotOptions.supertrend).3. Options for one single series are given in   [the series instance array](series.supertrend).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        supertrend: {            // shared options for all supertrend series        }    },    series: [{        // specific options for this series instance        type: 'supertrend'    }]});```            
		/// </summary>
		public PlotOptionsSupertrend Supertrend { get; set; }
		private PlotOptionsSupertrend Supertrend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Triple exponential moving average (TEMA) indicator. This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js` and `stock/indicators/ema.js`.In TypeScript the [type](series.tema.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `tema` series are defined in   [plotOptions.tema](plotOptions.tema).3. Options for one single series are given in   [the series instance array](series.tema).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        tema: {            // shared options for all tema series        }    },    series: [{        // specific options for this series instance        type: 'tema'    }]});```            
		/// </summary>
		public PlotOptionsTema Tema { get; set; }
		private PlotOptionsTema Tema_DefaultValue { get; set; }
		 

		/// <summary>
		/// Trendline (linear regression) fits a straight line to the selected datausing a method called the Sum Of Least Squares. This series requires the`linkedTo` option to be set.In TypeScript the [type](series.trendline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `trendline` series are defined in   [plotOptions.trendline](plotOptions.trendline).3. Options for one single series are given in   [the series instance array](series.trendline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        trendline: {            // shared options for all trendline series        }    },    series: [{        // specific options for this series instance        type: 'trendline'    }]});```            
		/// </summary>
		public PlotOptionsTrendline Trendline { get; set; }
		private PlotOptionsTrendline Trendline_DefaultValue { get; set; }
		 

		/// <summary>
		/// Triple exponential average (TRIX) oscillator. This series requires`linkedTo` option to be set.Requires https://code.highcharts.com/stock/indicators/ema.jsand https://code.highcharts.com/stock/indicators/tema.js.In TypeScript the [type](series.trix.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `trix` series are defined in   [plotOptions.trix](plotOptions.trix).3. Options for one single series are given in   [the series instance array](series.trix).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        trix: {            // shared options for all trix series        }    },    series: [{        // specific options for this series instance        type: 'trix'    }]});```            
		/// </summary>
		public PlotOptionsTrix Trix { get; set; }
		private PlotOptionsTrix Trix_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume By Price indicator.This series requires `linkedTo` option to be set.In TypeScript the [type](series.vbp.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vbp` series are defined in   [plotOptions.vbp](plotOptions.vbp).3. Options for one single series are given in   [the series instance array](series.vbp).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vbp: {            // shared options for all vbp series        }    },    series: [{        // specific options for this series instance        type: 'vbp'    }]});```            
		/// </summary>
		public PlotOptionsVbp Vbp { get; set; }
		private PlotOptionsVbp Vbp_DefaultValue { get; set; }
		 

		/// <summary>
		/// A vector plot is a type of cartesian chart where each point has an X andY position, a length and a direction. Vectors are drawn as arrows.In TypeScript the [type](series.vector.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vector` series are defined in   [plotOptions.vector](plotOptions.vector).3. Options for one single series are given in   [the series instance array](series.vector).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vector: {            // shared options for all vector series        }    },    series: [{        // specific options for this series instance        type: 'vector'    }]});```            
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		private PlotOptionsVector Vector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume Weighted Average Price indicator.This series requires `linkedTo` option to be set.In TypeScript the [type](series.vwap.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vwap` series are defined in   [plotOptions.vwap](plotOptions.vwap).3. Options for one single series are given in   [the series instance array](series.vwap).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vwap: {            // shared options for all vwap series        }    },    series: [{        // specific options for this series instance        type: 'vwap'    }]});```            
		/// </summary>
		public PlotOptionsVwap Vwap { get; set; }
		private PlotOptionsVwap Vwap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Williams %R. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.williamsr.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `williamsr` series are defined in   [plotOptions.williamsr](plotOptions.williamsr).3. Options for one single series are given in   [the series instance array](series.williamsr).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        williamsr: {            // shared options for all williamsr series        }    },    series: [{        // specific options for this series instance        type: 'williamsr'    }]});```            
		/// </summary>
		public PlotOptionsWilliamsr Williamsr { get; set; }
		private PlotOptionsWilliamsr Williamsr_DefaultValue { get; set; }
		 

		/// <summary>
		/// Wind barbs are a convenient way to represent wind speed and direction inone graphical form. Wind direction is given by the stem direction, andwind speed by the number and shape of barbs.In TypeScript the [type](series.windbarb.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `windbarb` series are defined in   [plotOptions.windbarb](plotOptions.windbarb).3. Options for one single series are given in   [the series instance array](series.windbarb).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        windbarb: {            // shared options for all windbarb series        }    },    series: [{        // specific options for this series instance        type: 'windbarb'    }]});```            
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		private PlotOptionsWindbarb Windbarb_DefaultValue { get; set; }
		 

		/// <summary>
		/// Weighted moving average indicator (WMA). This series requires `linkedTo`option to be set.In TypeScript the [type](series.wma.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `wma` series are defined in   [plotOptions.wma](plotOptions.wma).3. Options for one single series are given in   [the series instance array](series.wma).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        wma: {            // shared options for all wma series        }    },    series: [{        // specific options for this series instance        type: 'wma'    }]});```            
		/// </summary>
		public PlotOptionsWma Wma { get; set; }
		private PlotOptionsWma Wma_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X-range series displays ranges on the X axis, typically timeintervals with a start and end date.In TypeScript the [type](series.xrange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `xrange` series are defined in   [plotOptions.xrange](plotOptions.xrange).3. Options for one single series are given in   [the series instance array](series.xrange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        xrange: {            // shared options for all xrange series        }    },    series: [{        // specific options for this series instance        type: 'xrange'    }]});```            
		/// </summary>
		public PlotOptionsXrange Xrange { get; set; }
		private PlotOptionsXrange Xrange_DefaultValue { get; set; }
		 

		/// <summary>
		/// Zig Zag indicator.This series requires `linkedTo` option to be set.In TypeScript the [type](series.zigzag.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `zigzag` series are defined in   [plotOptions.zigzag](plotOptions.zigzag).3. Options for one single series are given in   [the series instance array](series.zigzag).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        zigzag: {            // shared options for all zigzag series        }    },    series: [{        // specific options for this series instance        type: 'zigzag'    }]});```            
		/// </summary>
		public PlotOptionsZigzag Zigzag { get; set; }
		private PlotOptionsZigzag Zigzag_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Abands.IsDirty()) h.Add("abands",Abands.ToHashtable());
			if (Ad.IsDirty()) h.Add("ad",Ad.ToHashtable());
			if (Ao.IsDirty()) h.Add("ao",Ao.ToHashtable());
			if (Apo.IsDirty()) h.Add("apo",Apo.ToHashtable());
			if (Area.IsDirty()) h.Add("area",Area.ToHashtable());
			if (Arearange.IsDirty()) h.Add("arearange",Arearange.ToHashtable());
			if (Areaspline.IsDirty()) h.Add("areaspline",Areaspline.ToHashtable());
			if (Areasplinerange.IsDirty()) h.Add("areasplinerange",Areasplinerange.ToHashtable());
			if (Aroon.IsDirty()) h.Add("aroon",Aroon.ToHashtable());
			if (Aroonoscillator.IsDirty()) h.Add("aroonoscillator",Aroonoscillator.ToHashtable());
			if (Atr.IsDirty()) h.Add("atr",Atr.ToHashtable());
			if (Bb.IsDirty()) h.Add("bb",Bb.ToHashtable());
			if (Bubble.IsDirty()) h.Add("bubble",Bubble.ToHashtable());
			if (Candlestick.IsDirty()) h.Add("candlestick",Candlestick.ToHashtable());
			if (Cci.IsDirty()) h.Add("cci",Cci.ToHashtable());
			if (Chaikin.IsDirty()) h.Add("chaikin",Chaikin.ToHashtable());
			if (Cmf.IsDirty()) h.Add("cmf",Cmf.ToHashtable());
			if (Column.IsDirty()) h.Add("column",Column.ToHashtable());
			if (Columnpyramid.IsDirty()) h.Add("columnpyramid",Columnpyramid.ToHashtable());
			if (Columnrange.IsDirty()) h.Add("columnrange",Columnrange.ToHashtable());
			if (Dema.IsDirty()) h.Add("dema",Dema.ToHashtable());
			if (Dpo.IsDirty()) h.Add("dpo",Dpo.ToHashtable());
			if (Dumbbell.IsDirty()) h.Add("dumbbell",Dumbbell.ToHashtable());
			if (Ema.IsDirty()) h.Add("ema",Ema.ToHashtable());
			if (Errorbar.IsDirty()) h.Add("errorbar",Errorbar.ToHashtable());
			if (Flags.IsDirty()) h.Add("flags",Flags.ToHashtable());
			if (Ikh.IsDirty()) h.Add("ikh",Ikh.ToHashtable());
			if (Keltnerchannels.IsDirty()) h.Add("keltnerchannels",Keltnerchannels.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Linearregression.IsDirty()) h.Add("linearregression",Linearregression.ToHashtable());
			if (Linearregressionangle.IsDirty()) h.Add("linearregressionangle",Linearregressionangle.ToHashtable());
			if (Linearregressionintercept.IsDirty()) h.Add("linearregressionintercept",Linearregressionintercept.ToHashtable());
			if (Linearregressionslope.IsDirty()) h.Add("linearregressionslope",Linearregressionslope.ToHashtable());
			if (Lollipop.IsDirty()) h.Add("lollipop",Lollipop.ToHashtable());
			if (Macd.IsDirty()) h.Add("macd",Macd.ToHashtable());
			if (Mfi.IsDirty()) h.Add("mfi",Mfi.ToHashtable());
			if (Momentum.IsDirty()) h.Add("momentum",Momentum.ToHashtable());
			if (Natr.IsDirty()) h.Add("natr",Natr.ToHashtable());
			if (Ohlc.IsDirty()) h.Add("ohlc",Ohlc.ToHashtable());
			if (PackedBubble.IsDirty()) h.Add("packedBubble",PackedBubble.ToHashtable());
			if (Pc.IsDirty()) h.Add("pc",Pc.ToHashtable());
			if (Pivotpoints.IsDirty()) h.Add("pivotpoints",Pivotpoints.ToHashtable());
			if (Polygon.IsDirty()) h.Add("polygon",Polygon.ToHashtable());
			if (Ppo.IsDirty()) h.Add("ppo",Ppo.ToHashtable());
			if (Priceenvelopes.IsDirty()) h.Add("priceenvelopes",Priceenvelopes.ToHashtable());
			if (Psar.IsDirty()) h.Add("psar",Psar.ToHashtable());
			if (Roc.IsDirty()) h.Add("roc",Roc.ToHashtable());
			if (Rsi.IsDirty()) h.Add("rsi",Rsi.ToHashtable());
			if (Scatter.IsDirty()) h.Add("scatter",Scatter.ToHashtable());
			if (Series.IsDirty()) h.Add("series",Series.ToHashtable());
			if (Slowstochastic.IsDirty()) h.Add("slowstochastic",Slowstochastic.ToHashtable());
			if (Sma.IsDirty()) h.Add("sma",Sma.ToHashtable());
			if (Spline.IsDirty()) h.Add("spline",Spline.ToHashtable());
			if (Stochastic.IsDirty()) h.Add("stochastic",Stochastic.ToHashtable());
			if (Streamgraph.IsDirty()) h.Add("streamgraph",Streamgraph.ToHashtable());
			if (Supertrend.IsDirty()) h.Add("supertrend",Supertrend.ToHashtable());
			if (Tema.IsDirty()) h.Add("tema",Tema.ToHashtable());
			if (Trendline.IsDirty()) h.Add("trendline",Trendline.ToHashtable());
			if (Trix.IsDirty()) h.Add("trix",Trix.ToHashtable());
			if (Vbp.IsDirty()) h.Add("vbp",Vbp.ToHashtable());
			if (Vector.IsDirty()) h.Add("vector",Vector.ToHashtable());
			if (Vwap.IsDirty()) h.Add("vwap",Vwap.ToHashtable());
			if (Williamsr.IsDirty()) h.Add("williamsr",Williamsr.ToHashtable());
			if (Windbarb.IsDirty()) h.Add("windbarb",Windbarb.ToHashtable());
			if (Wma.IsDirty()) h.Add("wma",Wma.ToHashtable());
			if (Xrange.IsDirty()) h.Add("xrange",Xrange.ToHashtable());
			if (Zigzag.IsDirty()) h.Add("zigzag",Zigzag.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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