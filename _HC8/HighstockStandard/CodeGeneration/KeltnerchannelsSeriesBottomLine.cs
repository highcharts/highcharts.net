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
	public partial class KeltnerchannelsSeriesBottomLine  : BaseObject
	{
		Hashtable h = new Hashtable();

		public KeltnerchannelsSeriesBottomLine()
		{
			Styles = Styles_DefaultValue = new KeltnerchannelsSeriesBottomLineStyles();
			
		}	
		

		/// <summary>
		/// Styles for a bottom line.
		/// </summary>
		public KeltnerchannelsSeriesBottomLineStyles Styles { get; set; }
		private KeltnerchannelsSeriesBottomLineStyles Styles_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Styles.IsDirty()) h.Add("styles",Styles.ToHashtable());
			

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