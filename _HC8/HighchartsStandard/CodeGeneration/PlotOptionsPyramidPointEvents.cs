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
	public partial class PlotOptionsPyramidPointEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPyramidPointEvents()
		{
			Click = Click_DefaultValue = "";
			Drag = Drag_DefaultValue = "";
			DragStart = DragStart_DefaultValue = "";
			Drop = Drop_DefaultValue = "";
			MouseOut = MouseOut_DefaultValue = "";
			MouseOver = MouseOver_DefaultValue = "";
			Remove = Remove_DefaultValue = "";
			Select = Select_DefaultValue = "";
			Unselect = Unselect_DefaultValue = "";
			Update = Update_DefaultValue = "";
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Fires when a point is clicked. One parameter, `event`, is passedto the function, containing common event information.If the `series.allowPointSelect` option is true, the defaultaction for the point's click event is to toggle the point'sselect state. Returning `false` cancels this action.
		/// </summary>
		public string Click { get; set; }
		private string Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback that fires while dragging a point. The mouse event is passed in asparameter. The original data can be accessed from `e.origin`, and the newpoint values can be accessed from `e.newPoints`. If there is only a singlepoint being updated, it can be accessed from `e.newPoint` for simplicity, andits ID can be accessed from `e.newPointId`. The `this` context is the pointbeing dragged. To stop the default drag action, return false. See[drag and drop options](plotOptions.series.dragDrop).
		/// </summary>
		public string Drag { get; set; }
		private string Drag_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback that fires when starting to drag a point. The mouse event object ispassed in as an argument. If a drag handle is used, `e.updateProp` is set tothe data property being dragged. The `this` context is the point. See[drag and drop options](plotOptions.series.dragDrop).
		/// </summary>
		public string DragStart { get; set; }
		private string DragStart_DefaultValue { get; set; }
		 

		/// <summary>
		/// Callback that fires when the point is dropped. The parameters passed are thesame as for [drag](#plotOptions.series.point.events.drag). To stop thedefault drop action, return false. See[drag and drop options](plotOptions.series.dragDrop).
		/// </summary>
		public string Drop { get; set; }
		private string Drop_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the mouse leaves the area close to the point. Oneparameter, `event`, is passed to the function, containing commonevent information.
		/// </summary>
		public string MouseOut { get; set; }
		private string MouseOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the mouse enters the area close to the point. Oneparameter, `event`, is passed to the function, containing commonevent information.
		/// </summary>
		public string MouseOver { get; set; }
		private string MouseOver_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the point is removed using the `.remove()` method. Oneparameter, `event`, is passed to the function. Returning `false`cancels the operation.
		/// </summary>
		public string Remove { get; set; }
		private string Remove_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the point is selected either programmatically orfollowing a click on the point. One parameter, `event`, is passedto the function. Returning `false` cancels the operation.
		/// </summary>
		public string Select { get; set; }
		private string Select_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the point is unselected either programmatically orfollowing a click on the point. One parameter, `event`, is passedto the function. Returning `false` cancels the operation.
		/// </summary>
		public string Unselect { get; set; }
		private string Unselect_DefaultValue { get; set; }
		 

		/// <summary>
		/// Fires when the point is updated programmatically through the`.update()` method. One parameter, `event`, is passed to thefunction. The new point options can be accessed through`event.options`. Returning `false` cancels the operation.
		/// </summary>
		public string Update { get; set; }
		private string Update_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("8dee59c1-01d0-4279-ada7-e14aca70d34e.click", Click); }  
			if (Drag != Drag_DefaultValue) { h.Add("drag",Drag); Highcharts.AddFunction("e7a0f882-976f-429a-8ec5-9f2d70eab84c.drag", Drag); }  
			if (DragStart != DragStart_DefaultValue) { h.Add("dragStart",DragStart); Highcharts.AddFunction("5be5a5f8-94e2-4c76-a2ca-d97468491a2e.dragStart", DragStart); }  
			if (Drop != Drop_DefaultValue) { h.Add("drop",Drop); Highcharts.AddFunction("4db8bf8f-4490-482d-ac8f-d8abe421b4c3.drop", Drop); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("69b43b1a-bc8f-4df2-b9ff-6164f9ef0184.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("f5f3826e-98d2-4072-82dc-ed0ce91a5c18.mouseOver", MouseOver); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); Highcharts.AddFunction("3dbdef13-cbfa-4808-8fd5-8b0081c19b5d.remove", Remove); }  
			if (Select != Select_DefaultValue) { h.Add("select",Select); Highcharts.AddFunction("cf9cc87c-9b12-44f5-ae3e-71b8ee7c9bb1.select", Select); }  
			if (Unselect != Unselect_DefaultValue) { h.Add("unselect",Unselect); Highcharts.AddFunction("a154424e-a84c-4b77-b770-1bcdd61a55b7.unselect", Unselect); }  
			if (Update != Update_DefaultValue) { h.Add("update",Update); Highcharts.AddFunction("2d494a2d-4787-400d-8ca1-e3c50df4755d.update", Update); }  
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