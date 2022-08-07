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
	public partial class PlotOptionsFunnelOnPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsFunnelOnPoint()
		{
			ConnectorOptions = ConnectorOptions_DefaultValue = new PlotOptionsFunnelOnPointConnectorOptions();
			Id = Id_DefaultValue = "";
			Position = Position_DefaultValue = new PlotOptionsFunnelOnPointPosition();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for the connector in the _Series on point_ feature.In styled mode, the connector can be styled with the`.highcharts-connector-seriesonpoint` class name.
		/// </summary>
		public PlotOptionsFunnelOnPointConnectorOptions ConnectorOptions { get; set; }
		private PlotOptionsFunnelOnPointConnectorOptions ConnectorOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of the point that we connect the series to. Only points with a given`plotX` and `plotY` values and map points are valid.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options allowing to set a position and an offset of the series in the_Series on point_ feature.
		/// </summary>
		public PlotOptionsFunnelOnPointPosition Position { get; set; }
		private PlotOptionsFunnelOnPointPosition Position_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (ConnectorOptions.IsDirty(ref highcharts)) h.Add("connectorOptions",ConnectorOptions.ToHashtable(ref highcharts));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Position.IsDirty(ref highcharts)) h.Add("position",Position.ToHashtable(ref highcharts));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}