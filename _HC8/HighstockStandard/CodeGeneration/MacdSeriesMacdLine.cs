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
	public partial class MacdSeriesMacdLine  : BaseObject
	{
		Hashtable h = new Hashtable();

		public MacdSeriesMacdLine()
		{
			Styles = Styles_DefaultValue = new MacdSeriesMacdLineStyles();
			Zones = Zones_DefaultValue = new MacdSeriesMacdLineZone();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public MacdSeriesMacdLineStyles Styles { get; set; }
		private MacdSeriesMacdLineStyles Styles_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public MacdSeriesMacdLineZone Zones { get; set; }
		private MacdSeriesMacdLineZone Zones_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Styles.IsDirty()) h.Add("styles",Styles.ToHashtable());
			if (Zones.IsDirty()) h.Add("zones",Zones.ToHashtable());
			

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