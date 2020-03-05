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
	public partial class VariablepieSeriesPointEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VariablepieSeriesPointEvents()
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
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("2242efe7-825d-434e-9a4d-c988ccc9c25f.click", Click); }  
			if (Drag != Drag_DefaultValue) { h.Add("drag",Drag); Highcharts.AddFunction("656a4f62-0a89-4f0b-a908-e218bff800bd.drag", Drag); }  
			if (DragStart != DragStart_DefaultValue) { h.Add("dragStart",DragStart); Highcharts.AddFunction("4452e6ea-6ea3-4d0d-a28c-9a2b64d58374.dragStart", DragStart); }  
			if (Drop != Drop_DefaultValue) { h.Add("drop",Drop); Highcharts.AddFunction("c2ce1722-3fb2-482f-86c3-37e296fc9453.drop", Drop); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("f651ade4-b1cb-4c64-94ca-2bab2e690422.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("6a59b7b3-026d-469f-9d87-df894698cb87.mouseOver", MouseOver); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); Highcharts.AddFunction("5c6dae5c-58f6-4681-acba-0b54400e5971.remove", Remove); }  
			if (Select != Select_DefaultValue) { h.Add("select",Select); Highcharts.AddFunction("58dd93a8-f11d-4d4d-bea6-d76e6a3210fb.select", Select); }  
			if (Unselect != Unselect_DefaultValue) { h.Add("unselect",Unselect); Highcharts.AddFunction("86d8687f-d852-42b4-b6a8-6f84fc6a9efa.unselect", Unselect); }  
			if (Update != Update_DefaultValue) { h.Add("update",Update); Highcharts.AddFunction("25744b09-f4e1-46fa-b00c-3e9ea038dc59.update", Update); }  
			

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