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
	public partial class Toolbox  : BaseObject
	{
		public Toolbox()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			Orient = Orient_DefaultValue = horizontal;
			X = X_DefaultValue = right;
			Y = Y_DefaultValue = top;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderColor = BorderColor_DefaultValue = #ccc;
			BorderWidth = BorderWidth_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			ItemGap = ItemGap_DefaultValue = null;
			ItemSize = ItemSize_DefaultValue = null;
			Color = Color_DefaultValue = null;
			DisableColor = DisableColor_DefaultValue = #ddd;
			EffectiveColor = EffectiveColor_DefaultValue = red;
			ShowTitle = ShowTitle_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = null;
			Feature = Feature_DefaultValue = new ToolboxFeature();
			
		}	
		

		/// <summary>
		/// Specifies whether to show toolbox. Valid values are: true (show) | false (hide).
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// The first grade cascading control. Every zlevel will be allocated to a independent canvas, charts and components with the same zlevel will be rendered in the same canvas. The higher zlevel the closer to the top. More canvas dom will need more memory and performance, so never set too many zlevel. Most of the time, the second grade cascading control 'z' is recommended.
		/// </summary>
		public number Zlevel { get; set; }
		private number Zlevel_DefaultValue { get; set; }
		 

		/// <summary>
		/// The second grade cascading control, In the same canvas (zlevel), the higher z the closer to the top.
		/// </summary>
		public number Z { get; set; }
		private number Z_DefaultValue { get; set; }
		 

		/// <summary>
		/// layout manner. Defaults to horizontal. Valid values are: 'horizontal' | 'vertical'.
		/// </summary>
		public string Orient { get; set; }
		private string Orient_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal position. Defaults to center. Valid values are: 'center' | 'left' | 'right' | <b>{number}</b>(x-coordinate, in px).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical position. Defaults to top. Valid values are: 'top' | 'bottom' | 'center' | <b>{number}</b>(y-coordinate, in px).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the toolbox's background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the drawn border around the toolbox.
		/// </summary>
		public color BorderColor { get; set; }
		private color BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the drawn border around the toolbox, in px, defaults to 0 (no border).
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding of the toolbox, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css, see image below.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel gap between each item. Defaults to 10. It is horizontal in a toolbox with horizontal layout, and vertical in a toolbox with vertical layout. See image below.
		/// </summary>
		public number ItemGap { get; set; }
		private number ItemGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// the size of toolbox icon, in px.
		/// </summary>
		public number ItemSize { get; set; }
		private number ItemSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array containing the default colors for the toolbox's icons. When all colors are used, new colors are pulled from the start again. Default colors can also be set on specific features.
		/// </summary>
		public Array Color { get; set; }
		private Array Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies the disable color.
		/// </summary>
		public color DisableColor { get; set; }
		private color DisableColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies the effective color.
		/// </summary>
		public color EffectiveColor { get; set; }
		private color EffectiveColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the toolbox text will be showed. Defaults to true.
		/// </summary>
		public boolean ShowTitle { get; set; }
		private boolean ShowTitle_DefaultValue { get; set; }
		 

		/// <summary>
		/// the style of toolbox text, (See textStyle).
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Currently toolbox supports all the features listed below. For custom features, <a href="/doc/example/toolbox.html" target="_blank">try this �</a> <br> <img src="/doc/asset/img/doc/toolbox.png" title="" alt="???">
		/// </summary>
		public ToolboxFeature Feature { get; set; }
		private ToolboxFeature Feature_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (Orient != Orient_DefaultValue) h.Add("orient",Orient);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (ItemGap != ItemGap_DefaultValue) h.Add("itemGap",ItemGap);
			if (ItemSize != ItemSize_DefaultValue) h.Add("itemSize",ItemSize);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DisableColor != DisableColor_DefaultValue) h.Add("disableColor",DisableColor);
			if (EffectiveColor != EffectiveColor_DefaultValue) h.Add("effectiveColor",EffectiveColor);
			if (ShowTitle != ShowTitle_DefaultValue) h.Add("showTitle",ShowTitle);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			if (Feature.IsDirty()) h.Add("feature",Feature.ToHashtable());
			

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