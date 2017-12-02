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
	public partial class BellcurveSeriesSunburstLevels  : BaseObject
	{
		public BellcurveSeriesSunburstLevels()
		{
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderDashStyle = BorderDashStyle_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = "";
			DataLabels = DataLabels_DefaultValue = "";
			Rotation = Rotation_DefaultValue = null;
			RotationMode = RotationMode_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderWidth` on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderDashStyle` on all points which lies on the same level.
		/// </summary>
		public string BorderDashStyle { get; set; }
		private string BorderDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `color` on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `colorVariation` on all points which lies on the same level.
		/// </summary>
		public BellcurveSeriesSunburstLevelsColorVariation ColorVariation { get; set; }
		private BellcurveSeriesSunburstLevelsColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `dataLabels` on all points which lies on the same level.
		/// </summary>
		public BellcurveSeriesSunburstDataLabels DataLabels { get; set; }
		private BellcurveSeriesSunburstDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `rotation` on all points which lies on the same level.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `rotationMode` on all points which lies on the same level.
		/// </summary>
		public string RotationMode { get; set; }
		private string RotationMode_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty()) h.Add("colorVariation",ColorVariation.ToHashtable());
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode",RotationMode);
			

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