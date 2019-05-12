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
	public partial class ChartScrollablePlotArea  : BaseObject
	{
		public ChartScrollablePlotArea()
		{
			MinWidth = MinWidth_DefaultValue = null;
			Opacity = Opacity_DefaultValue = null;
			ScrollPositionX = ScrollPositionX_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The minimum width for the plot area. If it gets smaller than this, the plotarea will become scrollable.
		/// </summary>
		public double? MinWidth { get; set; }
		private double? MinWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of mask applied on one of the sides of the plotarea.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The initial scrolling position of the scrollable plot area. Ranges from 0 to1, where 0 aligns the plot area to the left and 1 aligns it to the right.Typically we would use 1 if the chart has right aligned Y axes.
		/// </summary>
		public double? ScrollPositionX { get; set; }
		private double? ScrollPositionX_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (MinWidth != MinWidth_DefaultValue) h.Add("minWidth",MinWidth);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (ScrollPositionX != ScrollPositionX_DefaultValue) h.Add("scrollPositionX",ScrollPositionX);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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