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
	public partial class PlotOptionsScatterSonificationDefaultInstrumentOptionsActiveWhen  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatterSonificationDefaultInstrumentOptionsActiveWhen()
		{
		}	
		

		/// <summary>
		/// Track is only active when `prop` was above, and is now at orbelow this value.If both `crossingUp` and `crossingDown` are defined, the trackis active if either condition is met.
		/// </summary>
		public double? CrossingDown { get; set; }
		 

		/// <summary>
		/// Track is only active when `prop` was below, and is now at orabove this value.If both `crossingUp` and `crossingDown` are defined, the trackis active if either condition is met.
		/// </summary>
		public double? CrossingUp { get; set; }
		 

		/// <summary>
		/// Track is only active when `prop` is below or at this value.
		/// </summary>
		public double? Max { get; set; }
		 

		/// <summary>
		/// Track is only active when `prop` is above or at this value.
		/// </summary>
		public double? Min { get; set; }
		 

		/// <summary>
		/// The point property to compare, for example `y` or `x`.
		/// </summary>
		public string Prop { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (CrossingDown != null) h.Add("crossingDown",CrossingDown);
			if (CrossingUp != null) h.Add("crossingUp",CrossingUp);
			if (Max != null) h.Add("max",Max);
			if (Min != null) h.Add("min",Min);
			if (Prop != null) h.Add("prop",Prop);
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