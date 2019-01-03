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
	public partial class PaneBackgroundBackgroundColorLinearGradient  : BaseObject
	{
		public PaneBackgroundBackgroundColorLinearGradient()
		{
			X1 = X1_DefaultValue = 0;
			X2 = X2_DefaultValue = 0;
			Y1 = Y1_DefaultValue = 0;
			Y2 = Y2_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? X1 { get; set; }
		private double? X1_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X2 { get; set; }
		private double? X2_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y1 { get; set; }
		private double? Y1_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y2 { get; set; }
		private double? Y2_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X1 != X1_DefaultValue) h.Add("x1",X1);
			if (X2 != X2_DefaultValue) h.Add("x2",X2);
			if (Y1 != Y1_DefaultValue) h.Add("y1",Y1);
			if (Y2 != Y2_DefaultValue) h.Add("y2",Y2);
			

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