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
	public partial class LangAccessibilitySonification  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LangAccessibilitySonification()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PlayAsSoundButtonText { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PlayAsSoundClickAnnouncement { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (PlayAsSoundButtonText != null) h.Add("playAsSoundButtonText",PlayAsSoundButtonText);
			if (PlayAsSoundClickAnnouncement != null) h.Add("playAsSoundClickAnnouncement",PlayAsSoundClickAnnouncement);
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