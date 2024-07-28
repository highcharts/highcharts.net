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
	public partial class LegendBubbleLegendLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LegendBubbleLegendLabels()
		{
		}	
		

		/// <summary>
		/// The alignment of the labels compared to the bubblelegend. Can be one of `left`, `center` or `right`.
		/// </summary>
		public LegendBubbleLegendLabelsAlign Align { get; set; }
		 

		/// <summary>
		/// Whether to allow data labels to overlap.
		/// </summary>
		public bool? AllowOverlap { get; set; }
		 

		/// <summary>
		/// An additional class name to apply to the bubble legendlabel graphical elements. This option does not replacedefault class names of the graphical element.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// A format string for the bubble legend labels. Availablevariables are the same as for `formatter`.
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// Available `this` properties are:- `this.value`: The bubble value.- `this.radius`: The radius of the bubble range.- `this.center`: The center y position of the range.
		/// </summary>
		public string Formatter { get; set; }
		 

		/// <summary>
		/// CSS styles for the labels.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to theconnector.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to theconnector.
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != LegendBubbleLegendLabelsAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (AllowOverlap != null) h.Add("allowOverlap",AllowOverlap);
			if (ClassName != null) h.Add("className",ClassName);
			if (Format != null) h.Add("format",Format);
			if (Formatter != null) { h.Add("formatter",Formatter); highstock.AddFunction("formatter", Formatter); }  
			if (Style != null) h.Add("style",Style);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}