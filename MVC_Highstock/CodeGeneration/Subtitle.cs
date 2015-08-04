using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class Subtitle  : BaseObject
	{
		public Subtitle()
		{
			Align = Align_DefaultValue = SubtitleAlign.Center;
			Floating = Floating_DefaultValue = false;
			Style = Style_DefaultValue = new NameValueCollection{{ "color", "#555555" }};
			Text = Text_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = SubtitleVerticalAlign.Top;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue =  null;
			
		}	
		

		/// <summary>
		/// The horizontal alignment of the subtitle. Can be one of "left", "center" and "right".
		/// </summary>
		public SubtitleAlign Align { get; set; }
		private SubtitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the subtitle is floating, the plot area will not move to make space for it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. Exact positioning of the title can be achieved by changing the margin property, or by adding <code>position: "absolute"</code> and  left and top properties.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The subtitle of the chart.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the text.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the title. Can be one of "top", "middle" and "bottom". When a value is given, the title behaves as floating.
		/// </summary>
		public SubtitleVerticalAlign VerticalAlign { get; set; }
		private SubtitleVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the subtitle relative to the alignment within chart.spacingLeft and chart.spacingRight.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the subtitle relative to the alignment within chart.spacingTop and chart.spacingBottom. By default the subtitle is laid out below the title unless the title is floating.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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