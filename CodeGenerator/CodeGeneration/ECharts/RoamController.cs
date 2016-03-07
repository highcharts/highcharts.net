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
	public partial class RoamController  : BaseObject
	{
		public RoamController()
		{
			Show = Show_DefaultValue = null;
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			X = X_DefaultValue = left;
			Y = Y_DefaultValue = top;
			Width = Width_DefaultValue = null;
			Height = Height_DefaultValue = null;
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderColor = BorderColor_DefaultValue = #ccc;
			BorderWidth = BorderWidth_DefaultValue = null;
			Padding = Padding_DefaultValue = null;
			FillerColor = FillerColor_DefaultValue = #fff;
			HandleColor = HandleColor_DefaultValue = #6495ed;
			Step = Step_DefaultValue = null;
			MapTypeControl = MapTypeControl_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show. Valid values are: true (show) | false (hide).
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
		/// horizontal position. Defaults to left. Valid values are: 'center' | 'left' | 'right' | {number}(x-coordinate, in px).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical position. Defaults to top. Valid values are: 'top' | 'bottom' | 'center' | {number}(y-coordinate, in px).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies width which also define the size of the roam disk, can be <b>{number}</b>(in px)
		/// </summary>
		public number Width { get; set; }
		private number Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies height of the whold controller boundary box, the zoom button would be placed at the bottom, can be <b>{number}</b>(in px)
		/// </summary>
		public number Height { get; set; }
		private number Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the background. Defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the border.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the border.
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner padding, in px, defaults to 5. Can be set as array - [top, right, bottom, left], same as css, see image below.
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color of the text in the controller.
		/// </summary>
		public color FillerColor { get; set; }
		private color FillerColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The main color of the control handle.
		/// </summary>
		public color HandleColor { get; set; }
		private color HandleColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// moving step of the 4 direction roam in px
		/// </summary>
		public number Step { get; set; }
		private number Step_DefaultValue { get; set; }
		 

		/// <summary>
		/// Required. Specifies the mapType which should be under control, as: { china: true }<br>You can specify every single mapType when multiple map in a chart at the same time, such as: { china: false, world: true}
		/// </summary>
		public Object MapTypeControl { get; set; }
		private Object MapTypeControl_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (FillerColor != FillerColor_DefaultValue) h.Add("fillerColor",FillerColor);
			if (HandleColor != HandleColor_DefaultValue) h.Add("handleColor",HandleColor);
			if (Step != Step_DefaultValue) h.Add("step",Step);
			if (MapTypeControl != MapTypeControl_DefaultValue) h.Add("mapTypeControl",MapTypeControl);
			

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