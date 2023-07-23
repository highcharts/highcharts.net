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
	public partial class NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptions()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsControlPointOptions();
			Line = Line_DefaultValue = new NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsLine();
			Points = Points_DefaultValue = null;
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsControlPointOptions ControlPointOptions { get; set; }
		private NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsLine Line { get; set; }
		private NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Points { get; set; }
		private Object Points_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to.It refers to either the axis id or the index of the axisin the xAxis array.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to.It refers to either the axis id or the index of the axisin the xAxis array.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty(highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(highstock));
			if (Line.IsDirty(highstock)) h.Add("line",Line.ToHashtable(highstock));
			if (Points != Points_DefaultValue) h.Add("points",Points);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}