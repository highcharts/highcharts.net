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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesArrowInfinityLine ArrowInfinityLine { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesArrowRay ArrowRay { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesArrowSegment ArrowSegment { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesHorizontalLine HorizontalLine { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesLine Line { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesRay Ray { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesSegment Segment { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsLinesVerticalLine VerticalLine { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ArrowInfinityLine != null) h.Add("arrowInfinityLine",ArrowInfinityLine.ToHashtable(highstock));
			if (ArrowRay != null) h.Add("arrowRay",ArrowRay.ToHashtable(highstock));
			if (ArrowSegment != null) h.Add("arrowSegment",ArrowSegment.ToHashtable(highstock));
			if (HorizontalLine != null) h.Add("horizontalLine",HorizontalLine.ToHashtable(highstock));
			if (Items != null) h.Add("items",Items);
			if (Line != null) h.Add("line",Line.ToHashtable(highstock));
			if (Ray != null) h.Add("ray",Ray.ToHashtable(highstock));
			if (Segment != null) h.Add("segment",Segment.ToHashtable(highstock));
			if (VerticalLine != null) h.Add("verticalLine",VerticalLine.ToHashtable(highstock));
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