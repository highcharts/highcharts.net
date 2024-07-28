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
	public partial class PlotOptionsSankeyTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSankeyTooltip()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Distance { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the pointer or stay fixed onthe item.
		/// </summary>
		public bool? FollowPointer { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HeaderFormat { get; set; }
		 

		/// <summary>
		/// The[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)specifying what to show for _nodes_ in tooltip of a diagramseries, as opposed to links.
		/// </summary>
		public string NodeFormat { get; set; }
		 

		/// <summary>
		/// A callback for defining the format for _nodes_ in the chart'stooltip, as opposed to links.
		/// </summary>
		public string NodeFormatter { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Distance != null) h.Add("distance",Distance);
			if (FollowPointer != null) h.Add("followPointer",FollowPointer);
			if (HeaderFormat != null) h.Add("headerFormat",HeaderFormat);
			if (NodeFormat != null) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != null) { h.Add("nodeFormatter",NodeFormatter); highcharts.AddFunction("nodeFormatter", NodeFormatter); }  
			if (PointFormat != null) h.Add("pointFormat",PointFormat);
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