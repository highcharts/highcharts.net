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
			Decimals = Decimals_DefaultValue = 4;
			Increment = Increment_DefaultValue = null;
			Index = Index_DefaultValue = 2;
			InitialAccelerationFactor = InitialAccelerationFactor_DefaultValue = null;
			MaxAccelerationFactor = MaxAccelerationFactor_DefaultValue = null;
			Period = Period_DefaultValue = "undefined";
			
		}	
		

		/// <summary>
		/// Number of maximum decimals that are used in PSAR calculations.
		/// </summary>
		public double? Decimals { get; set; }
		private double? Decimals_DefaultValue { get; set; }
		 

		/// <summary>
		/// Acceleration factor increases by increment each timethe extreme point makes a new high.
		/// </summary>
		public double? Increment { get; set; }
		private double? Increment_DefaultValue { get; set; }
		 

		/// <summary>
		/// Index from which PSAR is starting calculation
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// The initial value for acceleration factor.Acceleration factor is starting with this valueand increases by specified increment each timethe extreme point makes a new high.AF can reach a maximum of maxAccelerationFactor,no matter how long the uptrend extends.
		/// </summary>
		public double? InitialAccelerationFactor { get; set; }
		private double? InitialAccelerationFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Maximum value for acceleration factor.AF can reach a maximum of maxAccelerationFactor,no matter how long the uptrend extends.
		/// </summary>
		public double? MaxAccelerationFactor { get; set; }
		private double? MaxAccelerationFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Period { get; set; }
		private string Period_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Decimals != Decimals_DefaultValue) h.Add("decimals",Decimals);
			if (Increment != Increment_DefaultValue) h.Add("increment",Increment);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (InitialAccelerationFactor != InitialAccelerationFactor_DefaultValue) h.Add("initialAccelerationFactor",InitialAccelerationFactor);
			if (MaxAccelerationFactor != MaxAccelerationFactor_DefaultValue) h.Add("maxAccelerationFactor",MaxAccelerationFactor);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}