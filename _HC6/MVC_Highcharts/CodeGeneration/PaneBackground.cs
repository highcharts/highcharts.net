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
	public partial class PaneBackground  : BaseObject
	{
		public PaneBackground()
		{
			BackgroundColor = BackgroundColor_DefaultValue = new PaneBackgroundBackgroundColor();
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			BorderWidth = BorderWidth_DefaultValue = 1;
			ClassName = ClassName_DefaultValue = "";
			InnerRadius = InnerRadius_DefaultValue = "null";
			InnerRadiusNumber = InnerRadiusNumber_DefaultValue = null;
			OuterRadius = OuterRadius_DefaultValue = "null";
			OuterRadiusNumber = OuterRadiusNumber_DefaultValue = null;
			Shape = Shape_DefaultValue = PaneBackgroundShape.Solid;
			
		}	
		

		/// <summary>
		/// The background color or gradient for the pane.
		/// </summary>
		public PaneBackgroundBackgroundColor BackgroundColor { get; set; }
		private PaneBackgroundBackgroundColor BackgroundColor_DefaultValue { get; set; }
		 

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
		/// The inner radius of the pane background. Can be either numeric(pixels) or a percentage string.
		/// </summary>
		public double? InnerRadiusNumber { get; set; }
		private double? InnerRadiusNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of the circular pane background. Can be eithernumeric (pixels) or a percentage string.
		/// </summary>
		public string OuterRadius { get; set; }
		private string OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of the circular pane background. Can be eithernumeric (pixels) or a percentage string.
		/// </summary>
		public double? OuterRadiusNumber { get; set; }
		private double? OuterRadiusNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// Tha shape of the pane background. When `solid`, the backgroundis circular. When `arc`, the background extends only from the minto the max of the value axis.
		/// </summary>
		public PaneBackgroundShape Shape { get; set; }
		private PaneBackgroundShape Shape_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BackgroundColor.IsDirty()) h.Add("backgroundColor",BackgroundColor.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (InnerRadiusNumber != InnerRadiusNumber_DefaultValue) h.Add("innerRadius",InnerRadiusNumber);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (OuterRadiusNumber != OuterRadiusNumber_DefaultValue) h.Add("outerRadius",OuterRadiusNumber);
			if (Shape != Shape_DefaultValue) h.Add("shape", Highcharts.FirstCharacterToLower(Shape.ToString()));
			

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