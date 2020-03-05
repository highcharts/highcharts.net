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
	public partial class XrangeSeriesDataDragDrop  : BaseObject
	{
		Hashtable h = new Hashtable();

		public XrangeSeriesDataDragDrop()
		{
			DraggableX = DraggableX_DefaultValue = null;
			DraggableY = DraggableY_DefaultValue = null;
			DragHandle = DragHandle_DefaultValue = new XrangeSeriesDataDragDropDragHandle();
			DragMaxX = DragMaxX_DefaultValue = null;
			DragMaxY = DragMaxY_DefaultValue = null;
			DragMinX = DragMinX_DefaultValue = null;
			DragMinY = DragMinY_DefaultValue = null;
			DragPrecisionX = DragPrecisionX_DefaultValue = 0;
			DragPrecisionY = DragPrecisionY_DefaultValue = 0;
			DragSensitivity = DragSensitivity_DefaultValue = 2;
			GroupBy = GroupBy_DefaultValue = "";
			GuideBox = GuideBox_DefaultValue = new XrangeSeriesDataDragDropGuideBox();
			LiveRedraw = LiveRedraw_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// Enable dragging in the X dimension.
		/// </summary>
		public bool? DraggableX { get; set; }
		private bool? DraggableX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable dragging in the Y dimension. Note that this is not supported forTreeGrid axes (the default axis type in Gantt charts).
		/// </summary>
		public bool? DraggableY { get; set; }
		private bool? DraggableY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the drag handles.
		/// </summary>
		public XrangeSeriesDataDragDropDragHandle DragHandle { get; set; }
		private XrangeSeriesDataDragDropDragHandle DragHandle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the maximum X value the points can be moved to.
		/// </summary>
		public double? DragMaxX { get; set; }
		private double? DragMaxX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the maximum Y value the points can be moved to.
		/// </summary>
		public double? DragMaxY { get; set; }
		private double? DragMaxY_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the minimum X value the points can be moved to.
		/// </summary>
		public double? DragMinX { get; set; }
		private double? DragMinX_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the minimum Y value the points can be moved to.
		/// </summary>
		public double? DragMinY { get; set; }
		private double? DragMinY_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X precision value to drag to for this series. Set to 0 to disable. Bydefault this is disabled, except for category axes, where the default is 1.
		/// </summary>
		public double? DragPrecisionX { get; set; }
		private double? DragPrecisionX_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y precision value to drag to for this series. Set to 0 to disable. Bydefault this is disabled, except for category axes, where the default is 1.
		/// </summary>
		public double? DragPrecisionY { get; set; }
		private double? DragPrecisionY_DefaultValue { get; set; }
		 

		/// <summary>
		/// The amount of pixels to drag the pointer before it counts as a dragoperation. This prevents drag/drop to fire when just clicking or selectingpoints.
		/// </summary>
		public double? DragSensitivity { get; set; }
		private double? DragSensitivity_DefaultValue { get; set; }
		 

		/// <summary>
		/// Group the points by a property. Points with the same property value will begrouped together when moving.
		/// </summary>
		public string GroupBy { get; set; }
		private string GroupBy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Style options for the guide box. The guide box has one state by default, the`default` state.
		/// </summary>
		public XrangeSeriesDataDragDropGuideBox GuideBox { get; set; }
		private XrangeSeriesDataDragDropGuideBox GuideBox_DefaultValue { get; set; }
		 

		/// <summary>
		/// Update points as they are dragged. If false, a guide box is drawn toillustrate the new point size.
		/// </summary>
		public bool? LiveRedraw { get; set; }
		private bool? LiveRedraw_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (DraggableX != DraggableX_DefaultValue) h.Add("draggableX",DraggableX);
			if (DraggableY != DraggableY_DefaultValue) h.Add("draggableY",DraggableY);
			if (DragHandle.IsDirty()) h.Add("dragHandle",DragHandle.ToHashtable());
			if (DragMaxX != DragMaxX_DefaultValue) h.Add("dragMaxX",DragMaxX);
			if (DragMaxY != DragMaxY_DefaultValue) h.Add("dragMaxY",DragMaxY);
			if (DragMinX != DragMinX_DefaultValue) h.Add("dragMinX",DragMinX);
			if (DragMinY != DragMinY_DefaultValue) h.Add("dragMinY",DragMinY);
			if (DragPrecisionX != DragPrecisionX_DefaultValue) h.Add("dragPrecisionX",DragPrecisionX);
			if (DragPrecisionY != DragPrecisionY_DefaultValue) h.Add("dragPrecisionY",DragPrecisionY);
			if (DragSensitivity != DragSensitivity_DefaultValue) h.Add("dragSensitivity",DragSensitivity);
			if (GroupBy != GroupBy_DefaultValue) h.Add("groupBy",GroupBy);
			if (GuideBox != GuideBox_DefaultValue) h.Add("guideBox",GuideBox);
			if (LiveRedraw != LiveRedraw_DefaultValue) h.Add("liveRedraw",LiveRedraw);
			

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