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
	public partial class YAxisBreaks  : BaseObject
	{
		public YAxisBreaks()
		{
			BreakSize = BreakSize_DefaultValue = 0;
			From = From_DefaultValue = null;
			Repeat = Repeat_DefaultValue = 0;
			To = To_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>A number indicating how much space should be left between the startand the end of the break. The break size is given in axis units,so for instance on a <code>datetime</code> axis, a break size of 3600000 wouldindicate the equivalent of an hour.</p>
		/// </summary>
		public double? BreakSize { get; set; }
		private double? BreakSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The point where the break starts.</p>
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines an interval after which the break appears again. By defaultthe breaks do not repeat.</p>
		/// </summary>
		public double? Repeat { get; set; }
		private double? Repeat_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The point where the break ends.</p>
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BreakSize != BreakSize_DefaultValue) h.Add("breakSize",BreakSize);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Repeat != Repeat_DefaultValue) h.Add("repeat",Repeat);
			if (To != To_DefaultValue) h.Add("to",To);
			

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