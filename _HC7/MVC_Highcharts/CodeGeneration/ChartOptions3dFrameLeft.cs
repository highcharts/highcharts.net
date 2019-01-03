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
	public partial class ChartOptions3dFrameLeft  : BaseObject
	{
		public ChartOptions3dFrameLeft()
		{
			Color = Color_DefaultValue = "transparent";
			Size = Size_DefaultValue = 1;
			Visible = Visible_DefaultValue = "null";
			VisibleBool = VisibleBool_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The color of the panel.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The thickness of the panel.
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the frame. Possible values are `true`,`false`, `"auto"` to display only the frames behind the data,and `"default"` to display faces behind the data based on theaxis layout, ignoring the point of view.
		/// </summary>
		public string Visible { get; set; }
		private string Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to display the frame. Possible values are `true`,`false`, `"auto"` to display only the frames behind the data,and `"default"` to display faces behind the data based on theaxis layout, ignoring the point of view.
		/// </summary>
		public bool? VisibleBool { get; set; }
		private bool? VisibleBool_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (VisibleBool != VisibleBool_DefaultValue) h.Add("visible",VisibleBool);
			

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