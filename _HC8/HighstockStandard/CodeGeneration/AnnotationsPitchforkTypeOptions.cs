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
	public partial class AnnotationsPitchforkTypeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsPitchforkTypeOptions()
		{
			InnerBackground = InnerBackground_DefaultValue = new AnnotationsPitchforkTypeOptionsInnerBackground();
			Line = Line_DefaultValue = new AnnotationsPitchforkTypeOptionsLine();
			OuterBackground = OuterBackground_DefaultValue = new AnnotationsPitchforkTypeOptionsOuterBackground();
			Points = Points_DefaultValue = new List<AnnotationsPitchforkTypeOptionsPoints>();
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
			CustomFields = new Hashtable();
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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (InnerBackground.IsDirty(highstock)) h.Add("innerBackground",InnerBackground.ToHashtable(highstock));
			if (Line.IsDirty(highstock)) h.Add("line",Line.ToHashtable(highstock));
			if (OuterBackground.IsDirty(highstock)) h.Add("outerBackground",OuterBackground.ToHashtable(highstock));
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(highstock,Points));
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