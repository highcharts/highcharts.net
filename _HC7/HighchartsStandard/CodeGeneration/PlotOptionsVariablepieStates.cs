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
	public partial class PlotOptionsVariablepieStates  : BaseObject
	{
		public PlotOptionsVariablepieStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsVariablepieStatesHover();
			
		}	
		

		/// <summary>
		/// Options for the hovered series. These settings override the normalstate options when a series is moused over or touched.
		/// </summary>
		public PlotOptionsVariablepieStatesHover Hover { get; set; }
		private PlotOptionsVariablepieStatesHover Hover_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			

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