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
	public partial class PlotOptionsPsarParams  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPsarParams()
		{
		}	
		

		/// <summary>
		/// Number of maximum decimals that are used in PSAR calculations.
		/// </summary>
		public double? Decimals { get; set; }
		 

		/// <summary>
		/// Acceleration factor increases by increment each timethe extreme point makes a new high.
		/// </summary>
		public double? Increment { get; set; }
		 

		/// <summary>
		/// Index from which PSAR is starting calculation
		/// </summary>
		public double? Index { get; set; }
		 

		/// <summary>
		/// The initial value for acceleration factor.Acceleration factor is starting with this valueand increases by specified increment each timethe extreme point makes a new high.AF can reach a maximum of maxAccelerationFactor,no matter how long the uptrend extends.
		/// </summary>
		public double? InitialAccelerationFactor { get; set; }
		 

		/// <summary>
		/// The Maximum value for acceleration factor.AF can reach a maximum of maxAccelerationFactor,no matter how long the uptrend extends.
		/// </summary>
		public double? MaxAccelerationFactor { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Decimals != null) h.Add("decimals",Decimals);
			if (Increment != null) h.Add("increment",Increment);
			if (Index != null) h.Add("index",Index);
			if (InitialAccelerationFactor != null) h.Add("initialAccelerationFactor",InitialAccelerationFactor);
			if (MaxAccelerationFactor != null) h.Add("maxAccelerationFactor",MaxAccelerationFactor);
			if (Period != null) h.Add("period",Period);
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