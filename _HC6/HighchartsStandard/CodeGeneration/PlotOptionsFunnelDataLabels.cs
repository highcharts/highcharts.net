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
	public partial class PlotOptionsFunnelDataLabels  : BaseObject
	{
		public PlotOptionsFunnelDataLabels()
		{
			AllowOverlap = AllowOverlap_DefaultValue = true;
			ConnectorColor = ConnectorColor_DefaultValue = "";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = true;
			Formatter = Formatter_DefaultValue = "";
			SoftConnector = SoftConnector_DefaultValue = null;
			Style = Style_DefaultValue = new PlotOptionsFunnelDataLabelsStyle();
			X = X_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the line connecting the data label to the pie slice.The default color is the same as the point's color.In styled mode, the connector stroke is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public string ConnectorColor { get; set; }
		private string ConnectorColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance from the data label to the connector.
		/// </summary>
		public double? ConnectorPadding { get; set; }
		private double? ConnectorPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the data label from the pie's edge. Negative numbersput the data label on top of the pie slices. Connectors are onlyshown for data labels outside the pie.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the data labels.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? SoftConnector { get; set; }
		private double? SoftConnector_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsFunnelDataLabelsStyle Style { get; set; }
		private PlotOptionsFunnelDataLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("PlotOptionsFunnelDataLabelsFormatter.formatter", Formatter); }  
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (X != X_DefaultValue) h.Add("x",X);
			

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