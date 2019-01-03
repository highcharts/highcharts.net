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
	public partial class PaneBackgroundBackgroundColor  : BaseObject
	{
		public PaneBackgroundBackgroundColor()
		{
			LinearGradient = LinearGradient_DefaultValue = new PaneBackgroundBackgroundColorLinearGradient();
			Stops = Stops_DefaultValue = new List<Stop>();
			
		}	
		

		/// <summary>
		/// Definition of the gradient, similar to SVG: object literal holdsstart position (x1, y1) and the end position (x2, y2) relativeto the shape, where 0 means top/left and 1 is bottom/right.All positions are floats between 0 and 1.
		/// </summary>
		public PaneBackgroundBackgroundColorLinearGradient LinearGradient { get; set; }
		private PaneBackgroundBackgroundColorLinearGradient LinearGradient_DefaultValue { get; set; }
		 

		/// <summary>
		/// The stops is an array of tuples, where the first item is a floatbetween 0 and 1 assigning the relative position in the gradient,and the second item is the color.
		/// </summary>
		public List<Stop> Stops { get; set; }
		private List<Stop> Stops_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LinearGradient.IsDirty()) h.Add("linearGradient",LinearGradient.ToHashtable());
			if (Stops.Any()) h.Add("stops", GetLists(Stops));
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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