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
	public partial class ExportingButtonsContextButton  : BaseObject
	{
		public ExportingButtonsContextButton()
		{
			ClassName = ClassName_DefaultValue = "highcharts-contextbutton";
			MenuClassName = MenuClassName_DefaultValue = "highcharts-contextmenu";
			Symbol = Symbol_DefaultValue = "menu";
			_titleKey = _titleKey_DefaultValue = "contextButtonTitle";
			MenuItems = MenuItems_DefaultValue = new List<MenuItem>();
			Onclick = Onclick_DefaultValue = "";
			SymbolFill = SymbolFill_DefaultValue = "#666666";
			X = X_DefaultValue = -10;
			Enabled = Enabled_DefaultValue = true;
			SymbolSize = SymbolSize_DefaultValue = 14;
			SymbolX = SymbolX_DefaultValue = null;
			SymbolY = SymbolY_DefaultValue = null;
			Align = Align_DefaultValue = ExportingButtonsContextButtonAlign.Right;
			ButtonSpacing = ButtonSpacing_DefaultValue = 3;
			Height = Height_DefaultValue = 22;
			Text = Text_DefaultValue = "null";
			Y = Y_DefaultValue = 0;
			VerticalAlign = VerticalAlign_DefaultValue = ExportingButtonsContextButtonVerticalAlign.Top;
			Width = Width_DefaultValue = 24;
			SymbolStroke = SymbolStroke_DefaultValue = "#666666";
			SymbolStrokeWidth = SymbolStrokeWidth_DefaultValue = 1;
			Theme = Theme_DefaultValue = new ExportingButtonsContextButtonTheme();
			
		}	
		

		/// <summary>
		/// The class name of the context button.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The class name of the menu appearing from the button.
		/// </summary>
		public string MenuClassName { get; set; }
		private string MenuClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The symbol for the button. Points to a definition function inthe `Highcharts.Renderer.symbols` collection. The default `exportIcon`function is part of the exporting module.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// The key to a [lang](#lang) option setting that is used for thebutton's title tooltip. When the key is `contextButtonTitle`, itrefers to [lang.contextButtonTitle](#lang.contextButtonTitle)that defaults to "Chart context menu".
		/// </summary>
		public string _titleKey { get; set; }
		private string _titleKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options for the menuitems. The config options are defined in the`menuItemDefinitions` option.By default, there is the "Print" menu item plus one menu itemfor each of the available export types. Defaults to <pre>['printChart','separator','downloadPNG','downloadJPEG','downloadPDF','downloadSVG']</pre>
		/// </summary>
		public List<MenuItem> MenuItems { get; set; }
		private List<MenuItem> MenuItems_DefaultValue { get; set; }
		 

		/// <summary>
		/// A click handler callback to use on the button directly instead ofthe popup menu.
		/// </summary>
		public string Onclick { get; set; }
		private string Onclick_DefaultValue { get; set; }
		 

		/// <summary>
		/// See [navigation.buttonOptions.symbolFill](#navigation.buttonOptions.symbolFill).
		/// </summary>
		public string SymbolFill { get; set; }
		private string SymbolFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal position of the button relative to the `align`option.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel size of the symbol on the button.
		/// </summary>
		public double? SymbolSize { get; set; }
		private double? SymbolSize_DefaultValue { get; set; }
		 

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
		public ExportingButtonsContextButtonAlign Align { get; set; }
		private ExportingButtonsContextButtonAlign Align_DefaultValue { get; set; }
		 

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
		/// A text string to add to the individual button.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its`verticalAlign`.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the buttons. Can be one of "top", "middle"or "bottom".
		/// </summary>
		public ExportingButtonsContextButtonVerticalAlign VerticalAlign { get; set; }
		private ExportingButtonsContextButtonVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the button.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

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
		public ExportingButtonsContextButtonTheme Theme { get; set; }
		private ExportingButtonsContextButtonTheme Theme_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (MenuClassName != MenuClassName_DefaultValue) h.Add("menuClassName",MenuClassName);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (_titleKey != _titleKey_DefaultValue) h.Add("_titleKey",_titleKey);
			if (MenuItems != MenuItems_DefaultValue) h.Add("menuItems",MenuItems);
			if (Onclick != Onclick_DefaultValue) { h.Add("onclick",Onclick); Highcharts.AddFunction("ExportingButtonsContextButtonOnclick.onclick", Onclick); }  
			if (SymbolFill != SymbolFill_DefaultValue) h.Add("symbolFill",SymbolFill);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (SymbolX != SymbolX_DefaultValue) h.Add("symbolX",SymbolX);
			if (SymbolY != SymbolY_DefaultValue) h.Add("symbolY",SymbolY);
			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (ButtonSpacing != ButtonSpacing_DefaultValue) h.Add("buttonSpacing",ButtonSpacing);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Width != Width_DefaultValue) h.Add("width",Width);
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