using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsSplineMarkerStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSplineMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsSplineMarkerStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsSplineMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsSplineMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsSplineMarkerStatesHover Hover { get; set; }
		private PlotOptionsSplineMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently onlyused for setting animation when returning to normal statefrom hover.
		/// </summary>
		public PlotOptionsSplineMarkerStatesNormal Normal { get; set; }
		private PlotOptionsSplineMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the`series.allowPointSelect` option to true.
		/// </summary>
		public PlotOptionsSplineMarkerStatesSelect Select { get; set; }
		private PlotOptionsSplineMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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