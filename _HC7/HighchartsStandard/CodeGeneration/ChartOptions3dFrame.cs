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
		}	
		

		/// <summary>
		/// The back side of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameBack Back { get; set; }
		 

		/// <summary>
		/// The bottom of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameBottom Bottom { get; set; }
		 

		/// <summary>
		/// The front of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameFront Front { get; set; }
		 

		/// <summary>
		/// The left side of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameLeft Left { get; set; }
		 

		/// <summary>
		/// The right of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameRight Right { get; set; }
		 

		/// <summary>
		/// Note: As of v5.0.12, `frame.left` or `frame.right` should be used instead.The side for the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameSide Side { get; set; }
		 

		/// <summary>
		/// General pixel thickness for the frame faces.
		/// </summary>
		public double? Size { get; set; }
		 

		/// <summary>
		/// The top of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameTop Top { get; set; }
		 

		/// <summary>
		/// Whether the frames are visible.
		/// </summary>
		public string Visible { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Back != null) h.Add("back",Back.ToHashtable(highcharts));
			if (Bottom != null) h.Add("bottom",Bottom.ToHashtable(highcharts));
			if (Front != null) h.Add("front",Front.ToHashtable(highcharts));
			if (Left != null) h.Add("left",Left.ToHashtable(highcharts));
			if (Right != null) h.Add("right",Right.ToHashtable(highcharts));
			if (Side != null) h.Add("side",Side.ToHashtable(highcharts));
			if (Size != null) h.Add("size",Size);
			if (Top != null) h.Add("top",Top.ToHashtable(highcharts));
			if (Visible != null) h.Add("visible",Visible);
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