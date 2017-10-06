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
	public partial class PivotpointsSeriesParams  : BaseObject
	{
		public PivotpointsSeriesParams()
		{
			Period = Period_DefaultValue = null;
			Algorithm = Algorithm_DefaultValue = "standard";
			
		}	
		

		/// <summary>
		/// <p>The base period for indicator calculations.</p>
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Algorithm used to calculate ressistance and support lines based on pivot points.Implemented algorithms: <code>&#39;standard&#39;</code>, <code>&#39;fibonacci&#39;</code> and <code>&#39;camarilla&#39;</code></p>
		/// </summary>
		public string Algorithm { get; set; }
		private string Algorithm_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (Algorithm != Algorithm_DefaultValue) h.Add("algorithm",Algorithm);
			

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