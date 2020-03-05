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
	public partial class SankeySeriesLevelsStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public SankeySeriesLevelsStates()
		{
			Hover = Hover_DefaultValue = new SankeySeriesLevelsStatesHover();
			Inactive = Inactive_DefaultValue = new SankeySeriesLevelsStatesInactive();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public SankeySeriesLevelsStatesHover Hover { get; set; }
		private SankeySeriesLevelsStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for a single point node/link.
		/// </summary>
		public SankeySeriesLevelsStatesInactive Inactive { get; set; }
		private SankeySeriesLevelsStatesInactive Inactive_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			

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