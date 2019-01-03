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
	public partial class PlotOptionsSunburstLevelSize  : BaseObject
	{
		public PlotOptionsSunburstLevelSize()
		{
			Unit = Unit_DefaultValue = PlotOptionsSunburstLevelSizeUnit.Weight;
			Value = Value_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// How to interpret `levelSize.value`.`percentage` gives a width relative to result of outer radius minusinner radius.`pixels` gives the ring a fixed width in pixels.`weight` takes the remaining width after percentage and pixels, anddistributes it accross all "weighted" levels. The value relative tothe sum of all weights determines the width.
		/// </summary>
		public PlotOptionsSunburstLevelSizeUnit Unit { get; set; }
		private PlotOptionsSunburstLevelSizeUnit Unit_DefaultValue { get; set; }
		 

		/// <summary>
		/// The value used for calculating the width of the ring. Its' affect isdetermined by `levelSize.unit`.
		/// </summary>
		public double? Value { get; set; }
		private double? Value_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Unit != Unit_DefaultValue) h.Add("unit", Highcharts.FirstCharacterToLower(Unit.ToString()));
			if (Value != Value_DefaultValue) h.Add("value",Value);
			

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