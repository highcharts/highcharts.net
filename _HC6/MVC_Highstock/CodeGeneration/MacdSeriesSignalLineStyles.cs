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
	public partial class MacdSeriesSignalLineStyles  : BaseObject
	{
		public MacdSeriesSignalLineStyles()
		{
			LineWidth = LineWidth_DefaultValue = null;
			LineColor = LineColor_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Pixel width of the line.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Color of the line.</p>
		/// </summary>
		public double? LineColor { get; set; }
		private double? LineColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			

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