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
	public partial class StreamgraphSeriesEvents  : BaseObject
	{
		public StreamgraphSeriesEvents()
		{
			AfterAnimate = AfterAnimate_DefaultValue = null;
			CheckboxClick = CheckboxClick_DefaultValue = null;
			Click = Click_DefaultValue = null;
			Hide = Hide_DefaultValue = null;
			LegendItemClick = LegendItemClick_DefaultValue = null;
			MouseOut = MouseOut_DefaultValue = null;
			MouseOver = MouseOver_DefaultValue = null;
			Show = Show_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Fires after the series has finished its initial animation, or incase animation is disabled, immediately as the series is displayed.</p>
		/// </summary>
		public function AfterAnimate { get; set; }
		private function AfterAnimate_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the checkbox next to the series&#39; name in the legend isclicked. One parameter, <code>event</code>, is passed to the function. The stateof the checkbox is found by <code>event.checked</code>. The checked item isfound by <code>event.item</code>. Return <code>false</code> to prevent the default actionwhich is to toggle the select state of the series.</p>
		/// </summary>
		public function CheckboxClick { get; set; }
		private function CheckboxClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the series is clicked. One parameter, <code>event</code>, is passedto the function, containing common event information. Additionally,<code>event.point</code> holds a pointer to the nearest point on the graph.</p>
		/// </summary>
		public function Click { get; set; }
		private function Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the series is hidden after chart generation time, eitherby clicking the legend item or by calling <code>.hide()</code>.</p>
		/// </summary>
		public function Hide { get; set; }
		private function Hide_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the legend item belonging to the series is clicked. Oneparameter, <code>event</code>, is passed to the function. The default actionis to toggle the visibility of the series. This can be preventedby returning <code>false</code> or calling <code>event.preventDefault()</code>.</p>
		/// </summary>
		public function LegendItemClick { get; set; }
		private function LegendItemClick_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the mouse leaves the graph. One parameter, <code>event</code>, ispassed to the function, containing common event information. If the<a href="#plotOptions.series">stickyTracking</a> option is true, <code>mouseOut</code>doesn&#39;t happen before the mouse enters another graph or leaves theplot area.</p>
		/// </summary>
		public function MouseOut { get; set; }
		private function MouseOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the mouse enters the graph. One parameter, <code>event</code>, ispassed to the function, containing common event information.</p>
		/// </summary>
		public function MouseOver { get; set; }
		private function MouseOver_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the series is shown after chart generation time, eitherby clicking the legend item or by calling <code>.show()</code>.</p>
		/// </summary>
		public function Show { get; set; }
		private function Show_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AfterAnimate != AfterAnimate_DefaultValue) h.Add("afterAnimate",AfterAnimate);
			if (CheckboxClick != CheckboxClick_DefaultValue) h.Add("checkboxClick",CheckboxClick);
			if (Click != Click_DefaultValue) h.Add("click",Click);
			if (Hide != Hide_DefaultValue) h.Add("hide",Hide);
			if (LegendItemClick != LegendItemClick_DefaultValue) h.Add("legendItemClick",LegendItemClick);
			if (MouseOut != MouseOut_DefaultValue) h.Add("mouseOut",MouseOut);
			if (MouseOver != MouseOver_DefaultValue) h.Add("mouseOver",MouseOver);
			if (Show != Show_DefaultValue) h.Add("show",Show);
			

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