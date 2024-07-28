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
	public partial class TimelineSeriesOnPointPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TimelineSeriesOnPointPosition()
		{
		}	
		

		/// <summary>
		/// Series center offset from the original x position. If defined, the connectorline is drawn connecting original position with new position.
		/// </summary>
		public double? OffsetX { get; set; }
		 

		/// <summary>
		/// Series center offset from the original y position. If defined, the connectorline is drawn from original position to a new position.
		/// </summary>
		public double? OffsetY { get; set; }
		 

		/// <summary>
		/// X position of the series center. By default, the series is displayed on thepoint that it is connected to.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Y position of the series center. By default, the series is displayed on thepoint that it is connected to.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (OffsetX != null) h.Add("offsetX",OffsetX);
			if (OffsetY != null) h.Add("offsetY",OffsetY);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
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