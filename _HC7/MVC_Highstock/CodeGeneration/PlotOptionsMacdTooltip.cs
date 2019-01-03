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
	public partial class PlotOptionsMacdTooltip  : BaseObject
	{
		public PlotOptionsMacdTooltip()
		{
			PointFormat = PointFormat_DefaultValue = "<span style='color:{point.color}'>●</span> <b> {series.name}</b><br/>Value: {point.MACD}<br/>Signal: {point.signal}<br/>Histogram: {point.y}<br/>";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		  

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