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
	public partial class ChartParallelAxes  : BaseObject
	{
		public ChartParallelAxes()
		{
			LineWidth = LineWidth_DefaultValue = 1;
			Title = Title_DefaultValue = null;
			Labels = Labels_DefaultValue = null;
			Offset = Offset_DefaultValue = 0;
			LineWidth = LineWidth_DefaultValue = 1;
			Title = Title_DefaultValue = "";
			Text = Text_DefaultValue = "";
			ReserveSpace = ReserveSpace_DefaultValue = False;
			Labels = Labels_DefaultValue = "";
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 4;
			Align = Align_DefaultValue = center;
			ReserveSpace = ReserveSpace_DefaultValue = False;
			Offset = Offset_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLineWidth LineWidth { get; set; }
		private ChartParallelAxesLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Titles for yAxes are taken from [xAxis.categories](#xAxis.categories). All options for `xAxis.labels` applies to parallel coordinates titles.For example, to style categories, use [xAxis.labels.style](#xAxis.labels.style).
		/// </summary>
		public ChartParallelAxesTitle Title { get; set; }
		private ChartParallelAxesTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabels Labels { get; set; }
		private ChartParallelAxesLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesOffset Offset { get; set; }
		private ChartParallelAxesOffset Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLineWidth LineWidth { get; set; }
		private ChartParallelAxesLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Titles for yAxes are taken from [xAxis.categories](#xAxis.categories). All options for `xAxis.labels` applies to parallel coordinates titles.For example, to style categories, use [xAxis.labels.style](#xAxis.labels.style).
		/// </summary>
		public ChartParallelAxesTitle Title { get; set; }
		private ChartParallelAxesTitle Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesText Text { get; set; }
		private ChartParallelAxesText Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesReserveSpace ReserveSpace { get; set; }
		private ChartParallelAxesReserveSpace ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesLabels Labels { get; set; }
		private ChartParallelAxesLabels Labels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesX X { get; set; }
		private ChartParallelAxesX X_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesY Y { get; set; }
		private ChartParallelAxesY Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesAlign Align { get; set; }
		private ChartParallelAxesAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesReserveSpace ReserveSpace { get; set; }
		private ChartParallelAxesReserveSpace ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ChartParallelAxesOffset Offset { get; set; }
		private ChartParallelAxesOffset Offset_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (Title.IsDirty()) h.Add("title",Title.ToHashtable());
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Labels.IsDirty()) h.Add("labels",Labels.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			

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