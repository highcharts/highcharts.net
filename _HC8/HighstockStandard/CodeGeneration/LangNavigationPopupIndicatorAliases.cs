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
	public partial class LangNavigationPopupIndicatorAliases  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangNavigationPopupIndicatorAliases()
		{
			Abands = Abands_DefaultValue = new List<string>();
			Ad = Ad_DefaultValue = new List<string>();
			Ao = Ao_DefaultValue = new List<string>();
			Apo = Apo_DefaultValue = new List<string>();
			Aroon = Aroon_DefaultValue = new List<string>();
			Aroonoscillator = Aroonoscillator_DefaultValue = new List<string>();
			Atr = Atr_DefaultValue = new List<string>();
			Bb = Bb_DefaultValue = new List<string>();
			Cci = Cci_DefaultValue = new List<string>();
			Chaikin = Chaikin_DefaultValue = new List<string>();
			Cmf = Cmf_DefaultValue = new List<string>();
			Cmo = Cmo_DefaultValue = new List<string>();
			Dema = Dema_DefaultValue = new List<string>();
			Disparityindex = Disparityindex_DefaultValue = new List<string>();
			Dmi = Dmi_DefaultValue = new List<string>();
			Dpo = Dpo_DefaultValue = new List<string>();
			Ema = Ema_DefaultValue = new List<string>();
			Ikh = Ikh_DefaultValue = new List<string>();
			Keltnerchannels = Keltnerchannels_DefaultValue = new List<string>();
			Klinger = Klinger_DefaultValue = new List<string>();
			LinearRegression = LinearRegression_DefaultValue = new List<string>();
			LinearRegressionAngle = LinearRegressionAngle_DefaultValue = new List<string>();
			LinearRegressionIntercept = LinearRegressionIntercept_DefaultValue = new List<string>();
			LinearRegressionSlope = LinearRegressionSlope_DefaultValue = new List<string>();
			Macd = Macd_DefaultValue = new List<string>();
			Mfi = Mfi_DefaultValue = new List<string>();
			Momentum = Momentum_DefaultValue = new List<string>();
			Natr = Natr_DefaultValue = new List<string>();
			Obv = Obv_DefaultValue = new List<string>();
			Pc = Pc_DefaultValue = new List<string>();
			Pivotpoints = Pivotpoints_DefaultValue = new List<string>();
			Ppo = Ppo_DefaultValue = new List<string>();
			Priceenvelopes = Priceenvelopes_DefaultValue = new List<string>();
			Psar = Psar_DefaultValue = new List<string>();
			Roc = Roc_DefaultValue = new List<string>();
			Rsi = Rsi_DefaultValue = new List<string>();
			Slowstochastic = Slowstochastic_DefaultValue = new List<string>();
			Sma = Sma_DefaultValue = new List<string>();
			Stochastic = Stochastic_DefaultValue = new List<string>();
			Supertrend = Supertrend_DefaultValue = new List<string>();
			Tema = Tema_DefaultValue = new List<string>();
			Trix = Trix_DefaultValue = new List<string>();
			Vbp = Vbp_DefaultValue = new List<string>();
			Vwap = Vwap_DefaultValue = new List<string>();
			Williamsr = Williamsr_DefaultValue = new List<string>();
			Wma = Wma_DefaultValue = new List<string>();
			Zigzag = Zigzag_DefaultValue = new List<string>();
			
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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Abands != Abands_DefaultValue) h.Add("abands",Abands);
			if (Ad != Ad_DefaultValue) h.Add("ad",Ad);
			if (Ao != Ao_DefaultValue) h.Add("ao",Ao);
			if (Apo != Apo_DefaultValue) h.Add("apo",Apo);
			if (Aroon != Aroon_DefaultValue) h.Add("aroon",Aroon);
			if (Aroonoscillator != Aroonoscillator_DefaultValue) h.Add("aroonoscillator",Aroonoscillator);
			if (Atr != Atr_DefaultValue) h.Add("atr",Atr);
			if (Bb != Bb_DefaultValue) h.Add("bb",Bb);
			if (Cci != Cci_DefaultValue) h.Add("cci",Cci);
			if (Chaikin != Chaikin_DefaultValue) h.Add("chaikin",Chaikin);
			if (Cmf != Cmf_DefaultValue) h.Add("cmf",Cmf);
			if (Cmo != Cmo_DefaultValue) h.Add("cmo",Cmo);
			if (Dema != Dema_DefaultValue) h.Add("dema",Dema);
			if (Disparityindex != Disparityindex_DefaultValue) h.Add("disparityindex",Disparityindex);
			if (Dmi != Dmi_DefaultValue) h.Add("dmi",Dmi);
			if (Dpo != Dpo_DefaultValue) h.Add("dpo",Dpo);
			if (Ema != Ema_DefaultValue) h.Add("ema",Ema);
			if (Ikh != Ikh_DefaultValue) h.Add("ikh",Ikh);
			if (Keltnerchannels != Keltnerchannels_DefaultValue) h.Add("keltnerchannels",Keltnerchannels);
			if (Klinger != Klinger_DefaultValue) h.Add("klinger",Klinger);
			if (LinearRegression != LinearRegression_DefaultValue) h.Add("linearRegression",LinearRegression);
			if (LinearRegressionAngle != LinearRegressionAngle_DefaultValue) h.Add("linearRegressionAngle",LinearRegressionAngle);
			if (LinearRegressionIntercept != LinearRegressionIntercept_DefaultValue) h.Add("linearRegressionIntercept",LinearRegressionIntercept);
			if (LinearRegressionSlope != LinearRegressionSlope_DefaultValue) h.Add("linearRegressionSlope",LinearRegressionSlope);
			if (Macd != Macd_DefaultValue) h.Add("macd",Macd);
			if (Mfi != Mfi_DefaultValue) h.Add("mfi",Mfi);
			if (Momentum != Momentum_DefaultValue) h.Add("momentum",Momentum);
			if (Natr != Natr_DefaultValue) h.Add("natr",Natr);
			if (Obv != Obv_DefaultValue) h.Add("obv",Obv);
			if (Pc != Pc_DefaultValue) h.Add("pc",Pc);
			if (Pivotpoints != Pivotpoints_DefaultValue) h.Add("pivotpoints",Pivotpoints);
			if (Ppo != Ppo_DefaultValue) h.Add("ppo",Ppo);
			if (Priceenvelopes != Priceenvelopes_DefaultValue) h.Add("priceenvelopes",Priceenvelopes);
			if (Psar != Psar_DefaultValue) h.Add("psar",Psar);
			if (Roc != Roc_DefaultValue) h.Add("roc",Roc);
			if (Rsi != Rsi_DefaultValue) h.Add("rsi",Rsi);
			if (Slowstochastic != Slowstochastic_DefaultValue) h.Add("slowstochastic",Slowstochastic);
			if (Sma != Sma_DefaultValue) h.Add("sma",Sma);
			if (Stochastic != Stochastic_DefaultValue) h.Add("stochastic",Stochastic);
			if (Supertrend != Supertrend_DefaultValue) h.Add("supertrend",Supertrend);
			if (Tema != Tema_DefaultValue) h.Add("tema",Tema);
			if (Trix != Trix_DefaultValue) h.Add("trix",Trix);
			if (Vbp != Vbp_DefaultValue) h.Add("vbp",Vbp);
			if (Vwap != Vwap_DefaultValue) h.Add("vwap",Vwap);
			if (Williamsr != Williamsr_DefaultValue) h.Add("williamsr",Williamsr);
			if (Wma != Wma_DefaultValue) h.Add("wma",Wma);
			if (Zigzag != Zigzag_DefaultValue) h.Add("zigzag",Zigzag);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}