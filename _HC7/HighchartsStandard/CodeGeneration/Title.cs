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
	public partial class Title  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Title()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The horizontal alignment of the title. Can be one of "left", "center"and "right".
		/// </summary>
		public TitleAlign Align { get; set; }
		 

		/// <summary>
		/// When the title is floating, the plot area will not move to make spacefor it.
		/// </summary>
		public bool? Floating { get; set; }
		 

		/// <summary>
		/// The margin between the title and the plot area, or if a subtitleis present, the margin between the subtitle and the plot area.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. Use this for font styling, but use `align`,`x` and `y` for text alignment.In styled mode, the title style is given in the `.highcharts-title`class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// The title of the chart. To disable the title, set the `text` to`undefined`.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// Whether to[use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the text.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the title. Can be one of `"top"`,`"middle"` and `"bottom"`. When a value is given, the title behavesas if [floating](#title.floating) were `true`.
		/// </summary>
		public TitleVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// Adjustment made to the title width, normally to reserve space forthe exporting burger menu.
		/// </summary>
		public double? WidthAdjust { get; set; }
		 

		/// <summary>
		/// The x position of the title relative to the alignment within`chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position of the title relative to the alignment within[chart.spacingTop](#chart.spacingTop) and [chart.spacingBottom](#chart.spacingBottom). By default it depends on the font size.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != TitleAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (Floating != null) h.Add("floating",Floating);
			if (Margin != null) h.Add("margin",Margin);
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != TitleVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (WidthAdjust != null) h.Add("widthAdjust",WidthAdjust);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields.Count > 0)
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