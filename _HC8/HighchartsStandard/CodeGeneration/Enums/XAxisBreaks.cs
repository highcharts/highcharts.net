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
	public partial class XAxisBreaks  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XAxisBreaks()
		{
			BreakSize = BreakSize_DefaultValue = 0;
			From = From_DefaultValue = null;
			Repeat = Repeat_DefaultValue = 0;
			To = To_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// A number indicating how much space should be left between the startand the end of the break. The break size is given in axis units,so for instance on a `datetime` axis, a break size of 3600000 wouldindicate the equivalent of an hour.
		/// </summary>
		public double? BreakSize { get; set; }
		private double? BreakSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point where the break starts.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines an interval after which the break appears again. By defaultthe breaks do not repeat.
		/// </summary>
		public double? Repeat { get; set; }
		private double? Repeat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point where the break ends.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (BreakSize != BreakSize_DefaultValue) h.Add("breakSize",BreakSize);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Repeat != Repeat_DefaultValue) h.Add("repeat",Repeat);
			if (To != To_DefaultValue) h.Add("to",To);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}