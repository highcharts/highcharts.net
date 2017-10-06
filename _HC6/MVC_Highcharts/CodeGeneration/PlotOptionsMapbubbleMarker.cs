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
	public partial class PlotOptionsMapbubbleMarker  : BaseObject
	{
		public PlotOptionsMapbubbleMarker()
		{
			LineColor = LineColor_DefaultValue = null;
			LineWidth = LineWidth_DefaultValue = null;
			States = States_DefaultValue = new PlotOptionsMapbubbleMarkerStates();
			Symbol = Symbol_DefaultValue = "circle";
			FillColor = FillColor_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The color of the point marker&#39;s outline. When <code>null</code>, the series&#39;or point&#39;s color is used.</p>
		/// </summary>
		public string LineColor { get; set; }
		private string LineColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the point marker&#39;s outline.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>States for a single point marker.</p>
		/// </summary>
		public PlotOptionsMapbubbleMarkerStates States { get; set; }
		private PlotOptionsMapbubbleMarkerStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A predefined shape or symbol for the marker. Possible values are&quot;circle&quot;, &quot;square&quot;, &quot;diamond&quot;, &quot;triangle&quot; and &quot;triangle-down&quot;.</p><p>Additionally, the URL to a graphic can be given on the form<code>url(graphic.png)</code>. Note that for the image to be applied to exportedcharts, its URL needs to be accessible by the export server.</p><p>Custom callbacks for symbol path generation can also be added to<code>Highcharts.SVGRenderer.prototype.symbols</code>. The callback is thenused by its method name, as shown in the demo.</p>
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The fill color of the point marker. When <code>null</code>, the series&#39; orpoint&#39;s color is used.</p>
		/// </summary>
		public object FillColor { get; set; }
		private object FillColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LineColor != LineColor_DefaultValue) h.Add("lineColor",LineColor);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (FillColor != FillColor_DefaultValue) h.Add("fillColor",FillColor);
			

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