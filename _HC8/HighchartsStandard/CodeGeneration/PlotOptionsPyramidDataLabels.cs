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
	public partial class PlotOptionsPyramidDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPyramidDataLabels()
		{
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			VerticalAlign = VerticalAlign_DefaultValue = PlotOptionsPyramidDataLabelsVerticalAlign.Middle;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? ConnectorWidth { get; set; }
		private double? ConnectorWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsPyramidDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsPyramidDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
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