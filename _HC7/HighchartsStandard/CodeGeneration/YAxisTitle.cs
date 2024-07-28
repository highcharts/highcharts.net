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
	public partial class YAxisTitle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisTitle()
		{
		}	
		

		/// <summary>
		/// Alignment of the title relative to the axis values. Possiblevalues are "low", "middle" or "high".
		/// </summary>
		public YAxisTitleAlign Align { get; set; }
		 

		/// <summary>
		/// Deprecated. Set the `text` to `undefined` to disable the title.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels and the title.Positive values are outside the axis line, negative are inside.
		/// </summary>
		public double? Margin { get; set; }
		 

		/// <summary>
		/// The distance of the axis title from the axis line. By default,this distance is computed from the offset width of the labels,the labels' distance from the axis and the title's margin.However when the offset option is set, it overrides all this.
		/// </summary>
		public double? Offset { get; set; }
		 

		/// <summary>
		/// Defines how the title is repositioned according to the 3D chartorientation.- `'offset'`: Maintain a fixed horizontal/vertical distance from  the tick marks, despite the chart orientation. This is the  backwards compatible behavior, and causes skewing of X and Z  axes.- `'chart'`: Preserve 3D position relative to the chart. This  looks nice, but hard to read if the text isn't forward-facing.- `'flap'`: Rotated text along the axis to compensate for the  chart orientation. This tries to maintain text as legible as  possible on all orientations.- `'ortho'`: Rotated text along the axis direction so that the  labels are orthogonal to the axis. This is very similar to  `'flap'`, but prevents skewing the labels (X and Y scaling are  still present).- `undefined`: Will use the config from `labels.position3d`
		/// </summary>
		public YAxisTitlePosition3d Position3d { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the title when laying out the axis.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		 

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 isvertical reading from bottom to top. Defaults to 0 for horizontalaxes, 270 for left-side axes and 90 for right-side axes.
		/// </summary>
		public double? Rotation { get; set; }
		 

		/// <summary>
		/// If enabled, the axis title will skewed to follow the perspective.This will fix overlapping labels and titles, but texts becomeless legible due to the distortion.The final appearance depends heavily on `title.position3d`.A `null` value will use the config from `labels.skew3d`.
		/// </summary>
		public bool? Skew3d { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. If the title text is longer than theaxis length, it will wrap to multiple lines by default. This canbe customized by setting `textOverflow: 'ellipsis'`, bysetting a specific `width` or by setting `whiteSpace: 'nowrap'`.In styled mode, the stroke width is given in the`.highcharts-axis-title` class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// The actual text of the axis title. Horizontal texts can containHTML, but rotated texts are painted using vector techniques andmust be clean text. The Y axis title is disabled by setting the`text` option to `undefined`.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// Alignment of the text, can be `"left"`, `"right"` or `"center"`.Default alignment depends on the[title.align](xAxis.title.align):Horizontal axes:- for `align` = `"low"`, `textAlign` is set to `left`- for `align` = `"middle"`, `textAlign` is set to `center`- for `align` = `"high"`, `textAlign` is set to `right`Vertical axes:- for `align` = `"low"` and `opposite` = `true`, `textAlign` is  set to `right`- for `align` = `"low"` and `opposite` = `false`, `textAlign` is  set to `left`- for `align` = `"middle"`, `textAlign` is set to `center`- for `align` = `"high"` and `opposite` = `true` `textAlign` is  set to `left`- for `align` = `"high"` and `opposite` = `false` `textAlign` is  set to `right`
		/// </summary>
		public YAxisTitleTextAlign TextAlign { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != YAxisTitleAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Margin != null) h.Add("margin",Margin);
			if (Offset != null) h.Add("offset",Offset);
			if (Position3d != YAxisTitlePosition3d.Null) h.Add("position3d", highcharts.FirstCharacterToLower(Position3d.ToString()));
			if (ReserveSpace != null) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != null) h.Add("rotation",Rotation);
			if (Skew3d != null) h.Add("skew3d",Skew3d);
			if (Style != null) h.Add("style",Style);
			if (Text != null) h.Add("text",Text);
			if (TextAlign != YAxisTitleTextAlign.Null) h.Add("textAlign", highcharts.FirstCharacterToLower(TextAlign.ToString()));
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