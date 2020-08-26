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
	public partial class BarSeriesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public BarSeriesEvents()
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

			if (AfterAnimate != AfterAnimate_DefaultValue) { h.Add("afterAnimate",AfterAnimate); Highcharts.AddFunction("dd6d1e7f-54be-4ae8-822d-53d12fd7a06a.afterAnimate", AfterAnimate); }  
			if (CheckboxClick != CheckboxClick_DefaultValue) { h.Add("checkboxClick",CheckboxClick); Highcharts.AddFunction("4a774910-da31-4e37-b7dd-89432824b960.checkboxClick", CheckboxClick); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("c78f3e06-eed5-4334-a749-b25690dac21a.click", Click); }  
			if (Hide != Hide_DefaultValue) { h.Add("hide",Hide); Highcharts.AddFunction("e772e06b-a3b6-49dc-857d-cbf928392db5.hide", Hide); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highcharts.AddFunction("6e36ac09-208f-4b99-a218-a2fa38c095c0.legendItemClick", LegendItemClick); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("0aa4d626-daa6-473a-a7ee-8d0cd52914bf.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("f86f4767-2136-4172-94ae-a74ac0f7489b.mouseOver", MouseOver); }  
			if (Show != Show_DefaultValue) { h.Add("show",Show); Highcharts.AddFunction("c3c34e8d-2c73-4f2d-8820-b8aff002c307.show", Show); }  
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