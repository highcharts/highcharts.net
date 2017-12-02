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
	public partial class HistogramSeriesSunburstEvents  : BaseObject
	{
		public HistogramSeriesSunburstEvents()
		{
			CheckboxClick = CheckboxClick_DefaultValue = "";
			LegendItemClick = LegendItemClick_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Fires when the checkbox next to the point name in the legend is clicked.One parameter, event, is passed to the function. The state of thecheckbox is found by event.checked. The checked item is found byevent.item. Return false to prevent the default action which is totoggle the select state of the series.
		/// </summary>
		public string CheckboxClick { get; set; }
		private string CheckboxClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Not applicable to pies, as the legend item is per point. See point.events.
		/// </summary>
		public string LegendItemClick { get; set; }
		private string LegendItemClick_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (CheckboxClick != CheckboxClick_DefaultValue) h.Add("checkboxClick",CheckboxClick);
			if (LegendItemClick != LegendItemClick_DefaultValue) h.Add("legendItemClick",LegendItemClick);
			

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