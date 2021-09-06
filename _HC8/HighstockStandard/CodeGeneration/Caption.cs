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
	public partial class Caption  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Caption()
		{
			Align = Align_DefaultValue = CaptionAlign.Left;
			Floating = Floating_DefaultValue = false;
			Margin = Margin_DefaultValue = null;
			Style = Style_DefaultValue = new Hashtable();
			Text = Text_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = CaptionVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The horizontal alignment of the caption. Can be one of "left", "center" and "right".
		/// </summary>
		public CaptionAlign Align { get; set; }
		private CaptionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the caption is floating, the plot area will not move to makespace for it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the caption and the plot area.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the caption.In styled mode, the caption style is given in the`.highcharts-caption` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The caption text of the chart.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to[use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the text.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the caption. Can be one of `"top"`,`"middle"` and `"bottom"`. When middle, the caption behaves asfloating.
		/// </summary>
		public CaptionVerticalAlign VerticalAlign { get; set; }
		private CaptionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the caption relative to the alignment within`chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the caption relative to the alignment within`chart.spacingTop` and `chart.spacingBottom`.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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