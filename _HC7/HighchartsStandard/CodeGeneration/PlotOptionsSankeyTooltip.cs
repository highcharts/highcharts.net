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
		public PlotOptionsSankeyTooltip()
		{
			FollowPointer = FollowPointer_DefaultValue = true;
			HeaderFormat = HeaderFormat_DefaultValue = "<span class='highcharts-header'>{series.name}</span><br/>";
			NodeFormat = NodeFormat_DefaultValue = "{point.name}: <b>{point.sum}</b><br/>";
			NodeFormatter = NodeFormatter_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = "{point.fromNode.name} → {point.toNode.name}: <b>{point.weight}</b><br/>";
			
		}	
		

		/// <summary>
		/// Whether the tooltip should follow the pointer or stay fixed on theitem.
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what toshow for _nodes_ in tooltipof a sankey diagram series, as opposed to links.
		/// </summary>
		public string NodeFormat { get; set; }
		private string NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback for defining the format for _nodes_ in the sankey chart'stooltip, as opposed to links.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) { h.Add("nodeFormatter",NodeFormatter); Highcharts.AddFunction("PlotOptionsSankeyTooltipNodeFormatter.nodeFormatter", NodeFormatter); }  
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

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