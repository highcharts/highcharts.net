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
	public partial class NavigatorYAxisTitle  : BaseObject
	{
		public NavigatorYAxisTitle()
		{
			Align = Align_DefaultValue = NavigatorYAxisTitleAlign.Middle;
			Margin = Margin_DefaultValue = null;
			Offset = Offset_DefaultValue = null;
			ReserveSpace = ReserveSpace_DefaultValue = true;
			Rotation = Rotation_DefaultValue = 0;
			Style = Style_DefaultValue = new NavigatorYAxisTitleStyle();
			Text = Text_DefaultValue = "Chart title";
			TextAlign = TextAlign_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Alignment of the title relative to the axis values. Possiblevalues are "low", "middle" or "high".
		/// </summary>
		public NavigatorYAxisTitleAlign Align { get; set; }
		private NavigatorYAxisTitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels or line and the title.Defaults to 0 for horizontal axes, 10 for vertical
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
		public NavigatorYAxisTitleStyle Style { get; set; }
		private NavigatorYAxisTitleStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
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

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
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