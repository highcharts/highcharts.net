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
	public partial class PlotOptionsBubbleStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBubbleStatesHover()
		{
			Halo = Halo_DefaultValue = new PlotOptionsBubbleStatesHoverHalo();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStatesHoverHalo Halo { get; set; }
		private PlotOptionsBubbleStatesHoverHalo Halo_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Halo.IsDirty(highstock)) h.Add("halo",Halo.ToHashtable(highstock));
			

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