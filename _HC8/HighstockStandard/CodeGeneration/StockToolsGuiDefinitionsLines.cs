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
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsLines()
		{
			ArrowInfinityLine = ArrowInfinityLine_DefaultValue = new StockToolsGuiDefinitionsLinesArrowInfinityLine();
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
		public StockToolsGuiDefinitionsLinesArrowInfinityLine ArrowInfinityLine { get; set; }
		private StockToolsGuiDefinitionsLinesArrowInfinityLine ArrowInfinityLine_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ArrowInfinityLine.IsDirty(ref highstock)) h.Add("arrowInfinityLine",ArrowInfinityLine.ToHashtable(ref highstock));
			if (ArrowRay.IsDirty(ref highstock)) h.Add("arrowRay",ArrowRay.ToHashtable(ref highstock));
			if (ArrowSegment.IsDirty(ref highstock)) h.Add("arrowSegment",ArrowSegment.ToHashtable(ref highstock));
			if (HorizontalLine.IsDirty(ref highstock)) h.Add("horizontalLine",HorizontalLine.ToHashtable(ref highstock));
			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (Line.IsDirty(ref highstock)) h.Add("line",Line.ToHashtable(ref highstock));
			if (Ray.IsDirty(ref highstock)) h.Add("ray",Ray.ToHashtable(ref highstock));
			if (Segment.IsDirty(ref highstock)) h.Add("segment",Segment.ToHashtable(ref highstock));
			if (VerticalLine.IsDirty(ref highstock)) h.Add("verticalLine",VerticalLine.ToHashtable(ref highstock));
			

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