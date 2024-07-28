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
	public partial class ArcdiagramSeriesLevels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ArcdiagramSeriesLevels()
		{
		}	
		

		/// <summary>
		/// Can set `borderColor` on all nodes which lay on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// Can set `borderWidth` on all nodes which lay on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		 

		/// <summary>
		/// Can set `color` on all nodes which lay on the same level.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// Can set `colorByPoint` on all nodes which lay on the same level.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		 

		/// <summary>
		/// Can set `dataLabels` on all points which lay on the same level.
		/// </summary>
		public ArcdiagramSeriesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		 

		/// <summary>
		/// Can set `linkOpacity` on all points which lay on the same level.
		/// </summary>
		public double? LinkOpacity { get; set; }
		 

		/// <summary>
		/// Can set `states` on all nodes and points which lay on the same level.
		/// </summary>
		public ArcdiagramSeriesLevelsStates States { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderWidth != null) h.Add("borderWidth",BorderWidth);
			if (Color != null) h.Add("color",Color);
			if (ColorByPoint != null) h.Add("colorByPoint",ColorByPoint);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Level != null) h.Add("level",Level);
			if (LinkOpacity != null) h.Add("linkOpacity",LinkOpacity);
			if (States != null) h.Add("states",States.ToHashtable(highcharts));
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