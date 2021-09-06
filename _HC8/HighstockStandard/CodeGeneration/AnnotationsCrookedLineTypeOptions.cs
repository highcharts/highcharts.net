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
	public partial class AnnotationsCrookedLineTypeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsCrookedLineTypeOptions()
		{
			Line = Line_DefaultValue = new AnnotationsCrookedLineTypeOptionsLine();
			Points = Points_DefaultValue = new List<AnnotationsCrookedLineTypeOptionsPoints>();
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsCrookedLineTypeOptionsLine Line { get; set; }
		private AnnotationsCrookedLineTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsCrookedLineTypeOptionsPoints> Points { get; set; }
		private List<AnnotationsCrookedLineTypeOptionsPoints> Points_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Line.IsDirty(ref highstock)) h.Add("line",Line.ToHashtable(ref highstock));
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(ref highstock,Points));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}