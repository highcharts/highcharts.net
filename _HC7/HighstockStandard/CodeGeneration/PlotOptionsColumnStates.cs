using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsColumnStates  : BaseObject
	{
		public PlotOptionsColumnStates()
		{
			Hover = Hover_DefaultValue = new PlotOptionsColumnStatesHover();
			Inactive = Inactive_DefaultValue = new PlotOptionsColumnStatesInactive();
			Normal = Normal_DefaultValue = new PlotOptionsColumnStatesNormal();
			Select = Select_DefaultValue = new PlotOptionsColumnStatesSelect();
			
		}	
		

		/// <summary>
		/// Options for the hovered point. These settings override the normalstate options when a point is moused over or touched.
		/// </summary>
		public PlotOptionsColumnStatesHover Hover { get; set; }
		private PlotOptionsColumnStatesHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opposite state of a hover for series.
		/// </summary>
		public PlotOptionsColumnStatesInactive Inactive { get; set; }
		private PlotOptionsColumnStatesInactive Inactive_DefaultValue { get; set; }
		 

		/// <summary>
		/// The normal state of a series, or for point items in column, pieand similar series. Currently only used for setting animationwhen returning to normal state from hover.
		/// </summary>
		public PlotOptionsColumnStatesNormal Normal { get; set; }
		private PlotOptionsColumnStatesNormal Normal_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the selected point. These settings override thenormal state options when a point is selected.
		/// </summary>
		public PlotOptionsColumnStatesSelect Select { get; set; }
		private PlotOptionsColumnStatesSelect Select_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Inactive.IsDirty()) h.Add("inactive",Inactive.ToHashtable());
			if (Normal.IsDirty()) h.Add("normal",Normal.ToHashtable());
			if (Select.IsDirty()) h.Add("select",Select.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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