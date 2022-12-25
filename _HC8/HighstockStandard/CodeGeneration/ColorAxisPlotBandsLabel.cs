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
	public partial class ColorAxisPlotBandsLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisPlotBandsLabel()
		{
			Align = Align_DefaultValue = ColorAxisPlotBandsLabelAlign.Center;
			Rotation = Rotation_DefaultValue = 0;
			Style = Style_DefaultValue = new Hashtable();
			Text = Text_DefaultValue = "";
			TextAlign = TextAlign_DefaultValue = ColorAxisPlotBandsLabelTextAlign.Null;
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = ColorAxisPlotBandsLabelVerticalAlign.Top;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Horizontal alignment of the label. Can be one of "left", "center" or"right".
		/// </summary>
		public ColorAxisPlotBandsLabelAlign Align { get; set; }
		private ColorAxisPlotBandsLabelAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the text label in degrees .
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the text label.In styled mode, the labels are styled by the`.highcharts-plot-band-label` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The string text itself. A subset of HTML is supported.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While `align` determines where thetexts anchor point is placed within the plot band, `textAlign` determineshow the text is aligned against its anchor point. Possible values are"left", "center" and "right". Defaults to the same as the `align` option.
		/// </summary>
		public ColorAxisPlotBandsLabelTextAlign TextAlign { get; set; }
		private ColorAxisPlotBandsLabelTextAlign TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the label relative to the plot band. Can be one of"top", "middle" or "bottom".
		/// </summary>
		public ColorAxisPlotBandsLabelVerticalAlign VerticalAlign { get; set; }
		private ColorAxisPlotBandsLabelVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal position relative the alignment. Default varies byorientation.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical position of the text baseline relative to the alignment. Defaultvaries by orientation.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign", highstock.FirstCharacterToLower(TextAlign.ToString()));
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}