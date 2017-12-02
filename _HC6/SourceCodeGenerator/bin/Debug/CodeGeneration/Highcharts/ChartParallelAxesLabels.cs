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
	public partial class ChartParallelAxesLabels  : BaseObject
	{
		public ChartParallelAxesLabels()
		{
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 4;
			Align = Align_DefaultValue = center;
			ReserveSpace = ReserveSpace_DefaultValue = False;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabelsX X { get; set; }
		private ChartParallelAxesLabelsX X_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabelsY Y { get; set; }
		private ChartParallelAxesLabelsY Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabelsAlign Align { get; set; }
		private ChartParallelAxesLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabelsReserveSpace ReserveSpace { get; set; }
		private ChartParallelAxesLabelsReserveSpace ReserveSpace_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			

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