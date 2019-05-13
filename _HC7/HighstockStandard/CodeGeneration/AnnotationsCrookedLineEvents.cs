using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class AnnotationsCrookedLineEvents  : BaseObject
	{
		public AnnotationsCrookedLineEvents()
		{
			Add = Add_DefaultValue = "";
			AfterUpdate = AfterUpdate_DefaultValue = "";
			Remove = Remove_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Event callback when annotation is added to the chart.
		/// </summary>
		public string Add { get; set; }
		private string Add_DefaultValue { get; set; }
		 

		/// <summary>
		/// Event callback when annotation is updated (e.g. drag anddroppped or resized by control points).
		/// </summary>
		public string AfterUpdate { get; set; }
        private string AfterUpdate_DefaultValue { get; set; }


        /// <summary>
        /// Event callback when annotation is removed from the chart.
        /// </summary>
        public string Remove { get; set; }
		private string Remove_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Add != Add_DefaultValue) { h.Add("add", Add); Highstock.AddFunction("NavigationAnnotationsOptionsEventsAdd.Add", Add); }
			if (AfterUpdate != AfterUpdate_DefaultValue) { h.Add("afterUpdate", AfterUpdate); Highstock.AddFunction("NavigationAnnotationsOptionsEventsAfterUpdate", AfterUpdate); }
			if (Remove != Remove_DefaultValue) { h.Add("remove", Remove); Highstock.AddFunction("NavigationAnnotationsOptionsEventsRemove.Remove", Remove); }
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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