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
	public partial class StockToolsGuiDefinitionsLines  : BaseObject
	{
		public StockToolsGuiDefinitionsLines()
		{
			ArrowLine = ArrowLine_DefaultValue = new StockToolsGuiDefinitionsLinesArrowLine();
			ArrowRay = ArrowRay_DefaultValue = new StockToolsGuiDefinitionsLinesArrowRay();
			ArrowSegment = ArrowSegment_DefaultValue = new StockToolsGuiDefinitionsLinesArrowSegment();
			HorizontalLine = HorizontalLine_DefaultValue = new StockToolsGuiDefinitionsLinesHorizontalLine();
			Items = Items_DefaultValue = new List<string>();
			Line = Line_DefaultValue = new StockToolsGuiDefinitionsLinesLine();
			Ray = Ray_DefaultValue = new StockToolsGuiDefinitionsLinesRay();
			Segment = Segment_DefaultValue = new StockToolsGuiDefinitionsLinesSegment();
			VerticalLine = VerticalLine_DefaultValue = new StockToolsGuiDefinitionsLinesVerticalLine();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesArrowLine ArrowLine { get; set; }
		private StockToolsGuiDefinitionsLinesArrowLine ArrowLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesArrowRay ArrowRay { get; set; }
		private StockToolsGuiDefinitionsLinesArrowRay ArrowRay_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesArrowSegment ArrowSegment { get; set; }
		private StockToolsGuiDefinitionsLinesArrowSegment ArrowSegment_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesHorizontalLine HorizontalLine { get; set; }
		private StockToolsGuiDefinitionsLinesHorizontalLine HorizontalLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesLine Line { get; set; }
		private StockToolsGuiDefinitionsLinesLine Line_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesRay Ray { get; set; }
		private StockToolsGuiDefinitionsLinesRay Ray_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesSegment Segment { get; set; }
		private StockToolsGuiDefinitionsLinesSegment Segment_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesVerticalLine VerticalLine { get; set; }
		private StockToolsGuiDefinitionsLinesVerticalLine VerticalLine_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ArrowLine.IsDirty()) h.Add("arrowLine",ArrowLine.ToHashtable());
			if (ArrowRay.IsDirty()) h.Add("arrowRay",ArrowRay.ToHashtable());
			if (ArrowSegment.IsDirty()) h.Add("arrowSegment",ArrowSegment.ToHashtable());
			if (HorizontalLine.IsDirty()) h.Add("horizontalLine",HorizontalLine.ToHashtable());
			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (Line.IsDirty()) h.Add("line",Line.ToHashtable());
			if (Ray.IsDirty()) h.Add("ray",Ray.ToHashtable());
			if (Segment.IsDirty()) h.Add("segment",Segment.ToHashtable());
			if (VerticalLine.IsDirty()) h.Add("verticalLine",VerticalLine.ToHashtable());
			

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