using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class AnnotationsFibonacciTypeOptionsPoints  : BaseObject
	{
		public AnnotationsFibonacciTypeOptionsPoints()
		{
			ControlPoint = ControlPoint_DefaultValue = null;
			Label = Label_DefaultValue = new AnnotationsFibonacciTypeOptionsPointsLabel();
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? ControlPoint { get; set; }
		private double? ControlPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsFibonacciTypeOptionsPointsLabel Label { get; set; }
		private AnnotationsFibonacciTypeOptionsPointsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position of the point.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position of the point.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ControlPoint != ControlPoint_DefaultValue) h.Add("controlPoint",ControlPoint);
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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