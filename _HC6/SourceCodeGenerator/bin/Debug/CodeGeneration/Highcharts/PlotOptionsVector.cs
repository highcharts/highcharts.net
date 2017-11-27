using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsVector  : BaseObject
	{
		public PlotOptionsVector()
		{
			LineWidth = LineWidth_DefaultValue = 2;
			RotationOrigin = RotationOrigin_DefaultValue = center;
			States = States_DefaultValue = null;
			Tooltip = Tooltip_DefaultValue = null;
			VectorLength = VectorLength_DefaultValue = 20;
			LineWidth = LineWidth_DefaultValue = 2;
			RotationOrigin = RotationOrigin_DefaultValue = center;
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			LineWidthPlus = LineWidthPlus_DefaultValue = 1;
			Tooltip = Tooltip_DefaultValue = "";
			PointFormat = PointFormat_DefaultValue = <b>[{point.x}, {point.y}]</b><br/>Length: <b>{point.length}</b><br/>Direction: <b>{point.direction}°</b><br/>;
			VectorLength = VectorLength_DefaultValue = 20;
			
		}	
		

		/// <summary>
		/// The line width for each vector arrow.
		/// </summary>
		public PlotOptionsVectorLineWidth LineWidth { get; set; }
		private PlotOptionsVectorLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the vector it should be rotated around. Can be one of`start`, `center` and `end`. When `start`, the vectors will start fromthe given [x, y] position, and when `end` the vectors will end in the[x, y] position.
		/// </summary>
		public PlotOptionsVectorRotationOrigin RotationOrigin { get; set; }
		private PlotOptionsVectorRotationOrigin RotationOrigin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorStates States { get; set; }
		private PlotOptionsVectorStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorTooltip Tooltip { get; set; }
		private PlotOptionsVectorTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum length of the arrows in the vector plot. The individual arrowlength is computed between 0 and this value.
		/// </summary>
		public PlotOptionsVectorVectorLength VectorLength { get; set; }
		private PlotOptionsVectorVectorLength VectorLength_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width for each vector arrow.
		/// </summary>
		public PlotOptionsVectorLineWidth LineWidth { get; set; }
		private PlotOptionsVectorLineWidth LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the vector it should be rotated around. Can be one of`start`, `center` and `end`. When `start`, the vectors will start fromthe given [x, y] position, and when `end` the vectors will end in the[x, y] position.
		/// </summary>
		public PlotOptionsVectorRotationOrigin RotationOrigin { get; set; }
		private PlotOptionsVectorRotationOrigin RotationOrigin_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorStates States { get; set; }
		private PlotOptionsVectorStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorHover Hover { get; set; }
		private PlotOptionsVectorHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additonal line width for the vector errors when they are hovered.
		/// </summary>
		public PlotOptionsVectorLineWidthPlus LineWidthPlus { get; set; }
		private PlotOptionsVectorLineWidthPlus LineWidthPlus_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorTooltip Tooltip { get; set; }
		private PlotOptionsVectorTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorPointFormat PointFormat { get; set; }
		private PlotOptionsVectorPointFormat PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Maximum length of the arrows in the vector plot. The individual arrowlength is computed between 0 and this value.
		/// </summary>
		public PlotOptionsVectorVectorLength VectorLength { get; set; }
		private PlotOptionsVectorVectorLength VectorLength_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (RotationOrigin != RotationOrigin_DefaultValue) h.Add("rotationOrigin",RotationOrigin);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (VectorLength != VectorLength_DefaultValue) h.Add("vectorLength",VectorLength);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (RotationOrigin != RotationOrigin_DefaultValue) h.Add("rotationOrigin",RotationOrigin);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (LineWidthPlus != LineWidthPlus_DefaultValue) h.Add("lineWidthPlus",LineWidthPlus);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (VectorLength != VectorLength_DefaultValue) h.Add("vectorLength",VectorLength);
			

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