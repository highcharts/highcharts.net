using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class MapNavigationButtonsZoomOut  : BaseObject
	{
		public MapNavigationButtonsZoomOut()
		{
			Align = Align_DefaultValue = MapNavigationButtonsZoomOutAlign.Left;
			AlignTo = AlignTo_DefaultValue = MapNavigationButtonsZoomOutAlignTo.PlotBox;
			Height = Height_DefaultValue = 18;
			Onclick = Onclick_DefaultValue = "";
			Style = Style_DefaultValue = new NameValueCollection();
			Text = Text_DefaultValue = "-";
			Theme = Theme_DefaultValue = null;
			VerticalAlign = VerticalAlign_DefaultValue = MapNavigationButtonsZoomOutVerticalAlign.Bottom;
			Width = Width_DefaultValue = 18;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 28;
			
		}	
		

		/// <summary>
		/// The alignment of the navigation buttons.
		/// </summary>
		public MapNavigationButtonsZoomOutAlign Align { get; set; }
		private MapNavigationButtonsZoomOutAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// What box to align the buttons to. Possible values are <code>plotBox</code> and <code>spacingBox</code>.
		/// </summary>
		public MapNavigationButtonsZoomOutAlignTo AlignTo { get; set; }
		private MapNavigationButtonsZoomOutAlignTo AlignTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel height of the map navigation buttons.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// Click handler for the button. Defaults to:<pre>function () {   this.mapZoom(2);}</pre>
		/// </summary>
		public string Onclick { get; set; }
		private string Onclick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text styles for the map navigation buttons. Defaults to<pre>{   fontSize: '15px',   fontWeight: 'bold',   textAlign: 'center'}</pre>
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text for the button. The tooltip (title) is a language option given by <a href="#lang.zoomIn">lang.zoomOut</a>.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// A configuration object for the button theme. The object accepts SVG properties like <code>stroke-width</code>, <code>stroke</code> and <code>fill</code>. Tri-state button styles are supported by the <code>states.hover</code> and <code>states.select</code> objects.
		/// </summary>
		public Object Theme { get; set; }
		private Object Theme_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the buttons. Individual alignment can be adjusted by each button's <code>y</code> offset.
		/// </summary>
		public MapNavigationButtonsZoomOutVerticalAlign VerticalAlign { get; set; }
		private MapNavigationButtonsZoomOutVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the map navigation buttons.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X offset of the buttons relative to its <code>align</code> setting. 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The position of the zoomOut button relative to the vertical alignment. 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highmaps.FirstCharacterToLower(Align.ToString()));
			if (AlignTo != AlignTo_DefaultValue) h.Add("alignTo", Highmaps.FirstCharacterToLower(AlignTo.ToString()));
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Onclick != Onclick_DefaultValue) { h.Add("onclick",Onclick); Highmaps.AddFunction("MapNavigationButtonsZoomOutOnclick.onclick", Onclick); }  
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Theme != Theme_DefaultValue) h.Add("theme",Theme);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highmaps.FirstCharacterToLower(VerticalAlign.ToString()));
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