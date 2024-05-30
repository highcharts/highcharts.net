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
	public partial class PlotOptionsHistogramOnPointPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsHistogramOnPointPosition()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Series center offset from the original x position. If defined, the connectorline is drawn connecting original position with new position.
		/// </summary>
		public double? OffsetX { get; set; }
		private double? OffsetX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Series center offset from the original y position. If defined, the connectorline is drawn from original position to a new position.
		/// </summary>
		public double? OffsetY { get; set; }
		private double? OffsetY_DefaultValue { get; set; }
		 

		/// <summary>
		/// X position of the series center. By default, the series is displayed on thepoint that it is connected to.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y position of the series center. By default, the series is displayed on thepoint that it is connected to.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (OffsetX != null) h.Add("offsetX",OffsetX);
			if (OffsetY != null) h.Add("offsetY",OffsetY);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}