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
	public partial class NavigationButtonOptions  : BaseObject
	{
		public NavigationButtonOptions()
		{
			SymbolSize = SymbolSize_DefaultValue = 14;
			Enabled = Enabled_DefaultValue = true;
			SymbolX = SymbolX_DefaultValue = null;
			SymbolY = SymbolY_DefaultValue = null;
			Align = Align_DefaultValue = NavigationButtonOptionsAlign.Right;
			ButtonSpacing = ButtonSpacing_DefaultValue = 3;
			Height = Height_DefaultValue = 22;
			VerticalAlign = VerticalAlign_DefaultValue = NavigationButtonOptionsVerticalAlign.Top;
			Text = Text_DefaultValue = "null";
			Width = Width_DefaultValue = 24;
			Y = Y_DefaultValue = 0;
			SymbolFill = SymbolFill_DefaultValue = "#666666";
			SymbolStroke = SymbolStroke_DefaultValue = "#666666";
			SymbolStrokeWidth = SymbolStrokeWidth_DefaultValue = 1;
			Theme = Theme_DefaultValue = new NavigationButtonOptionsTheme();
			
		}	
		

		/// <summary>
		/// The pixel size of the symbol on the button.
		/// </summary>
		public double? SymbolSize { get; set; }
		private double? SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the center of the symbol inside the button.
		/// </summary>
		public double? SymbolX { get; set; }
		private double? SymbolX_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the center of the symbol inside the button.
		/// </summary>
		public double? SymbolY { get; set; }
		private double? SymbolY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Alignment for the buttons.
		/// </summary>
		public NavigationButtonOptionsAlign Align { get; set; }
		private NavigationButtonOptionsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel spacing between buttons.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel height of the buttons.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the buttons. Can be one of "top", "middle"or "bottom".
		/// </summary>
		public NavigationButtonOptionsVerticalAlign VerticalAlign { get; set; }
		private NavigationButtonOptionsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// A text string to add to the individual button.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the button.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its`verticalAlign`.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fill color for the symbol within the button.
		/// </summary>
		public string SymbolFill { get; set; }
		private string SymbolFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the symbol's stroke or line.
		/// </summary>
		public string SymbolStroke { get; set; }
		private string SymbolStroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel stroke width of the symbol on the button.
		/// </summary>
		public double? SymbolStrokeWidth { get; set; }
		private double? SymbolStrokeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the button theme. The object acceptsSVG properties like `stroke-width`, `stroke` and `fill`. Tri-statebutton styles are supported by the `states.hover` and `states.select`objects.
		/// </summary>
		public NavigationButtonOptionsTheme Theme { get; set; }
		private NavigationButtonOptionsTheme Theme_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (SymbolX != SymbolX_DefaultValue) h.Add("symbolX",SymbolX);
			if (SymbolY != SymbolY_DefaultValue) h.Add("symbolY",SymbolY);
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (ButtonSpacing != ButtonSpacing_DefaultValue) h.Add("buttonSpacing",ButtonSpacing);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (SymbolFill != SymbolFill_DefaultValue) h.Add("symbolFill",SymbolFill);
			if (SymbolStroke != SymbolStroke_DefaultValue) h.Add("symbolStroke",SymbolStroke);
			if (SymbolStrokeWidth != SymbolStrokeWidth_DefaultValue) h.Add("symbolStrokeWidth",SymbolStrokeWidth);
			if (Theme.IsDirty()) h.Add("theme",Theme.ToHashtable());
			

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