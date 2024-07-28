using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class ScatterSeriesClusterDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ScatterSeriesClusterDataLabels()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public ScatterSeriesClusterDataLabelsAlign Align { get; set; }
		 

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
		public ScatterSeriesClusterDataLabelsVerticalAlign VerticalAlign { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != ScatterSeriesClusterDataLabelsAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Format != null) h.Add("format",Format);
			if (Inside != null) h.Add("inside",Inside);
			if (Style != null) h.Add("style",Style);
			if (VerticalAlign != ScatterSeriesClusterDataLabelsVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
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