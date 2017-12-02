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
	public partial class BubbleSeriesStatesHoverHalo  : BaseObject
	{
		public BubbleSeriesStatesHoverHalo()
		{
			Size = Size_DefaultValue = 5;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public BubbleSeriesStatesHoverHaloSize Size { get; set; }
		private BubbleSeriesStatesHoverHaloSize Size_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Size != Size_DefaultValue) h.Add("size",Size);
			

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