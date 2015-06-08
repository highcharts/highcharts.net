using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class ChartOptions3dFrame  
	{
		public ChartOptions3dFrame()
		{
			Back = Back_DefaultValue = new ChartOptions3dFrameBack();
			Bottom = Bottom_DefaultValue = new ChartOptions3dFrameBottom();
			Side = Side_DefaultValue = new ChartOptions3dFrameSide();
			
		}	
		

		/// <summary>
		/// Defines the back panel of the frame around 3D charts.
		/// </summary>
		public ChartOptions3dFrameBack Back { get; set; }
		private ChartOptions3dFrameBack Back_DefaultValue { get; set; }
		 

		/// <summary>
		/// The bottom of the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameBottom Bottom { get; set; }
		private ChartOptions3dFrameBottom Bottom_DefaultValue { get; set; }
		 

		/// <summary>
		/// The side for the frame around a 3D chart.
		/// </summary>
		public ChartOptions3dFrameSide Side { get; set; }
		private ChartOptions3dFrameSide Side_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Back.IsDirty()) h.Add("back",Back.ToHashtable());
			if (Bottom.IsDirty()) h.Add("bottom",Bottom.ToHashtable());
			if (Side.IsDirty()) h.Add("side",Side.ToHashtable());
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}