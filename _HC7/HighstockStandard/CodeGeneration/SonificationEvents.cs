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
	public partial class SonificationEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SonificationEvents()
		{
		}	
		

		/// <summary>
		/// Called after updating the sonification.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string AfterUpdate { get; set; }
		 

		/// <summary>
		/// Called immediately when a play is requested.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string BeforePlay { get; set; }
		 

		/// <summary>
		/// Called before updating the sonification.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string BeforeUpdate { get; set; }
		 

		/// <summary>
		/// Called when attempting to play an adjacent point or series, andthere is none.By default a percussive sound is played.A context object is passed to the function, with properties `chart`,`timeline`, and `attemptedNext`. `attemptedNext` is a booleanproperty that is `true` if the boundary hit was from trying to playthe next series/point, and `false` if it was from trying to play theprevious.
		/// </summary>
		public string OnBoundaryHit { get; set; }
		 

		/// <summary>
		/// Called when play is completed.A context object is passed to the function, with properties `chart`,`timeline` and `pointsPlayed`. `pointsPlayed` is an array of `Point`objects, referencing data points that were related to the audioevents played.
		/// </summary>
		public string OnEnd { get; set; }
		 

		/// <summary>
		/// Called on play.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string OnPlay { get; set; }
		 

		/// <summary>
		/// Called when finished playing a series.A context object is passed to the function, with properties `series`and `timeline`.
		/// </summary>
		public string OnSeriesEnd { get; set; }
		 

		/// <summary>
		/// Called on the beginning of playing a series.A context object is passed to the function, with properties `series`and `timeline`.
		/// </summary>
		public string OnSeriesStart { get; set; }
		 

		/// <summary>
		/// Called on pause, cancel, or if play is completed.A context object is passed to the function, with properties `chart`,`timeline` and `pointsPlayed`. `pointsPlayed` is an array of `Point`objects, referencing data points that were related to the audioevents played.
		/// </summary>
		public string OnStop { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AfterUpdate != null) { h.Add("afterUpdate",AfterUpdate); highstock.AddFunction("afterUpdate", AfterUpdate); }  
			if (BeforePlay != null) { h.Add("beforePlay",BeforePlay); highstock.AddFunction("beforePlay", BeforePlay); }  
			if (BeforeUpdate != null) { h.Add("beforeUpdate",BeforeUpdate); highstock.AddFunction("beforeUpdate", BeforeUpdate); }  
			if (OnBoundaryHit != null) { h.Add("onBoundaryHit",OnBoundaryHit); highstock.AddFunction("onBoundaryHit", OnBoundaryHit); }  
			if (OnEnd != null) { h.Add("onEnd",OnEnd); highstock.AddFunction("onEnd", OnEnd); }  
			if (OnPlay != null) { h.Add("onPlay",OnPlay); highstock.AddFunction("onPlay", OnPlay); }  
			if (OnSeriesEnd != null) { h.Add("onSeriesEnd",OnSeriesEnd); highstock.AddFunction("onSeriesEnd", OnSeriesEnd); }  
			if (OnSeriesStart != null) { h.Add("onSeriesStart",OnSeriesStart); highstock.AddFunction("onSeriesStart", OnSeriesStart); }  
			if (OnStop != null) { h.Add("onStop",OnStop); highstock.AddFunction("onStop", OnStop); }  
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