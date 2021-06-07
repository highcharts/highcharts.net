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
	public partial class PlotOptionsKlingerSignalLineStyles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsKlingerSignalLineStyles()
		{
			LineColor = LineColor_DefaultValue = "#ff0000";
			LineWidth = LineWidth_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// Color of the line. If not set, it's inherited from[plotOptions.klinger.color](#plotOptions.klinger.color).
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Pixel width of the line.
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			

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