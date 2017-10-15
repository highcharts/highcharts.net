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
	public partial class VectorSeriesEvents  : BaseObject
	{
		public VectorSeriesEvents()
		{
			AfterAnimate = AfterAnimate_DefaultValue = "";
			CheckboxClick = CheckboxClick_DefaultValue = "";
			Click = Click_DefaultValue = "";
			Hide = Hide_DefaultValue = "";
			LegendItemClick = LegendItemClick_DefaultValue = "";
			MouseOut = MouseOut_DefaultValue = "";
			MouseOver = MouseOver_DefaultValue = "";
			Show = Show_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// <p>Fires after the series has finished its initial animation, or incase animation is disabled, immediately as the series is displayed.</p>
		/// </summary>
		public string AfterAnimate { get; set; }
		private string AfterAnimate_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the checkbox next to the series&#39; name in the legend isclicked. One parameter, <code>event</code>, is passed to the function. The stateof the checkbox is found by <code>event.checked</code>. The checked item isfound by <code>event.item</code>. Return <code>false</code> to prevent the default actionwhich is to toggle the select state of the series.</p>
		/// </summary>
		public string CheckboxClick { get; set; }
		private string CheckboxClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the series is clicked. One parameter, <code>event</code>, is passedto the function, containing common event information. Additionally,<code>event.point</code> holds a pointer to the nearest point on the graph.</p>
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the series is hidden after chart generation time, eitherby clicking the legend item or by calling <code>.hide()</code>.</p>
		/// </summary>
		public string Hide { get; set; }
		private string Hide_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the legend item belonging to the series is clicked. Oneparameter, <code>event</code>, is passed to the function. The default actionis to toggle the visibility of the series. This can be preventedby returning <code>false</code> or calling <code>event.preventDefault()</code>.</p>
		/// </summary>
		public string LegendItemClick { get; set; }
		private string LegendItemClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the mouse leaves the graph. One parameter, <code>event</code>, ispassed to the function, containing common event information. If the<a href="#plotOptions.series">stickyTracking</a> option is true, <code>mouseOut</code>doesn&#39;t happen before the mouse enters another graph or leaves theplot area.</p>
		/// </summary>
		public string MouseOut { get; set; }
		private string MouseOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the mouse enters the graph. One parameter, <code>event</code>, ispassed to the function, containing common event information.</p>
		/// </summary>
		public string MouseOver { get; set; }
		private string MouseOver_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the series is shown after chart generation time, eitherby clicking the legend item or by calling <code>.show()</code>.</p>
		/// </summary>
		public string Show { get; set; }
		private string Show_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterAnimate != AfterAnimate_DefaultValue) { h.Add("afterAnimate",AfterAnimate); Highstock.AddFunction("VectorSeriesEventsAfterAnimate.afterAnimate", AfterAnimate); }  
			if (CheckboxClick != CheckboxClick_DefaultValue) { h.Add("checkboxClick",CheckboxClick); Highstock.AddFunction("VectorSeriesEventsCheckboxClick.checkboxClick", CheckboxClick); }  
			if (Click != Click_DefaultValue) { h.Add("click",Click); Highstock.AddFunction("VectorSeriesEventsClick.click", Click); }  
			if (Hide != Hide_DefaultValue) { h.Add("hide",Hide); Highstock.AddFunction("VectorSeriesEventsHide.hide", Hide); }  
			if (LegendItemClick != LegendItemClick_DefaultValue) { h.Add("legendItemClick",LegendItemClick); Highstock.AddFunction("VectorSeriesEventsLegendItemClick.legendItemClick", LegendItemClick); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highstock.AddFunction("VectorSeriesEventsMouseOut.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highstock.AddFunction("VectorSeriesEventsMouseOver.mouseOver", MouseOver); }  
			if (Show != Show_DefaultValue) { h.Add("show",Show); Highstock.AddFunction("VectorSeriesEventsShow.show", Show); }  
			

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