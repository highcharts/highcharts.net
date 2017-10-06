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
			SymbolX = SymbolX_DefaultValue = 12.5;
			SymbolY = SymbolY_DefaultValue = 10.5;
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
		public NavigationButtonOptionsAlign Align { get; set; }
		private NavigationButtonOptionsAlign Align_DefaultValue { get; set; }
		 

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
		public NavigationButtonOptionsVerticalAlign VerticalAlign { get; set; }
		private NavigationButtonOptionsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

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
		/// <p>Fill color for the symbol within the button.</p>
		/// </summary>
		public string SymbolFill { get; set; }
		private string SymbolFill_DefaultValue { get; set; }
		 

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