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
	public partial class ColorAxisPlotBands  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColorAxisPlotBands()
		{
			AcrossPanes = AcrossPanes_DefaultValue = true;
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = 0;
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "#e6ebf5";
			Events = Events_DefaultValue = new ColorAxisPlotBandsEvents();
			From = From_DefaultValue = null;
			Id = Id_DefaultValue = "";
			Label = Label_DefaultValue = new ColorAxisPlotBandsLabel();
			To = To_DefaultValue = null;
			ZIndex = ZIndex_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Flag to decide if plotBand should be rendered across all panes.
		/// </summary>
		public bool? AcrossPanes { get; set; }
		private bool? AcrossPanes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border color for the plot band. Also requires `borderWidth` to be set.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Border width for the plot band. Also requires `borderColor` to be set.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// A custom class name, in addition to the default `highcharts-plot-band`,to apply to each individual band.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the plot band.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object defining mouse events for the plot band. Supported propertiesare `click`, `mouseover`, `mouseout`, `mousemove`.
		/// </summary>
		public ColorAxisPlotBandsEvents Events { get; set; }
		private ColorAxisPlotBandsEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start position of the plot band in axis units.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id used for identifying the plot band in Axis.removePlotBand.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Text labels for the plot bands
		/// </summary>
		public ColorAxisPlotBandsLabel Label { get; set; }
		private ColorAxisPlotBandsLabel Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end position of the plot band in axis units.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		/// <summary>
		/// The z index of the plot band within the chart, relative to otherelements. Using the same z index as another element may giveunpredictable results, as the last rendered element will be on top.Values from 0 to 20 make sense.
		/// </summary>
		public double? ZIndex { get; set; }
		private double? ZIndex_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (AcrossPanes != AcrossPanes_DefaultValue) h.Add("acrossPanes",AcrossPanes);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Events.IsDirty(highcharts)) h.Add("events",Events.ToHashtable(highcharts));
			if (From != From_DefaultValue) h.Add("from",From);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Label.IsDirty(highcharts)) h.Add("label",Label.ToHashtable(highcharts));
			if (To != To_DefaultValue) h.Add("to",To);
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
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