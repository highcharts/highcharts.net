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
	public partial class PlotOptionsCmoOnPoint  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsCmoOnPoint()
		{
		}	
		

		/// <summary>
		/// Options for the connector in the _Series on point_ feature.In styled mode, the connector can be styled with the`.highcharts-connector-seriesonpoint` class name.
		/// </summary>
		public PlotOptionsCmoOnPointConnectorOptions ConnectorOptions { get; set; }
		 

		/// <summary>
		/// The `id` of the point that we connect the series to. Only points with a given`plotX` and `plotY` values and map points are valid.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// Options allowing to set a position and an offset of the series in the_Series on point_ feature.
		/// </summary>
		public PlotOptionsCmoOnPointPosition Position { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ConnectorOptions != null) h.Add("connectorOptions",ConnectorOptions.ToHashtable(highstock));
			if (Id != null) h.Add("id",Id);
			if (Position != null) h.Add("position",Position.ToHashtable(highstock));
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