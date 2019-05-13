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
	public partial class PlotOptionsPcTopLine  : BaseObject
	{
		public PlotOptionsPcTopLine()
		{
			Styles = Styles_DefaultValue = new PlotOptionsPcTopLineStyles();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPcTopLineStyles Styles { get; set; }
		private PlotOptionsPcTopLineStyles Styles_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Styles.IsDirty()) h.Add("styles",Styles.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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