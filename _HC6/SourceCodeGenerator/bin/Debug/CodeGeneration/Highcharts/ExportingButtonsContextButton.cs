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
			ClassName = ClassName_DefaultValue = "highcharts-contextbutton";
			MenuClassName = MenuClassName_DefaultValue = "highcharts-contextmenu";
			Symbol = Symbol_DefaultValue = "menu";
			_titleKey = _titleKey_DefaultValue = "contextButtonTitle";
			MenuItems = MenuItems_DefaultValue = new List<MenuItem>();
			Onclick = Onclick_DefaultValue = "";
			SymbolFill = SymbolFill_DefaultValue = "#666666";
			X = X_DefaultValue = -10;
			
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
		/// The key to a [lang](#lang) option setting that is used for thebutton`s title tooltip. When the key is `contextButtonTitle`, itrefers to [lang.contextButtonTitle](#lang.contextButtonTitle)that defaults to "Chart context menu".
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
		/// The key to a [lang](#lang) option setting that is used for thebutton`s title tooltip. When the key is `contextButtonTitle`, itrefers to [lang.contextButtonTitle](#lang.contextButtonTitle)that defaults to "Chart context menu".
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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (MenuClassName != MenuClassName_DefaultValue) h.Add("menuClassName",MenuClassName);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (_titleKey != _titleKey_DefaultValue) h.Add("_titleKey",_titleKey);
			if (MenuItems != MenuItems_DefaultValue) h.Add("menuItems",MenuItems);
			if (Onclick != Onclick_DefaultValue) h.Add("onclick",Onclick);
			if (SymbolFill != SymbolFill_DefaultValue) h.Add("symbolFill",SymbolFill);
			if (X != X_DefaultValue) h.Add("x",X);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (MenuClassName != MenuClassName_DefaultValue) h.Add("menuClassName",MenuClassName);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (_titleKey != _titleKey_DefaultValue) h.Add("_titleKey",_titleKey);
			if (MenuItems != MenuItems_DefaultValue) h.Add("menuItems",MenuItems);
			if (Onclick != Onclick_DefaultValue) h.Add("onclick",Onclick);
			if (SymbolFill != SymbolFill_DefaultValue) h.Add("symbolFill",SymbolFill);
			if (X != X_DefaultValue) h.Add("x",X);
			

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