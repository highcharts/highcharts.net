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
	public partial class PlotOptionsTilemapClusterDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTilemapClusterDataLabels()
		{
			Align = Align_DefaultValue = PlotOptionsTilemapClusterDataLabelsAlign.Center;
			Enabled = Enabled_DefaultValue = true;
			Format = Format_DefaultValue = "{point.clusterPointsAmount}";
			Inside = Inside_DefaultValue = true;
			Style = Style_DefaultValue = new PlotOptionsTilemapClusterDataLabelsStyle();
			VerticalAlign = VerticalAlign_DefaultValue = PlotOptionsTilemapClusterDataLabelsVerticalAlign.Middle;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapClusterDataLabelsAlign Align { get; set; }
		private PlotOptionsTilemapClusterDataLabelsAlign Align_DefaultValue { get; set; }
		 

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
		public PlotOptionsTilemapClusterDataLabelsStyle Style { get; set; }
		private PlotOptionsTilemapClusterDataLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapClusterDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsTilemapClusterDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			

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