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
	public partial class Grid  : BaseObject
	{
		public Grid()
		{
			Zlevel = Zlevel_DefaultValue = null;
			Z = Z_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			X2 = X2_DefaultValue = null;
			Y2 = Y2_DefaultValue = null;
			Width = Width_DefaultValue = "";
			Height = Height_DefaultValue = "";
			BackgroundColor = BackgroundColor_DefaultValue = rgba(0,0,0,0);
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderColor = BorderColor_DefaultValue = #ccc;
			
		}	
		

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
		/// Set abscissa on the upper left corner of the grid in px, or in percent (string) such as '50%' (horizontal center of the display area).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set ordinate on the upper left corner of the grid in px, or in percent (string). Defaults to null. The position varies with y2, such as '50%' (vertical center of the display area).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set abscissa on the lower right corner of the grid in px, or in percent (string) such as '50%' (horizontal center of the display area).
		/// </summary>
		public string X2 { get; set; }
		private string X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set ordinate on the lower right corner of the grid in px, or in percent (string) such as '50%' (vertical center of the display area).
		/// </summary>
		public string Y2 { get; set; }
		private string Y2_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the grid (without axes), defaults to the total width - x - x2, in px, ignore x2 after specifying width. See the image below.                                 <br>Can also be set in percent (string), such as '50%' (half the width of the display area).
		/// </summary>
		public number Width { get; set; }
		private number Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Height of the grid (without axes), defaults to the total height - y - y2, in px, ignore y2 after specifying height. See the image below.                                 <br>Can also be set in percent (string), such as '50%' (half the height of the display area).
		/// </summary>
		public number Height { get; set; }
		private number Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// Background color, defaults to transparent.
		/// </summary>
		public color BackgroundColor { get; set; }
		private color BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the border.
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the border.
		/// </summary>
		public color BorderColor { get; set; }
		private color BorderColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Zlevel != Zlevel_DefaultValue) h.Add("zlevel",Zlevel);
			if (Z != Z_DefaultValue) h.Add("z",Z);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			if (Y2 != Y2_DefaultValue) h.Add("y2",Y2);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			

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