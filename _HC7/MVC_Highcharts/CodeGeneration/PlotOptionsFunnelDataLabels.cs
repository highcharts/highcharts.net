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
	public partial class PlotOptionsFunnelDataLabels  : BaseObject
	{
		public PlotOptionsFunnelDataLabels()
		{
			AlignTo = AlignTo_DefaultValue = "undefined";
			AllowOverlap = AllowOverlap_DefaultValue = true;
			ConnectorColor = ConnectorColor_DefaultValue = "";
			ConnectorPadding = ConnectorPadding_DefaultValue = 5;
			ConnectorShape = ConnectorShape_DefaultValue = "fixedOffset";
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			CrookDistance = CrookDistance_DefaultValue = "70%";
			Distance = Distance_DefaultValue = 30;
			Enabled = Enabled_DefaultValue = true;
			Formatter = Formatter_DefaultValue = "";
			SoftConnector = SoftConnector_DefaultValue = null;
			Style = Style_DefaultValue = new PlotOptionsFunnelDataLabelsStyle();
			X = X_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// Alignment method for data labels. Possible values are:`'toPlotEdges'` (each label touches the nearest vertical edge ofthe plot area) or `'connectors'` (connectors have the same xposition and the widest label of each half (left & right) touchesthe nearest vertical edge of the plot area).
		/// </summary>
		public string AlignTo { get; set; }
		private string AlignTo_DefaultValue { get; set; }
		 

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
		/// The distance from the data label to the connector. Note that datalabels also have a default `padding`, so in order for the connectorto touch the text, the `padding` must also be 0.
		/// </summary>
		public double? ConnectorPadding { get; set; }
		private double? ConnectorPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies the method that is used to generate the connector path.Highcharts provides 3 built-in connector shapes: `'fixedOffset'`(default), `'straight'` and `'crookedLine'`. Using `'crookedLine'`has the most sense (in most of the cases) when `'alignTo'` is set.Users can provide their own method by passing a function instead ofa String. 3 arguments are passed to the callback:<ol> <li>  Object that holds the information about the coordinates of the  label (`x` & `y` properties) and how the label is located in  relation to the pie (`alignment` property). `alignment` can by one  of the following:  `'left'` (pie on the left side of the data label),  `'right'` (pie on the right side of the data label) or  `'center'` (data label overlaps the pie). </li> <li>  Object that holds the information about the position of the  connector. Its `touchingSliceAt`  porperty tells the position of  the place where the connector touches the slice. </li> <li>  Data label options </li></ol>The function has to return an SVG path definition in array form(see the example).
		/// </summary>
		public string ConnectorShape { get; set; }
		private string ConnectorShape_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Works only if `connectorShape` is `'crookedLine'`. It defines how farfrom the vertical plot edge the coonnector path should be crooked.
		/// </summary>
		public string CrookDistance { get; set; }
		private string CrookDistance_DefaultValue { get; set; }
		 

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
		/// Whether to render the connector as a soft arc or a line with sharpbreak. Works only if `connectorShape` equals to `fixedOffset`.
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

			if (AlignTo != AlignTo_DefaultValue) h.Add("alignTo",AlignTo);
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (ConnectorColor != ConnectorColor_DefaultValue) h.Add("connectorColor",ConnectorColor);
			if (ConnectorPadding != ConnectorPadding_DefaultValue) h.Add("connectorPadding",ConnectorPadding);
			if (ConnectorShape != ConnectorShape_DefaultValue) h.Add("connectorShape",ConnectorShape);
			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			if (CrookDistance != CrookDistance_DefaultValue) h.Add("crookDistance",CrookDistance);
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