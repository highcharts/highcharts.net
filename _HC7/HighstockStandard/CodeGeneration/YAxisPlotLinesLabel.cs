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
	public partial class YAxisPlotLinesLabel  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisPlotLinesLabel()
		{
		}	
		

		/// <summary>
		/// Horizontal alignment of the label. Can be one of "left", "center" or"right".
		/// </summary>
		public YAxisPlotLinesLabelAlign Align { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the label. Useful properties likethe value of plot line or the range of plot band (`from` & `to`properties) can be found in `this.options` object.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// Rotation of the text label in degrees. Defaults to 0 for horizontal plotlines and 90 for vertical lines.
		/// </summary>
		public double? Rotation { get; set; }
		 

		/// <summary>
		/// CSS styles for the text label.In styled mode, the labels are styled by the`.highcharts-plot-line-label` class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// The text itself. A subset of HTML is supported.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While `align` determines where thetexts anchor point is placed within the plot band, `textAlign` determineshow the text is aligned against its anchor point. Possible values are"left", "center" and "right". Defaults to the same as the `align` option.
		/// </summary>
		public YAxisPlotLinesLabelTextAlign TextAlign { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the label relative to the plot line. Can beone of "top", "middle" or "bottom".
		/// </summary>
		public YAxisPlotLinesLabelVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// Horizontal position relative the alignment. Default varies byorientation.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Vertical position of the text baseline relative to the alignment. Defaultvaries by orientation.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != YAxisPlotLinesLabelAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (Formatter != null) { h.Add("formatter",Formatter); highstock.AddFunction("formatter", Formatter); }  
			if (Rotation != null) h.Add("rotation",Rotation);
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (TextAlign != YAxisPlotLinesLabelTextAlign.Null) h.Add("textAlign", highstock.FirstCharacterToLower(TextAlign.ToString()));
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != YAxisPlotLinesLabelVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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