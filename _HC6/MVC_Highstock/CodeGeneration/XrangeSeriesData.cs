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
	public partial class XrangeSeriesData  : BaseObject
	{
		public XrangeSeriesData()
		{
			X2 = X2_DefaultValue = null;
			PartialFill = PartialFill_DefaultValue = new XrangeSeriesDataPartialFill();
			
		}	
		

		/// <summary>
		/// The ending X value of the range point.
		/// </summary>
		public double? X2 { get; set; }
		private double? X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public XrangeSeriesDataPartialFill PartialFill { get; set; }
		private XrangeSeriesDataPartialFill PartialFill_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			if (PartialFill.IsDirty()) h.Add("partialFill",PartialFill.ToHashtable());
			

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