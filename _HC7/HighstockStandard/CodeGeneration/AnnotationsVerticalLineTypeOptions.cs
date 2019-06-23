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
	public partial class AnnotationsVerticalLineTypeOptions  : BaseObject
	{
		public AnnotationsVerticalLineTypeOptions()
		{
			Connector = Connector_DefaultValue = new AnnotationsVerticalLineTypeOptionsConnector();
			Label = Label_DefaultValue = new AnnotationsVerticalLineTypeOptionsLabel();
			Line = Line_DefaultValue = new AnnotationsVerticalLineTypeOptionsLine();
			Points = Points_DefaultValue = new List<AnnotationsVerticalLineTypeOptionsPoints>();
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Connector options.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsConnector Connector { get; set; }
		private AnnotationsVerticalLineTypeOptionsConnector Connector_DefaultValue { get; set; }
		 

		/// <summary>
		/// Label options.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabel Label { get; set; }
		private AnnotationsVerticalLineTypeOptionsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLine Line { get; set; }
		private AnnotationsVerticalLineTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsVerticalLineTypeOptionsPoints> Points { get; set; }
		private List<AnnotationsVerticalLineTypeOptionsPoints> Points_DefaultValue { get; set; }
		 

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

			if (Connector.IsDirty()) h.Add("connector",Connector.ToHashtable());
			if (Label.IsDirty()) h.Add("label",Label.ToHashtable());
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(Points));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

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