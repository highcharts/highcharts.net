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
	public partial class YAxisBreaks  : BaseObject
	{
		Hashtable h = new Hashtable();

		public YAxisBreaks()
		{
		}	
		

		/// <summary>
		/// A number indicating how much space should be left between the startand the end of the break. The break size is given in axis units,so for instance on a `datetime` axis, a break size of 3600000 wouldindicate the equivalent of an hour.
		/// </summary>
		public double? BreakSize { get; set; }
		 

		/// <summary>
		/// The point where the break starts.
		/// </summary>
		public double? From { get; set; }
		 

		/// <summary>
		/// Defines an interval after which the break appears again. By defaultthe breaks do not repeat.
		/// </summary>
		public double? Repeat { get; set; }
		 

		/// <summary>
		/// The point where the break ends.
		/// </summary>
		public double? To { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BreakSize != null) h.Add("breakSize",BreakSize);
			if (From != null) h.Add("from",From);
			if (Repeat != null) h.Add("repeat",Repeat);
			if (To != null) h.Add("to",To);
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