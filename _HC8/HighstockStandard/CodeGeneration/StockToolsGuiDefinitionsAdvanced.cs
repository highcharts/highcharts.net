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
			Items = Items_DefaultValue = new List<string>();
			ParallelChannel = ParallelChannel_DefaultValue = new StockToolsGuiDefinitionsAdvancedParallelChannel();
			Pitchfork = Pitchfork_DefaultValue = new StockToolsGuiDefinitionsAdvancedPitchfork();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public StockToolsGuiDefinitionsAdvancedFibonacci Fibonacci { get; set; }
		private StockToolsGuiDefinitionsAdvancedFibonacci Fibonacci_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Fibonacci.IsDirty(ref highstock)) h.Add("fibonacci",Fibonacci.ToHashtable(ref highstock));
			if (Items != Items_DefaultValue) h.Add("items",Items);
			if (ParallelChannel.IsDirty(ref highstock)) h.Add("parallelChannel",ParallelChannel.ToHashtable(ref highstock));
			if (Pitchfork.IsDirty(ref highstock)) h.Add("pitchfork",Pitchfork.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}