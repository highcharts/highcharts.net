using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsXrangeData  : BaseObject
	{
		public PlotOptionsXrangeData()
		{
			PartialFill = PartialFill_DefaultValue = new PlotOptionsXrangeDataPartialFill();
			X2 = X2_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// A partial fill for each point, typically used to visualize how much ofa task is performed. The partial fill object can be set either on seriesor point level.
		/// </summary>
		public PlotOptionsXrangeDataPartialFill PartialFill { get; set; }
		private PlotOptionsXrangeDataPartialFill PartialFill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending X value of the range point.
		/// </summary>
		public double? X2 { get; set; }
		private double? X2_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PartialFill.IsDirty()) h.Add("partialFill",PartialFill.ToHashtable());
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			

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