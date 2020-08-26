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
	public partial class PlotOptionsWaterfallEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWaterfallEvents()
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

			if (AfterAnimate != AfterAnimate_DefaultValue) { h.Add("afterAnimate",AfterAnimate); Highcharts.AddFunction("15c54511-b21e-417c-b7d2-6583215e66ed.afterAnimate", AfterAnimate); }  
			if (CheckboxClick != CheckboxClick_DefaultValue) { h.Add("checkboxClick",CheckboxClick); Highcharts.AddFunction("f905b4e5-2385-41e3-a750-23beca5d9043.checkboxClick", CheckboxClick); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("3e2487d6-b2ff-4282-8923-96e528870c57.click", Click); }  
			if (Hide != Hide_DefaultValue) { h.Add("hide",Hide); Highcharts.AddFunction("9e75012a-e5ff-4a25-bc5c-3b553199fb10.hide", Hide); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highcharts.AddFunction("6dcb769e-dec1-4efc-8028-14b08da310e0.legendItemClick", LegendItemClick); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("c21b84b7-561a-4717-af40-da5c0fad7e28.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("621a924a-0a7d-4c3d-8efd-2151224fbeca.mouseOver", MouseOver); }  
			if (Show != Show_DefaultValue) { h.Add("show",Show); Highcharts.AddFunction("d61f1633-4733-4377-a5ec-a7b0001893ba.show", Show); }  
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