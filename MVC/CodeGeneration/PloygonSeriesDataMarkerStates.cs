using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class PloygonSeriesDataMarkerStates 
	{
		public PloygonSeriesDataMarkerStates()
		{
			Hover = Hover_DefaultValue = new PloygonSeriesDataMarkerStatesHover();
			Select = Select_DefaultValue = new PloygonSeriesDataMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PloygonSeriesDataMarkerStatesHover Hover { get; set; }
		private PloygonSeriesDataMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The appearance of the point marker when selected. In order to allow a point to be selected, set the <code>series.allowPointSelect</code> option to true.
		/// </summary>
		public PloygonSeriesDataMarkerStatesSelect Select { get; set; }
		private PloygonSeriesDataMarkerStatesSelect Select_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}