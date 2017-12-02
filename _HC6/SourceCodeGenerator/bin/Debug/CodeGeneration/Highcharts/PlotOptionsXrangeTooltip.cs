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
	public partial class PlotOptionsXrangeTooltip  : BaseObject
	{
		public PlotOptionsXrangeTooltip()
		{
			HeaderFormat = HeaderFormat_DefaultValue = <span style="font-size: 0.85em">{point.x} - {point.x2}</span><br/>;
			PointFormat = PointFormat_DefaultValue = <span style="color:{point.color}">●</span> {series.name}: <b>{point.yCategory}</b><br/>;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeTooltipHeaderFormat HeaderFormat { get; set; }
		private PlotOptionsXrangeTooltipHeaderFormat HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsXrangeTooltipPointFormat PointFormat { get; set; }
		private PlotOptionsXrangeTooltipPointFormat PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			

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