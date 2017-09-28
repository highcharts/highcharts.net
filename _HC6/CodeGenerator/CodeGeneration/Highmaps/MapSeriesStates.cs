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
	public partial class MapSeriesStates  : BaseObject
	{
		public MapSeriesStates()
		{
			Hover = Hover_DefaultValue = new MapSeriesStatesHover();
			Normal = Normal_DefaultValue = new MapSeriesStatesNormal();
			Select = Select_DefaultValue = new MapSeriesStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public MapSeriesStatesHover Hover { get; set; }
		private MapSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Overrides for the normal state
		/// </summary>
		public MapSeriesStatesNormal Normal { get; set; }
		private MapSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after being selected by <a href="#plotOptions.series.allowPointSelect">allowPointSelect</a> or programmatically. 
		/// </summary>
		public MapSeriesStatesSelect Select { get; set; }
		private MapSeriesStatesSelect Select_DefaultValue { get; set; }
		  

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