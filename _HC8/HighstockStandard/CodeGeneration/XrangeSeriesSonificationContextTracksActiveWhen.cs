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
	public partial class XrangeSeriesSonificationContextTracksActiveWhen  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XrangeSeriesSonificationContextTracksActiveWhen()
		{
			CrossingDown = CrossingDown_DefaultValue = null;
			CrossingUp = CrossingUp_DefaultValue = null;
			Max = Max_DefaultValue = null;
			Min = Min_DefaultValue = null;
			Prop = Prop_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Track is only active when `prop` was above, and is now at orbelow this value.If both `crossingUp` and `crossingDown` are defined, the trackis active if either condition is met.
		/// </summary>
		public double? CrossingDown { get; set; }
		private double? CrossingDown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Track is only active when `prop` was below, and is now at orabove this value.If both `crossingUp` and `crossingDown` are defined, the trackis active if either condition is met.
		/// </summary>
		public double? CrossingUp { get; set; }
		private double? CrossingUp_DefaultValue { get; set; }
		 

		/// <summary>
		/// Track is only active when `prop` is below or at this value.
		/// </summary>
		public double? Max { get; set; }
		private double? Max_DefaultValue { get; set; }
		 

		/// <summary>
		/// Track is only active when `prop` is above or at this value.
		/// </summary>
		public double? Min { get; set; }
		private double? Min_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point property to compare, for example `y` or `x`.
		/// </summary>
		public string Prop { get; set; }
		private string Prop_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (CrossingDown != CrossingDown_DefaultValue) h.Add("crossingDown",CrossingDown);
			if (CrossingUp != CrossingUp_DefaultValue) h.Add("crossingUp",CrossingUp);
			if (Max != Max_DefaultValue) h.Add("max",Max);
			if (Min != Min_DefaultValue) h.Add("min",Min);
			if (Prop != Prop_DefaultValue) h.Add("prop",Prop);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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