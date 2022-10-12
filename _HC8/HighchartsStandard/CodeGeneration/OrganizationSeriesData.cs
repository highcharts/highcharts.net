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
	public partial class OrganizationSeriesData  : BaseObject
	{
		Hashtable h = new Hashtable();

		public OrganizationSeriesData()
		{
			Accessibility = Accessibility_DefaultValue = new OrganizationSeriesDataAccessibility();
			ClassName = ClassName_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Custom = Custom_DefaultValue = new Hashtable();
			Description = Description_DefaultValue = "";
			Events = Events_DefaultValue = new OrganizationSeriesDataEvents();
			From = From_DefaultValue = "";
			Id = Id_DefaultValue = "";
			Labelrank = Labelrank_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Selected = Selected_DefaultValue = false;
			To = To_DefaultValue = "";
			Weight = Weight_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Accessibility options for a data point.
		/// </summary>
		public OrganizationSeriesDataAccessibility Accessibility { get; set; }
		private OrganizationSeriesDataAccessibility Accessibility_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional, individual class name for the data point's graphicrepresentation.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual color for the point. By default the color is pulled fromthe global `colors` array.In styled mode, the `color` option doesn't take effect. Instead, use`colorIndex`.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// A specific color index to use for the point, so its graphic representationsare given the class name `highcharts-color-{n}`. In styled mode this willchange the color of the graphic. In non-styled mode, the color by is set bythe `fill` attribute, so the change in class name won't have a visual effectby default.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// A reserved subspace to store options and values for customized functionality.Here you can add additional data for your own event callbacks and formattercallbacks.
		/// </summary>
		public Hashtable Custom { get; set; }
		private Hashtable Custom_DefaultValue { get; set; }
		 

		/// <summary>
		/// A description of the point to add to the screen reader informationabout the point.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// The individual point events.
		/// </summary>
		public OrganizationSeriesDataEvents Events { get; set; }
		private OrganizationSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get apointer to the point object through `chart.get()`.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The rank for this point's data label in case of collision. If twodata labels are about to overlap, only the one with the highest `labelrank`will be drawn.
		/// </summary>
		public double? Labelrank { get; set; }
		private double? Labelrank_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the point as shown in the legend, tooltip, dataLabels, etc.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Accessibility.IsDirty(ref highcharts)) h.Add("accessibility",Accessibility.ToHashtable(ref highcharts));
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Custom != Custom_DefaultValue) h.Add("custom",Custom);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Events.IsDirty(ref highcharts)) h.Add("events",Events.ToHashtable(ref highcharts));
			if (From != From_DefaultValue) h.Add("from",From);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
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