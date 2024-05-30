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
	public partial class Subtitle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Subtitle()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The horizontal alignment of the subtitle. Can be one of "left", "center" and "right".
		/// </summary>
		public SubtitleAlign Align { get; set; }
		private SubtitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// When the subtitle is floating, the plot area will not move to makespace for it.
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the title.In styled mode, the subtitle style is given in the`.highcharts-subtitle` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The subtitle of the chart.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to[use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the text.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the title. Can be one of `"top"`,`"middle"` and `"bottom"`. When middle, the subtitle behaves asfloating.
		/// </summary>
		public SubtitleVerticalAlign VerticalAlign { get; set; }
		private SubtitleVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Adjustment made to the subtitle width, normally to reserve spacefor the exporting burger menu.
		/// </summary>
		public double? WidthAdjust { get; set; }
		private double? WidthAdjust_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the subtitle relative to the alignment within`chart.spacingLeft` and `chart.spacingRight`.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the subtitle relative to the alignment within`chart.spacingTop` and `chart.spacingBottom`. By default the subtitleis laid out below the title unless the title is floating.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Align != SubtitleAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (Floating != null) h.Add("floating",Floating);
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != SubtitleVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
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