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
	public partial class LegendBubbleLegendLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendBubbleLegendLabels()
		{
			Align = Align_DefaultValue = LegendBubbleLegendLabelsAlign.Right;
			AllowOverlap = AllowOverlap_DefaultValue = false;
			ClassName = ClassName_DefaultValue = "undefined";
			Format = Format_DefaultValue = "";
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = new Hashtable();
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The alignment of the labels compared to the bubblelegend. Can be one of `left`, `center` or `right`.
		/// </summary>
		public LegendBubbleLegendLabelsAlign Align { get; set; }
		private LegendBubbleLegendLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to allow data labels to overlap.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		private bool? AllowOverlap_DefaultValue { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the bubble legendlabel graphical elements. This option does not replacedefault class names of the graphical element.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// A format string for the bubble legend labels. Availablevariables are the same as for `formatter`.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// Available `this` properties are:- `this.value`: The bubble value.- `this.radius`: The radius of the bubble range.- `this.center`: The center y position of the range.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the labels.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to theconnector.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to theconnector.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != AllowOverlap_DefaultValue) h.Add("allowOverlap",AllowOverlap);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highcharts.AddFunction("7bbdbb70-cc39-4aac-ba3d-48a679d96643.formatter", Formatter); }  
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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