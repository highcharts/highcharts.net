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
	public partial class PlotOptionsVectorClusterDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsVectorClusterDataLabels()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorClusterDataLabelsAlign Align { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Format { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Inside { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsVectorClusterDataLabelsVerticalAlign VerticalAlign { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != PlotOptionsVectorClusterDataLabelsAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format);
			if (Inside != null) h.Add("inside",Inside);
			if (Style != null) h.Add("style",Style);
			if (VerticalAlign != PlotOptionsVectorClusterDataLabelsVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}