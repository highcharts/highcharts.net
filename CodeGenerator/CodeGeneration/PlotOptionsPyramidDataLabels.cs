using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class PlotOptionsPyramidDataLabels
	{
		public PlotOptionsPyramidDataLabels()
		{
			BackgroundColor = BackgroundColor_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = null;
			BorderRadius = BorderRadius_DefaultValue = 0;
			BorderWidth = BorderWidth_DefaultValue = 0;
			Color = Color_DefaultValue = null;
			ConnectorColor = ConnectorColor_DefaultValue = "{point.color}";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			Crop = Crop_DefaultValue = true;
			Defer = Defer_DefaultValue = true;
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "{y}";
			Formatter = Formatter_DefaultValue = null;
			Inside = Inside_DefaultValue = null;
			Overflow = Overflow_DefaultValue = "justify";
			Padding = Padding_DefaultValue = 2;
			Rotation = Rotation_DefaultValue = 0;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			SoftConnector = SoftConnector_DefaultValue = true;
			Style = Style_DefaultValue = new NameValueCollection{{"color", "#606060"},{ "fontSize", "11px"}};
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = null;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = -6;
			ZIndex = ZIndex_DefaultValue = 6;
			
		}	
		

		/// <summary>
		/// The background color or gradient for the data label. Defaults to <code>undefined</code>.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the data label. Defaults to <code>undefined</code>.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius in pixels for the data label.
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border width in pixels for the data label.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text color for the data labels. Defaults to <code>null</code>.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line connecting the data label to the pie slice. The default color is the same as the point's color.
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance from the data label to the connector.
		/// </summary>
		public double? ConnectorPadding { get; set; }
		private double? ConnectorPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the line connecting the data label to the pie slice.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to hide data labels that are outside the plot area. By default, the data label is moved inside the plot area according to the <a href="#plotOptions.series.dataLabels.overflow">overflow</a> option.
		/// </summary>
		public bool? Crop { get; set; }
		private bool? Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to defer displaying the data labels until the initial series animation has finished.
		/// </summary>
		public bool? Defer { get; set; }
		private bool? Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbers put the data label on top of the pie slices. Connectors are only shown for data labels outside the pie.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// A <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format string</a> for the data label. Available variables are the same as for <code>formatter</code>.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback JavaScript function to format the data label. Note that if a <code>format</code> is defined, the format takes precedence and the formatter is ignored. Available data are:<table><tbody><tr>  <td><code>this.percentage</code></td>  <td>Stacked series and pies only. The point's percentage of the total.</td></tr><tr>  <td><code>this.point</code></td>  <td>The point object. The point name, if defined, is available through <code>this.point.name</code>.</td></tr><tr>  <td><code>this.series</code>:</td>  <td>The series object. The series name is available through <code>this.series.name</code>.</td></tr><tr>  <td><code>this.total</code></td>  <td>Stacked series only. The total value at this point's x value.</td></tr><tr>  <td><code>this.x</code>:</td>  <td>The x value.</td></tr><tr>  <td><code>this.y</code>:</td>  <td>The y value.</td></tr></tbody></table>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// For points with an extent, like columns, whether to align the data label inside the box or to the actual value point. Defaults to <code>false</code> in most cases, <code>true</code> in stacked columns.
		/// </summary>
		public bool? Inside { get; set; }
		private bool? Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle data labels that flow outside the plot area. The default is <code>justify</code>, which aligns them inside the plot area. For columns and bars, this means it will be moved inside the bar. To display data labels outside the plot area, set <code>crop</code> to <code>false</code> and <code>overflow</code> to <code>"none"</code>.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// When either the <code>borderWidth</code> or the <code>backgroundColor</code> is set, thisis the padding within the box.
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text rotation in degrees. Note that due to a more complex structure, backgrounds and borders will be lost on a rotated data label.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow of the box. Works best with <code>borderWidth</code> or <code>backgroundColor</code>. Since 2.3 the shadow can be an object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>, <code>opacity</code> and <code>width</code>.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharp break.
		/// </summary>
		public bool? SoftConnector { get; set; }
		private bool? SoftConnector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the label.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of a data label. Can be one of <code>top</code>, <code>middle</code> or <code>bottom</code>. The default value depends on the data, for instance in a column chart, the label is above positive values and below negative values.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the point. 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the point. 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Z index of the data labels. The default Z index puts it above the series. Use a Z index of 2 to display it behind the series.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}