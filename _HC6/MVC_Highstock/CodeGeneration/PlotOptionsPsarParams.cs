using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsPsarParams  : BaseObject
	{
		public PlotOptionsPsarParams()
		{
			InitialAccelerationFactor = InitialAccelerationFactor_DefaultValue = null;
			MaxAccelerationFactor = MaxAccelerationFactor_DefaultValue = null;
			Increment = Increment_DefaultValue = null;
			Decimals = Decimals_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The initial value for acceleration factor.Acceleration factor is starting with this valueand increases by specified increment each timethe extreme point makes a new high.AF can reach a maximum of maxAccelerationFactor,no matter how long the uptrend extends.</p>
		/// </summary>
		public double? InitialAccelerationFactor { get; set; }
		private double? InitialAccelerationFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Maximum value for acceleration factor.AF can reach a maximum of maxAccelerationFactor,no matter how long the uptrend extends.</p>
		/// </summary>
		public double? MaxAccelerationFactor { get; set; }
		private double? MaxAccelerationFactor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Acceleration factor increases by increment each timethe extreme point makes a new high.</p>
		/// </summary>
		public double? Increment { get; set; }
		private double? Increment_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Number of maximum decimals that are used in PSAR calculations.</p>
		/// </summary>
		public double? Decimals { get; set; }
		private double? Decimals_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (InitialAccelerationFactor != InitialAccelerationFactor_DefaultValue) h.Add("initialAccelerationFactor",InitialAccelerationFactor);
			if (MaxAccelerationFactor != MaxAccelerationFactor_DefaultValue) h.Add("maxAccelerationFactor",MaxAccelerationFactor);
			if (Increment != Increment_DefaultValue) h.Add("increment",Increment);
			if (Decimals != Decimals_DefaultValue) h.Add("decimals",Decimals);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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