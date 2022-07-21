using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class CmfSeriesOnPointPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public CmfSeriesOnPointPosition()
		{
			OffsetX = OffsetX_DefaultValue = null;
			OffsetY = OffsetY_DefaultValue = null;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (OffsetX != OffsetX_DefaultValue) h.Add("offsetX",OffsetX);
			if (OffsetY != OffsetY_DefaultValue) h.Add("offsetY",OffsetY);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}