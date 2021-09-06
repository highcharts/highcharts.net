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
	public partial class PlotOptionsScatterClusterStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatterClusterStatesHover()
		{
			FillColor = FillColor_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The fill color of the cluster marker in hover state. When`undefined`, the series' or point's fillColor for normalstate is used.
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			

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