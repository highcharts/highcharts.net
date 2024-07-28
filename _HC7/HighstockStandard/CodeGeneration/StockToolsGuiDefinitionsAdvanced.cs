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
	public partial class StockToolsGuiDefinitionsAdvanced  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockToolsGuiDefinitionsAdvanced()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedFibonacci Fibonacci { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedFibonacciTimeZones FibonacciTimeZones { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedParallelChannel ParallelChannel { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedPitchfork Pitchfork { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedTimeCycles TimeCycles { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Fibonacci != null) h.Add("fibonacci",Fibonacci.ToHashtable(highstock));
			if (FibonacciTimeZones != null) h.Add("fibonacciTimeZones",FibonacciTimeZones.ToHashtable(highstock));
			if (Items != null) h.Add("items",Items);
			if (ParallelChannel != null) h.Add("parallelChannel",ParallelChannel.ToHashtable(highstock));
			if (Pitchfork != null) h.Add("pitchfork",Pitchfork.ToHashtable(highstock));
			if (TimeCycles != null) h.Add("timeCycles",TimeCycles.ToHashtable(highstock));
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