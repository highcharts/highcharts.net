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
	public partial class PlotOptionsArearangeDataLabels  : BaseObject
	{
		public PlotOptionsArearangeDataLabels()
		{
			Align = Align_DefaultValue = null;
			VerticalAlign = VerticalAlign_DefaultValue = null;
			XLow = XLow_DefaultValue = 0;
			XHigh = XHigh_DefaultValue = 0;
			YLow = YLow_DefaultValue = 16;
			YHigh = YHigh_DefaultValue = -6;
			Align = Align_DefaultValue = "";
			VerticalAlign = VerticalAlign_DefaultValue = "";
			XLow = XLow_DefaultValue = 0;
			XHigh = XHigh_DefaultValue = 0;
			YLow = YLow_DefaultValue = 16;
			YHigh = YHigh_DefaultValue = -6;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeDataLabelsAlign Align { get; set; }
		private PlotOptionsArearangeDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsArearangeDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the lower data labels relative to the point value.
		/// </summary>
		public double? XLow { get; set; }
		private double? XLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the higher data labels relative to the point value.
		/// </summary>
		public double? XHigh { get; set; }
		private double? XHigh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the lower data labels relative to the point value.
		/// </summary>
		public double? YLow { get; set; }
		private double? YLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the higher data labels relative to the point value.
		/// </summary>
		public double? YHigh { get; set; }
		private double? YHigh_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeDataLabelsAlign Align { get; set; }
		private PlotOptionsArearangeDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsArearangeDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsArearangeDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the lower data labels relative to the point value.
		/// </summary>
		public double? XLow { get; set; }
		private double? XLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the higher data labels relative to the point value.
		/// </summary>
		public double? XHigh { get; set; }
		private double? XHigh_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the lower data labels relative to the point value.
		/// </summary>
		public double? YLow { get; set; }
		private double? YLow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the higher data labels relative to the point value.
		/// </summary>
		public double? YHigh { get; set; }
		private double? YHigh_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (XLow != XLow_DefaultValue) h.Add("xLow",XLow);
			if (XHigh != XHigh_DefaultValue) h.Add("xHigh",XHigh);
			if (YLow != YLow_DefaultValue) h.Add("yLow",YLow);
			if (YHigh != YHigh_DefaultValue) h.Add("yHigh",YHigh);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (XLow != XLow_DefaultValue) h.Add("xLow",XLow);
			if (XHigh != XHigh_DefaultValue) h.Add("xHigh",XHigh);
			if (YLow != YLow_DefaultValue) h.Add("yLow",YLow);
			if (YHigh != YHigh_DefaultValue) h.Add("yHigh",YHigh);
			

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