using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class XrangeSeriesDataLabels  : BaseObject
	{
		public XrangeSeriesDataLabels()
		{
			Align = Align_DefaultValue = XrangeSeriesDataLabelsAlign.Center;
			Formatter = Formatter_DefaultValue = "function () { return H.numberFormat(this.y, -1); }";
			Padding = Padding_DefaultValue = "5";
			Style = Style_DefaultValue = new Hashtable();
			VerticalAlign = VerticalAlign_DefaultValue = XrangeSeriesDataLabelsVerticalAlign.Bottom;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public XrangeSeriesDataLabelsAlign Align { get; set; }
		private XrangeSeriesDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Padding { get; set; }
		private string Padding_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// above singular point
		/// </summary>
		public XrangeSeriesDataLabelsVerticalAlign VerticalAlign { get; set; }
		private XrangeSeriesDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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