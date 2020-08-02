using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class AnnotationsLabelsPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsLabelsPoint()
		{
			X = X_DefaultValue = null;
			XAxis = XAxis_DefaultValue = "";
			XAxisNumber = XAxisNumber_DefaultValue = null;
			Y = Y_DefaultValue = null;
			YAxis = YAxis_DefaultValue = "";
			YAxisNumber = YAxisNumber_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The x position of the point. Units can be either in axisor chart pixel coordinates.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to.It refers to either the axis id or the index of the axis inthe xAxis array. If the option is not configured or the axisis not found the point's x coordinate refers to the chartpixels.
		/// </summary>
		public string XAxis { get; set; }
		private string XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which xAxis the point is connected to.It refers to either the axis id or the index of the axis inthe xAxis array. If the option is not configured or the axisis not found the point's x coordinate refers to the chartpixels.
		/// </summary>
		public double? XAxisNumber { get; set; }
		private double? XAxisNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the point. Units can be either in axisor chart pixel coordinates.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to.It refers to either the axis id or the index of the axis inthe yAxis array. If the option is not configured or the axisis not found the point's y coordinate refers to the chartpixels.
		/// </summary>
		public string YAxis { get; set; }
		private string YAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// This number defines which yAxis the point is connected to.It refers to either the axis id or the index of the axis inthe yAxis array. If the option is not configured or the axisis not found the point's y coordinate refers to the chartpixels.
		/// </summary>
		public double? YAxisNumber { get; set; }
		private double? YAxisNumber_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (X != X_DefaultValue) h.Add("x",X);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (XAxisNumber != XAxisNumber_DefaultValue) h.Add("xAxis",XAxisNumber);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			if (YAxisNumber != YAxisNumber_DefaultValue) h.Add("yAxis",YAxisNumber);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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