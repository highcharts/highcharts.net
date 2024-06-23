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
	public partial class GlobalButtonTheme  : BaseObject
	{
		Hashtable h = new Hashtable();

		public GlobalButtonTheme()
		{
			Fill = Fill_DefaultValue = "#f7f7f7";
			Padding = Padding_DefaultValue = 8;
			R = R_DefaultValue = 2;
			States = States_DefaultValue = new GlobalButtonThemeStates();
			Stroke = Stroke_DefaultValue = "#cccccc";
			StrokeWidth = StrokeWidth_DefaultValue = 1;
			Style = Style_DefaultValue = new Hashtable();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The fill color for buttons
		/// </summary>
		public string Fill { get; set; }
		private string Fill_DefaultValue { get; set; }
		 

		/// <summary>
		/// The padding of buttons
		/// </summary>
		public double? Padding { get; set; }
		private double? Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border radius for buttons
		/// </summary>
		public double? R { get; set; }
		private double? R_DefaultValue { get; set; }
		 

		/// <summary>
		/// State overrides for the buttons
		/// </summary>
		public GlobalButtonThemeStates States { get; set; }
		private GlobalButtonThemeStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The stroke color for buttons
		/// </summary>
		public string Stroke { get; set; }
		private string Stroke_DefaultValue { get; set; }
		 

		/// <summary>
		/// The stroke width for buttons
		/// </summary>
		public double? StrokeWidth { get; set; }
		private double? StrokeWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styling for the buttons' text
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Fill != Fill_DefaultValue) h.Add("fill",Fill);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (R != R_DefaultValue) h.Add("r",R);
			if (States.IsDirty(highstock)) h.Add("states",States.ToHashtable(highstock));
			if (Stroke != Stroke_DefaultValue) h.Add("stroke",Stroke);
			if (StrokeWidth != StrokeWidth_DefaultValue) h.Add("strokeWidth",StrokeWidth);
			if (Style != Style_DefaultValue) h.Add("style",Style);
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