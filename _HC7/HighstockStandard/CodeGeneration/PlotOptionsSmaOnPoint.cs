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
	public partial class PlotOptionsSmaOnPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsSmaOnPoint()
		{
			ConnectorOptions = ConnectorOptions_DefaultValue = new PlotOptionsSmaOnPointConnectorOptions();
			Id = Id_DefaultValue = "";
			Position = Position_DefaultValue = new PlotOptionsSmaOnPointPosition();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Options for the connector in the _Series on point_ feature.In styled mode, the connector can be styled with the`.highcharts-connector-seriesonpoint` class name.
		/// </summary>
		public PlotOptionsSmaOnPointConnectorOptions ConnectorOptions { get; set; }
		private PlotOptionsSmaOnPointConnectorOptions ConnectorOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The `id` of the point that we connect the series to. Only points with a given`plotX` and `plotY` values and map points are valid.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options allowing to set a position and an offset of the series in the_Series on point_ feature.
		/// </summary>
		public PlotOptionsSmaOnPointPosition Position { get; set; }
		private PlotOptionsSmaOnPointPosition Position_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ConnectorOptions.IsDirty(highstock)) h.Add("connectorOptions",ConnectorOptions.ToHashtable(highstock));
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Position.IsDirty(highstock)) h.Add("position",Position.ToHashtable(highstock));
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