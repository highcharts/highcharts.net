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
		}	
		

		/// <summary>
		/// Acceleration bands (ABANDS). This series requires the `linkedTo` optionto be set and should be loaded after the`stock/indicators/indicators.js`.In TypeScript the [type](series.abands.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `abands` series are defined in   [plotOptions.abands](plotOptions.abands).3. Options for one single series are given in   [the series instance array](series.abands).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        abands: {            // shared options for all abands series        }    },    series: [{        // specific options for this series instance        type: 'abands'    }]});```            
		/// </summary>
		public PlotOptionsAbands Abands { get; set; }
		 

		/// <summary>
		/// Accumulation Distribution (AD). This series requires `linkedTo` option tobe set.In TypeScript the [type](series.ad.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ad` series are defined in   [plotOptions.ad](plotOptions.ad).3. Options for one single series are given in   [the series instance array](series.ad).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ad: {            // shared options for all ad series        }    },    series: [{        // specific options for this series instance        type: 'ad'    }]});```            
		/// </summary>
		public PlotOptionsAd Ad { get; set; }
		 

		/// <summary>
		/// Awesome Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`In TypeScript the [type](series.ao.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ao` series are defined in   [plotOptions.ao](plotOptions.ao).3. Options for one single series are given in   [the series instance array](series.ao).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ao: {            // shared options for all ao series        }    },    series: [{        // specific options for this series instance        type: 'ao'    }]});```            
		/// </summary>
		public PlotOptionsAo Ao { get; set; }
		 

		/// <summary>
		/// Absolute Price Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.apo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `apo` series are defined in   [plotOptions.apo](plotOptions.apo).3. Options for one single series are given in   [the series instance array](series.apo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        apo: {            // shared options for all apo series        }    },    series: [{        // specific options for this series instance        type: 'apo'    }]});```            
		/// </summary>
		public PlotOptionsApo Apo { get; set; }
		 

		/// <summary>
		/// The area series type.In TypeScript the [type](series.area.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `area` series are defined in   [plotOptions.area](plotOptions.area).3. Options for one single series are given in   [the series instance array](series.area).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        area: {            // shared options for all area series        }    },    series: [{        // specific options for this series instance        type: 'area'    }]});```            
		/// </summary>
		public PlotOptionsArea Area { get; set; }
		 

		/// <summary>
		/// The area range series is a carteseian series with higher and lower values foreach point along an X axis, where the area between the values is shaded.In TypeScript the [type](series.arearange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `arearange` series are defined in   [plotOptions.arearange](plotOptions.arearange).3. Options for one single series are given in   [the series instance array](series.arearange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        arearange: {            // shared options for all arearange series        }    },    series: [{        // specific options for this series instance        type: 'arearange'    }]});```            
		/// </summary>
		public PlotOptionsArearange Arearange { get; set; }
		 

		/// <summary>
		/// The area spline series is an area series where the graph between thepoints is smoothed into a spline.In TypeScript the [type](series.areaspline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `areaspline` series are defined in   [plotOptions.areaspline](plotOptions.areaspline).3. Options for one single series are given in   [the series instance array](series.areaspline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areaspline: {            // shared options for all areaspline series        }    },    series: [{        // specific options for this series instance        type: 'areaspline'    }]});```            
		/// </summary>
		public PlotOptionsAreaspline Areaspline { get; set; }
		 

		/// <summary>
		/// The area spline range is a cartesian series type with higher andlower Y values along an X axis. The area inside the range is colored, andthe graph outlining the area is a smoothed spline.In TypeScript the [type](series.areasplinerange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `areasplinerange` series are defined in   [plotOptions.areasplinerange](plotOptions.areasplinerange).3. Options for one single series are given in   [the series instance array](series.areasplinerange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        areasplinerange: {            // shared options for all areasplinerange series        }    },    series: [{        // specific options for this series instance        type: 'areasplinerange'    }]});```            
		/// </summary>
		public PlotOptionsAreasplinerange Areasplinerange { get; set; }
		 

		/// <summary>
		/// Aroon. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.aroon.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `aroon` series are defined in   [plotOptions.aroon](plotOptions.aroon).3. Options for one single series are given in   [the series instance array](series.aroon).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        aroon: {            // shared options for all aroon series        }    },    series: [{        // specific options for this series instance        type: 'aroon'    }]});```            
		/// </summary>
		public PlotOptionsAroon Aroon { get; set; }
		 

		/// <summary>
		/// Aroon Oscillator. This series requires the `linkedTo` option to be setand should be loaded after the `stock/indicators/indicators.js` and`stock/indicators/aroon.js`.In TypeScript the [type](series.aroonoscillator.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `aroonoscillator` series are defined in   [plotOptions.aroonoscillator](plotOptions.aroonoscillator).3. Options for one single series are given in   [the series instance array](series.aroonoscillator).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        aroonoscillator: {            // shared options for all aroonoscillator series        }    },    series: [{        // specific options for this series instance        type: 'aroonoscillator'    }]});```            
		/// </summary>
		public PlotOptionsAroonoscillator Aroonoscillator { get; set; }
		 

		/// <summary>
		/// Average true range indicator (ATR). This series requires `linkedTo`option to be set.In TypeScript the [type](series.atr.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `atr` series are defined in   [plotOptions.atr](plotOptions.atr).3. Options for one single series are given in   [the series instance array](series.atr).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        atr: {            // shared options for all atr series        }    },    series: [{        // specific options for this series instance        type: 'atr'    }]});```            
		/// </summary>
		public PlotOptionsAtr Atr { get; set; }
		 

		/// <summary>
		/// Bollinger bands (BB). This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.bb.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bb` series are defined in   [plotOptions.bb](plotOptions.bb).3. Options for one single series are given in   [the series instance array](series.bb).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bb: {            // shared options for all bb series        }    },    series: [{        // specific options for this series instance        type: 'bb'    }]});```            
		/// </summary>
		public PlotOptionsBb Bb { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each pointrenders an X, Y and Z value. Each points is drawn as a bubble where theposition along the X and Y axes mark the X and Y values, and the size ofthe bubble relates to the Z value.In TypeScript the [type](series.bubble.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `bubble` series are defined in   [plotOptions.bubble](plotOptions.bubble).3. Options for one single series are given in   [the series instance array](series.bubble).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        bubble: {            // shared options for all bubble series        }    },    series: [{        // specific options for this series instance        type: 'bubble'    }]});```            
		/// </summary>
		public PlotOptionsBubble Bubble { get; set; }
		 

		/// <summary>
		/// A candlestick chart is a style of financial chart used to describeprice movements over time.In TypeScript the [type](series.candlestick.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `candlestick` series are defined in   [plotOptions.candlestick](plotOptions.candlestick).3. Options for one single series are given in   [the series instance array](series.candlestick).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        candlestick: {            // shared options for all candlestick series        }    },    series: [{        // specific options for this series instance        type: 'candlestick'    }]});```            
		/// </summary>
		public PlotOptionsCandlestick Candlestick { get; set; }
		 

		/// <summary>
		/// Commodity Channel Index (CCI). This series requires `linkedTo` option tobe set.In TypeScript the [type](series.cci.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `cci` series are defined in   [plotOptions.cci](plotOptions.cci).3. Options for one single series are given in   [the series instance array](series.cci).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cci: {            // shared options for all cci series        }    },    series: [{        // specific options for this series instance        type: 'cci'    }]});```            
		/// </summary>
		public PlotOptionsCci Cci { get; set; }
		 

		/// <summary>
		/// Chaikin Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.chaikin.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `chaikin` series are defined in   [plotOptions.chaikin](plotOptions.chaikin).3. Options for one single series are given in   [the series instance array](series.chaikin).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        chaikin: {            // shared options for all chaikin series        }    },    series: [{        // specific options for this series instance        type: 'chaikin'    }]});```            
		/// </summary>
		public PlotOptionsChaikin Chaikin { get; set; }
		 

		/// <summary>
		/// Chaikin Money Flow indicator (cmf).In TypeScript the [type](series.cmf.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `cmf` series are defined in   [plotOptions.cmf](plotOptions.cmf).3. Options for one single series are given in   [the series instance array](series.cmf).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cmf: {            // shared options for all cmf series        }    },    series: [{        // specific options for this series instance        type: 'cmf'    }]});```            
		/// </summary>
		public PlotOptionsCmf Cmf { get; set; }
		 

		/// <summary>
		/// Chande Momentum Oscilator (CMO) technical indicator. This seriesrequires the `linkedTo` option to be set and should be loaded afterthe `stock/indicators/indicators.js` file.In TypeScript the [type](series.cmo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `cmo` series are defined in   [plotOptions.cmo](plotOptions.cmo).3. Options for one single series are given in   [the series instance array](series.cmo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        cmo: {            // shared options for all cmo series        }    },    series: [{        // specific options for this series instance        type: 'cmo'    }]});```            
		/// </summary>
		public PlotOptionsCmo Cmo { get; set; }
		 

		/// <summary>
		/// Column series display one column per value along an X axis.In TypeScript the [type](series.column.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `column` series are defined in   [plotOptions.column](plotOptions.column).3. Options for one single series are given in   [the series instance array](series.column).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        column: {            // shared options for all column series        }    },    series: [{        // specific options for this series instance        type: 'column'    }]});```            
		/// </summary>
		public PlotOptionsColumn Column { get; set; }
		 

		/// <summary>
		/// Column pyramid series display one pyramid per value along an X axis.To display horizontal pyramids, set [chart.inverted](#chart.inverted) to`true`.In TypeScript the [type](series.columnpyramid.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `columnpyramid` series are defined in   [plotOptions.columnpyramid](plotOptions.columnpyramid).3. Options for one single series are given in   [the series instance array](series.columnpyramid).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnpyramid: {            // shared options for all columnpyramid series        }    },    series: [{        // specific options for this series instance        type: 'columnpyramid'    }]});```            
		/// </summary>
		public PlotOptionsColumnpyramid Columnpyramid { get; set; }
		 

		/// <summary>
		/// The column range is a cartesian series type with higher and lowerY values along an X axis. To display horizontal bars, set[chart.inverted](#chart.inverted) to `true`.In TypeScript the [type](series.columnrange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `columnrange` series are defined in   [plotOptions.columnrange](plotOptions.columnrange).3. Options for one single series are given in   [the series instance array](series.columnrange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        columnrange: {            // shared options for all columnrange series        }    },    series: [{        // specific options for this series instance        type: 'columnrange'    }]});```            
		/// </summary>
		public PlotOptionsColumnrange Columnrange { get; set; }
		 

		/// <summary>
		/// Double exponential moving average (DEMA) indicator. This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js`.In TypeScript the [type](series.dema.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dema` series are defined in   [plotOptions.dema](plotOptions.dema).3. Options for one single series are given in   [the series instance array](series.dema).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dema: {            // shared options for all dema series        }    },    series: [{        // specific options for this series instance        type: 'dema'    }]});```            
		/// </summary>
		public PlotOptionsDema Dema { get; set; }
		 

		/// <summary>
		/// Disparity Index.This series requires the `linkedTo` option to be set and shouldbe loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.disparityindex.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `disparityindex` series are defined in   [plotOptions.disparityindex](plotOptions.disparityindex).3. Options for one single series are given in   [the series instance array](series.disparityindex).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        disparityindex: {            // shared options for all disparityindex series        }    },    series: [{        // specific options for this series instance        type: 'disparityindex'    }]});```            
		/// </summary>
		public PlotOptionsDisparityindex Disparityindex { get; set; }
		 

		/// <summary>
		/// Directional Movement Index (DMI).This series requires the `linkedTo` option to be set and shouldbe loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.dmi.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dmi` series are defined in   [plotOptions.dmi](plotOptions.dmi).3. Options for one single series are given in   [the series instance array](series.dmi).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dmi: {            // shared options for all dmi series        }    },    series: [{        // specific options for this series instance        type: 'dmi'    }]});```            
		/// </summary>
		public PlotOptionsDmi Dmi { get; set; }
		 

		/// <summary>
		/// Detrended Price Oscillator. This series requires the `linkedTo` option tobe set and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.dpo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dpo` series are defined in   [plotOptions.dpo](plotOptions.dpo).3. Options for one single series are given in   [the series instance array](series.dpo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dpo: {            // shared options for all dpo series        }    },    series: [{        // specific options for this series instance        type: 'dpo'    }]});```            
		/// </summary>
		public PlotOptionsDpo Dpo { get; set; }
		 

		/// <summary>
		/// The dumbbell series is a cartesian series with higher and lower valuesfor each point along an X axis, connected with a line between thevalues.Requires `highcharts-more.js` and `modules/dumbbell.js`.In TypeScript the [type](series.dumbbell.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `dumbbell` series are defined in   [plotOptions.dumbbell](plotOptions.dumbbell).3. Options for one single series are given in   [the series instance array](series.dumbbell).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        dumbbell: {            // shared options for all dumbbell series        }    },    series: [{        // specific options for this series instance        type: 'dumbbell'    }]});```            
		/// </summary>
		public PlotOptionsDumbbell Dumbbell { get; set; }
		 

		/// <summary>
		/// Exponential moving average indicator (EMA). This series requires the`linkedTo` option to be set.In TypeScript the [type](series.ema.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ema` series are defined in   [plotOptions.ema](plotOptions.ema).3. Options for one single series are given in   [the series instance array](series.ema).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ema: {            // shared options for all ema series        }    },    series: [{        // specific options for this series instance        type: 'ema'    }]});```            
		/// </summary>
		public PlotOptionsEma Ema { get; set; }
		 

		/// <summary>
		/// Flags are used to mark events in stock charts. They can be added on thetimeline, or attached to a specific series.In TypeScript the [type](series.flags.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `flags` series are defined in   [plotOptions.flags](plotOptions.flags).3. Options for one single series are given in   [the series instance array](series.flags).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        flags: {            // shared options for all flags series        }    },    series: [{        // specific options for this series instance        type: 'flags'    }]});```            
		/// </summary>
		public PlotOptionsFlags Flags { get; set; }
		 

		/// <summary>
		/// An HeikinAshi series is a style of financial chart used to describe pricemovements over time. It displays open, high, low and close values perdata point.In TypeScript the [type](series.heikinashi.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `heikinashi` series are defined in   [plotOptions.heikinashi](plotOptions.heikinashi).3. Options for one single series are given in   [the series instance array](series.heikinashi).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        heikinashi: {            // shared options for all heikinashi series        }    },    series: [{        // specific options for this series instance        type: 'heikinashi'    }]});```            
		/// </summary>
		public PlotOptionsHeikinashi Heikinashi { get; set; }
		 

		/// <summary>
		/// An HLC chart is a style of financial chart used to describe pricemovements over time. It displays high, low and close values perdata point.In TypeScript the [type](series.hlc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `hlc` series are defined in   [plotOptions.hlc](plotOptions.hlc).3. Options for one single series are given in   [the series instance array](series.hlc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        hlc: {            // shared options for all hlc series        }    },    series: [{        // specific options for this series instance        type: 'hlc'    }]});```            
		/// </summary>
		public PlotOptionsHlc Hlc { get; set; }
		 

		/// <summary>
		/// A hollow candlestick chart is a style of financial chart used todescribe price movements over time.In TypeScript the [type](series.hollowcandlestick.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `hollowcandlestick` series are defined in   [plotOptions.hollowcandlestick](plotOptions.hollowcandlestick).3. Options for one single series are given in   [the series instance array](series.hollowcandlestick).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        hollowcandlestick: {            // shared options for all hollowcandlestick series        }    },    series: [{        // specific options for this series instance        type: 'hollowcandlestick'    }]});```            
		/// </summary>
		public PlotOptionsHollowcandlestick Hollowcandlestick { get; set; }
		 

		/// <summary>
		/// Ichimoku Kinko Hyo (IKH). This series requires `linkedTo` option to beset.In TypeScript the [type](series.ikh.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ikh` series are defined in   [plotOptions.ikh](plotOptions.ikh).3. Options for one single series are given in   [the series instance array](series.ikh).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ikh: {            // shared options for all ikh series        }    },    series: [{        // specific options for this series instance        type: 'ikh'    }]});```            
		/// </summary>
		public PlotOptionsIkh Ikh { get; set; }
		 

		/// <summary>
		/// Keltner Channels. This series requires the `linkedTo` option to be setand should be loaded after the `stock/indicators/indicators.js`,`stock/indicators/atr.js`, and `stock/ema/.js`.In TypeScript the [type](series.keltnerchannels.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `keltnerchannels` series are defined in   [plotOptions.keltnerchannels](plotOptions.keltnerchannels).3. Options for one single series are given in   [the series instance array](series.keltnerchannels).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        keltnerchannels: {            // shared options for all keltnerchannels series        }    },    series: [{        // specific options for this series instance        type: 'keltnerchannels'    }]});```            
		/// </summary>
		public PlotOptionsKeltnerchannels Keltnerchannels { get; set; }
		 

		/// <summary>
		/// Klinger oscillator. This series requires the `linkedTo` option to be setand should be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.klinger.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `klinger` series are defined in   [plotOptions.klinger](plotOptions.klinger).3. Options for one single series are given in   [the series instance array](series.klinger).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        klinger: {            // shared options for all klinger series        }    },    series: [{        // specific options for this series instance        type: 'klinger'    }]});```            
		/// </summary>
		public PlotOptionsKlinger Klinger { get; set; }
		 

		/// <summary>
		/// A line series displays information as a series of data points connected bystraight line segments.In TypeScript the [type](series.line.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `line` series are defined in   [plotOptions.line](plotOptions.line).3. Options for one single series are given in   [the series instance array](series.line).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});```            
		/// </summary>
		public PlotOptionsLine Line { get; set; }
		 

		/// <summary>
		/// Linear regression indicator. This series requires `linkedTo` option to beset.In TypeScript the [type](series.linearregression.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregression` series are defined in   [plotOptions.linearregression](plotOptions.linearregression).3. Options for one single series are given in   [the series instance array](series.linearregression).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregression: {            // shared options for all linearregression series        }    },    series: [{        // specific options for this series instance        type: 'linearregression'    }]});```            
		/// </summary>
		public PlotOptionsLinearregression Linearregression { get; set; }
		 

		/// <summary>
		/// Linear regression angle indicator. This series requires `linkedTo`option to be set.In TypeScript the [type](series.linearregressionangle.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregressionangle` series are defined in   [plotOptions.linearregressionangle](plotOptions.linearregressionangle).3. Options for one single series are given in   [the series instance array](series.linearregressionangle).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregressionangle: {            // shared options for all linearregressionangle series        }    },    series: [{        // specific options for this series instance        type: 'linearregressionangle'    }]});```            
		/// </summary>
		public PlotOptionsLinearregressionangle Linearregressionangle { get; set; }
		 

		/// <summary>
		/// Linear regression intercept indicator. This series requires `linkedTo`option to be set.In TypeScript the [type](series.linearregressionintercept.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregressionintercept` series are defined in   [plotOptions.linearregressionintercept](plotOptions.linearregressionintercept).3. Options for one single series are given in   [the series instance array](series.linearregressionintercept).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregressionintercept: {            // shared options for all linearregressionintercept series        }    },    series: [{        // specific options for this series instance        type: 'linearregressionintercept'    }]});```            
		/// </summary>
		public PlotOptionsLinearregressionintercept Linearregressionintercept { get; set; }
		 

		/// <summary>
		/// Linear regression slope indicator. This series requires `linkedTo`option to be set.In TypeScript the [type](series.linearregressionslope.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `linearregressionslope` series are defined in   [plotOptions.linearregressionslope](plotOptions.linearregressionslope).3. Options for one single series are given in   [the series instance array](series.linearregressionslope).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        linearregressionslope: {            // shared options for all linearregressionslope series        }    },    series: [{        // specific options for this series instance        type: 'linearregressionslope'    }]});```            
		/// </summary>
		public PlotOptionsLinearregressionslope Linearregressionslope { get; set; }
		 

		/// <summary>
		/// The lollipop series is a carteseian series with a line anchored fromthe x axis and a dot at the end to mark the value.Requires `highcharts-more.js`, `modules/dumbbell.js` and`modules/lollipop.js`.In TypeScript the [type](series.lollipop.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `lollipop` series are defined in   [plotOptions.lollipop](plotOptions.lollipop).3. Options for one single series are given in   [the series instance array](series.lollipop).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        lollipop: {            // shared options for all lollipop series        }    },    series: [{        // specific options for this series instance        type: 'lollipop'    }]});```            
		/// </summary>
		public PlotOptionsLollipop Lollipop { get; set; }
		 

		/// <summary>
		/// Moving Average Convergence Divergence (MACD). This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js`.In TypeScript the [type](series.macd.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `macd` series are defined in   [plotOptions.macd](plotOptions.macd).3. Options for one single series are given in   [the series instance array](series.macd).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        macd: {            // shared options for all macd series        }    },    series: [{        // specific options for this series instance        type: 'macd'    }]});```            
		/// </summary>
		public PlotOptionsMacd Macd { get; set; }
		 

		/// <summary>
		/// Money Flow Index. This series requires `linkedTo` option to be set andshould be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.mfi.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `mfi` series are defined in   [plotOptions.mfi](plotOptions.mfi).3. Options for one single series are given in   [the series instance array](series.mfi).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        mfi: {            // shared options for all mfi series        }    },    series: [{        // specific options for this series instance        type: 'mfi'    }]});```            
		/// </summary>
		public PlotOptionsMfi Mfi { get; set; }
		 

		/// <summary>
		/// Momentum. This series requires `linkedTo` option to be set.In TypeScript the [type](series.momentum.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `momentum` series are defined in   [plotOptions.momentum](plotOptions.momentum).3. Options for one single series are given in   [the series instance array](series.momentum).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        momentum: {            // shared options for all momentum series        }    },    series: [{        // specific options for this series instance        type: 'momentum'    }]});```            
		/// </summary>
		public PlotOptionsMomentum Momentum { get; set; }
		 

		/// <summary>
		/// Normalized average true range indicator (NATR). This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js` and `stock/indicators/atr.js`.In TypeScript the [type](series.natr.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `natr` series are defined in   [plotOptions.natr](plotOptions.natr).3. Options for one single series are given in   [the series instance array](series.natr).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        natr: {            // shared options for all natr series        }    },    series: [{        // specific options for this series instance        type: 'natr'    }]});```            
		/// </summary>
		public PlotOptionsNatr Natr { get; set; }
		 

		/// <summary>
		/// On-Balance Volume (OBV) technical indicator. This seriesrequires the `linkedTo` option to be set and should be loaded afterthe `stock/indicators/indicators.js` file. Through the `volumeSeriesID`there also should be linked the volume series.In TypeScript the [type](series.obv.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `obv` series are defined in   [plotOptions.obv](plotOptions.obv).3. Options for one single series are given in   [the series instance array](series.obv).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        obv: {            // shared options for all obv series        }    },    series: [{        // specific options for this series instance        type: 'obv'    }]});```            
		/// </summary>
		public PlotOptionsObv Obv { get; set; }
		 

		/// <summary>
		/// An OHLC chart is a style of financial chart used to describe pricemovements over time. It displays open, high, low and close values perdata point.In TypeScript the [type](series.ohlc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ohlc` series are defined in   [plotOptions.ohlc](plotOptions.ohlc).3. Options for one single series are given in   [the series instance array](series.ohlc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ohlc: {            // shared options for all ohlc series        }    },    series: [{        // specific options for this series instance        type: 'ohlc'    }]});```            
		/// </summary>
		public PlotOptionsOhlc Ohlc { get; set; }
		 

		/// <summary>
		/// Price channel (PC). This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.pc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pc` series are defined in   [plotOptions.pc](plotOptions.pc).3. Options for one single series are given in   [the series instance array](series.pc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pc: {            // shared options for all pc series        }    },    series: [{        // specific options for this series instance        type: 'pc'    }]});```            
		/// </summary>
		public PlotOptionsPc Pc { get; set; }
		 

		/// <summary>
		/// Pivot points indicator. This series requires the `linkedTo` option to beset and should be loaded after `stock/indicators/indicators.js` file.In TypeScript the [type](series.pivotpoints.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `pivotpoints` series are defined in   [plotOptions.pivotpoints](plotOptions.pivotpoints).3. Options for one single series are given in   [the series instance array](series.pivotpoints).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        pivotpoints: {            // shared options for all pivotpoints series        }    },    series: [{        // specific options for this series instance        type: 'pivotpoints'    }]});```            
		/// </summary>
		public PlotOptionsPivotpoints Pivotpoints { get; set; }
		 

		/// <summary>
		/// A polygon series can be used to draw any freeform shape in the cartesiancoordinate system. A fill is applied with the `color` option, andstroke is applied through `lineWidth` and `lineColor` options.In TypeScript the [type](series.polygon.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `polygon` series are defined in   [plotOptions.polygon](plotOptions.polygon).3. Options for one single series are given in   [the series instance array](series.polygon).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        polygon: {            // shared options for all polygon series        }    },    series: [{        // specific options for this series instance        type: 'polygon'    }]});```            
		/// </summary>
		public PlotOptionsPolygon Polygon { get; set; }
		 

		/// <summary>
		/// Percentage Price Oscillator. This series requires the`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js`.In TypeScript the [type](series.ppo.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `ppo` series are defined in   [plotOptions.ppo](plotOptions.ppo).3. Options for one single series are given in   [the series instance array](series.ppo).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        ppo: {            // shared options for all ppo series        }    },    series: [{        // specific options for this series instance        type: 'ppo'    }]});```            
		/// </summary>
		public PlotOptionsPpo Ppo { get; set; }
		 

		/// <summary>
		/// Price envelopes indicator based on [SMA](#plotOptions.sma) calculations.This series requires the `linkedTo` option to be set and should be loadedafter the `stock/indicators/indicators.js` file.In TypeScript the [type](series.priceenvelopes.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `priceenvelopes` series are defined in   [plotOptions.priceenvelopes](plotOptions.priceenvelopes).3. Options for one single series are given in   [the series instance array](series.priceenvelopes).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        priceenvelopes: {            // shared options for all priceenvelopes series        }    },    series: [{        // specific options for this series instance        type: 'priceenvelopes'    }]});```            
		/// </summary>
		public PlotOptionsPriceenvelopes Priceenvelopes { get; set; }
		 

		/// <summary>
		/// Parabolic SAR. This series requires `linkedTo`option to be set and should be loadedafter `stock/indicators/indicators.js` file.In TypeScript the [type](series.psar.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `psar` series are defined in   [plotOptions.psar](plotOptions.psar).3. Options for one single series are given in   [the series instance array](series.psar).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        psar: {            // shared options for all psar series        }    },    series: [{        // specific options for this series instance        type: 'psar'    }]});```            
		/// </summary>
		public PlotOptionsPsar Psar { get; set; }
		 

		/// <summary>
		/// Rate of change indicator (ROC). The indicator value for each pointis defined as:`(C - Cn) / Cn * 100`where: `C` is the close value of the point of the same x in thelinked series and `Cn` is the close value of the point `n` periodsago. `n` is set through [period](#plotOptions.roc.params.period).This series requires `linkedTo` option to be set.In TypeScript the [type](series.roc.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `roc` series are defined in   [plotOptions.roc](plotOptions.roc).3. Options for one single series are given in   [the series instance array](series.roc).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        roc: {            // shared options for all roc series        }    },    series: [{        // specific options for this series instance        type: 'roc'    }]});```            
		/// </summary>
		public PlotOptionsRoc Roc { get; set; }
		 

		/// <summary>
		/// Relative strength index (RSI) technical indicator. This seriesrequires the `linkedTo` option to be set and should be loaded afterthe `stock/indicators/indicators.js` file.In TypeScript the [type](series.rsi.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `rsi` series are defined in   [plotOptions.rsi](plotOptions.rsi).3. Options for one single series are given in   [the series instance array](series.rsi).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        rsi: {            // shared options for all rsi series        }    },    series: [{        // specific options for this series instance        type: 'rsi'    }]});```            
		/// </summary>
		public PlotOptionsRsi Rsi { get; set; }
		 

		/// <summary>
		/// A scatter plot uses cartesian coordinates to display values for twovariables for a set of data.In TypeScript the [type](series.scatter.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `scatter` series are defined in   [plotOptions.scatter](plotOptions.scatter).3. Options for one single series are given in   [the series instance array](series.scatter).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        scatter: {            // shared options for all scatter series        }    },    series: [{        // specific options for this series instance        type: 'scatter'    }]});```            
		/// </summary>
		public PlotOptionsScatter Scatter { get; set; }
		 

		/// <summary>
		/// General options for all series types.In TypeScript the [type](series.line.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `line` series are defined in   [plotOptions.line](plotOptions.line).3. Options for one single series are given in   [the series instance array](series.line).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        line: {            // shared options for all line series        }    },    series: [{        // specific options for this series instance        type: 'line'    }]});```            
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		 

		/// <summary>
		/// Slow Stochastic oscillator. This series requires the `linkedTo` optionto be set and should be loaded after `stock/indicators/indicators.js`and `stock/indicators/stochastic.js` files.In TypeScript the [type](series.slowstochastic.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `slowstochastic` series are defined in   [plotOptions.slowstochastic](plotOptions.slowstochastic).3. Options for one single series are given in   [the series instance array](series.slowstochastic).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        slowstochastic: {            // shared options for all slowstochastic series        }    },    series: [{        // specific options for this series instance        type: 'slowstochastic'    }]});```            
		/// </summary>
		public PlotOptionsSlowstochastic Slowstochastic { get; set; }
		 

		/// <summary>
		/// Simple moving average indicator (SMA). This series requires `linkedTo`option to be set.In TypeScript the [type](series.sma.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `sma` series are defined in   [plotOptions.sma](plotOptions.sma).3. Options for one single series are given in   [the series instance array](series.sma).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        sma: {            // shared options for all sma series        }    },    series: [{        // specific options for this series instance        type: 'sma'    }]});```            
		/// </summary>
		public PlotOptionsSma Sma { get; set; }
		 

		/// <summary>
		/// A spline series is a special type of line series, where the segmentsbetween the data points are smoothed.In TypeScript the [type](series.spline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `spline` series are defined in   [plotOptions.spline](plotOptions.spline).3. Options for one single series are given in   [the series instance array](series.spline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        spline: {            // shared options for all spline series        }    },    series: [{        // specific options for this series instance        type: 'spline'    }]});```            
		/// </summary>
		public PlotOptionsSpline Spline { get; set; }
		 

		/// <summary>
		/// Stochastic oscillator. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` file.In TypeScript the [type](series.stochastic.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `stochastic` series are defined in   [plotOptions.stochastic](plotOptions.stochastic).3. Options for one single series are given in   [the series instance array](series.stochastic).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        stochastic: {            // shared options for all stochastic series        }    },    series: [{        // specific options for this series instance        type: 'stochastic'    }]});```            
		/// </summary>
		public PlotOptionsStochastic Stochastic { get; set; }
		 

		/// <summary>
		/// A streamgraph is a type of stacked area graph which is displaced around acentral axis, resulting in a flowing, organic shape.In TypeScript the [type](series.streamgraph.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `streamgraph` series are defined in   [plotOptions.streamgraph](plotOptions.streamgraph).3. Options for one single series are given in   [the series instance array](series.streamgraph).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        streamgraph: {            // shared options for all streamgraph series        }    },    series: [{        // specific options for this series instance        type: 'streamgraph'    }]});```            
		/// </summary>
		public PlotOptionsStreamgraph Streamgraph { get; set; }
		 

		/// <summary>
		/// Supertrend indicator. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js` and`stock/indicators/sma.js`.In TypeScript the [type](series.supertrend.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `supertrend` series are defined in   [plotOptions.supertrend](plotOptions.supertrend).3. Options for one single series are given in   [the series instance array](series.supertrend).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        supertrend: {            // shared options for all supertrend series        }    },    series: [{        // specific options for this series instance        type: 'supertrend'    }]});```            
		/// </summary>
		public PlotOptionsSupertrend Supertrend { get; set; }
		 

		/// <summary>
		/// Triple exponential moving average (TEMA) indicator. This series requires`linkedTo` option to be set and should be loaded after the`stock/indicators/indicators.js`.In TypeScript the [type](series.tema.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `tema` series are defined in   [plotOptions.tema](plotOptions.tema).3. Options for one single series are given in   [the series instance array](series.tema).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        tema: {            // shared options for all tema series        }    },    series: [{        // specific options for this series instance        type: 'tema'    }]});```            
		/// </summary>
		public PlotOptionsTema Tema { get; set; }
		 

		/// <summary>
		/// Trendline (linear regression) fits a straight line to the selected datausing a method called the Sum Of Least Squares. This series requires the`linkedTo` option to be set.In TypeScript the [type](series.trendline.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `trendline` series are defined in   [plotOptions.trendline](plotOptions.trendline).3. Options for one single series are given in   [the series instance array](series.trendline).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        trendline: {            // shared options for all trendline series        }    },    series: [{        // specific options for this series instance        type: 'trendline'    }]});```            
		/// </summary>
		public PlotOptionsTrendline Trendline { get; set; }
		 

		/// <summary>
		/// Triple exponential average (TRIX) oscillator. This series requires`linkedTo` option to be set.In TypeScript the [type](series.trix.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `trix` series are defined in   [plotOptions.trix](plotOptions.trix).3. Options for one single series are given in   [the series instance array](series.trix).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        trix: {            // shared options for all trix series        }    },    series: [{        // specific options for this series instance        type: 'trix'    }]});```            
		/// </summary>
		public PlotOptionsTrix Trix { get; set; }
		 

		/// <summary>
		/// Volume By Price indicator.This series requires `linkedTo` option to be set.In TypeScript the [type](series.vbp.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vbp` series are defined in   [plotOptions.vbp](plotOptions.vbp).3. Options for one single series are given in   [the series instance array](series.vbp).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vbp: {            // shared options for all vbp series        }    },    series: [{        // specific options for this series instance        type: 'vbp'    }]});```            
		/// </summary>
		public PlotOptionsVbp Vbp { get; set; }
		 

		/// <summary>
		/// A vector plot is a type of cartesian chart where each point has an X andY position, a length and a direction. Vectors are drawn as arrows.In TypeScript the [type](series.vector.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vector` series are defined in   [plotOptions.vector](plotOptions.vector).3. Options for one single series are given in   [the series instance array](series.vector).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vector: {            // shared options for all vector series        }    },    series: [{        // specific options for this series instance        type: 'vector'    }]});```            
		/// </summary>
		public PlotOptionsVector Vector { get; set; }
		 

		/// <summary>
		/// Volume Weighted Average Price indicator.This series requires `linkedTo` option to be set.In TypeScript the [type](series.vwap.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `vwap` series are defined in   [plotOptions.vwap](plotOptions.vwap).3. Options for one single series are given in   [the series instance array](series.vwap).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        vwap: {            // shared options for all vwap series        }    },    series: [{        // specific options for this series instance        type: 'vwap'    }]});```            
		/// </summary>
		public PlotOptionsVwap Vwap { get; set; }
		 

		/// <summary>
		/// Williams %R. This series requires the `linkedTo` option to beset and should be loaded after the `stock/indicators/indicators.js`.In TypeScript the [type](series.williamsr.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `williamsr` series are defined in   [plotOptions.williamsr](plotOptions.williamsr).3. Options for one single series are given in   [the series instance array](series.williamsr).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        williamsr: {            // shared options for all williamsr series        }    },    series: [{        // specific options for this series instance        type: 'williamsr'    }]});```            
		/// </summary>
		public PlotOptionsWilliamsr Williamsr { get; set; }
		 

		/// <summary>
		/// Wind barbs are a convenient way to represent wind speed and direction inone graphical form. Wind direction is given by the stem direction, andwind speed by the number and shape of barbs.In TypeScript the [type](series.windbarb.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `windbarb` series are defined in   [plotOptions.windbarb](plotOptions.windbarb).3. Options for one single series are given in   [the series instance array](series.windbarb).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        windbarb: {            // shared options for all windbarb series        }    },    series: [{        // specific options for this series instance        type: 'windbarb'    }]});```            
		/// </summary>
		public PlotOptionsWindbarb Windbarb { get; set; }
		 

		/// <summary>
		/// Weighted moving average indicator (WMA). This series requires `linkedTo`option to be set.In TypeScript the [type](series.wma.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `wma` series are defined in   [plotOptions.wma](plotOptions.wma).3. Options for one single series are given in   [the series instance array](series.wma).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        wma: {            // shared options for all wma series        }    },    series: [{        // specific options for this series instance        type: 'wma'    }]});```            
		/// </summary>
		public PlotOptionsWma Wma { get; set; }
		 

		/// <summary>
		/// The X-range series displays ranges on the X axis, typically timeintervals with a start and end date.In TypeScript the [type](series.xrange.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `xrange` series are defined in   [plotOptions.xrange](plotOptions.xrange).3. Options for one single series are given in   [the series instance array](series.xrange).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        xrange: {            // shared options for all xrange series        }    },    series: [{        // specific options for this series instance        type: 'xrange'    }]});```            
		/// </summary>
		public PlotOptionsXrange Xrange { get; set; }
		 

		/// <summary>
		/// Zig Zag indicator.This series requires `linkedTo` option to be set.In TypeScript the [type](series.zigzag.type) option must always be set.Configuration options for the series are given in three levels:1. Options for all series in a chart are defined in the   [plotOptions.series](plotOptions.series) object.2. Options for all `zigzag` series are defined in   [plotOptions.zigzag](plotOptions.zigzag).3. Options for one single series are given in   [the series instance array](series.zigzag).```Highcharts.chart('container', {    plotOptions: {        series: {            // general options for all series        },        zigzag: {            // shared options for all zigzag series        }    },    series: [{        // specific options for this series instance        type: 'zigzag'    }]});```            
		/// </summary>
		public PlotOptionsZigzag Zigzag { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Abands != null) h.Add("abands",Abands.ToHashtable(highstock));
			if (Ad != null) h.Add("ad",Ad.ToHashtable(highstock));
			if (Ao != null) h.Add("ao",Ao.ToHashtable(highstock));
			if (Apo != null) h.Add("apo",Apo.ToHashtable(highstock));
			if (Area != null) h.Add("area",Area.ToHashtable(highstock));
			if (Arearange != null) h.Add("arearange",Arearange.ToHashtable(highstock));
			if (Areaspline != null) h.Add("areaspline",Areaspline.ToHashtable(highstock));
			if (Areasplinerange != null) h.Add("areasplinerange",Areasplinerange.ToHashtable(highstock));
			if (Aroon != null) h.Add("aroon",Aroon.ToHashtable(highstock));
			if (Aroonoscillator != null) h.Add("aroonoscillator",Aroonoscillator.ToHashtable(highstock));
			if (Atr != null) h.Add("atr",Atr.ToHashtable(highstock));
			if (Bb != null) h.Add("bb",Bb.ToHashtable(highstock));
			if (Bubble != null) h.Add("bubble",Bubble.ToHashtable(highstock));
			if (Candlestick != null) h.Add("candlestick",Candlestick.ToHashtable(highstock));
			if (Cci != null) h.Add("cci",Cci.ToHashtable(highstock));
			if (Chaikin != null) h.Add("chaikin",Chaikin.ToHashtable(highstock));
			if (Cmf != null) h.Add("cmf",Cmf.ToHashtable(highstock));
			if (Cmo != null) h.Add("cmo",Cmo.ToHashtable(highstock));
			if (Column != null) h.Add("column",Column.ToHashtable(highstock));
			if (Columnpyramid != null) h.Add("columnpyramid",Columnpyramid.ToHashtable(highstock));
			if (Columnrange != null) h.Add("columnrange",Columnrange.ToHashtable(highstock));
			if (Dema != null) h.Add("dema",Dema.ToHashtable(highstock));
			if (Disparityindex != null) h.Add("disparityindex",Disparityindex.ToHashtable(highstock));
			if (Dmi != null) h.Add("dmi",Dmi.ToHashtable(highstock));
			if (Dpo != null) h.Add("dpo",Dpo.ToHashtable(highstock));
			if (Dumbbell != null) h.Add("dumbbell",Dumbbell.ToHashtable(highstock));
			if (Ema != null) h.Add("ema",Ema.ToHashtable(highstock));
			if (Flags != null) h.Add("flags",Flags.ToHashtable(highstock));
			if (Heikinashi != null) h.Add("heikinashi",Heikinashi.ToHashtable(highstock));
			if (Hlc != null) h.Add("hlc",Hlc.ToHashtable(highstock));
			if (Hollowcandlestick != null) h.Add("hollowcandlestick",Hollowcandlestick.ToHashtable(highstock));
			if (Ikh != null) h.Add("ikh",Ikh.ToHashtable(highstock));
			if (Keltnerchannels != null) h.Add("keltnerchannels",Keltnerchannels.ToHashtable(highstock));
			if (Klinger != null) h.Add("klinger",Klinger.ToHashtable(highstock));
			if (Line != null) h.Add("line",Line.ToHashtable(highstock));
			if (Linearregression != null) h.Add("linearregression",Linearregression.ToHashtable(highstock));
			if (Linearregressionangle != null) h.Add("linearregressionangle",Linearregressionangle.ToHashtable(highstock));
			if (Linearregressionintercept != null) h.Add("linearregressionintercept",Linearregressionintercept.ToHashtable(highstock));
			if (Linearregressionslope != null) h.Add("linearregressionslope",Linearregressionslope.ToHashtable(highstock));
			if (Lollipop != null) h.Add("lollipop",Lollipop.ToHashtable(highstock));
			if (Macd != null) h.Add("macd",Macd.ToHashtable(highstock));
			if (Mfi != null) h.Add("mfi",Mfi.ToHashtable(highstock));
			if (Momentum != null) h.Add("momentum",Momentum.ToHashtable(highstock));
			if (Natr != null) h.Add("natr",Natr.ToHashtable(highstock));
			if (Obv != null) h.Add("obv",Obv.ToHashtable(highstock));
			if (Ohlc != null) h.Add("ohlc",Ohlc.ToHashtable(highstock));
			if (Pc != null) h.Add("pc",Pc.ToHashtable(highstock));
			if (Pivotpoints != null) h.Add("pivotpoints",Pivotpoints.ToHashtable(highstock));
			if (Polygon != null) h.Add("polygon",Polygon.ToHashtable(highstock));
			if (Ppo != null) h.Add("ppo",Ppo.ToHashtable(highstock));
			if (Priceenvelopes != null) h.Add("priceenvelopes",Priceenvelopes.ToHashtable(highstock));
			if (Psar != null) h.Add("psar",Psar.ToHashtable(highstock));
			if (Roc != null) h.Add("roc",Roc.ToHashtable(highstock));
			if (Rsi != null) h.Add("rsi",Rsi.ToHashtable(highstock));
			if (Scatter != null) h.Add("scatter",Scatter.ToHashtable(highstock));
			if (Series != null) h.Add("series",Series.ToHashtable(highstock));
			if (Slowstochastic != null) h.Add("slowstochastic",Slowstochastic.ToHashtable(highstock));
			if (Sma != null) h.Add("sma",Sma.ToHashtable(highstock));
			if (Spline != null) h.Add("spline",Spline.ToHashtable(highstock));
			if (Stochastic != null) h.Add("stochastic",Stochastic.ToHashtable(highstock));
			if (Streamgraph != null) h.Add("streamgraph",Streamgraph.ToHashtable(highstock));
			if (Supertrend != null) h.Add("supertrend",Supertrend.ToHashtable(highstock));
			if (Tema != null) h.Add("tema",Tema.ToHashtable(highstock));
			if (Trendline != null) h.Add("trendline",Trendline.ToHashtable(highstock));
			if (Trix != null) h.Add("trix",Trix.ToHashtable(highstock));
			if (Vbp != null) h.Add("vbp",Vbp.ToHashtable(highstock));
			if (Vector != null) h.Add("vector",Vector.ToHashtable(highstock));
			if (Vwap != null) h.Add("vwap",Vwap.ToHashtable(highstock));
			if (Williamsr != null) h.Add("williamsr",Williamsr.ToHashtable(highstock));
			if (Windbarb != null) h.Add("windbarb",Windbarb.ToHashtable(highstock));
			if (Wma != null) h.Add("wma",Wma.ToHashtable(highstock));
			if (Xrange != null) h.Add("xrange",Xrange.ToHashtable(highstock));
			if (Zigzag != null) h.Add("zigzag",Zigzag.ToHashtable(highstock));
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}