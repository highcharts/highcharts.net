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
	public partial class PlotOptionsTreemapStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapStatesHover()
		{
		}	
		

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if theheatmap series is loaded first, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (Brightness != null) h.Add("brightness",Brightness);
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Shadow != null) h.Add("shadow",Shadow);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}