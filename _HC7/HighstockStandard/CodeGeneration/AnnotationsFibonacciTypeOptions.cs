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
	public partial class AnnotationsFibonacciTypeOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsFibonacciTypeOptions()
		{
		}	
		

		/// <summary>
		/// An array of background colors:Default to:```['rgba(130, 170, 255, 0.4)','rgba(139, 191, 216, 0.4)','rgba(150, 216, 192, 0.4)','rgba(156, 229, 161, 0.4)','rgba(162, 241, 130, 0.4)','rgba(169, 255, 101, 0.4)']```
		/// </summary>
		public List<string> BackgroundColors { get; set; }
		 

		/// <summary>
		/// The height of the fibonacci in terms of yAxis.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// An array with options for the labels.
		/// </summary>
		public AnnotationsFibonacciTypeOptionsLabels Labels { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsFibonacciTypeOptionsLine Line { get; set; }
		 

		/// <summary>
		/// The color of line.
		/// </summary>
		public string LineColor { get; set; }
		 

		/// <summary>
		/// An array of colors for the lines.
		/// </summary>
		public List<string> LineColors { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsFibonacciTypeOptionsPoints> Points { get; set; }
		 

		/// <summary>
		/// Whether the annotation levels should be reversed. By default theystart from 0 and go to 1.
		/// </summary>
		public bool? Reversed { get; set; }
		 

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
			if (BackgroundColors != null) h.Add("backgroundColors",BackgroundColors);
			if (Height != null) h.Add("height",Height);
			if (Labels != null) h.Add("labels",Labels.ToHashtable(highstock));
			if (Line != null) h.Add("line",Line.ToHashtable(highstock));
			if (LineColor != null) h.Add("lineColor",LineColor);
			if (LineColors != null) h.Add("lineColors",LineColors);
			if (Points != null) h.Add("points", HashifyList(highstock,Points));
			if (Reversed != null) h.Add("reversed",Reversed);
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