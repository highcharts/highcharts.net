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
	public partial class StreamgraphSeriesStatesHoverAnimation  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StreamgraphSeriesStatesHoverAnimation()
		{
			Duration = Duration_DefaultValue = 50;
			
		}	
		

		/// <summary>
		/// The duration of the hover animation in milliseconds. Bydefault the hover state animates quickly in, and slowlyback to normal.
		/// </summary>
		public double? Duration { get; set; }
		private double? Duration_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Duration != Duration_DefaultValue) h.Add("duration",Duration);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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