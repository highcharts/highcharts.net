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
	public partial class PlotOptionsPriceenvelopesParams  : BaseObject
	{
		public PlotOptionsPriceenvelopesParams()
		{
			BottomBand = BottomBand_DefaultValue = null;
			Index = Index_DefaultValue = 0;
			Period = Period_DefaultValue = 20;
			TopBand = TopBand_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Percentage below the moving average that should be displayed.0.1 means 90%. Relative to the calculated value.
		/// </summary>
		public double? BottomBand { get; set; }
		private double? BottomBand_DefaultValue { get; set; }
		 

		/// <summary>
		/// The point index which indicator calculations will base. Forexample using OHLC data, index=2 means the indicator will becalculated using Low values.
		/// </summary>
		public double? Index { get; set; }
		private double? Index_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Period { get; set; }
		private double? Period_DefaultValue { get; set; }
		 

		/// <summary>
		/// Percentage above the moving average that should be displayed.0.1 means 110%. Relative to the calculated value.
		/// </summary>
		public double? TopBand { get; set; }
		private double? TopBand_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BottomBand != BottomBand_DefaultValue) h.Add("bottomBand",BottomBand);
			if (Index != Index_DefaultValue) h.Add("index",Index);
			if (Period != Period_DefaultValue) h.Add("period",Period);
			if (TopBand != TopBand_DefaultValue) h.Add("topBand",TopBand);
			

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