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
	public partial class WindbarbSeriesTooltip  : BaseObject
	{
		public WindbarbSeriesTooltip()
		{
			PointFormat = PointFormat_DefaultValue = <b>{series.name}</b>: {point.value} ({point.beaufort})<br/>;
			
		}	
		

		/// <summary>
		/// The default point format for the wind barb tooltip. Note the `point.beaufort` property that refers to the Beaufort wind scale. Thenames can be internationalized by modifying`Highcharts.seriesTypes.windbarb.prototype.beaufortNames`.
		/// </summary>
		public WindbarbSeriesTooltipPointFormat PointFormat { get; set; }
		private WindbarbSeriesTooltipPointFormat PointFormat_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

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