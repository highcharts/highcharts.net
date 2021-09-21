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
	public partial class PlotOptionsSunburstLevels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSunburstLevels()
		{
			BorderColor = BorderColor_DefaultValue = "";
			BorderDashStyle = BorderDashStyle_DefaultValue = new Hashtable();
			BorderWidth = BorderWidth_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = new PlotOptionsSunburstLevelsColorVariation();
			DataLabels = DataLabels_DefaultValue = new Hashtable();
			Level = Level_DefaultValue = null;
			LevelSize = LevelSize_DefaultValue = new PlotOptionsSunburstLevelsLevelSize();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderDashStyle` on all points which lies on the samelevel.
		/// </summary>
		public Hashtable BorderDashStyle { get; set; }
		private Hashtable BorderDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderWidth` on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `color` on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `colorVariation` on all points which lies on the samelevel.
		/// </summary>
		public PlotOptionsSunburstLevelsColorVariation ColorVariation { get; set; }
		private PlotOptionsSunburstLevelsColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `dataLabels` on all points which lies on the same level.
		/// </summary>
		public Hashtable DataLabels { get; set; }
		private Hashtable DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `levelSize` on all points which lies on the same level.
		/// </summary>
		public PlotOptionsSunburstLevelsLevelSize LevelSize { get; set; }
		private PlotOptionsSunburstLevelsLevelSize LevelSize_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty(ref highcharts)) h.Add("colorVariation",ColorVariation.ToHashtable(ref highcharts));
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Level != Level_DefaultValue) h.Add("level",Level);
			if (LevelSize.IsDirty(ref highcharts)) h.Add("levelSize",LevelSize.ToHashtable(ref highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}