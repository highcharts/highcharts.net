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
	public partial class PyramidSeriesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PyramidSeriesEvents()
		{
			AfterAnimate = AfterAnimate_DefaultValue = "";
			CheckboxClick = CheckboxClick_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Hide = Hide_DefaultValue = "";
			LegendItemClick = LegendItemClick_DefaultValue = "";
			MouseOut = MouseOut_DefaultValue = "";
			MouseOver = MouseOver_DefaultValue = "";
			Show = Show_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Fires after the series has finished its initial animation, or in caseanimation is disabled, immediately as the series is displayed.
		/// </summary>
		public string AfterAnimate { get; set; }
		private string AfterAnimate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the checkbox next to the series' name in the legend isclicked. One parameter, `event`, is passed to the function. The stateof the checkbox is found by `event.checked`. The checked item isfound by `event.item`. Return `false` to prevent the default actionwhich is to toggle the select state of the series.
		/// </summary>
		public string CheckboxClick { get; set; }
		private string CheckboxClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the series is clicked. One parameter, `event`, is passedto the function, containing common event information. Additionally,`event.point` holds a pointer to the nearest point on the graph.
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the series is hidden after chart generation time, eitherby clicking the legend item or by calling `.hide()`.
		/// </summary>
		public string Hide { get; set; }
		private string Hide_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the legend item belonging to the series is clicked. Oneparameter, `event`, is passed to the function. The default actionis to toggle the visibility of the series. This can be preventedby returning `false` or calling `event.preventDefault()`.
		/// </summary>
		public string LegendItemClick { get; set; }
		private string LegendItemClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the mouse leaves the graph. One parameter, `event`, ispassed to the function, containing common event information. If the[stickyTracking](#plotOptions.series) option is true, `mouseOut`doesn't happen before the mouse enters another graph or leaves theplot area.
		/// </summary>
		public string MouseOut { get; set; }
		private string MouseOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the mouse enters the graph. One parameter, `event`, ispassed to the function, containing common event information.
		/// </summary>
		public string MouseOver { get; set; }
		private string MouseOver_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the series is shown after chart generation time, eitherby clicking the legend item or by calling `.show()`.
		/// </summary>
		public string Show { get; set; }
		private string Show_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (AfterAnimate != AfterAnimate_DefaultValue) { h.Add("afterAnimate",AfterAnimate); Highcharts.AddFunction("f8a37462-491c-46b0-9c54-b2b09c52c60a.afterAnimate", AfterAnimate); }  
			if (CheckboxClick != CheckboxClick_DefaultValue) { h.Add("checkboxClick",CheckboxClick); Highcharts.AddFunction("3d731877-51c0-4d44-80cd-ee36039584bf.checkboxClick", CheckboxClick); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("fac08157-6a39-4401-8682-5da0f59d9cac.click", Click); }  
			if (Hide != Hide_DefaultValue) { h.Add("hide",Hide); Highcharts.AddFunction("ad0751e9-3a19-425b-bcda-26e026931b31.hide", Hide); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highcharts.AddFunction("da1ef41a-d3ad-4e79-813b-06bc16e32763.legendItemClick", LegendItemClick); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("0c016afb-dc7b-41e4-b939-48b693277d67.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("c06ebbd3-0cb6-4aa0-bd4d-e6a186a2b47b.mouseOver", MouseOver); }  
			if (Show != Show_DefaultValue) { h.Add("show",Show); Highcharts.AddFunction("9a1354a4-f571-49e0-a528-ab8a96d306bd.show", Show); }  
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