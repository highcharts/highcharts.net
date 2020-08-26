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
	public partial class Funnel3dSeriesEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Funnel3dSeriesEvents()
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

			if (AfterAnimate != AfterAnimate_DefaultValue) { h.Add("afterAnimate",AfterAnimate); Highcharts.AddFunction("2a5efb8f-1ede-4aa1-93c4-d16a053060d1.afterAnimate", AfterAnimate); }  
			if (CheckboxClick != CheckboxClick_DefaultValue) { h.Add("checkboxClick",CheckboxClick); Highcharts.AddFunction("581305fd-35a9-40f7-95b6-4e53bf4a4d85.checkboxClick", CheckboxClick); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("f22bf2f8-801c-4013-af47-1025c021efcc.click", Click); }  
			if (Hide != Hide_DefaultValue) { h.Add("hide",Hide); Highcharts.AddFunction("88616751-cd49-4f7a-bec6-6e55ff0cd823.hide", Hide); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highcharts.AddFunction("00d3def1-2e89-4751-927b-4d236acf34d9.legendItemClick", LegendItemClick); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("a89dfb70-deff-45e6-b3ae-f49c8b8a26a4.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("e9e388bf-d205-48a8-89a4-ab8153acc431.mouseOver", MouseOver); }  
			if (Show != Show_DefaultValue) { h.Add("show",Show); Highcharts.AddFunction("fbe7d474-2d6e-41a5-b0d0-0a6e8b99bdbd.show", Show); }  
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