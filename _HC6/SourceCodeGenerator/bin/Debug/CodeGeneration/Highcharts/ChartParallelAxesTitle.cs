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
	public partial class ChartParallelAxesTitle  : BaseObject
	{
		public ChartParallelAxesTitle()
		{
			Text = Text_DefaultValue = Chart title;
			ReserveSpace = ReserveSpace_DefaultValue = False;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesTitleText Text { get; set; }
		private ChartParallelAxesTitleText Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesTitleReserveSpace ReserveSpace { get; set; }
		private ChartParallelAxesTitleReserveSpace ReserveSpace_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Text != Text_DefaultValue) h.Add("text",Text);
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