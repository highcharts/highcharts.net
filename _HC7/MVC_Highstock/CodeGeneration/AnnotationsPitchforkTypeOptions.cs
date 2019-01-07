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
	public partial class AnnotationsPitchforkTypeOptions  : BaseObject
	{
		public AnnotationsPitchforkTypeOptions()
		{
			InnerBackground = InnerBackground_DefaultValue = new AnnotationsPitchforkTypeOptionsInnerBackground();
			Line = Line_DefaultValue = new AnnotationsPitchforkTypeOptionsLine();
			OuterBackground = OuterBackground_DefaultValue = new AnnotationsPitchforkTypeOptionsOuterBackground();
			Points = Points_DefaultValue = new List<AnnotationsPitchforkTypeOptionsPoints>();
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Inner background options.
		/// </summary>
		public AnnotationsPitchforkTypeOptionsInnerBackground InnerBackground { get; set; }
		private AnnotationsPitchforkTypeOptionsInnerBackground InnerBackground_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsPitchforkTypeOptionsLine Line { get; set; }
		private AnnotationsPitchforkTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// Outer background options.
		/// </summary>
		public AnnotationsPitchforkTypeOptionsOuterBackground OuterBackground { get; set; }
		private AnnotationsPitchforkTypeOptionsOuterBackground OuterBackground_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsPitchforkTypeOptionsPoints> Points { get; set; }
		private List<AnnotationsPitchforkTypeOptionsPoints> Points_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (InnerBackground.IsDirty()) h.Add("innerBackground",InnerBackground.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (OuterBackground.IsDirty()) h.Add("outerBackground",OuterBackground.ToHashtable());
			if (Points != Points_DefaultValue) h.Add("points",HashifyList(Points));
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