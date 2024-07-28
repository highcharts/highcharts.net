using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class LangNavigationPopupIndicatorAliases  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangNavigationPopupIndicatorAliases()
		{
		}	
		

		/// <summary>
		/// Acceleration Bands alias.
		/// </summary>
		public List<string> Abands { get; set; }
		 

		/// <summary>
		/// Accumulation/Distribution alias.
		/// </summary>
		public List<string> Ad { get; set; }
		 

		/// <summary>
		/// Awesome oscillator alias.
		/// </summary>
		public List<string> Ao { get; set; }
		 

		/// <summary>
		/// Absolute price indicator alias.
		/// </summary>
		public List<string> Apo { get; set; }
		 

		/// <summary>
		/// Aroon alias.
		/// </summary>
		public List<string> Aroon { get; set; }
		 

		/// <summary>
		/// Aroon oscillator alias.
		/// </summary>
		public List<string> Aroonoscillator { get; set; }
		 

		/// <summary>
		/// Average True Range alias.
		/// </summary>
		public List<string> Atr { get; set; }
		 

		/// <summary>
		/// Bollinger Bands alias.
		/// </summary>
		public List<string> Bb { get; set; }
		 

		/// <summary>
		/// Commodity Channel Index alias.
		/// </summary>
		public List<string> Cci { get; set; }
		 

		/// <summary>
		/// Chaikin alias.
		/// </summary>
		public List<string> Chaikin { get; set; }
		 

		/// <summary>
		/// Chaikin Money Flow alias.
		/// </summary>
		public List<string> Cmf { get; set; }
		 

		/// <summary>
		/// Chande Momentum Oscillator alias.
		/// </summary>
		public List<string> Cmo { get; set; }
		 

		/// <summary>
		/// Double Exponential Moving Average alias.
		/// </summary>
		public List<string> Dema { get; set; }
		 

		/// <summary>
		/// Disparity Index alias.
		/// </summary>
		public List<string> Disparityindex { get; set; }
		 

		/// <summary>
		/// Directional Movement Index alias.
		/// </summary>
		public List<string> Dmi { get; set; }
		 

		/// <summary>
		/// Detrended price oscillator alias.
		/// </summary>
		public List<string> Dpo { get; set; }
		 

		/// <summary>
		/// Exponential Moving Average alias.
		/// </summary>
		public List<string> Ema { get; set; }
		 

		/// <summary>
		/// Ichimoku Kinko Hyo alias.
		/// </summary>
		public List<string> Ikh { get; set; }
		 

		/// <summary>
		/// Keltner Channels alias.
		/// </summary>
		public List<string> Keltnerchannels { get; set; }
		 

		/// <summary>
		/// Klinger Oscillator alias.
		/// </summary>
		public List<string> Klinger { get; set; }
		 

		/// <summary>
		/// Linear Regression alias.
		/// </summary>
		public List<string> LinearRegression { get; set; }
		 

		/// <summary>
		/// Linear Regression Angle alias.
		/// </summary>
		public List<string> LinearRegressionAngle { get; set; }
		 

		/// <summary>
		/// Linear Regression Intercept alias.
		/// </summary>
		public List<string> LinearRegressionIntercept { get; set; }
		 

		/// <summary>
		/// Linear Regression Slope alias.
		/// </summary>
		public List<string> LinearRegressionSlope { get; set; }
		 

		/// <summary>
		/// Moving Average Convergence Divergence alias.
		/// </summary>
		public List<string> Macd { get; set; }
		 

		/// <summary>
		/// Money Flow Index alias.
		/// </summary>
		public List<string> Mfi { get; set; }
		 

		/// <summary>
		/// Momentum alias.
		/// </summary>
		public List<string> Momentum { get; set; }
		 

		/// <summary>
		/// Normalized Average True Range alias.
		/// </summary>
		public List<string> Natr { get; set; }
		 

		/// <summary>
		/// On-Balance Volume alias.
		/// </summary>
		public List<string> Obv { get; set; }
		 

		/// <summary>
		/// Price Channel alias.
		/// </summary>
		public List<string> Pc { get; set; }
		 

		/// <summary>
		/// Pivot Points alias.
		/// </summary>
		public List<string> Pivotpoints { get; set; }
		 

		/// <summary>
		/// Percentage Price oscillator alias.
		/// </summary>
		public List<string> Ppo { get; set; }
		 

		/// <summary>
		/// Price Envelopes alias.
		/// </summary>
		public List<string> Priceenvelopes { get; set; }
		 

		/// <summary>
		/// Parabolic SAR alias.
		/// </summary>
		public List<string> Psar { get; set; }
		 

		/// <summary>
		/// Rate of Change alias.
		/// </summary>
		public List<string> Roc { get; set; }
		 

		/// <summary>
		/// Relative Strength Index alias.
		/// </summary>
		public List<string> Rsi { get; set; }
		 

		/// <summary>
		/// Slow Stochastic alias.
		/// </summary>
		public List<string> Slowstochastic { get; set; }
		 

		/// <summary>
		/// Simple Moving Average alias.
		/// </summary>
		public List<string> Sma { get; set; }
		 

		/// <summary>
		/// Stochastic alias.
		/// </summary>
		public List<string> Stochastic { get; set; }
		 

		/// <summary>
		/// Super Trend alias.
		/// </summary>
		public List<string> Supertrend { get; set; }
		 

		/// <summary>
		/// Triple Exponential Moving Average alias.
		/// </summary>
		public List<string> Tema { get; set; }
		 

		/// <summary>
		/// TRIX alias.
		/// </summary>
		public List<string> Trix { get; set; }
		 

		/// <summary>
		/// Volume by Price alias.
		/// </summary>
		public List<string> Vbp { get; set; }
		 

		/// <summary>
		/// Volume Weighted Moving Average alias.
		/// </summary>
		public List<string> Vwap { get; set; }
		 

		/// <summary>
		/// Williams %R alias.
		/// </summary>
		public List<string> Williamsr { get; set; }
		 

		/// <summary>
		/// Weighted Moving Average alias.
		/// </summary>
		public List<string> Wma { get; set; }
		 

		/// <summary>
		/// Zig Zagalias.
		/// </summary>
		public List<string> Zigzag { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Abands != null) h.Add("abands",Abands);
			if (Ad != null) h.Add("ad",Ad);
			if (Ao != null) h.Add("ao",Ao);
			if (Apo != null) h.Add("apo",Apo);
			if (Aroon != null) h.Add("aroon",Aroon);
			if (Aroonoscillator != null) h.Add("aroonoscillator",Aroonoscillator);
			if (Atr != null) h.Add("atr",Atr);
			if (Bb != null) h.Add("bb",Bb);
			if (Cci != null) h.Add("cci",Cci);
			if (Chaikin != null) h.Add("chaikin",Chaikin);
			if (Cmf != null) h.Add("cmf",Cmf);
			if (Cmo != null) h.Add("cmo",Cmo);
			if (Dema != null) h.Add("dema",Dema);
			if (Disparityindex != null) h.Add("disparityindex",Disparityindex);
			if (Dmi != null) h.Add("dmi",Dmi);
			if (Dpo != null) h.Add("dpo",Dpo);
			if (Ema != null) h.Add("ema",Ema);
			if (Ikh != null) h.Add("ikh",Ikh);
			if (Keltnerchannels != null) h.Add("keltnerchannels",Keltnerchannels);
			if (Klinger != null) h.Add("klinger",Klinger);
			if (LinearRegression != null) h.Add("linearRegression",LinearRegression);
			if (LinearRegressionAngle != null) h.Add("linearRegressionAngle",LinearRegressionAngle);
			if (LinearRegressionIntercept != null) h.Add("linearRegressionIntercept",LinearRegressionIntercept);
			if (LinearRegressionSlope != null) h.Add("linearRegressionSlope",LinearRegressionSlope);
			if (Macd != null) h.Add("macd",Macd);
			if (Mfi != null) h.Add("mfi",Mfi);
			if (Momentum != null) h.Add("momentum",Momentum);
			if (Natr != null) h.Add("natr",Natr);
			if (Obv != null) h.Add("obv",Obv);
			if (Pc != null) h.Add("pc",Pc);
			if (Pivotpoints != null) h.Add("pivotpoints",Pivotpoints);
			if (Ppo != null) h.Add("ppo",Ppo);
			if (Priceenvelopes != null) h.Add("priceenvelopes",Priceenvelopes);
			if (Psar != null) h.Add("psar",Psar);
			if (Roc != null) h.Add("roc",Roc);
			if (Rsi != null) h.Add("rsi",Rsi);
			if (Slowstochastic != null) h.Add("slowstochastic",Slowstochastic);
			if (Sma != null) h.Add("sma",Sma);
			if (Stochastic != null) h.Add("stochastic",Stochastic);
			if (Supertrend != null) h.Add("supertrend",Supertrend);
			if (Tema != null) h.Add("tema",Tema);
			if (Trix != null) h.Add("trix",Trix);
			if (Vbp != null) h.Add("vbp",Vbp);
			if (Vwap != null) h.Add("vwap",Vwap);
			if (Williamsr != null) h.Add("williamsr",Williamsr);
			if (Wma != null) h.Add("wma",Wma);
			if (Zigzag != null) h.Add("zigzag",Zigzag);
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