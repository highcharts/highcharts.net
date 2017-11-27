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
	public partial class SeriesWaterfallData  : BaseObject
	{
		public SeriesWaterfallData()
		{
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			IsIntermediateSum = IsIntermediateSum_DefaultValue = false;
			IsSum = IsSum_DefaultValue = false;
			
		}	
		

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the points acts as a summary column forthe values added or substracted since the last intermediate sum,or since the start of the series. The `y` value is ignored.
		/// </summary>
		public bool? IsIntermediateSum { get; set; }
		private bool? IsIntermediateSum_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this property is true, the point display the total sum acrossthe entire series. The `y` value is ignored.
		/// </summary>
		public bool? IsSum { get; set; }
		private bool? IsSum_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			if (IsIntermediateSum != IsIntermediateSum_DefaultValue) h.Add("isIntermediateSum",IsIntermediateSum);
			if (IsSum != IsSum_DefaultValue) h.Add("isSum",IsSum);
			

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