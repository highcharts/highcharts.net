using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class PlotOptionsMapStates  : BaseObject
	{
		public PlotOptionsMapStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsMapStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsMapStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsMapStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsMapStatesHover Hover { get; set; }
		private PlotOptionsMapStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Overrides for the normal state
		/// </summary>
		public PlotOptionsMapStatesNormal Normal { get; set; }
		private PlotOptionsMapStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after being selected by <a href="#plotOptions.series.allowPointSelect">allowPointSelect</a> or programmatically. 
		/// </summary>
		public PlotOptionsMapStatesSelect Select { get; set; }
		private PlotOptionsMapStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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