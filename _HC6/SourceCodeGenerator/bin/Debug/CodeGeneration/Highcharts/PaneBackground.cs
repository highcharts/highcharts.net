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
			Shape = Shape_DefaultValue = PaneBackgroundShape.Circle;
			BorderWidth = BorderWidth_DefaultValue = 1;
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			BackgroundColor = BackgroundColor_DefaultValue = "";
			InnerRadius = InnerRadius_DefaultValue = 0;
			OuterRadius = OuterRadius_DefaultValue = 105%;
			ClassName = ClassName_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Tha shape of the pane background. When `solid`, the backgroundis circular. When `arc`, the background extends only from the minto the max of the value axis.
		/// </summary>
		public PaneBackgroundShape Shape { get; set; }
		private PaneBackgroundShape Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel border width of the pane background.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pane background border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background color or gradient for the pane.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of the pane background. Can be either numeric(pixels) or a percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of the circular pane background. Can be eithernumeric (pixels) or a percentage string.
		/// </summary>
		public double? OuterRadius { get; set; }
		private double? OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The class name for this background.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Shape != Shape_DefaultValue) h.Add("shape", Highcharts.FirstCharacterToLower(Shape.ToString()));
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BackgroundColor.IsDirty()) h.Add("backgroundColor",BackgroundColor.ToHashtable());
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			

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