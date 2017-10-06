using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsVbpZoneLinesStyles  : BaseObject
	{
		public PlotOptionsVbpZoneLinesStyles()
		{
			Color = Color_DefaultValue = "#0A9AC9";
			DashStyle = DashStyle_DefaultValue = "LongDash";
			LineWidth = LineWidth_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Color of zone lines.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The dash style of zone lines.</p>
		/// </summary>
		public string DashStyle { get; set; }
		private string DashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Pixel width of zone lines.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DashStyle != DashStyle_DefaultValue) h.Add("dashStyle",DashStyle);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			

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