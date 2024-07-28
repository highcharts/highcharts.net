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
	public partial class TilemapSeriesDataDragDrop  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TilemapSeriesDataDragDrop()
		{
		}	
		

		/// <summary>
		/// Enable dragging in the X dimension.
		/// </summary>
		public bool? DraggableX { get; set; }
		 

		/// <summary>
		/// Enable dragging in the Y dimension. Note that this is not supported forTreeGrid axes (the default axis type in Gantt charts).
		/// </summary>
		public bool? DraggableY { get; set; }
		 

		/// <summary>
		/// Options for the drag handles available in column series.
		/// </summary>
		public TilemapSeriesDataDragDropDragHandle DragHandle { get; set; }
		 

		/// <summary>
		/// Set the maximum X value the points can be moved to.
		/// </summary>
		public double? DragMaxX { get; set; }
		 

		/// <summary>
		/// Set the maximum Y value the points can be moved to.
		/// </summary>
		public double? DragMaxY { get; set; }
		 

		/// <summary>
		/// Set the minimum X value the points can be moved to.
		/// </summary>
		public double? DragMinX { get; set; }
		 

		/// <summary>
		/// Set the minimum Y value the points can be moved to.
		/// </summary>
		public double? DragMinY { get; set; }
		 

		/// <summary>
		/// The X precision value to drag to for this series. Set to 0 to disable. Bydefault this is disabled, except for category axes, where the default is`1`.
		/// </summary>
		public double? DragPrecisionX { get; set; }
		 

		/// <summary>
		/// The Y precision value to drag to for this series. Set to 0 to disable. Bydefault this is disabled, except for category axes, where the default is`1`.
		/// </summary>
		public double? DragPrecisionY { get; set; }
		 

		/// <summary>
		/// The amount of pixels to drag the pointer before it counts as a dragoperation. This prevents drag/drop to fire when just clicking orselecting points.
		/// </summary>
		public double? DragSensitivity { get; set; }
		 

		/// <summary>
		/// Group the points by a property. Points with the same property value willbe grouped together when moving.
		/// </summary>
		public string GroupBy { get; set; }
		 

		/// <summary>
		/// Style options for the guide box. The guide box has one state by default,the `default` state.
		/// </summary>
		public TilemapSeriesDataDragDropGuideBox GuideBox { get; set; }
		 

		/// <summary>
		/// Update points as they are dragged. If false, a guide box is drawn toillustrate the new point size.
		/// </summary>
		public bool? LiveRedraw { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (DraggableX != null) h.Add("draggableX",DraggableX);
			if (DraggableY != null) h.Add("draggableY",DraggableY);
			if (DragHandle != null) h.Add("dragHandle",DragHandle.ToHashtable(highcharts));
			if (DragMaxX != null) h.Add("dragMaxX",DragMaxX);
			if (DragMaxY != null) h.Add("dragMaxY",DragMaxY);
			if (DragMinX != null) h.Add("dragMinX",DragMinX);
			if (DragMinY != null) h.Add("dragMinY",DragMinY);
			if (DragPrecisionX != null) h.Add("dragPrecisionX",DragPrecisionX);
			if (DragPrecisionY != null) h.Add("dragPrecisionY",DragPrecisionY);
			if (DragSensitivity != null) h.Add("dragSensitivity",DragSensitivity);
			if (GroupBy != null) h.Add("groupBy",GroupBy);
			if (GuideBox != null) h.Add("guideBox",GuideBox.ToHashtable(highcharts));
			if (LiveRedraw != null) h.Add("liveRedraw",LiveRedraw);
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