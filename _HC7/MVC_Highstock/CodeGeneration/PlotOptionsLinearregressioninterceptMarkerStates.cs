using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsLinearregressioninterceptMarkerStates  : BaseObject
	{
		public PlotOptionsLinearregressioninterceptMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsLinearregressioninterceptMarkerStatesHover();
			Normal = Normal_DefaultValue = new PlotOptionsLinearregressioninterceptMarkerStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsLinearregressioninterceptMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// The hover state for a single point marker.
		/// </summary>
		public PlotOptionsLinearregressioninterceptMarkerStatesHover Hover { get; set; }
		private PlotOptionsLinearregressioninterceptMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a single point marker. Currently only usedfor setting animation when returning to normal state from hover.
		/// </summary>
		public PlotOptionsLinearregressioninterceptMarkerStatesNormal Normal { get; set; }
		private PlotOptionsLinearregressioninterceptMarkerStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order toallow a point to be selected, set the `series.allowPointSelect`option to true.
		/// </summary>
		public PlotOptionsLinearregressioninterceptMarkerStatesSelect Select { get; set; }
		private PlotOptionsLinearregressioninterceptMarkerStatesSelect Select_DefaultValue { get; set; }
		  

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