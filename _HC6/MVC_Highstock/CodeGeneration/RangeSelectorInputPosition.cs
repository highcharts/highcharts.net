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
	public partial class RangeSelectorInputPosition  : BaseObject
	{
		public RangeSelectorInputPosition()
		{
			Align = Align_DefaultValue = RangeSelectorInputPositionAlign.Right;
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The alignment of the input box. Allowed properties are <code>left</code>,<code>center</code>, <code>right</code>.</p>
		/// </summary>
		public RangeSelectorInputPositionAlign Align { get; set; }
		private RangeSelectorInputPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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