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
	public partial class PlotOptionsGaugeDial  : BaseObject
	{
		public PlotOptionsGaugeDial()
		{
			BaseLength = BaseLength_DefaultValue = "70%";
			BaseWidth = BaseWidth_DefaultValue = 3;
			Radius = Radius_DefaultValue = "80%";
			RearLength = RearLength_DefaultValue = "10%";
			TopWidth = TopWidth_DefaultValue = 1;
			BackgroundColor = BackgroundColor_DefaultValue = "#000000";
			BorderColor = BorderColor_DefaultValue = "#cccccc";
			BorderWidth = BorderWidth_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// The length of the dial's base part, relative to the total radiusor length of the dial.
		/// </summary>
		public string BaseLength { get; set; }
		private string BaseLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of the base of the gauge dial. The base is the partclosest to the pivot, defined by baseLength.
		/// </summary>
		public double? BaseWidth { get; set; }
		private double? BaseWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The radius or length of the dial, in percentages relative to theradius of the gauge itself.
		/// </summary>
		public string Radius { get; set; }
		private string Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The length of the dial's rear end, the part that extends out on theother side of the pivot. Relative to the dial's length.
		/// </summary>
		public string RearLength { get; set; }
		private string RearLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the top of the dial, closest to the perimeter. The pivotnarrows in from the base to the top.
		/// </summary>
		public double? TopWidth { get; set; }
		private double? TopWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The background or fill color of the gauge's dial.
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color or stroke of the gauge's dial. By default, the borderWidthis 0, so this must be set in addition to a custom border color.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the gauge dial border in pixels.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BaseLength != BaseLength_DefaultValue) h.Add("baseLength",BaseLength);
			if (BaseWidth != BaseWidth_DefaultValue) h.Add("baseWidth",BaseWidth);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (RearLength != RearLength_DefaultValue) h.Add("rearLength",RearLength);
			if (TopWidth != TopWidth_DefaultValue) h.Add("topWidth",TopWidth);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			

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