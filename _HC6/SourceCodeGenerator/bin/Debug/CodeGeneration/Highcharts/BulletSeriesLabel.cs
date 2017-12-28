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
	public partial class BulletSeriesLabel  : BaseObject
	{
		public BulletSeriesLabel()
		{
			Enabled = Enabled_DefaultValue = true;
			ConnectorAllowed = ConnectorAllowed_DefaultValue = true;
			ConnectorNeighbourDistance = ConnectorNeighbourDistance_DefaultValue = 24;
			MinFontSize = MinFontSize_DefaultValue = null;
			MaxFontSize = MaxFontSize_DefaultValue = null;
			OnArea = OnArea_DefaultValue = "";
			Style = Style_DefaultValue = new BulletSeriesLabelStyle();
			BoxesToAvoid = BoxesToAvoid_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Enable the series label per series.
		/// </summary>
		public BulletSeriesLabelEnabled Enabled { get; set; }
		private BulletSeriesLabelEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Allow labels to be placed distant to the graph if necessary,and draw a connector line to the graph.
		/// </summary>
		public BulletSeriesLabelConnectorAllowed ConnectorAllowed { get; set; }
		private BulletSeriesLabelConnectorAllowed ConnectorAllowed_DefaultValue { get; set; }
		 

		/// <summary>
		/// If the label is closer than this to a neighbour graph, draw aconnector.
		/// </summary>
		public BulletSeriesLabelConnectorNeighbourDistance ConnectorNeighbourDistance { get; set; }
		private BulletSeriesLabelConnectorNeighbourDistance ConnectorNeighbourDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MinFontSize { get; set; }
		private double? MinFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.
		/// </summary>
		public double? MaxFontSize { get; set; }
		private double? MaxFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// Draw the label on the area of an area series. By default itis drawn on the area. Set it to `false` to draw it next tothe graph instead.
		/// </summary>
		public bool? OnArea { get; set; }
		private bool? OnArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// Styles for the series label. The color defaults to the seriescolor, or a contrast color if `onArea`.
		/// </summary>
		public BulletSeriesLabelStyle Style { get; set; }
		private BulletSeriesLabelStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of boxes to avoid when laying out the labels. Each item has a `left`, `right`, `top` and `bottom` property.
		/// </summary>
		public List<object> BoxesToAvoid { get; set; }
		private List<object> BoxesToAvoid_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (ConnectorAllowed != ConnectorAllowed_DefaultValue) h.Add("connectorAllowed",ConnectorAllowed);
			if (ConnectorNeighbourDistance != ConnectorNeighbourDistance_DefaultValue) h.Add("connectorNeighbourDistance",ConnectorNeighbourDistance);
			if (MinFontSize != MinFontSize_DefaultValue) h.Add("minFontSize",MinFontSize);
			if (MaxFontSize != MaxFontSize_DefaultValue) h.Add("maxFontSize",MaxFontSize);
			if (OnArea != OnArea_DefaultValue) h.Add("onArea",OnArea);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (BoxesToAvoid != BoxesToAvoid_DefaultValue) h.Add("boxesToAvoid",BoxesToAvoid);
			

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