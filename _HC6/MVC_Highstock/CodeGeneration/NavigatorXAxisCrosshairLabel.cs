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
	public partial class NavigatorXAxisCrosshairLabel  : BaseObject
	{
		public NavigatorXAxisCrosshairLabel()
		{
			Align = Align_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = null;
			BorderRadius = BorderRadius_DefaultValue = 3;
			BorderWidth = BorderWidth_DefaultValue = 0;
			Format = Format_DefaultValue = null;
			Formatter = Formatter_DefaultValue = null;
			Padding = Padding_DefaultValue = 8;
			Shape = Shape_DefaultValue = "callout";
			Style = Style_DefaultValue = new Hashtable{{ "color", "white"},{ "fontWeight", "normal"},{ "fontSize", "11px"},{ "textAlign", "center" }};
			
		}	
		

		/// <summary>
		/// <p>Alignment of the label compared to the axis. Defaults to <code>left</code> forright-side axes, <code>right</code> for left-side axes and <code>center</code> for horizontalaxes.</p>
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color for the label. Defaults to the related seriescolor, or <code>#666666</code> if that is not available.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border color for the crosshair label</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border corner radius of the crosshair label.</p>
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border width for the crosshair label.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A format string for the crosshair label. Defaults to <code>{value}</code> fornumeric axes and <code>{value:%b %d, %Y}</code> for datetime axes.</p>
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Formatter function for the label text.</p>
		/// </summary>
		public function Formatter { get; set; }
		private function Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Padding inside the crosshair label.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The shape to use for the label box.</p>
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Text styles for the crosshair label.</p>
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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