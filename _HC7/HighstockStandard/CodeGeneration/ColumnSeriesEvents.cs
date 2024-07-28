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
	public partial class ColumnSeriesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnSeriesEvents()
		{
		}	
		

		/// <summary>
		/// Fires after the series has finished its initial animation, or in caseanimation is disabled, immediately as the series is displayed.
		/// </summary>
		public string AfterAnimate { get; set; }
		 

		/// <summary>
		/// Fires when the checkbox next to the series' name in the legend isclicked. One parameter, `event`, is passed to the function. The stateof the checkbox is found by `event.checked`. The checked item isfound by `event.item`. Return `false` to prevent the default actionwhich is to toggle the select state of the series.
		/// </summary>
		public string CheckboxClick { get; set; }
		 

		/// <summary>
		/// Fires when the series is clicked. One parameter, `event`, is passedto the function, containing common event information. Additionally,`event.point` holds a pointer to the nearest point on the graph.
		/// </summary>
		public string Click { get; set; }
		 

		/// <summary>
		/// Fires when the series is hidden after chart generation time, eitherby clicking the legend item or by calling `.hide()`.
		/// </summary>
		public string Hide { get; set; }
		 

		/// <summary>
		/// Fires when the legend item belonging to the series is clicked. Oneparameter, `event`, is passed to the function. The default actionis to toggle the visibility of the series. This can be preventedby returning `false` or calling `event.preventDefault()`.**Note:** This option is deprecated in favor of[legend.events.itemClick](#legend.events.itemClick).
		/// </summary>
		public string LegendItemClick { get; set; }
		 

		/// <summary>
		/// Fires when the mouse leaves the graph. One parameter, `event`, ispassed to the function, containing common event information. If the[stickyTracking](#plotOptions.series) option is true, `mouseOut`doesn't happen before the mouse enters another graph or leaves theplot area.
		/// </summary>
		public string MouseOut { get; set; }
		 

		/// <summary>
		/// Fires when the mouse enters the graph. One parameter, `event`, ispassed to the function, containing common event information.
		/// </summary>
		public string MouseOver { get; set; }
		 

		/// <summary>
		/// Fires when the series is shown after chart generation time, eitherby clicking the legend item or by calling `.show()`.
		/// </summary>
		public string Show { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (AfterAnimate != null) { h.Add("afterAnimate",AfterAnimate); highstock.AddFunction("afterAnimate", AfterAnimate); }  
			if (CheckboxClick != null) { h.Add("checkboxClick",CheckboxClick); highstock.AddFunction("checkboxClick", CheckboxClick); }  
			if (Click != null) { h.Add("click",Click); highstock.AddFunction("click", Click); }  
			if (Hide != null) { h.Add("hide",Hide); highstock.AddFunction("hide", Hide); }  
			if (LegendItemClick != null) { h.Add("legendItemClick",LegendItemClick); highstock.AddFunction("legendItemClick", LegendItemClick); }  
			if (MouseOut != null) { h.Add("mouseOut",MouseOut); highstock.AddFunction("mouseOut", MouseOut); }  
			if (MouseOver != null) { h.Add("mouseOver",MouseOver); highstock.AddFunction("mouseOver", MouseOver); }  
			if (Show != null) { h.Add("show",Show); highstock.AddFunction("show", Show); }  
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