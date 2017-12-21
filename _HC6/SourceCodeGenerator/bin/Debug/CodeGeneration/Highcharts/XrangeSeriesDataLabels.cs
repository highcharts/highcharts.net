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
	public partial class XrangeSeriesDataLabels  : BaseObject
	{
		public XrangeSeriesDataLabels()
		{
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Inside = Inside_DefaultValue = true;
			Formatter = Formatter_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public XrangeSeriesDataLabelsVerticalAlign VerticalAlign { get; set; }
		private XrangeSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public XrangeSeriesDataLabelsInside Inside { get; set; }
		private XrangeSeriesDataLabelsInside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// The default formatter for X-range data labels displays the percentageof the partial fill amount.
		/// </summary>
		public XrangeSeriesDataLabelsFormatter Formatter { get; set; }
		private XrangeSeriesDataLabelsFormatter Formatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			

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