using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class AreasplinerangeSeriesStatesHoverMarkerStates  : BaseObject
	{
		public AreasplinerangeSeriesStatesHoverMarkerStates()
		{
			Normal = Normal_DefaultValue = new AreasplinerangeSeriesStatesHoverMarkerStatesNormal();
			Hover = Hover_DefaultValue = new AreasplinerangeSeriesStatesHoverMarkerStatesHover();
			Select = Select_DefaultValue = new AreasplinerangeSeriesStatesHoverMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The normal state of a single point marker. Currently only usedfor setting animation when returning to normal state from hover.
		/// </summary>
		public AreasplinerangeSeriesStatesHoverMarkerStatesNormal Normal { get; set; }
		private AreasplinerangeSeriesStatesHoverMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public AreasplinerangeSeriesStatesHoverMarkerStatesHover Hover { get; set; }
		private AreasplinerangeSeriesStatesHoverMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the `series.allowPointSelect`option to true.
		/// </summary>
		public AreasplinerangeSeriesStatesHoverMarkerStatesSelect Select { get; set; }
		private AreasplinerangeSeriesStatesHoverMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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