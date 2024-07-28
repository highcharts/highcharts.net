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
	public partial class SunburstSeriesLevels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SunburstSeriesLevels()
		{
		}	
		

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// Can set a `borderDashStyle` on all points which lies on the samelevel.
		/// </summary>
		public Hashtable BorderDashStyle { get; set; }
		 

		/// <summary>
		/// Can set a `borderWidth` on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// Can set a `color` on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Determines whether the chart should receive one color per point basedon this level.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		 

		/// <summary>
		/// Can set a `colorVariation` on all points which lies on the samelevel.
		/// </summary>
		public SunburstSeriesLevelsColorVariation ColorVariation { get; set; }
		 

		/// <summary>
		/// Can set `dataLabels` on all points which lies on the same level.
		/// </summary>
		public SunburstSeriesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		 

		/// <summary>
		/// Can set a `levelSize` on all points which lies on the same level.
		/// </summary>
		public SunburstSeriesLevelsLevelSize LevelSize { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != null) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Color != null) h.Add("color",Color);
			if (ColorByPoint != null) h.Add("colorByPoint",ColorByPoint);
			if (ColorVariation != null) h.Add("colorVariation",ColorVariation.ToHashtable(highcharts));
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Level != null) h.Add("level",Level);
			if (LevelSize != null) h.Add("levelSize",LevelSize.ToHashtable(highcharts));
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}