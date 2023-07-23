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
	public partial class ChartZoomingResetButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartZoomingResetButtonPosition()
		{
			Align = Align_DefaultValue = ChartZoomingResetButtonPositionAlign.Right;
			VerticalAlign = VerticalAlign_DefaultValue = ChartZoomingResetButtonPositionVerticalAlign.Top;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 10;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The horizontal alignment of the button.
		/// </summary>
		public ChartZoomingResetButtonPositionAlign Align { get; set; }
		private ChartZoomingResetButtonPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical alignment of the button.
		/// </summary>
		public ChartZoomingResetButtonPositionVerticalAlign VerticalAlign { get; set; }
		private ChartZoomingResetButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of the button.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
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

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}