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
		Hashtable h = new Hashtable();

		public AnnotationsVerticalLineTypeOptions()
		{
		}	
		

		/// <summary>
		/// Connector options.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsConnector Connector { get; set; }
		 

		/// <summary>
		/// Label options.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLabel Label { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsVerticalLineTypeOptionsLine Line { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsVerticalLineTypeOptionsPoints> Points { get; set; }
		 

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
			if (Connector != null) h.Add("connector",Connector.ToHashtable(highstock));
			if (Label != null) h.Add("label",Label.ToHashtable(highstock));
			if (Line != null) h.Add("line",Line.ToHashtable(highstock));
			if (Points != null) h.Add("points", HashifyList(highstock,Points));
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