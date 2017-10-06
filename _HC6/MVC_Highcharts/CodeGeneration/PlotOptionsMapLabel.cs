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
	public partial class PlotOptionsMapLabel  : BaseObject
	{
		public PlotOptionsMapLabel()
		{
			Enabled = Enabled_DefaultValue = null;
			ConnectorAllowed = ConnectorAllowed_DefaultValue = null;
			ConnectorNeighbourDistance = ConnectorNeighbourDistance_DefaultValue = null;
			MinFontSize = MinFontSize_DefaultValue = null;
			MaxFontSize = MaxFontSize_DefaultValue = null;
			OnArea = OnArea_DefaultValue = null;
			Style = Style_DefaultValue = new PlotOptionsMapLabelStyle();
			BoxesToAvoid = BoxesToAvoid_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Enable the series label per series.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allow labels to be placed distant to the graph if necessary,and draw a connector line to the graph.</p>
		/// </summary>
		public bool? ConnectorAllowed { get; set; }
		private bool? ConnectorAllowed_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>If the label is closer than this to a neighbour graph, draw aconnector.</p>
		/// </summary>
		public double? ConnectorNeighbourDistance { get; set; }
		private double? ConnectorNeighbourDistance_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.</p>
		/// </summary>
		public double? MinFontSize { get; set; }
		private double? MinFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>For area-like series, allow the font size to vary so thatsmall areas get a smaller font size. The default applies thiseffect to area-like series but not line-like series.</p>
		/// </summary>
		public double? MaxFontSize { get; set; }
		private double? MaxFontSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Draw the label on the area of an area series. By default itis drawn on the area. Set it to <code>false</code> to draw it next tothe graph instead.</p>
		/// </summary>
		public bool? OnArea { get; set; }
		private bool? OnArea_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Styles for the series label. The color defaults to the seriescolor, or a contrast color if <code>onArea</code>.</p>
		/// </summary>
		public PlotOptionsMapLabelStyle Style { get; set; }
		private PlotOptionsMapLabelStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of boxes to avoid when laying out the labels. Each item has a <code>left</code>, <code>right</code>, <code>top</code> and <code>bottom</code> property.</p>
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