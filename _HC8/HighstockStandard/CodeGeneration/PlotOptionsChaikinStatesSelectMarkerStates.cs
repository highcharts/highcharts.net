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
	public partial class PlotOptionsChaikinStatesSelectMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsChaikinStatesSelectMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsChaikinStatesSelectMarkerStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsChaikinStatesSelectMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsChaikinStatesSelectMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsChaikinStatesSelectMarkerStatesHover Hover { get; set; }
		private PlotOptionsChaikinStatesSelectMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PlotOptionsChaikinStatesSelectMarkerStatesNormal Normal { get; set; }
		private PlotOptionsChaikinStatesSelectMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PlotOptionsChaikinStatesSelectMarkerStatesSelect Select { get; set; }
		private PlotOptionsChaikinStatesSelectMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty(ref highstock)) h.Add("hover",Hover.ToHashtable(ref highstock));
			if (Normal.IsDirty(ref highstock)) h.Add("normal",Normal.ToHashtable(ref highstock));
			if (Select.IsDirty(ref highstock)) h.Add("select",Select.ToHashtable(ref highstock));
			

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