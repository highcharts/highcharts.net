using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class ColumnrangeSeriesData  : BaseObject
	{
		public ColumnrangeSeriesData()
		{
			High = High_DefaultValue = null;
			Low = Low_DefaultValue = null;
			Color = Color_DefaultValue = "undefined";
			DataLabels = DataLabels_DefaultValue = new ColumnrangeSeriesDataLabels();
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Name = Name_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			Events = Events_DefaultValue = new ColumnrangeSeriesDataEvents();
			
		}	
		

		/// <summary>
		/// <p>The high or maximum value for each data point.</p>
		/// </summary>
		public double? High { get; set; }
		private double? High_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The low or minimum value for each data point.</p>
		/// </summary>
		public double? Low { get; set; }
		private double? Low_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual color for the point. By default the color is pulled fromthe global <code>colors</code> array.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual data label for each point. The options are the same asthe ones for <a href="#plotOptions.series.dataLabels">plotOptions.series.dataLabels</a></p>
		/// </summary>
		public ColumnrangeSeriesDataLabels DataLabels { get; set; }
		private ColumnrangeSeriesDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A description of the point to add to the screen reader informationabout the point. Requires the Accessibility module.</p>
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An id for the point. This can be used after render time to get apointer to the point object through <code>chart.get()</code>.</p>
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The rank for this point&#39;s data label in case of collision. If twodata labels are about to overlap, only the one with the highest <code>labelrank</code>will be drawn.</p>
		/// </summary>
		public double? Labelrank { get; set; }
		private double? Labelrank_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The name of the point as shown in the legend, tooltip, dataLabeletc.</p>
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether the data point is selected initially.</p>
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x value of the point. For datetime axes, the X value is the timestampin milliseconds since 1970.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual point events</p>
		/// </summary>
		public ColumnrangeSeriesDataEvents Events { get; set; }
		private ColumnrangeSeriesDataEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (High != High_DefaultValue) h.Add("high",High);
			if (Low != Low_DefaultValue) h.Add("low",Low);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			

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