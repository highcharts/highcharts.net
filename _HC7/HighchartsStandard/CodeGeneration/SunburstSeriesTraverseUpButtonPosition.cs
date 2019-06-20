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
	public partial class SunburstSeriesTraverseUpButtonPosition  : BaseObject
	{
		public SunburstSeriesTraverseUpButtonPosition()
		{
			Align = Align_DefaultValue = SunburstSeriesTraverseUpButtonPositionAlign.Right;
			VerticalAlign = VerticalAlign_DefaultValue = SunburstSeriesTraverseUpButtonPositionVerticalAlign.Top;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 10;
			
		}	
		

		/// <summary>
		/// Horizontal alignment of the button.
		/// </summary>
		public SunburstSeriesTraverseUpButtonPositionAlign Align { get; set; }
		private SunburstSeriesTraverseUpButtonPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public SunburstSeriesTraverseUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		private SunburstSeriesTraverseUpButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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