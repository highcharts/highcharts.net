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
	public partial class Legend  : BaseObject
	{
		public Legend()
		{
			KeyboardNavigation = KeyboardNavigation_DefaultValue = new LegendKeyboardNavigation();
			Enabled = Enabled_DefaultValue = null;
			Align = Align_DefaultValue = LegendAlign.Center;
			Layout = Layout_DefaultValue = LegendLayout.Horizontal;
			LabelFormatter = LabelFormatter_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "#999999";
			BorderRadius = BorderRadius_DefaultValue = 0;
			Navigation = Navigation_DefaultValue = new LegendNavigation();
			ItemStyle = ItemStyle_DefaultValue = new LegendItemStyle();
			ItemHoverStyle = ItemHoverStyle_DefaultValue = new LegendItemHoverStyle();
			ItemHiddenStyle = ItemHiddenStyle_DefaultValue = new LegendItemHiddenStyle();
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			ItemCheckboxStyle = ItemCheckboxStyle_DefaultValue = new LegendItemCheckboxStyle();
			SquareSymbol = SquareSymbol_DefaultValue = true;
			SymbolPadding = SymbolPadding_DefaultValue = 5;
			VerticalAlign = VerticalAlign_DefaultValue = LegendVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			Title = Title_DefaultValue = new LegendTitle();
			BackgroundColor = BackgroundColor_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = 0;
			Floating = Floating_DefaultValue = false;
			ItemDistance = ItemDistance_DefaultValue = null;
			ItemMarginBottom = ItemMarginBottom_DefaultValue = 0;
			ItemMarginTop = ItemMarginTop_DefaultValue = 0;
			ItemWidth = ItemWidth_DefaultValue = null;
			LabelFormat = LabelFormat_DefaultValue = "{name}";
			Margin = Margin_DefaultValue = null;
			MaxHeight = MaxHeight_DefaultValue = null;
			Padding = Padding_DefaultValue = 8;
			Reversed = Reversed_DefaultValue = false;
			SymbolHeight = SymbolHeight_DefaultValue = null;
			SymbolRadius = SymbolRadius_DefaultValue = null;
			SymbolWidth = SymbolWidth_DefaultValue = null;
			UseHTML = UseHTML_DefaultValue = false;
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Keyboard navigation for the legend. Requires the Accessibility module.</p>
		/// </summary>
		public LegendKeyboardNavigation KeyboardNavigation { get; set; }
		private LegendKeyboardNavigation KeyboardNavigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable or disable the legend.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The horizontal alignment of the legend box within the chart area.Valid values are <code>left</code>, <code>center</code> and <code>right</code>.</p><p>In the case that the legend is aligned in a corner position, the<code>layout</code> option will determine whether to place it above/belowor on the side of the plot area.</p>
		/// </summary>
		public LegendAlign Align { get; set; }
		private LegendAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The layout of the legend items. Can be one of &quot;horizontal&quot; or &quot;vertical&quot;.</p>
		/// </summary>
		public LegendLayout Layout { get; set; }
		private LegendLayout Layout_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Callback function to format each of the series&#39; labels. The <code>this</code>keyword refers to the series object, or the point object in caseof pie charts. By default the series or point name is printed.</p>
		/// </summary>
		public string LabelFormatter { get; set; }
		private string LabelFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the drawn border around the legend.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border corner radius of the legend.</p>
		/// </summary>
		public double? BorderRadius { get; set; }
		private double? BorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the paging or navigation appearing when the legendis overflown. Navigation works well on screen, but not in staticexported images. One way of working around that is to <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/legend/navigation-enabled-false/">increasethe chart height in export</a>.</p>
		/// </summary>
		public LegendNavigation Navigation { get; set; }
		private LegendNavigation Navigation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for each legend item. Only a subset of CSS is supported,notably those options related to text. The default <code>textOverflow</code>property makes long texts truncate. Set it to <code>null</code> to wrap textinstead. A <code>width</code> property can be added to control the text width.</p>
		/// </summary>
		public LegendItemStyle ItemStyle { get; set; }
		private LegendItemStyle ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for each legend item in hover mode. Only a subset ofCSS is supported, notably those options related to text. Propertiesare inherited from <code>style</code> unless overridden here.</p>
		/// </summary>
		public LegendItemHoverStyle ItemHoverStyle { get; set; }
		private LegendItemHoverStyle ItemHoverStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for each legend item when the corresponding series orpoint is hidden. Only a subset of CSS is supported, notably thoseoptions related to text. Properties are inherited from <code>style</code>unless overridden here.</p>
		/// </summary>
		public LegendItemHiddenStyle ItemHiddenStyle { get; set; }
		private LegendItemHiddenStyle ItemHiddenStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to apply a drop shadow to the legend. A <code>backgroundColor</code>also needs to be applied for this to take effect. The shadow can bean object configuration containing <code>color</code>, <code>offsetX</code>, <code>offsetY</code>,<code>opacity</code> and <code>width</code>.</p>
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Default styling for the checkbox next to a legend item when<code>showCheckbox</code> is true.</p>
		/// </summary>
		public LegendItemCheckboxStyle ItemCheckboxStyle { get; set; }
		private LegendItemCheckboxStyle ItemCheckboxStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this is true, the legend symbol width will be the same asthe symbol height, which in turn defaults to the font size of thelegend items.</p>
		/// </summary>
		public bool? SquareSymbol { get; set; }
		private bool? SquareSymbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel padding between the legend item symbol and the legenditem text.</p>
		/// </summary>
		public double? SymbolPadding { get; set; }
		private double? SymbolPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical alignment of the legend box. Can be one of <code>top</code>,<code>middle</code> or <code>bottom</code>. Vertical position can be further determinedby the <code>y</code> option.</p><p>In the case that the legend is aligned in a corner position, the<code>layout</code> option will determine whether to place it above/belowor on the side of the plot area.</p>
		/// </summary>
		public LegendVerticalAlign VerticalAlign { get; set; }
		private LegendVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x offset of the legend relative to its horizontal alignment<code>align</code> within chart.spacingLeft and chart.spacingRight. Negativex moves it to the left, positive x moves it to the right.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The vertical offset of the legend relative to it&#39;s vertical alignment<code>verticalAlign</code> within chart.spacingTop and chart.spacingBottom. Negative y moves it up, positive y moves it down.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A title to be added on top of the legend.</p>
		/// </summary>
		public LegendTitle Title { get; set; }
		private LegendTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The background color of the legend.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the drawn border around the legend.</p>
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When the legend is floating, the plot area ignores it and is allowedto be placed below it.</p>
		/// </summary>
		public bool? Floating { get; set; }
		private bool? Floating_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>In a legend with horizontal layout, the itemDistance defines thepixel distance between each item.</p>
		/// </summary>
		public double? ItemDistance { get; set; }
		private double? ItemDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel bottom margin for each legend item.</p>
		/// </summary>
		public double? ItemMarginBottom { get; set; }
		private double? ItemMarginBottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel top margin for each legend item.</p>
		/// </summary>
		public double? ItemMarginTop { get; set; }
		private double? ItemMarginTop_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width for each legend item. This is useful in a horizontal layoutwith many items when you want the items to align vertically. .</p>
		/// </summary>
		public double? ItemWidth { get; set; }
		private double? ItemWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting">format string</a> for each legend label. Available variablesrelates to properties on the series, or the point in case of pies.</p>
		/// </summary>
		public string LabelFormat { get; set; }
		private string LabelFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If the plot area sized is calculated automatically and the legendis not floating, the legend margin is the space between the legendand the axis labels or plot area.</p>
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Maximum pixel height for the legend. When the maximum height is extended, navigation will show.</p>
		/// </summary>
		public double? MaxHeight { get; set; }
		private double? MaxHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The inner padding of the legend box.</p>
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to reverse the order of the legend items compared to theorder of the series or points as defined in the configuration object.</p>
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel height of the symbol for series types that use a rectanglein the legend. Defaults to the font size of legend items.</p>
		/// </summary>
		public double? SymbolHeight { get; set; }
		private double? SymbolHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The border radius of the symbol for series types that use a rectanglein the legend. Defaults to half the <code>symbolHeight</code>.</p>
		/// </summary>
		public double? SymbolRadius { get; set; }
		private double? SymbolRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of the legend item symbol. When the <code>squareSymbol</code>option is set, this defaults to the <code>symbolHeight</code>, otherwise 16.</p>
		/// </summary>
		public double? SymbolWidth { get; set; }
		private double? SymbolWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the legend item texts. Priorto 4.1.7, when using HTML, <a href="#legend.navigation">legend.navigation</a>was disabled.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the legend box.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (KeyboardNavigation.IsDirty()) h.Add("keyboardNavigation",KeyboardNavigation.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Layout != Layout_DefaultValue) h.Add("layout", Highstock.FirstCharacterToLower(Layout.ToString()));
			if (LabelFormatter != LabelFormatter_DefaultValue) { h.Add("labelFormatter",LabelFormatter); Highstock.AddFunction("LegendLabelFormatter.labelFormatter", LabelFormatter); }  
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderRadius != BorderRadius_DefaultValue) h.Add("borderRadius",BorderRadius);
			if (Navigation.IsDirty()) h.Add("navigation",Navigation.ToHashtable());
			if (ItemStyle.IsDirty()) h.Add("itemStyle",ItemStyle.ToHashtable());
			if (ItemHoverStyle.IsDirty()) h.Add("itemHoverStyle",ItemHoverStyle.ToHashtable());
			if (ItemHiddenStyle.IsDirty()) h.Add("itemHiddenStyle",ItemHiddenStyle.ToHashtable());
			if (Shadow.IsDirty()) h.Add("shadow",Shadow.ToHashtable());
			if (ItemCheckboxStyle.IsDirty()) h.Add("itemCheckboxStyle",ItemCheckboxStyle.ToHashtable());
			if (SquareSymbol != SquareSymbol_DefaultValue) h.Add("squareSymbol",SquareSymbol);
			if (SymbolPadding != SymbolPadding_DefaultValue) h.Add("symbolPadding",SymbolPadding);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Floating != Floating_DefaultValue) h.Add("floating",Floating);
			if (ItemDistance != ItemDistance_DefaultValue) h.Add("itemDistance",ItemDistance);
			if (ItemMarginBottom != ItemMarginBottom_DefaultValue) h.Add("itemMarginBottom",ItemMarginBottom);
			if (ItemMarginTop != ItemMarginTop_DefaultValue) h.Add("itemMarginTop",ItemMarginTop);
			if (ItemWidth != ItemWidth_DefaultValue) h.Add("itemWidth",ItemWidth);
			if (LabelFormat != LabelFormat_DefaultValue) h.Add("labelFormat",LabelFormat);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (MaxHeight != MaxHeight_DefaultValue) h.Add("maxHeight",MaxHeight);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (SymbolHeight != SymbolHeight_DefaultValue) h.Add("symbolHeight",SymbolHeight);
			if (SymbolRadius != SymbolRadius_DefaultValue) h.Add("symbolRadius",SymbolRadius);
			if (SymbolWidth != SymbolWidth_DefaultValue) h.Add("symbolWidth",SymbolWidth);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

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