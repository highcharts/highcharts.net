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
	public partial class VectorSeriesClusterDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public VectorSeriesClusterDataLabels()
		{
			Align = Align_DefaultValue = VectorSeriesClusterDataLabelsAlign.Center;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "{point.clusterPointsAmount}";
			Inside = Inside_DefaultValue = true;
			Style = Style_DefaultValue = new Hashtable();
			VerticalAlign = VerticalAlign_DefaultValue = VectorSeriesClusterDataLabelsVerticalAlign.Middle;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public VectorSeriesClusterDataLabelsAlign Align { get; set; }
		private VectorSeriesClusterDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Inside { get; set; }
		private bool? Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public VectorSeriesClusterDataLabelsVerticalAlign VerticalAlign { get; set; }
		private VectorSeriesClusterDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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