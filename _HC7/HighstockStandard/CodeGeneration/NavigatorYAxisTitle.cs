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
	public partial class NavigatorYAxisTitle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigatorYAxisTitle()
		{
		}	
		

		/// <summary>
		/// Alignment of the title relative to the axis values. Possiblevalues are "low", "middle" or "high".
		/// </summary>
		public NavigatorYAxisTitleAlign Align { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels or line and the title.Defaults to 0 for horizontal axes, 10 for vertical
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// The distance of the axis title from the axis line. By default,this distance is computed from the offset width of the labels,the labels' distance from the axis and the title's margin.However when the offset option is set, it overrides all this.
		/// </summary>
		public double? Offset { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the title when laying out the axis.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		 

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 isvertical reading from bottom to top. Defaults to 0 for horizontalaxes, 270 for left-side axes and 90 for right-side axes.
		/// </summary>
		public double? Rotation { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. If the title text is longer than theaxis length, it will wrap to multiple lines by default. This canbe customized by setting `textOverflow: 'ellipsis'`, bysetting a specific `width` or by setting `whiteSpace: 'nowrap'`.In styled mode, the stroke width is given in the`.highcharts-axis-title` class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// Alignment of the text, can be `"left"`, `"right"` or `"center"`.Default alignment depends on the[title.align](xAxis.title.align):Horizontal axes:- for `align` = `"low"`, `textAlign` is set to `left`- for `align` = `"middle"`, `textAlign` is set to `center`- for `align` = `"high"`, `textAlign` is set to `right`Vertical axes:- for `align` = `"low"` and `opposite` = `true`, `textAlign` is  set to `right`- for `align` = `"low"` and `opposite` = `false`, `textAlign` is  set to `left`- for `align` = `"middle"`, `textAlign` is set to `center`- for `align` = `"high"` and `opposite` = `true` `textAlign` is  set to `left`- for `align` = `"high"` and `opposite` = `false` `textAlign` is  set to `right`
		/// </summary>
		public NavigatorYAxisTitleTextAlign TextAlign { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html)to render the axis title.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// Horizontal pixel offset of the title position.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Vertical pixel offset of the title position.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != NavigatorYAxisTitleAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (Margin != null) h.Add("margin",Margin);
			if (Offset != null) h.Add("offset",Offset);
			if (ReserveSpace != null) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != null) h.Add("rotation",Rotation);
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (TextAlign != NavigatorYAxisTitleTextAlign.Null) h.Add("textAlign", highstock.FirstCharacterToLower(TextAlign.ToString()));
			if (UseHTML != null) h.Add("useHTML",UseHTML);
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