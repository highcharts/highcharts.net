using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Highstock
{
	public partial class FlagsSeriesData  : BaseObject
	{
		public FlagsSeriesData()
		{
			Color = Color_DefaultValue = "undefined";
			Events = Events_DefaultValue = new FlagsSeriesDataEvents();
			Id = Id_DefaultValue = "null";
			Selected = Selected_DefaultValue = false;
			Text = Text_DefaultValue = null;
			Title = Title_DefaultValue = null;
			X = X_DefaultValue = double.MinValue;
			
		}	
		

		/// <summary>
		/// Individual color for the point.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public FlagsSeriesDataEvents Events { get; set; }
		private FlagsSeriesDataEvents Events_DefaultValue { get; set; }
		 

		/// <summary>
		/// An id for the point. This can be used after render time to get a pointer to the point object through <code>chart.get()</code>.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the data point is selected initially.
		/// </summary>
		public bool? Selected { get; set; }
		private bool? Selected_DefaultValue { get; set; }
		 

		/// <summary>
		/// The longer text to be shown in the flag's tooltip.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// The short text to be shown on the flag.
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x value of the point. For datetime axes, the X value is the timestamp in milliseconds since 1970.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Selected != Selected_DefaultValue) h.Add("selected",Selected);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (X != X_DefaultValue) h.Add("x",X);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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