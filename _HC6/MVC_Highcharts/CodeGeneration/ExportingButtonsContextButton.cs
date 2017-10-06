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
			SymbolSize = SymbolSize_DefaultValue = 14;
			Enabled = Enabled_DefaultValue = true;
			SymbolX = SymbolX_DefaultValue = 12.5;
			SymbolY = SymbolY_DefaultValue = 10.5;
			Align = Align_DefaultValue = ExportingButtonsContextButtonAlign.Right;
			ButtonSpacing = ButtonSpacing_DefaultValue = 3;
			Height = Height_DefaultValue = 22;
			VerticalAlign = VerticalAlign_DefaultValue = ExportingButtonsContextButtonVerticalAlign.Top;
			Text = Text_DefaultValue = "null";
			Width = Width_DefaultValue = 24;
			Y = Y_DefaultValue = 0;
			SymbolStroke = SymbolStroke_DefaultValue = "#666666";
			SymbolStrokeWidth = SymbolStrokeWidth_DefaultValue = 1;
			Theme = Theme_DefaultValue = new ExportingButtonsContextButtonTheme();
			
		}	
		

		/// <summary>
		/// <p>The class name of the context button.</p>
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The class name of the menu appearing from the button.</p>
		/// </summary>
		public string MenuClassName { get; set; }
		private string MenuClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The symbol for the button. Points to a definition function inthe <code>Highcharts.Renderer.symbols</code> collection. The default <code>exportIcon</code>function is part of the exporting module.</p>
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The key to a <a href="#lang">lang</a> option setting that is used for thebutton<code>s title tooltip. When the key is</code>contextButtonTitle`, itrefers to <a href="#lang.contextButtonTitle">lang.contextButtonTitle</a>that defaults to &quot;Chart context menu&quot;.</p>
		/// </summary>
		public string _titleKey { get; set; }
		private string _titleKey_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of strings pointing to config options for the menuitems. The config options are defined in the<code>menuItemDefinitions</code> option.</p><p>By default, there is the &quot;Print&quot; menu item plus one menu itemfor each of the available export types. </p><p>Defaults to </p><pre>[    'printChart',    'separator',    'downloadPNG',    'downloadJPEG',    'downloadPDF',    'downloadSVG']</pre>
		/// </summary>
		public List<MenuItem> MenuItems { get; set; }
		private List<MenuItem> MenuItems_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A click handler callback to use on the button directly instead ofthe popup menu.</p>
		/// </summary>
		public string Onclick { get; set; }
		private string Onclick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>See <a href="#navigation.buttonOptions.symbolFill">navigation.buttonOptions.symbolFill</a>.</p>
		/// </summary>
		public string SymbolFill { get; set; }
		private string SymbolFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The horizontal position of the button relative to the <code>align</code>option.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel size of the symbol on the button.</p>
		/// </summary>
		public double? SymbolSize { get; set; }
		private double? SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to enable buttons.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x position of the center of the symbol inside the button.</p>
		/// </summary>
		public double? SymbolX { get; set; }
		private double? SymbolX_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position of the center of the symbol inside the button.</p>
		/// </summary>
		public double? SymbolY { get; set; }
		private double? SymbolY_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Alignment for the buttons.</p>
		/// </summary>
		public ExportingButtonsContextButtonAlign Align { get; set; }
		private ExportingButtonsContextButtonAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel spacing between buttons.</p>
		/// </summary>
		public double? ButtonSpacing { get; set; }
		private double? ButtonSpacing_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pixel height of the buttons.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical alignment of the buttons. Can be one of &quot;top&quot;, &quot;middle&quot;or &quot;bottom&quot;.</p>
		/// </summary>
		public ExportingButtonsContextButtonVerticalAlign VerticalAlign { get; set; }
		private ExportingButtonsContextButtonVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A text string to add to the individual button.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the button.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical offset of the button&#39;s position relative to its<code>verticalAlign</code>.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the symbol&#39;s stroke or line.</p>
		/// </summary>
		public string SymbolStroke { get; set; }
		private string SymbolStroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel stroke width of the symbol on the button.</p>
		/// </summary>
		public double? SymbolStrokeWidth { get; set; }
		private double? SymbolStrokeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A configuration object for the button theme. The object acceptsSVG properties like <code>stroke-width</code>, <code>stroke</code> and <code>fill</code>. Tri-statebutton styles are supported by the <code>states.hover</code> and <code>states.select</code>objects.</p>
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