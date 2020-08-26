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
	public partial class PlotOptionsBulletPointEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsBulletPointEvents()
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

			if (Click != Click_DefaultValue) { h.Add("click",Click); Highcharts.AddFunction("21081c87-2d22-4029-bf13-6d9694fdcbc8.click", Click); }  
			if (Drag != Drag_DefaultValue) { h.Add("drag",Drag); Highcharts.AddFunction("3b2c393e-2eef-49e3-8886-3a4287d6bb1e.drag", Drag); }  
			if (DragStart != DragStart_DefaultValue) { h.Add("dragStart",DragStart); Highcharts.AddFunction("9c2ef9ec-325a-44fb-b4b5-094ff31d23d6.dragStart", DragStart); }  
			if (Drop != Drop_DefaultValue) { h.Add("drop",Drop); Highcharts.AddFunction("4984a9ec-178e-4074-ba80-60d156b65683.drop", Drop); }  
			if (MouseOut != MouseOut_DefaultValue) { h.Add("mouseOut",MouseOut); Highcharts.AddFunction("4dd7fadc-6d91-425f-b531-fdba35c33d1b.mouseOut", MouseOut); }  
			if (MouseOver != MouseOver_DefaultValue) { h.Add("mouseOver",MouseOver); Highcharts.AddFunction("6b6b6779-4393-4b63-a0c6-dc2aeac63a8b.mouseOver", MouseOver); }  
			if (Remove != Remove_DefaultValue) { h.Add("remove",Remove); Highcharts.AddFunction("7f3fbecf-9cb8-441a-bcfb-8cb7566a8f16.remove", Remove); }  
			if (Select != Select_DefaultValue) { h.Add("select",Select); Highcharts.AddFunction("0eb20bb9-309f-4d44-ace1-3b2d8f5aeec0.select", Select); }  
			if (Unselect != Unselect_DefaultValue) { h.Add("unselect",Unselect); Highcharts.AddFunction("def98360-1f74-4769-9e5b-2193215b4388.unselect", Unselect); }  
			if (Update != Update_DefaultValue) { h.Add("update",Update); Highcharts.AddFunction("cdcf9274-2f3e-4b09-a1ea-78c937fa2f88.update", Update); }  
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