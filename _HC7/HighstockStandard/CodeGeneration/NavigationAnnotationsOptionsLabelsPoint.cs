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
	public partial class NavigationAnnotationsOptionsLabelsPoint  : BaseObject
	{
		public NavigationAnnotationsOptionsLabelsPoint()
		{
			X = X_DefaultValue = null;
			XAxis = XAxis_DefaultValue = "";
			XAxisNumber = XAxisNumber_DefaultValue = null;
			Y = Y_DefaultValue = null;
			YAxis = YAxis_DefaultValue = "";
			YAxisNumber = YAxisNumber_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The x position of the point. Units can be either in axisor chart pixel coordinates.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to. It refersto either the axis id or the index of the axis in the xAxis array.If the option is not configured or the axis is not found the point'sx coordinate refers to the chart pixels.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to. It refersto either the axis id or the index of the axis in the xAxis array.If the option is not configured or the axis is not found the point'sx coordinate refers to the chart pixels.
		/// </summary>
		public double? XAxisNumber { get; set; }
		private double? XAxisNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the point. Units can be either in axisor chart pixel coordinates.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to. It refersto either the axis id or the index of the axis in the yAxis array.If the option is not configured or the axis is not found the point'sy coordinate refers to the chart pixels.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to. It refersto either the axis id or the index of the axis in the yAxis array.If the option is not configured or the axis is not found the point'sy coordinate refers to the chart pixels.
		/// </summary>
		public double? YAxisNumber { get; set; }
		private double? YAxisNumber_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X != X_DefaultValue) h.Add("x",X);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (XAxisNumber != XAxisNumber_DefaultValue) h.Add("xAxis",XAxisNumber);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (YAxisNumber != YAxisNumber_DefaultValue) h.Add("yAxis",YAxisNumber);
			

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