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
	public partial class PlotOptionsArearangeStatesHoverMarkerStates  : BaseObject
	{
		public PlotOptionsArearangeStatesHoverMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsArearangeStatesHoverMarkerStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsArearangeStatesHoverMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsArearangeStatesHoverMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsArearangeStatesHoverMarkerStatesHover Hover { get; set; }
		private PlotOptionsArearangeStatesHoverMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently only usedfor setting animation when returning to normal state from hover.
		/// </summary>
		public PlotOptionsArearangeStatesHoverMarkerStatesNormal Normal { get; set; }
		private PlotOptionsArearangeStatesHoverMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the `series.allowPointSelect`option to true.
		/// </summary>
		public PlotOptionsArearangeStatesHoverMarkerStatesSelect Select { get; set; }
		private PlotOptionsArearangeStatesHoverMarkerStatesSelect Select_DefaultValue { get; set; }
		  

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