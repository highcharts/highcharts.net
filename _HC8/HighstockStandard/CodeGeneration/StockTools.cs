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
	public partial class StockTools  : BaseObject
	{
		Hashtable h = new Hashtable();

		public StockTools()
		{
			Gui = Gui_DefaultValue = new StockToolsGui();
			
		}	
		

		/// <summary>
		/// Definitions of buttons in Stock Tools GUI.
		/// </summary>
		public StockToolsGui Gui { get; set; }
		private StockToolsGui Gui_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Gui.IsDirty(ref highstock)) h.Add("gui",Gui.ToHashtable(ref highstock));
			

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