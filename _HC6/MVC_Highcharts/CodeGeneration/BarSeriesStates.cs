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
	public partial class BarSeriesStates  : BaseObject
	{
		public BarSeriesStates()
		{
			Hover = Hover_DefaultValue = new BarSeriesStatesHover();
			Select = Select_DefaultValue = new BarSeriesStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered point. These settings override the normalstate options when a point is moused over or touched.
		/// </summary>
		public BarSeriesStatesHover Hover { get; set; }
		private BarSeriesStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the selected point. These settings override the normalstate options when a point is selected.
		/// </summary>
		public BarSeriesStatesSelect Select { get; set; }
		private BarSeriesStatesSelect Select_DefaultValue { get; set; }
		  

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