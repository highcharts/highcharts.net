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
	public partial class PlotOptionsCandlestickLabel  : BaseObject
	{
		public PlotOptionsCandlestickLabel()
		{
			BoxesToAvoid = BoxesToAvoid_DefaultValue = new List<object>();
			ConnectorAllowed = ConnectorAllowed_DefaultValue = false;
			ConnectorNeighbourDistance = ConnectorNeighbourDistance_DefaultValue = 24;
			Enabled = Enabled_DefaultValue = true;
			MaxFontSize = MaxFontSize_DefaultValue = null;
			MinFontSize = MinFontSize_DefaultValue = null;
			OnArea = OnArea_DefaultValue = null;
			Style = Style_DefaultValue = new PlotOptionsCandlestickLabelStyle();
			
		}	
		

		/// <summary>
		/// An array of boxes to avoid when laying out the labels. Eachitem has a `left`, `right`, `top` and `bottom` property.
		/// </summary>
		public List<object> BoxesToAvoid { get; set; }
		private List<object> BoxesToAvoid_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow labels to be placed distant to the graph if necessary,and draw a connector line to the graph. Setting this optionto true may decrease the performance significantly, since thealgorithm with systematically search for open spaces in thewhole plot area. Visually, it may also result in a morecluttered chart, though more of the series will be labeled.
		/// </summary>
		public bool? ConnectorAllowed { get; set; }
		private bool? ConnectorAllowed_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the label is closer than this to a neighbour graph, draw aconnector.
		/// </summary>
		public double? ConnectorNeighbourDistance { get; set; }
		private double? ConnectorNeighbourDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable the series label per series.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MaxFontSize { get; set; }
		private double? MaxFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MinFontSize { get; set; }
		private double? MinFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Draw the label on the area of an area series. By default itis drawn on the area. Set it to `false` to draw it next tothe graph instead.
		/// </summary>
		public bool? OnArea { get; set; }
		private bool? OnArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the series label. The color defaults to the seriescolor, or a contrast color if `onArea`.
		/// </summary>
		public PlotOptionsCandlestickLabelStyle Style { get; set; }
		private PlotOptionsCandlestickLabelStyle Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BoxesToAvoid != BoxesToAvoid_DefaultValue) h.Add("boxesToAvoid",BoxesToAvoid);
			if (ConnectorAllowed != ConnectorAllowed_DefaultValue) h.Add("connectorAllowed",ConnectorAllowed);
			if (ConnectorNeighbourDistance != ConnectorNeighbourDistance_DefaultValue) h.Add("connectorNeighbourDistance",ConnectorNeighbourDistance);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (MaxFontSize != MaxFontSize_DefaultValue) h.Add("maxFontSize",MaxFontSize);
			if (MinFontSize != MinFontSize_DefaultValue) h.Add("minFontSize",MinFontSize);
			if (OnArea != OnArea_DefaultValue) h.Add("onArea",OnArea);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			

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