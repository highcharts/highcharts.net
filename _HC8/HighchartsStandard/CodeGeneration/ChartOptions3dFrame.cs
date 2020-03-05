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
	public partial class ChartOptions3dFrame  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ChartOptions3dFrame()
		{
			Back = Back_DefaultValue = new ChartOptions3dFrameBack();
			Bottom = Bottom_DefaultValue = new ChartOptions3dFrameBottom();
			Front = Front_DefaultValue = new ChartOptions3dFrameFront();
			Left = Left_DefaultValue = new ChartOptions3dFrameLeft();
			Right = Right_DefaultValue = new ChartOptions3dFrameRight();
			Side = Side_DefaultValue = new ChartOptions3dFrameSide();
			Size = Size_DefaultValue = 1;
			Top = Top_DefaultValue = new ChartOptions3dFrameTop();
			Visible = Visible_DefaultValue = "default";
			
		}	
		

		/// <summary>
		/// The back side of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameBack Back { get; set; }
		private ChartOptions3dFrameBack Back_DefaultValue { get; set; }
		 

		/// <summary>
		/// The bottom of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameBottom Bottom { get; set; }
		private ChartOptions3dFrameBottom Bottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The front of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameFront Front { get; set; }
		private ChartOptions3dFrameFront Front_DefaultValue { get; set; }
		 

		/// <summary>
		/// The left side of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameLeft Left { get; set; }
		private ChartOptions3dFrameLeft Left_DefaultValue { get; set; }
		 

		/// <summary>
		/// The right of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameRight Right { get; set; }
		private ChartOptions3dFrameRight Right_DefaultValue { get; set; }
		 

		/// <summary>
		/// Note: As of v5.0.12, `frame.left` or `frame.right` should be used instead.The side for the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameSide Side { get; set; }
		private ChartOptions3dFrameSide Side_DefaultValue { get; set; }
		 

		/// <summary>
		/// General pixel thickness for the frame faces.
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// The top of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameTop Top { get; set; }
		private ChartOptions3dFrameTop Top_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the frames are visible.
		/// </summary>
		public string Visible { get; set; }
		private string Visible_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Back.IsDirty()) h.Add("back",Back.ToHashtable());
			if (Bottom.IsDirty()) h.Add("bottom",Bottom.ToHashtable());
			if (Front.IsDirty()) h.Add("front",Front.ToHashtable());
			if (Left.IsDirty()) h.Add("left",Left.ToHashtable());
			if (Right.IsDirty()) h.Add("right",Right.ToHashtable());
			if (Side.IsDirty()) h.Add("side",Side.ToHashtable());
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Top.IsDirty()) h.Add("top",Top.ToHashtable());
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			

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