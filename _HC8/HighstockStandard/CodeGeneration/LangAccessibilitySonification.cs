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
			
			CustomFields = new Hashtable();
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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (PlayAsSoundButtonText != PlayAsSoundButtonText_DefaultValue) h.Add("playAsSoundButtonText",PlayAsSoundButtonText);
			if (PlayAsSoundClickAnnouncement != PlayAsSoundClickAnnouncement_DefaultValue) h.Add("playAsSoundClickAnnouncement",PlayAsSoundClickAnnouncement);
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