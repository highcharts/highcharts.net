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
			AfterUpdate = AfterUpdate_DefaultValue = "";
			BeforePlay = BeforePlay_DefaultValue = "";
			BeforeUpdate = BeforeUpdate_DefaultValue = "";
			OnBoundaryHit = OnBoundaryHit_DefaultValue = "";
			OnEnd = OnEnd_DefaultValue = "";
			OnPlay = OnPlay_DefaultValue = "";
			OnSeriesEnd = OnSeriesEnd_DefaultValue = "";
			OnSeriesStart = OnSeriesStart_DefaultValue = "";
			OnStop = OnStop_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Called after updating the sonification.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string AfterUpdate { get; set; }
		private string AfterUpdate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called immediately when a play is requested.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string BeforePlay { get; set; }
		private string BeforePlay_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called before updating the sonification.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string BeforeUpdate { get; set; }
		private string BeforeUpdate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called when attempting to play an adjacent point or series, andthere is none.By default a percussive sound is played.A context object is passed to the function, with properties `chart`,`timeline`, and `attemptedNext`. `attemptedNext` is a booleanproperty that is `true` if the boundary hit was from trying to playthe next series/point, and `false` if it was from trying to play theprevious.
		/// </summary>
		public string OnBoundaryHit { get; set; }
		private string OnBoundaryHit_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called when play is completed.A context object is passed to the function, with properties `chart`,`timeline` and `pointsPlayed`. `pointsPlayed` is an array of `Point`objects, referencing data points that were related to the audioevents played.
		/// </summary>
		public string OnEnd { get; set; }
		private string OnEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called on play.A context object is passed to the function, with properties `chart`and `timeline`.
		/// </summary>
		public string OnPlay { get; set; }
		private string OnPlay_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called when finished playing a series.A context object is passed to the function, with properties `series`and `timeline`.
		/// </summary>
		public string OnSeriesEnd { get; set; }
		private string OnSeriesEnd_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called on the beginning of playing a series.A context object is passed to the function, with properties `series`and `timeline`.
		/// </summary>
		public string OnSeriesStart { get; set; }
		private string OnSeriesStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Called on pause, cancel, or if play is completed.A context object is passed to the function, with properties `chart`,`timeline` and `pointsPlayed`. `pointsPlayed` is an array of `Point`objects, referencing data points that were related to the audioevents played.
		/// </summary>
		public string OnStop { get; set; }
		private string OnStop_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (AfterUpdate != AfterUpdate_DefaultValue) { h.Add("afterUpdate",AfterUpdate); highstock.AddFunction("afterUpdate", AfterUpdate); }  
			if (BeforePlay != BeforePlay_DefaultValue) { h.Add("beforePlay",BeforePlay); highstock.AddFunction("beforePlay", BeforePlay); }  
			if (BeforeUpdate != BeforeUpdate_DefaultValue) { h.Add("beforeUpdate",BeforeUpdate); highstock.AddFunction("beforeUpdate", BeforeUpdate); }  
			if (OnBoundaryHit != OnBoundaryHit_DefaultValue) { h.Add("onBoundaryHit",OnBoundaryHit); highstock.AddFunction("onBoundaryHit", OnBoundaryHit); }  
			if (OnEnd != OnEnd_DefaultValue) { h.Add("onEnd",OnEnd); highstock.AddFunction("onEnd", OnEnd); }  
			if (OnPlay != OnPlay_DefaultValue) { h.Add("onPlay",OnPlay); highstock.AddFunction("onPlay", OnPlay); }  
			if (OnSeriesEnd != OnSeriesEnd_DefaultValue) { h.Add("onSeriesEnd",OnSeriesEnd); highstock.AddFunction("onSeriesEnd", OnSeriesEnd); }  
			if (OnSeriesStart != OnSeriesStart_DefaultValue) { h.Add("onSeriesStart",OnSeriesStart); highstock.AddFunction("onSeriesStart", OnSeriesStart); }  
			if (OnStop != OnStop_DefaultValue) { h.Add("onStop",OnStop); highstock.AddFunction("onStop", OnStop); }  
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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