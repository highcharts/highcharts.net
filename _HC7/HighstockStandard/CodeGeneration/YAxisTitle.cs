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
	public partial class YAxisTitle  : BaseObject
	{
		public YAxisTitle()
		{
			Align = Align_DefaultValue = "middle";
			Margin = Margin_DefaultValue = null;
			Offset = Offset_DefaultValue = null;
			ReserveSpace = ReserveSpace_DefaultValue = true;
			Rotation = Rotation_DefaultValue = 270;
			Style = Style_DefaultValue = new YAxisTitleStyle();
			Text = Text_DefaultValue = "Values";
			TextAlign = TextAlign_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Alignment of the title relative to the axis values. Possiblevalues are "low", "middle" or "high".
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels and the title.Positive values are outside the axis line, negative are inside.
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the axis title from the axis line. By default,this distance is computed from the offset width of the labels,the labels' distance from the axis and the title's margin.However when the offset option is set, it overrides all this.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the title when laying out the axis.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		private bool? ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 isvertical reading from bottom to top.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. If the title text is longer than theaxis length, it will wrap to multiple lines by default. This canbe customized by setting `textOverflow: 'ellipsis'`, bysetting a specific `width` or by setting `whiteSpace: 'nowrap'`.In styled mode, the stroke width is given in the`.highcharts-axis-title` class.
		/// </summary>
		public YAxisTitleStyle Style { get; set; }
		private YAxisTitleStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The actual text of the axis title. Horizontal texts can containHTML, but rotated texts are painted using vector techniques andmust be clean text. The Y axis title is disabled by setting the`text` option to `undefined`.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Alignment of the text, can be `"left"`, `"right"` or `"center"`.Default alignment depends on the[title.align](xAxis.title.align):Horizontal axes:- for `align` = `"low"`, `textAlign` is set to `left`- for `align` = `"middle"`, `textAlign` is set to `center`- for `align` = `"high"`, `textAlign` is set to `right`Vertical axes:- for `align` = `"low"` and `opposite` = `true`, `textAlign` is  set to `right`- for `align` = `"low"` and `opposite` = `false`, `textAlign` is  set to `left`- for `align` = `"middle"`, `textAlign` is set to `center`- for `align` = `"high"` and `opposite` = `true` `textAlign` is  set to `left`- for `align` = `"high"` and `opposite` = `false` `textAlign` is  set to `right`
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the axis title.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal pixel offset of the title position.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical pixel offset of the title position.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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