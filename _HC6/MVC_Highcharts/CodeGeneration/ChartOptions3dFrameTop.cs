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
	public partial class ChartOptions3dFrameTop  : BaseObject
	{
		public ChartOptions3dFrameTop()
		{
			Color = Color_DefaultValue = "transparent";
			Size = Size_DefaultValue = 1;
			Visible = Visible_DefaultValue = ChartOptions3dFrameTopVisible.Default;
			
		}	
		

		/// <summary>
		/// <p>The color of the panel.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The thickness of the panel.</p>
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to display the frame. Possible values are <code>true</code>, <code>false</code>,<code>&quot;auto&quot;</code> to display only the frames behind the data, and <code>&quot;default&quot;</code>to display faces behind the data based on the axis layout, ignoringthe point of view.</p>
		/// </summary>
		public ChartOptions3dFrameTopVisible Visible { get; set; }
		private ChartOptions3dFrameTopVisible Visible_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Visible != Visible_DefaultValue) h.Add("visible", Highcharts.FirstCharacterToLower(Visible.ToString()));
			

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