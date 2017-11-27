using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsPieDataLabels  : BaseObject
	{
		public PlotOptionsPieDataLabels()
		{
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = True;
			Formatter = Formatter_DefaultValue = null;
			X = X_DefaultValue = 0;
			ConnectorColor = ConnectorColor_DefaultValue = "{point.color}";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			SoftConnector = SoftConnector_DefaultValue = null;
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = True;
			Formatter = Formatter_DefaultValue = "";
			X = X_DefaultValue = 0;
			ConnectorColor = ConnectorColor_DefaultValue = "{point.color}";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			SoftConnector = SoftConnector_DefaultValue = null;
			
		}	
		

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
		public PlotOptionsPieDataLabelsFormatter Formatter { get; set; }
		private PlotOptionsPieDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

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
		/// The width of the line connecting the data label to the pie slice.In styled mode, the connector stroke width is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? SoftConnector { get; set; }
		private double? SoftConnector_DefaultValue { get; set; }
		 

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
		public PlotOptionsPieDataLabelsFormatter Formatter { get; set; }
		private PlotOptionsPieDataLabelsFormatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

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
		/// The width of the line connecting the data label to the pie slice.In styled mode, the connector stroke width is given in the`.highcharts-data-label-connector` class.
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to render the connector as a soft arc or a line with sharpbreak.
		/// </summary>
		public double? SoftConnector { get; set; }
		private double? SoftConnector_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (X != X_DefaultValue) h.Add("x",X);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (X != X_DefaultValue) h.Add("x",X);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (SoftConnector != SoftConnector_DefaultValue) h.Add("softConnector",SoftConnector);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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