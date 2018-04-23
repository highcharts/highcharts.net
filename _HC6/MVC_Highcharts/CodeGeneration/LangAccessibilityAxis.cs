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
	public partial class LangAccessibilityAxis  : BaseObject
	{
		public LangAccessibilityAxis()
		{
			XAxisDescriptionPlural = XAxisDescriptionPlural_DefaultValue = "The chart has {numAxes} X axes displaying {#each(names, -1), }and {names[-1]}";
			XAxisDescriptionSingular = XAxisDescriptionSingular_DefaultValue = "The chart has 1 X axis displaying {names[0]}.";
			YAxisDescriptionPlural = YAxisDescriptionPlural_DefaultValue = "The chart has {numAxes} Y axes displaying {#each(names, -1), }and {names[-1]}";
			YAxisDescriptionSingular = YAxisDescriptionSingular_DefaultValue = "The chart has 1 Y axis displaying {names[0]}.";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string XAxisDescriptionPlural { get; set; }
		private string XAxisDescriptionPlural_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string XAxisDescriptionSingular { get; set; }
		private string XAxisDescriptionSingular_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxisDescriptionPlural { get; set; }
		private string YAxisDescriptionPlural_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string YAxisDescriptionSingular { get; set; }
		private string YAxisDescriptionSingular_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (XAxisDescriptionPlural != XAxisDescriptionPlural_DefaultValue) h.Add("xAxisDescriptionPlural",XAxisDescriptionPlural);
			if (XAxisDescriptionSingular != XAxisDescriptionSingular_DefaultValue) h.Add("xAxisDescriptionSingular",XAxisDescriptionSingular);
			if (YAxisDescriptionPlural != YAxisDescriptionPlural_DefaultValue) h.Add("yAxisDescriptionPlural",YAxisDescriptionPlural);
			if (YAxisDescriptionSingular != YAxisDescriptionSingular_DefaultValue) h.Add("yAxisDescriptionSingular",YAxisDescriptionSingular);
			

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