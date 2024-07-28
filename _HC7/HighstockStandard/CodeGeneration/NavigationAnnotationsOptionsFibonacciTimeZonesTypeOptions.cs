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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsControlPointOptions ControlPointOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NavigationAnnotationsOptionsFibonacciTimeZonesTypeOptionsLine Line { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Object Points { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to.It refers to either the axis id or the index of the axisin the xAxis array.
		/// </summary>
		public string XAxis { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to.It refers to either the axis id or the index of the axisin the xAxis array.
		/// </summary>
		public string YAxis { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ControlPointOptions != null) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(highstock));
			if (Line != null) h.Add("line",Line.ToHashtable(highstock));
			if (Points != null) h.Add("points",Points);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (YAxis != null) h.Add("yAxis",YAxis);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}