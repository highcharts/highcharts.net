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
		public ExportingButtonsContextButton()
		{
			_titleKey = _titleKey_DefaultValue = "";
			ClassName = ClassName_DefaultValue = "highcharts-contextbutton";
			Enabled = Enabled_DefaultValue = true;
			MenuClassName = MenuClassName_DefaultValue = "highcharts-contextmenu";
			MenuItems = MenuItems_DefaultValue = new List<MenuItem>();
			Onclick = Onclick_DefaultValue = "";
			Symbol = Symbol_DefaultValue = "menu";
			SymbolFill = SymbolFill_DefaultValue = "#666666";
			SymbolStroke = SymbolStroke_DefaultValue = "#666666";
			SymbolStrokeWidth = SymbolStrokeWidth_DefaultValue = 3;
			Text = Text_DefaultValue = "null";
			Theme = Theme_DefaultValue = new ExportingButtonsContextButtonTheme();
			TitleKey = TitleKey_DefaultValue = "contextButtonTitle";
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// This option is deprecated, use[titleKey](#exporting.buttons.contextButton.titleKey) instead.
		/// </summary>
		public string _titleKey { get; set; }
		private string _titleKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// The class name of the context button.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The class name of the menu appearing from the button.
		/// </summary>
		public string MenuClassName { get; set; }
		private string MenuClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options for the menuitems. The config options are defined in the`menuItemDefinitions` option.By default, there is the "View in full screen" and "Print" menuitems, plus one menu item for each of the available export types.
		/// </summary>
		public List<MenuItem> MenuItems { get; set; }
		private List<MenuItem> MenuItems_DefaultValue { get; set; }
		 

		/// <summary>
		/// A click handler callback to use on the button directly instead ofthe popup menu.
		/// </summary>
		public string Onclick { get; set; }
		private string Onclick_DefaultValue { get; set; }
		 

		/// <summary>
		/// The symbol for the button. Points to a definition function inthe `Highcharts.Renderer.symbols` collection. The default`exportIcon` function is part of the exporting module. Possiblevalues are "circle", "square", "diamond", "triangle","triangle-down", "menu", "menuball" or custom shape.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// See [navigation.buttonOptions.symbolFill](#navigation.buttonOptions.symbolFill).
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
		/// A text string to add to the individual button.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the button theme. The object acceptsSVG properties like `stroke-width`, `stroke` and `fill`.Tri-state button styles are supported by the `states.hover` and`states.select` objects.
		/// </summary>
		public ExportingButtonsContextButtonTheme Theme { get; set; }
		private ExportingButtonsContextButtonTheme Theme_DefaultValue { get; set; }
		 

		/// <summary>
		/// The key to a [lang](#lang) option setting that is used for thebutton's title tooltip. When the key is `contextButtonTitle`, itrefers to [lang.contextButtonTitle](#lang.contextButtonTitle)that defaults to "Chart context menu".
		/// </summary>
		public string TitleKey { get; set; }
		private string TitleKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal position of the button relative to the `align`option.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its`verticalAlign`.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (_titleKey != _titleKey_DefaultValue) h.Add("_titleKey",_titleKey);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (MenuClassName != MenuClassName_DefaultValue) h.Add("menuClassName",MenuClassName);
			if (MenuItems != MenuItems_DefaultValue) h.Add("menuItems", HashifyList(MenuItems));
			if (Onclick != Onclick_DefaultValue) { h.Add("onclick",Onclick); Highcharts.AddFunction("e83a3383-069f-4c69-aa85-30c0bd560bb8.onclick", Onclick); }  
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolFill != SymbolFill_DefaultValue) h.Add("symbolFill",SymbolFill);
			if (SymbolStroke != SymbolStroke_DefaultValue) h.Add("symbolStroke",SymbolStroke);
			if (SymbolStrokeWidth != SymbolStrokeWidth_DefaultValue) h.Add("symbolStrokeWidth",SymbolStrokeWidth);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Theme.IsDirty()) h.Add("theme",Theme.ToHashtable());
			if (TitleKey != TitleKey_DefaultValue) h.Add("titleKey",TitleKey);
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