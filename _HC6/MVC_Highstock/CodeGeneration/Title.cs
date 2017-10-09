using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Title  : BaseObject
	{
		public Title()
		{
			Text = Text_DefaultValue = "Chart title";
			Align = Align_DefaultValue = TitleAlign.Center;
			Margin = Margin_DefaultValue = null;
			WidthAdjust = WidthAdjust_DefaultValue = -44;
			Floating = Floating_DefaultValue = false;
			Style = Style_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = TitleVerticalAlign.Null;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The title of the chart. To disable the title, set the <code>text</code> to<code>null</code>.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The horizontal alignment of the title. Can be one of &quot;left&quot;, &quot;center&quot;and &quot;right&quot;.</p>
		/// </summary>
		public TitleAlign Align { get; set; }
		private TitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The margin between the title and the plot area, or if a subtitleis present, the margin between the subtitle and the plot area.</p>
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Adjustment made to the title width, normally to reserve space forthe exporting burger menu.</p>
		/// </summary>
		public double? WidthAdjust { get; set; }
		private double? WidthAdjust_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the title is floating, the plot area will not move to make spacefor it.</p>
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the title. Use this for font styling, but use <code>align</code>,<code>x</code> and <code>y</code> for text alignment.</p><p>In styled mode, the title style is given in the <code>.highcharts-title</code> class.</p>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the text.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical alignment of the title. Can be one of <code>&quot;top&quot;</code>, <code>&quot;middle&quot;</code>and <code>&quot;bottom&quot;</code>. When a value is given, the title behaves as if <a href="#title.floating">floating</a> were <code>true</code>.</p>
		/// </summary>
		public TitleVerticalAlign VerticalAlign { get; set; }
		private TitleVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position of the title relative to the alignment within <a href="#chart.spacingTop">chart.spacingTop</a> and <a href="#chart.spacingBottom">chart.spacingBottom</a>. By default it depends on the font size.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (WidthAdjust != WidthAdjust_DefaultValue) h.Add("widthAdjust",WidthAdjust);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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