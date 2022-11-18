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
			Fibonacci = Fibonacci_DefaultValue = new StockToolsGuiDefinitionsAdvancedFibonacci();
			FibonacciTimeZones = FibonacciTimeZones_DefaultValue = new Hashtable();
			Items = Items_DefaultValue = new List<string>();
			ParallelChannel = ParallelChannel_DefaultValue = new StockToolsGuiDefinitionsAdvancedParallelChannel();
			Pitchfork = Pitchfork_DefaultValue = new StockToolsGuiDefinitionsAdvancedPitchfork();
			TimeCycles = TimeCycles_DefaultValue = new StockToolsGuiDefinitionsAdvancedTimeCycles();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedFibonacci Fibonacci { get; set; }
		private StockToolsGuiDefinitionsAdvancedFibonacci Fibonacci_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable FibonacciTimeZones { get; set; }
		private Hashtable FibonacciTimeZones_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of strings pointing to config options forthe items.
		/// </summary>
		public List<string> Items { get; set; }
		private List<string> Items_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedParallelChannel ParallelChannel { get; set; }
		private StockToolsGuiDefinitionsAdvancedParallelChannel ParallelChannel_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedPitchfork Pitchfork { get; set; }
		private StockToolsGuiDefinitionsAdvancedPitchfork Pitchfork_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedTimeCycles TimeCycles { get; set; }
		private StockToolsGuiDefinitionsAdvancedTimeCycles TimeCycles_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Fibonacci.IsDirty(highstock)) h.Add("fibonacci",Fibonacci.ToHashtable(highstock));
			if (FibonacciTimeZones != FibonacciTimeZones_DefaultValue) h.Add("fibonacciTimeZones",FibonacciTimeZones);
			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (ParallelChannel.IsDirty(highstock)) h.Add("parallelChannel",ParallelChannel.ToHashtable(highstock));
			if (Pitchfork.IsDirty(highstock)) h.Add("pitchfork",Pitchfork.ToHashtable(highstock));
			if (TimeCycles.IsDirty(highstock)) h.Add("timeCycles",TimeCycles.ToHashtable(highstock));
			

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