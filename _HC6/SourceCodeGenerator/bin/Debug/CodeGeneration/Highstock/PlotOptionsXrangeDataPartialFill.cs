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
	public partial class PlotOptionsXrangeDataPartialFill  : BaseObject
	{
		public PlotOptionsXrangeDataPartialFill()
		{
			Amount = Amount_DefaultValue = null;
			Fill = Fill_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The amount of the X-range point to be filled. Values can be 0-1 and are converted to percentages in the default data label formatter.
		/// </summary>
		public double? Amount { get; set; }
		private double? Amount_DefaultValue { get; set; }
		 

		/// <summary>
		/// The fill color to be used for partial fills. Defaults to a darker shadeof the point color.
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Amount != Amount_DefaultValue) h.Add("amount",Amount);
			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			

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