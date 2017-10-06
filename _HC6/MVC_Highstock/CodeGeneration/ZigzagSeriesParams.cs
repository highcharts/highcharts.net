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
	public partial class ZigzagSeriesParams  : BaseObject
	{
		public ZigzagSeriesParams()
		{
			LowIndex = LowIndex_DefaultValue = null;
			HighIndex = HighIndex_DefaultValue = null;
			Deviation = Deviation_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The point index which indicator calculations will base - lowvalue.</p><p>For example using OHLC data, index=2 means the indicator will becalculated using Low values.</p>
		/// </summary>
		public double? LowIndex { get; set; }
		private double? LowIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The point index which indicator calculations will base - highvalue.</p><p>For example using OHLC data, index=1 means the indicator will becalculated using High values.</p>
		/// </summary>
		public double? HighIndex { get; set; }
		private double? HighIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The threshold for the value change.</p><p>For example deviation=1 means the indicator will ignore all pricemovements less than 1%.</p>
		/// </summary>
		public double? Deviation { get; set; }
		private double? Deviation_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LowIndex != LowIndex_DefaultValue) h.Add("lowIndex",LowIndex);
			if (HighIndex != HighIndex_DefaultValue) h.Add("highIndex",HighIndex);
			if (Deviation != Deviation_DefaultValue) h.Add("deviation",Deviation);
			

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