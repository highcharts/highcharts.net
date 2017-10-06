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
	public partial class PlotOptionsMfiStatesSelectMarkerStates  : BaseObject
	{
		public PlotOptionsMfiStatesSelectMarkerStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsMfiStatesSelectMarkerStatesHover();
			Select = Select_DefaultValue = new PlotOptionsMfiStatesSelectMarkerStatesSelect();
			
		}	
		

		/// <summary>
		/// <p>The hover state for a single point marker.</p>
		/// </summary>
		public PlotOptionsMfiStatesSelectMarkerStatesHover Hover { get; set; }
		private PlotOptionsMfiStatesSelectMarkerStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The appearance of the point marker when selected. In order toallow a point to be selected, set the <code>series.allowPointSelect</code>option to true.</p>
		/// </summary>
		public PlotOptionsMfiStatesSelectMarkerStatesSelect Select { get; set; }
		private PlotOptionsMfiStatesSelectMarkerStatesSelect Select_DefaultValue { get; set; }
		  

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