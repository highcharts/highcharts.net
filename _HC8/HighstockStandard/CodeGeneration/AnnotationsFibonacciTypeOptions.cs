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
			BackgroundColors = BackgroundColors_DefaultValue = new List<string>();
			Height = Height_DefaultValue = 2;
			Labels = Labels_DefaultValue = new AnnotationsFibonacciTypeOptionsLabels();
			Line = Line_DefaultValue = new AnnotationsFibonacciTypeOptionsLine();
			LineColor = LineColor_DefaultValue = "#999999";
			LineColors = LineColors_DefaultValue = new List<string>();
			Points = Points_DefaultValue = new List<AnnotationsFibonacciTypeOptionsPoints>();
			XAxis = XAxis_DefaultValue = "";
			YAxis = YAxis_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// An array of background colors:Default to:```['rgba(130, 170, 255, 0.4)','rgba(139, 191, 216, 0.4)','rgba(150, 216, 192, 0.4)','rgba(156, 229, 161, 0.4)','rgba(162, 241, 130, 0.4)','rgba(169, 255, 101, 0.4)']```
		/// </summary>
		public List<string> BackgroundColors { get; set; }
		private List<string> BackgroundColors_DefaultValue { get; set; }
		 

		/// <summary>
		/// The height of the fibonacci in terms of yAxis.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array with options for the labels.
		/// </summary>
		public AnnotationsFibonacciTypeOptionsLabels Labels { get; set; }
		private AnnotationsFibonacciTypeOptionsLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line options.
		/// </summary>
		public AnnotationsFibonacciTypeOptionsLine Line { get; set; }
		private AnnotationsFibonacciTypeOptionsLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of line.
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of colors for the lines.
		/// </summary>
		public List<string> LineColors { get; set; }
		private List<string> LineColors_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<AnnotationsFibonacciTypeOptionsPoints> Points { get; set; }
		private List<AnnotationsFibonacciTypeOptionsPoints> Points_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (BackgroundColors != BackgroundColors_DefaultValue) h.Add("backgroundColors",BackgroundColors);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Labels.IsDirty(ref highstock)) h.Add("labels",Labels.ToHashtable(ref highstock));
			if (Line.IsDirty(ref highstock)) h.Add("line",Line.ToHashtable(ref highstock));
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineColors != LineColors_DefaultValue) h.Add("lineColors",LineColors);
			if (Points != Points_DefaultValue) h.Add("points", HashifyList(ref highstock,Points));
			if (XAxis != XAxis_DefaultValue) h.Add("xAxis",XAxis);
			if (YAxis != YAxis_DefaultValue) h.Add("yAxis",YAxis);
			

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