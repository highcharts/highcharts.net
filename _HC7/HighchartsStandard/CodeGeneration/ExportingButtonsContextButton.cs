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
	public partial class ExportingButtonsContextButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingButtonsContextButton()
		{
		}	
		

		/// <summary>
		/// This option is deprecated, use[titleKey](#exporting.buttons.contextButton.titleKey) instead.
		/// </summary>
		public string _titleKey { get; set; }
		 

		/// <summary>
		/// Alignment for the buttons.
		/// </summary>
		public ExportingButtonsContextButtonAlign Align { get; set; }
		 

		/// <summary>
		/// The pixel spacing between buttons.
		/// </summary>
		public double? ButtonSpacing { get; set; }
		 

		/// <summary>
		/// The class name of the context button.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Pixel height of the buttons.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The class name of the menu appearing from the button.
		/// </summary>
		public string MenuClassName { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options for the menuitems. The config options are defined in the`menuItemDefinitions` option.By default, there is the "View in full screen" and "Print" menuitems, plus one menu item for each of the available export types.
		/// </summary>
		public List<MenuItem> MenuItems { get; set; }
		 

		/// <summary>
		/// A click handler callback to use on the button directly instead ofthe popup menu.
		/// </summary>
		public string Onclick { get; set; }
		 

		/// <summary>
		/// The symbol for the button. Points to a definition function inthe `Highcharts.Renderer.symbols` collection. The default`menu` function is part of the exporting module. Possiblevalues are "circle", "square", "diamond", "triangle","triangle-down", "menu", "menuball" or custom shape.
		/// </summary>
		public string Symbol { get; set; }
		 

		/// <summary>
		/// See [navigation.buttonOptions.symbolFill](#navigation.buttonOptions.symbolFill).
		/// </summary>
		public string SymbolFill { get; set; }
		 

		/// <summary>
		/// The pixel size of the symbol on the button.
		/// </summary>
		public double? SymbolSize { get; set; }
		 

		/// <summary>
		/// The color of the symbol's stroke or line.
		/// </summary>
		public string SymbolStroke { get; set; }
		 

		/// <summary>
		/// The pixel stroke width of the symbol on the button.
		/// </summary>
		public double? SymbolStrokeWidth { get; set; }
		 

		/// <summary>
		/// The x position of the center of the symbol inside the button.
		/// </summary>
		public double? SymbolX { get; set; }
		 

		/// <summary>
		/// The y position of the center of the symbol inside the button.
		/// </summary>
		public double? SymbolY { get; set; }
		 

		/// <summary>
		/// A text string to add to the individual button.
		/// </summary>
		public string Text { get; set; }
		 

		/// <summary>
		/// A configuration object for the button theme. The object acceptsSVG properties like `stroke-width`, `stroke` and `fill`.Tri-state button styles are supported by the `states.hover` and`states.select` objects.
		/// </summary>
		public ExportingButtonsContextButtonTheme Theme { get; set; }
		 

		/// <summary>
		/// The key to a [lang](#lang) option setting that is used for thebutton's title tooltip. When the key is `contextButtonTitle`, itrefers to [lang.contextButtonTitle](#lang.contextButtonTitle)that defaults to "Chart context menu".
		/// </summary>
		public string TitleKey { get; set; }
		 

		/// <summary>
		/// Whether to use HTML for rendering the button. HTML allows for thingslike inline CSS or image-based icons.
		/// </summary>
		public bool? UseHTML { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the buttons. Can be one of `"top"`,`"middle"` or `"bottom"`.
		/// </summary>
		public ExportingButtonsContextButtonVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// The pixel width of the button.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// The horizontal position of the button relative to the `align`option.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its`verticalAlign`.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (_titleKey != null) h.Add("_titleKey",_titleKey);
			if (Align != ExportingButtonsContextButtonAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (ButtonSpacing != null) h.Add("buttonSpacing",ButtonSpacing);
			if (ClassName != null) h.Add("className",ClassName);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Height != null) h.Add("height",Height);
			if (MenuClassName != null) h.Add("menuClassName",MenuClassName);
			if (MenuItems != null) h.Add("menuItems", HashifyList(highcharts,MenuItems));
			if (Onclick != null) { h.Add("onclick",Onclick); highcharts.AddFunction("onclick", Onclick); }  
			if (Symbol != null) h.Add("symbol",Symbol);
			if (SymbolFill != null) h.Add("symbolFill",SymbolFill);
			if (SymbolSize != null) h.Add("symbolSize",SymbolSize);
			if (SymbolStroke != null) h.Add("symbolStroke",SymbolStroke);
			if (SymbolStrokeWidth != null) h.Add("symbolStrokeWidth",SymbolStrokeWidth);
			if (SymbolX != null) h.Add("symbolX",SymbolX);
			if (SymbolY != null) h.Add("symbolY",SymbolY);
			if (Text != null) h.Add("text",Text);
			if (Theme != null) h.Add("theme",Theme.ToHashtable(highcharts));
			if (TitleKey != null) h.Add("titleKey",TitleKey);
			if (UseHTML != null) h.Add("useHTML",UseHTML);
			if (VerticalAlign != ExportingButtonsContextButtonVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (Width != null) h.Add("width",Width);
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