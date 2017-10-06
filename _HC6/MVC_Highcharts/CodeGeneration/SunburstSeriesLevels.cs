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
	public partial class SunburstSeriesLevels  : BaseObject
	{
		public SunburstSeriesLevels()
		{
			BorderColor = BorderColor_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderDashStyle = BorderDashStyle_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorVariation = ColorVariation_DefaultValue = new SunburstSeriesLevelsColorVariation();
			DataLabels = DataLabels_DefaultValue = new SunburstSeriesDataLabels();
			Rotation = Rotation_DefaultValue = null;
			RotationMode = RotationMode_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Can set a <code>borderColor</code> on all points which lies on the same level.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>borderWidth</code> on all points which lies on the same level.</p>
		/// </summary>
		public string BorderWidth { get; set; }
		private string BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>borderDashStyle</code> on all points which lies on the same level.</p>
		/// </summary>
		public string BorderDashStyle { get; set; }
		private string BorderDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>color</code> on all points which lies on the same level.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>colorVariation</code> on all points which lies on the same level.</p>
		/// </summary>
		public SunburstSeriesLevelsColorVariation ColorVariation { get; set; }
		private SunburstSeriesLevelsColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>dataLabels</code> on all points which lies on the same level.</p>
		/// </summary>
		public SunburstSeriesDataLabels DataLabels { get; set; }
		private SunburstSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>rotation</code> on all points which lies on the same level.</p>
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Can set a <code>rotationMode</code> on all points which lies on the same level.</p>
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
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
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