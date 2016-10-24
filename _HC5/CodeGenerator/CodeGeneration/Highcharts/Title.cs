using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Title  : BaseObject
	{
		public Title()
		{
			Align = Align_DefaultValue = TitleAlign.Center;
			Floating = Floating_DefaultValue = false;
			Margin = Margin_DefaultValue = new string[] {};
			Style = Style_DefaultValue = new NameValueCollection{{ "color", "#333333"},{ "fontSize", "18px" }};
			Text = Text_DefaultValue = "Chart title";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = TitleVerticalAlign.Null;
			WidthAdjust = WidthAdjust_DefaultValue = -44;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The horizontal alignment of the title. Can be one of "left", "center" and "right".
		/// </summary>
		public TitleAlign Align { get; set; }
		private TitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the title is floating, the plot area will not move to make space for it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the title and the plot area, or if a subtitle is present, the margin between the subtitle and the plot area.
		/// </summary>
		public new string[] Margin { get; set; }
		private new string[] Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the title. Use this for font styling, but use <code>align</code>, <code>x</code> and <code>y</code> for text alignment.</p><p>In <a href="http://www.highcharts.com/docs/chart-design-and-style/style-by-css">styled mode</a>, the title style is given in the <code>.highcharts-title</code> class.</p>
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The title of the chart. To disable the title, set the <code>text</code> to <code>null</code>.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the text.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the title. Can be one of <code>"top"</code>, <code>"middle"</code> and <code>"bottom"</code>. When a value is given, the title behaves as if <a href="#title.floating">floating</a> were <code>true</code>.
		/// </summary>
		public TitleVerticalAlign VerticalAlign { get; set; }
		private TitleVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Adjustment made to the title width, normally to reserve space for the exporting burger menu.
		/// </summary>
		public double? WidthAdjust { get; set; }
		private double? WidthAdjust_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the title relative to the alignment within <a href="#chart.spacingTop">chart.spacingTop</a> and <a href="#chart.spacingBottom">chart.spacingBottom</a>. By default it depends on the font size.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (WidthAdjust != WidthAdjust_DefaultValue) h.Add("widthAdjust",WidthAdjust);
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