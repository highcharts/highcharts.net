using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class PlotOptions  : BaseObject
	{
		public PlotOptions()
		{
			Heatmap = Heatmap_DefaultValue = new PlotOptionsHeatmap();
			Map = Map_DefaultValue = new PlotOptionsMap();
			Mapbubble = Mapbubble_DefaultValue = new PlotOptionsMapbubble();
			Mapline = Mapline_DefaultValue = new PlotOptionsMapline();
			Mappoint = Mappoint_DefaultValue = new PlotOptionsMappoint();
			Series = Series_DefaultValue = new PlotOptionsSeries();
			
		}	
		

		/// <summary>
		/// The heatmap series type, a special case of a choropleth map where each point is a square colored to signify a value. Heatmaps are available both in Highmaps and in Highcharts since version 4.
		/// </summary>
		public PlotOptionsHeatmap Heatmap { get; set; }
		private PlotOptionsHeatmap Heatmap_DefaultValue { get; set; }
		 

		/// <summary>
		/// The map series type is the default series type of a Highcharts map, where each point is represented by an area given by its <code>path</code> option of the path option of its corresponding <code>mapData</code> point.
		/// </summary>
		public PlotOptionsMap Map { get; set; }
		private PlotOptionsMap Map_DefaultValue { get; set; }
		 

		/// <summary>
		/// A bubble series is a three dimensional series type where each point renders an X, Y and Z value. Each points is drawn as a bubble where the position along the X and Y axes mark the X and Y values, and the size of the bubble relates to the Z value.
		/// </summary>
		public PlotOptionsMapbubble Mapbubble { get; set; }
		private PlotOptionsMapbubble Mapbubble_DefaultValue { get; set; }
		 

		/// <summary>
		/// Mapline series represent paths or lines in a map, all features that don't have an area. It can typically be used for rivers or roads, or for separator lines to distinguish overseas territories. For separator lines, set <code>enableMouseTracking</code> to false to turn off interactivity.
		/// </summary>
		public PlotOptionsMapline Mapline { get; set; }
		private PlotOptionsMapline Mapline_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A <code>mappoint</code> series is a scatter series laid on top of a map, where X and Y values relate to the coordinate system established by the paths used for the main map series. In Highmaps it is typically used to mark cities. The only difference from a Highcharts scatter series is that the data labels are by default enabled and formatted to display the name of the point.</p><p>For documentation on how to use the mappoint series, see <a href="http://api.highcharts.com/highcharts#plotOptions.scatter">scatter series</a> in the basic Highcharts API.</p>
		/// </summary>
		public PlotOptionsMappoint Mappoint { get; set; }
		private PlotOptionsMappoint Mappoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>General options for all series types.</p>
		/// </summary>
		public PlotOptionsSeries Series { get; set; }
		private PlotOptionsSeries Series_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Heatmap.IsDirty()) h.Add("heatmap",Heatmap.ToHashtable());
			if (Map.IsDirty()) h.Add("map",Map.ToHashtable());
			if (Mapbubble.IsDirty()) h.Add("mapbubble",Mapbubble.ToHashtable());
			if (Mapline.IsDirty()) h.Add("mapline",Mapline.ToHashtable());
			if (Mappoint.IsDirty()) h.Add("mappoint",Mappoint.ToHashtable());
			if (Series.IsDirty()) h.Add("series",Series.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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