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
	public partial class AnnotationsShapesPoint  : BaseObject
	{
		public AnnotationsShapesPoint()
		{
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			XAxis = XAxis_DefaultValue = new List<XAxis>();
			YAxis = YAxis_DefaultValue = new List<YAxis>();
			
		}	
		

		/// <summary>
		/// <p>The x position of the point. Units can be either in axis or chart pixel coordinates.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y position of the point. Units can be either in axisor chart pixel coordinates.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>This number defines which xAxis the point is connected to. It refersto either the axis id or the index of the axis in the xAxis array.If the option is not configured or the axis is not found the point&#39;sx coordinate refers to the chart pixels.</p>
		/// </summary>
		public List<XAxis> XAxis { get; set; }
		private List<XAxis> XAxis_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>This number defines which yAxis the point is connected to. It refersto either the axis id or the index of the axis in the yAxis array.If the option is not configured or the axis is not found the point&#39;sy coordinate refers to the chart pixels.</p>
		/// </summary>
		public List<YAxis> YAxis { get; set; }
		private List<YAxis> YAxis_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

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