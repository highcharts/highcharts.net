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
	public partial class PlotOptionsVariwidePointEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVariwidePointEvents()
		{
		}	
		

		/// <summary>
		/// Fires when a point is clicked. One parameter, `event`, is passedto the function, containing common event information.If the `series.allowPointSelect` option is true, the defaultaction for the point's click event is to toggle the point'sselect state. Returning `false` cancels this action.
		/// </summary>
		public string Click { get; set; }
		 

		/// <summary>
		/// Callback that fires while dragging a point. The mouse event is passed inas parameter. The original data can be accessed from `e.origin`, and thenew point values can be accessed from `e.newPoints`. If there is only asingle point being updated, it can be accessed from `e.newPoint` forsimplicity, and its ID can be accessed from `e.newPointId`. The `this`context is the point being dragged. To stop the default drag action,return false. See [drag and drop options](plotOptions.series.dragDrop).
		/// </summary>
		public string Drag { get; set; }
		 

		/// <summary>
		/// Callback that fires when starting to drag a point. The mouse event objectis passed in as an argument. If a drag handle is used, `e.updateProp` isset to the data property being dragged. The `this` context is the point.See [drag and drop options](plotOptions.series.dragDrop).
		/// </summary>
		public string DragStart { get; set; }
		 

		/// <summary>
		/// Callback that fires when the point is dropped. The parameters passed arethe same as for [drag](#plotOptions.series.point.events.drag). To stopthe default drop action, return false. See[drag and drop options](plotOptions.series.dragDrop).
		/// </summary>
		public string Drop { get; set; }
		 

		/// <summary>
		/// Fires when the mouse leaves the area close to the point. Oneparameter, `event`, is passed to the function, containing commonevent information.
		/// </summary>
		public string MouseOut { get; set; }
		 

		/// <summary>
		/// Fires when the mouse enters the area close to the point. Oneparameter, `event`, is passed to the function, containing commonevent information.Returning `false` cancels the default behavior, which is to show atooltip for the point.
		/// </summary>
		public string MouseOver { get; set; }
		 

		/// <summary>
		/// Fires when the point is removed using the `.remove()` method. Oneparameter, `event`, is passed to the function. Returning `false`cancels the operation.
		/// </summary>
		public string Remove { get; set; }
		 

		/// <summary>
		/// Fires when the point is selected either programmatically orfollowing a click on the point. One parameter, `event`, is passedto the function. Returning `false` cancels the operation.
		/// </summary>
		public string Select { get; set; }
		 

		/// <summary>
		/// Fires when the point is unselected either programmatically orfollowing a click on the point. One parameter, `event`, is passedto the function. Returning `false` cancels the operation.
		/// </summary>
		public string Unselect { get; set; }
		 

		/// <summary>
		/// Fires when the point is updated programmatically through the`.update()` method. One parameter, `event`, is passed to thefunction. The new point options can be accessed through`event.options`. Returning `false` cancels the operation.
		/// </summary>
		public string Update { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Click != null) { h.Add("click",Click); highcharts.AddFunction("click", Click); }  
			if (Drag != null) { h.Add("drag",Drag); highcharts.AddFunction("drag", Drag); }  
			if (DragStart != null) { h.Add("dragStart",DragStart); highcharts.AddFunction("dragStart", DragStart); }  
			if (Drop != null) { h.Add("drop",Drop); highcharts.AddFunction("drop", Drop); }  
			if (MouseOut != null) { h.Add("mouseOut",MouseOut); highcharts.AddFunction("mouseOut", MouseOut); }  
			if (MouseOver != null) { h.Add("mouseOver",MouseOver); highcharts.AddFunction("mouseOver", MouseOver); }  
			if (Remove != null) { h.Add("remove",Remove); highcharts.AddFunction("remove", Remove); }  
			if (Select != null) { h.Add("select",Select); highcharts.AddFunction("select", Select); }  
			if (Unselect != null) { h.Add("unselect",Unselect); highcharts.AddFunction("unselect", Unselect); }  
			if (Update != null) { h.Add("update",Update); highcharts.AddFunction("update", Update); }  
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