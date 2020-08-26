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
	public partial class PlotOptionsAreasplinerangeEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsAreasplinerangeEvents()
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

			if (AfterAnimate != AfterAnimate_DefaultValue) { h.Add("afterAnimate",AfterAnimate); Highcharts.AddFunction("bdbcff18-96c6-46fc-8e45-71214ad4abda.afterAnimate", AfterAnimate); }  
			if (CheckboxClick != CheckboxClick_DefaultValue) { h.Add("checkboxClick",CheckboxClick); Highcharts.AddFunction("0befa2ee-be9b-4285-9a87-f8ccca8d7c3e.checkboxClick", CheckboxClick); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("873a59c5-309e-4117-aa49-68dba4f46804.click", Click); }  
			if (Hide != Hide_DefaultValue) { h.Add("hide",Hide); Highcharts.AddFunction("a6c16ab0-a058-4a21-bc6f-c07ceff15318.hide", Hide); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highcharts.AddFunction("822a864a-a1f7-4de6-bf8f-697086834295.legendItemClick", LegendItemClick); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("e75d7ef5-87e4-4838-8825-0c57c62cd53c.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("f806fba9-6d5e-4e05-9ba2-b5d637053480.mouseOver", MouseOver); }  
			if (Show != Show_DefaultValue) { h.Add("show",Show); Highcharts.AddFunction("c6c5f2f9-eff9-4a0a-b66e-94ad2227fbf8.show", Show); }  
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