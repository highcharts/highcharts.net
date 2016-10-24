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
	public partial class PlotOptionsMaplineStates  : BaseObject
	{
		public PlotOptionsMaplineStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsMaplineStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsMaplineStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsMaplineStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public PlotOptionsMaplineStatesHover Hover { get; set; }
		private PlotOptionsMaplineStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Overrides for the normal state
		/// </summary>
		public PlotOptionsMaplineStatesNormal Normal { get; set; }
		private PlotOptionsMaplineStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after being selected by <a href="#plotOptions.series.allowPointSelect">allowPointSelect</a> or programmatically. 
		/// </summary>
		public PlotOptionsMaplineStatesSelect Select { get; set; }
		private PlotOptionsMaplineStatesSelect Select_DefaultValue { get; set; }
		  

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