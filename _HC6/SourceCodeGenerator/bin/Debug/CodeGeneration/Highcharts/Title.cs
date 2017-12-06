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
			Text = Text_DefaultValue = "Chart title";
			Align = Align_DefaultValue = "center";
			Margin = Margin_DefaultValue = null;
			WidthAdjust = WidthAdjust_DefaultValue = -44;
			Floating = Floating_DefaultValue = false;
			Style = Style_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = "";
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The title of the chart. To disable the title, set the `text` to`null`.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal alignment of the title. Can be one of "left", "center"and "right".
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// The margin between the title and the plot area, or if a subtitleis present, the margin between the subtitle and the plot area.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Adjustment made to the title width, normally to reserve space forthe exporting burger menu.
		/// </summary>
		public double? WidthAdjust { get; set; }
		private double? WidthAdjust_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the title is floating, the plot area will not move to make spacefor it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. Use this for font styling, but use `align`,`x` and `y` for text alignment.In styled mode, the title style is given in the `.highcharts-title` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html) to render the text.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the title. Can be one of `"top"`, `"middle"`and `"bottom"`. When a value is given, the title behaves as if [floating](#title.floating) were `true`.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the title relative to the alignment within chart.spacingLeft and chart.spacingRight.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the title relative to the alignment within [chart.spacingTop](#chart.spacingTop) and [chart.spacingBottom](#chart.spacingBottom). By default it depends on the font size.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (WidthAdjust != WidthAdjust_DefaultValue) h.Add("widthAdjust",WidthAdjust);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
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