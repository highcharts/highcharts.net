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
	public partial class MapBubbleSeriesStates  : BaseObject
	{
		public MapBubbleSeriesStates()
		{
			Hover = Hover_DefaultValue = new MapBubbleSeriesStatesHover();
			Normal = Normal_DefaultValue = new MapBubbleSeriesStatesNormal();
			Select = Select_DefaultValue = new MapBubbleSeriesStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered series
		/// </summary>
		public MapBubbleSeriesStatesHover Hover { get; set; }
		private MapBubbleSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Overrides for the normal state
		/// </summary>
		public MapBubbleSeriesStatesNormal Normal { get; set; }
		private MapBubbleSeriesStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specific options for point in selected states, after being selected by <a href="#plotOptions.series.allowPointSelect">allowPointSelect</a> or programmatically. 
		/// </summary>
		public MapBubbleSeriesStatesSelect Select { get; set; }
		private MapBubbleSeriesStatesSelect Select_DefaultValue { get; set; }
		  

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