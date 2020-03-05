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
	public partial class ColumnpyramidSeriesPointEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ColumnpyramidSeriesPointEvents()
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

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("ff2c5359-863e-4503-b84f-cf532879d69b.click", Click); }  
			if (Drag != Drag_DefaultValue) { h.Add("drag",Drag); Highcharts.AddFunction("8006fe1f-ea26-4f50-8906-5f63a13c76e4.drag", Drag); }  
			if (DragStart != DragStart_DefaultValue) { h.Add("dragStart",DragStart); Highcharts.AddFunction("80a79974-b9df-4ebf-9022-7869de4feca4.dragStart", DragStart); }  
			if (Drop != Drop_DefaultValue) { h.Add("drop",Drop); Highcharts.AddFunction("d83d0006-50f4-4b8a-8383-e2d6ee416068.drop", Drop); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("39928945-dfe1-4768-909f-f9b340f1843c.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("a11f0368-0302-4251-8cd7-19ce3b1b4458.mouseOver", MouseOver); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); Highcharts.AddFunction("de598a44-d9d0-45ca-b568-4f5442b0fbc8.remove", Remove); }  
			if (Select != Select_DefaultValue) { h.Add("select",Select); Highcharts.AddFunction("5b8f1abd-1fb3-4bbe-9695-178feb9d22cf.select", Select); }  
			if (Unselect != Unselect_DefaultValue) { h.Add("unselect",Unselect); Highcharts.AddFunction("cbac01cf-4d7c-4b0c-80c9-67d24a90fcf9.unselect", Unselect); }  
			if (Update != Update_DefaultValue) { h.Add("update",Update); Highcharts.AddFunction("7751118f-b495-4c6b-9104-b7b0e2678a40.update", Update); }  
			

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