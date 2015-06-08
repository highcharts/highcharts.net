using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class XAxisBreaks  
	{
		public XAxisBreaks()
		{
			BreakSize = BreakSize_DefaultValue = 0;
			From = From_DefaultValue = null;
			Repeat = Repeat_DefaultValue = 0;
			To = To_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A number indicating how much space should be left between the start and the end of the break.
		/// </summary>
		public double? BreakSize { get; set; }
		private double? BreakSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point where the break starts.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines an interval after which the break appears again. By default the breaks do not repeat.
		/// </summary>
		public double? Repeat { get; set; }
		private double? Repeat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point where the break ends.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BreakSize != BreakSize_DefaultValue) h.Add("breakSize",BreakSize);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Repeat != Repeat_DefaultValue) h.Add("repeat",Repeat);
			if (To != To_DefaultValue) h.Add("to",To);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}