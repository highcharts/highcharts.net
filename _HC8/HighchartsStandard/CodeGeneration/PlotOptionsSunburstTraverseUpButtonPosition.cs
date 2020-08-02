using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsSunburstTraverseUpButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSunburstTraverseUpButtonPosition()
		{
			Align = Align_DefaultValue = PlotOptionsSunburstTraverseUpButtonPositionAlign.Right;
			VerticalAlign = VerticalAlign_DefaultValue = PlotOptionsSunburstTraverseUpButtonPositionVerticalAlign.Top;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 10;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Horizontal alignment of the button.
		/// </summary>
		public PlotOptionsSunburstTraverseUpButtonPositionAlign Align { get; set; }
		private PlotOptionsSunburstTraverseUpButtonPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public PlotOptionsSunburstTraverseUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsSunburstTraverseUpButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset of the button.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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