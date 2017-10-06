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
	public partial class FlagsSeriesData  : BaseObject
	{
		public FlagsSeriesData()
		{
			FillColor = FillColor_DefaultValue = null;
			Text = Text_DefaultValue = null;
			Title = Title_DefaultValue = null;
			Color = Color_DefaultValue = "undefined";
			Description = Description_DefaultValue = "undefined";
			Id = Id_DefaultValue = "null";
			Labelrank = Labelrank_DefaultValue = null;
			Selected = Selected_DefaultValue = false;
			X = X_DefaultValue = double.MinValue;
			Events = Events_DefaultValue = new FlagsSeriesDataEvents();
			
		}	
		

		/// <summary>
		/// <p>The fill color of an individual flag. By default it inherits fromthe series color.</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The longer text to be shown in the flag&#39;s tooltip.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The short text to be shown on the flag.</p>
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Individual color for the point. By default the color is pulled fromthe global <code>colors</code> array.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

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
		public FlagsSeriesDataEvents Events { get; set; }
		private FlagsSeriesDataEvents Events_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Labelrank != Labelrank_DefaultValue) h.Add("labelrank",Labelrank);
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