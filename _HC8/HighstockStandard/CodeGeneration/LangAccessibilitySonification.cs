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
	public partial class LangAccessibilitySonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilitySonification()
		{
			PlayAsSoundButtonText = PlayAsSoundButtonText_DefaultValue = "Play as sound, {chartTitle}";
			PlayAsSoundClickAnnouncement = PlayAsSoundClickAnnouncement_DefaultValue = "Play";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PlayAsSoundButtonText { get; set; }
		private string PlayAsSoundButtonText_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PlayAsSoundClickAnnouncement { get; set; }
		private string PlayAsSoundClickAnnouncement_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (PlayAsSoundButtonText != PlayAsSoundButtonText_DefaultValue) h.Add("playAsSoundButtonText",PlayAsSoundButtonText);
			if (PlayAsSoundClickAnnouncement != PlayAsSoundClickAnnouncement_DefaultValue) h.Add("playAsSoundClickAnnouncement",PlayAsSoundClickAnnouncement);
			

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