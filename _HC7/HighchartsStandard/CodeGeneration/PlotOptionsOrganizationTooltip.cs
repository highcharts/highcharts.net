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
	public partial class PlotOptionsOrganizationTooltip  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsOrganizationTooltip()
		{
			Distance = Distance_DefaultValue = 6;
			FollowPointer = FollowPointer_DefaultValue = true;
			HeaderFormat = HeaderFormat_DefaultValue = "<span style='font-size: 0.8em'>{series.name}</span><br/>";
			NodeFormat = NodeFormat_DefaultValue = "{point.name}<br>{point.title}<br>{point.description}";
			NodeFormatter = NodeFormatter_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = "{point.fromNode.name} → {point.toNode.name}: <b>{point.weight}</b><br/>";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the tooltip should follow the pointer or stay fixed onthe item.
		/// </summary>
		public bool? FollowPointer { get; set; }
		private bool? FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string NodeFormat { get; set; }
		private string NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback for defining the format for _nodes_ in the chart'stooltip, as opposed to links.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) { h.Add("nodeFormatter",NodeFormatter); highcharts.AddFunction("nodeFormatter", NodeFormatter); }  
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}