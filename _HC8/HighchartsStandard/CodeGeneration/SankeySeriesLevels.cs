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
	public partial class SankeySeriesLevels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SankeySeriesLevels()
		{
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = null;
			Color = Color_DefaultValue = "";
			ColorByPoint = ColorByPoint_DefaultValue = true;
			DataLabels = DataLabels_DefaultValue = new SankeySeriesDataLabels();
			Level = Level_DefaultValue = null;
			LinkOpacity = LinkOpacity_DefaultValue = null;
			States = States_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Can set `borderColor` on all nodes which lay on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `borderWidth` on all nodes which lay on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `color` on all nodes which lay on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `colorByPoint` on all nodes which lay on the same level.
		/// </summary>
		public bool? ColorByPoint { get; set; }
		private bool? ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `dataLabels` on all points which lay on the same level.
		/// </summary>
		public SankeySeriesDataLabels DataLabels { get; set; }
		private SankeySeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levelsobject.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `linkOpacity` on all points which lay on the same level.
		/// </summary>
		public double? LinkOpacity { get; set; }
		private double? LinkOpacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set `states` on all nodes and points which lay on the same level.
		/// </summary>
		public Hashtable States { get; set; }
		private Hashtable States_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Level != Level_DefaultValue) h.Add("level",Level);
			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			if (States != States_DefaultValue) h.Add("states",States);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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