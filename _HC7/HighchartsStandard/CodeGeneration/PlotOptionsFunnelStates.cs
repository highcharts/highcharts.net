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
	public partial class PlotOptionsFunnelStates  : BaseObject
	{
		public PlotOptionsFunnelStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsFunnelStatesHover();
			Select = Select_DefaultValue = new PlotOptionsFunnelStatesSelect();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelStatesHover Hover { get; set; }
		private PlotOptionsFunnelStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for a selected funnel item.
		/// </summary>
		public PlotOptionsFunnelStatesSelect Select { get; set; }
		private PlotOptionsFunnelStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

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