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
	public partial class PaneBackground  : BaseObject
	{
		public PaneBackground()
		{
			BackgroundColor = BackgroundColor_DefaultValue = new object();
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			BorderWidth = BorderWidth_DefaultValue = 1;
			ClassName = ClassName_DefaultValue = "";
			InnerRadius = InnerRadius_DefaultValue = "0";
			OuterRadius = OuterRadius_DefaultValue = "105%";
			Shape = Shape_DefaultValue = "circle";
			
		}	
		

		/// <summary>
		/// The background color or gradient for the pane.
		/// </summary>
		public Object BackgroundColor { get; set; }
		private Object BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pane background border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel border width of the pane background.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The class name for this background.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of the pane background. Can be either numeric(pixels) or a percentage string.
		/// </summary>
		public string InnerRadius { get; set; }
		private string InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of the circular pane background. Can be eithernumeric (pixels) or a percentage string.
		/// </summary>
		public string OuterRadius { get; set; }
		private string OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shape of the pane background. When `solid`, the backgroundis circular. When `arc`, the background extends only from the minto the max of the value axis.
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			

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