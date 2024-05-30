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
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Acceleration Bands alias.
		/// </summary>
		public List<string> Abands { get; set; }
		private List<string> Abands_DefaultValue { get; set; }
		 

		/// <summary>
		/// Accumulation/Distribution alias.
		/// </summary>
		public List<string> Ad { get; set; }
		private List<string> Ad_DefaultValue { get; set; }
		 

		/// <summary>
		/// Awesome oscillator alias.
		/// </summary>
		public List<string> Ao { get; set; }
		private List<string> Ao_DefaultValue { get; set; }
		 

		/// <summary>
		/// Absolute price indicator alias.
		/// </summary>
		public List<string> Apo { get; set; }
		private List<string> Apo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Aroon alias.
		/// </summary>
		public List<string> Aroon { get; set; }
		private List<string> Aroon_DefaultValue { get; set; }
		 

		/// <summary>
		/// Aroon oscillator alias.
		/// </summary>
		public List<string> Aroonoscillator { get; set; }
		private List<string> Aroonoscillator_DefaultValue { get; set; }
		 

		/// <summary>
		/// Average True Range alias.
		/// </summary>
		public List<string> Atr { get; set; }
		private List<string> Atr_DefaultValue { get; set; }
		 

		/// <summary>
		/// Bollinger Bands alias.
		/// </summary>
		public List<string> Bb { get; set; }
		private List<string> Bb_DefaultValue { get; set; }
		 

		/// <summary>
		/// Commodity Channel Index alias.
		/// </summary>
		public List<string> Cci { get; set; }
		private List<string> Cci_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chaikin alias.
		/// </summary>
		public List<string> Chaikin { get; set; }
		private List<string> Chaikin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chaikin Money Flow alias.
		/// </summary>
		public List<string> Cmf { get; set; }
		private List<string> Cmf_DefaultValue { get; set; }
		 

		/// <summary>
		/// Chande Momentum Oscillator alias.
		/// </summary>
		public List<string> Cmo { get; set; }
		private List<string> Cmo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Double Exponential Moving Average alias.
		/// </summary>
		public List<string> Dema { get; set; }
		private List<string> Dema_DefaultValue { get; set; }
		 

		/// <summary>
		/// Disparity Index alias.
		/// </summary>
		public List<string> Disparityindex { get; set; }
		private List<string> Disparityindex_DefaultValue { get; set; }
		 

		/// <summary>
		/// Directional Movement Index alias.
		/// </summary>
		public List<string> Dmi { get; set; }
		private List<string> Dmi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Detrended price oscillator alias.
		/// </summary>
		public List<string> Dpo { get; set; }
		private List<string> Dpo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Exponential Moving Average alias.
		/// </summary>
		public List<string> Ema { get; set; }
		private List<string> Ema_DefaultValue { get; set; }
		 

		/// <summary>
		/// Ichimoku Kinko Hyo alias.
		/// </summary>
		public List<string> Ikh { get; set; }
		private List<string> Ikh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Keltner Channels alias.
		/// </summary>
		public List<string> Keltnerchannels { get; set; }
		private List<string> Keltnerchannels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Klinger Oscillator alias.
		/// </summary>
		public List<string> Klinger { get; set; }
		private List<string> Klinger_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear Regression alias.
		/// </summary>
		public List<string> LinearRegression { get; set; }
		private List<string> LinearRegression_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear Regression Angle alias.
		/// </summary>
		public List<string> LinearRegressionAngle { get; set; }
		private List<string> LinearRegressionAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear Regression Intercept alias.
		/// </summary>
		public List<string> LinearRegressionIntercept { get; set; }
		private List<string> LinearRegressionIntercept_DefaultValue { get; set; }
		 

		/// <summary>
		/// Linear Regression Slope alias.
		/// </summary>
		public List<string> LinearRegressionSlope { get; set; }
		private List<string> LinearRegressionSlope_DefaultValue { get; set; }
		 

		/// <summary>
		/// Moving Average Convergence Divergence alias.
		/// </summary>
		public List<string> Macd { get; set; }
		private List<string> Macd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Money Flow Index alias.
		/// </summary>
		public List<string> Mfi { get; set; }
		private List<string> Mfi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Momentum alias.
		/// </summary>
		public List<string> Momentum { get; set; }
		private List<string> Momentum_DefaultValue { get; set; }
		 

		/// <summary>
		/// Normalized Average True Range alias.
		/// </summary>
		public List<string> Natr { get; set; }
		private List<string> Natr_DefaultValue { get; set; }
		 

		/// <summary>
		/// On-Balance Volume alias.
		/// </summary>
		public List<string> Obv { get; set; }
		private List<string> Obv_DefaultValue { get; set; }
		 

		/// <summary>
		/// Price Channel alias.
		/// </summary>
		public List<string> Pc { get; set; }
		private List<string> Pc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pivot Points alias.
		/// </summary>
		public List<string> Pivotpoints { get; set; }
		private List<string> Pivotpoints_DefaultValue { get; set; }
		 

		/// <summary>
		/// Percentage Price oscillator alias.
		/// </summary>
		public List<string> Ppo { get; set; }
		private List<string> Ppo_DefaultValue { get; set; }
		 

		/// <summary>
		/// Price Envelopes alias.
		/// </summary>
		public List<string> Priceenvelopes { get; set; }
		private List<string> Priceenvelopes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Parabolic SAR alias.
		/// </summary>
		public List<string> Psar { get; set; }
		private List<string> Psar_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rate of Change alias.
		/// </summary>
		public List<string> Roc { get; set; }
		private List<string> Roc_DefaultValue { get; set; }
		 

		/// <summary>
		/// Relative Strength Index alias.
		/// </summary>
		public List<string> Rsi { get; set; }
		private List<string> Rsi_DefaultValue { get; set; }
		 

		/// <summary>
		/// Slow Stochastic alias.
		/// </summary>
		public List<string> Slowstochastic { get; set; }
		private List<string> Slowstochastic_DefaultValue { get; set; }
		 

		/// <summary>
		/// Simple Moving Average alias.
		/// </summary>
		public List<string> Sma { get; set; }
		private List<string> Sma_DefaultValue { get; set; }
		 

		/// <summary>
		/// Stochastic alias.
		/// </summary>
		public List<string> Stochastic { get; set; }
		private List<string> Stochastic_DefaultValue { get; set; }
		 

		/// <summary>
		/// Super Trend alias.
		/// </summary>
		public List<string> Supertrend { get; set; }
		private List<string> Supertrend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Triple Exponential Moving Average alias.
		/// </summary>
		public List<string> Tema { get; set; }
		private List<string> Tema_DefaultValue { get; set; }
		 

		/// <summary>
		/// TRIX alias.
		/// </summary>
		public List<string> Trix { get; set; }
		private List<string> Trix_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume by Price alias.
		/// </summary>
		public List<string> Vbp { get; set; }
		private List<string> Vbp_DefaultValue { get; set; }
		 

		/// <summary>
		/// Volume Weighted Moving Average alias.
		/// </summary>
		public List<string> Vwap { get; set; }
		private List<string> Vwap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Williams %R alias.
		/// </summary>
		public List<string> Williamsr { get; set; }
		private List<string> Williamsr_DefaultValue { get; set; }
		 

		/// <summary>
		/// Weighted Moving Average alias.
		/// </summary>
		public List<string> Wma { get; set; }
		private List<string> Wma_DefaultValue { get; set; }
		 

		/// <summary>
		/// Zig Zagalias.
		/// </summary>
		public List<string> Zigzag { get; set; }
		private List<string> Zigzag_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

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
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}