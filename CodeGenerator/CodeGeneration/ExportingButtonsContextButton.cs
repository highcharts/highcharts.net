using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class ExportingButtonsContextButton  : BaseObject
	{
		public ExportingButtonsContextButton()
		{
			Align = Align_DefaultValue = ExportingButtonsContextButtonAlign.Right;
			Enabled = Enabled_DefaultValue = true;
			Height = Height_DefaultValue = 20;
			MenuItems = MenuItems_DefaultValue = null;
			Onclick = Onclick_DefaultValue = "";
			Symbol = Symbol_DefaultValue = ExportingButtonsContextButtonSymbol.Menu;
			SymbolFill = SymbolFill_DefaultValue = "#A8BF77";
			SymbolSize = SymbolSize_DefaultValue = 14;
			SymbolStroke = SymbolStroke_DefaultValue = "#666";
			SymbolStrokeWidth = SymbolStrokeWidth_DefaultValue = 1;
			SymbolX = SymbolX_DefaultValue = 12.5;
			SymbolY = SymbolY_DefaultValue = 10.5;
			Text = Text_DefaultValue = "null";
			Theme = Theme_DefaultValue = "";
			VerticalAlign = VerticalAlign_DefaultValue = ExportingButtonsContextButtonVerticalAlign.Top;
			Width = Width_DefaultValue = 24;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Alignment for the buttons.
		/// </summary>
		public ExportingButtonsContextButtonAlign Align { get; set; }
		private ExportingButtonsContextButtonAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable buttons.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel height of the buttons.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of config options for the menu items. Each options object consists of a <code>text</code> option which is a string to show in the menu item, as well as an <code>onclick</code> parameter which is a callback function to run on click.</p> <p>By default, there is the "Print" menu item plus one menu item for each of the available export types. Menu items can be customized by defining a new array of items and assigning  <code>null</code> to unwanted positions (see override example below).</p>
		/// </summary>
		public List<MenuItem> MenuItems { get; set; }
		private List<MenuItem> MenuItems_DefaultValue { get; set; }
		 

		/// <summary>
		/// A click handler callback to use on the button directly instead of the popup menu.
		/// </summary>
		public string Onclick { get; set; }
		private string Onclick_DefaultValue { get; set; }
		 

		/// <summary>
		/// The symbol for the button. Points to a definition function in the  <code>Highcharts.Renderer.symbols</code> collection. The default <code>exportIcon</code> function is part of the exporting module.
		/// </summary>
		public ExportingButtonsContextButtonSymbol Symbol { get; set; }
		private ExportingButtonsContextButtonSymbol Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// See <a class="internal" href="#navigation.buttonOptions">navigation.buttonOptions</a> =&gt; symbolFill.
		/// </summary>
		public string SymbolFill { get; set; }
		private string SymbolFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel size of the symbol on the button.
		/// </summary>
		public double? SymbolSize { get; set; }
		private double? SymbolSize_DefaultValue { get; set; }
		 

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
		/// A text string to add to the individual button. 
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the button theme. The object accepts SVG properties like <code>stroke-width</code>, <code>stroke</code> and <code>fill</code>. Tri-state button styles are supported by the <code>states.hover</code> and <code>states.select</code> objects.
		/// </summary>
		public Object Theme { get; set; }
		private Object Theme_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the buttons. Can be one of "top", "middle" or "bottom".
		/// </summary>
		public ExportingButtonsContextButtonVerticalAlign VerticalAlign { get; set; }
		private ExportingButtonsContextButtonVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the button.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal position of the button relative to the <code>align</code> option.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button's position relative to its <code>verticalAlign</code>. .
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align.ToString().ToLower());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (MenuItems != MenuItems_DefaultValue) h.Add("menuItems",MenuItems);
			if (Onclick != Onclick_DefaultValue) { h.Add("onclick",Onclick); Highcharts.AddFunction("ExportingButtonsContextButtonOnclick.onclick", Onclick); }  
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol.ToString().ToLower());
			if (SymbolFill != SymbolFill_DefaultValue) h.Add("symbolFill",SymbolFill);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (SymbolStroke != SymbolStroke_DefaultValue) h.Add("symbolStroke",SymbolStroke);
			if (SymbolStrokeWidth != SymbolStrokeWidth_DefaultValue) h.Add("symbolStrokeWidth",SymbolStrokeWidth);
			if (SymbolX != SymbolX_DefaultValue) h.Add("symbolX",SymbolX);
			if (SymbolY != SymbolY_DefaultValue) h.Add("symbolY",SymbolY);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Theme != Theme_DefaultValue) h.Add("theme",Theme);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign.ToString().ToLower());
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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