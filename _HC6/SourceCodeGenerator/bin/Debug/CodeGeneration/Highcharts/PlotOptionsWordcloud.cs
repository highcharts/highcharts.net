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
	public partial class PlotOptionsWordcloud  : BaseObject
	{
		public PlotOptionsWordcloud()
		{
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			BorderWidth = BorderWidth_DefaultValue = 0;
			Clip = Clip_DefaultValue = False;
			ColorByPoint = ColorByPoint_DefaultValue = True;
			PlacementStrategy = PlacementStrategy_DefaultValue = center;
			Rotation = Rotation_DefaultValue = null;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			Spiral = Spiral_DefaultValue = rectangular;
			Style = Style_DefaultValue = new Hashtable{{"fontFamily","Impact},{ sans-serif"}};
			Tooltip = Tooltip_DefaultValue = null;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			Duration = Duration_DefaultValue = 500;
			BorderWidth = BorderWidth_DefaultValue = 0;
			ColorByPoint = ColorByPoint_DefaultValue = True;
			PlacementStrategy = PlacementStrategy_DefaultValue = center;
			Rotation = Rotation_DefaultValue = "";
			From = From_DefaultValue = 0;
			Orientations = Orientations_DefaultValue = 2;
			To = To_DefaultValue = 90;
			ShowInLegend = ShowInLegend_DefaultValue = False;
			Spiral = Spiral_DefaultValue = rectangular;
			Style = Style_DefaultValue = new Hashtable{{"fontFamily","Impact},{ sans-serif"}};
			FontFamily = FontFamily_DefaultValue = Impact, sans-serif;
			Tooltip = Tooltip_DefaultValue = "";
			FollowPointer = FollowPointer_DefaultValue = True;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudBorderWidth BorderWidth { get; set; }
		private PlotOptionsWordcloudBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudClip Clip { get; set; }
		private PlotOptionsWordcloudClip Clip_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the `options.colors`collection, this option determines whether the chart should receiveone color per series or one color per point.
		/// </summary>
		public PlotOptionsWordcloudColorByPoint ColorByPoint { get; set; }
		private PlotOptionsWordcloudColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for placement, and rotationof a word. The choice of algorith is therefore a crucial part of theresulting layout of the wordcloud.It is possible for users to add their own custom placement strategiesfor use in word cloud. Read more about it in our[documentation](https://www.highcharts.com/docs/chart-and-series-types/word-cloud-series#custom-placement-strategies)
		/// </summary>
		public PlotOptionsWordcloudPlacementStrategy PlacementStrategy { get; set; }
		private PlotOptionsWordcloudPlacementStrategy PlacementStrategy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation options for the words in the wordcloud.
		/// </summary>
		public PlotOptionsWordcloudRotation Rotation { get; set; }
		private PlotOptionsWordcloudRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudShowInLegend ShowInLegend { get; set; }
		private PlotOptionsWordcloudShowInLegend ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Spiral used for placing a word after the inital position experienced acollision with either another word or the borders.It is possible for users to add their own custom spiralling algorithmsfor use in word cloud. Read more about it in our[documentation](https://www.highcharts.com/docs/chart-and-series-types/word-cloud-series#custom-spiralling-algorithm)
		/// </summary>
		public PlotOptionsWordcloudSpiral Spiral { get; set; }
		private PlotOptionsWordcloudSpiral Spiral_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the words.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudTooltip Tooltip { get; set; }
		private PlotOptionsWordcloudTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudDuration Duration { get; set; }
		private PlotOptionsWordcloudDuration Duration_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudBorderWidth BorderWidth { get; set; }
		private PlotOptionsWordcloudBorderWidth BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// When using automatic point colors pulled from the `options.colors`collection, this option determines whether the chart should receiveone color per series or one color per point.
		/// </summary>
		public PlotOptionsWordcloudColorByPoint ColorByPoint { get; set; }
		private PlotOptionsWordcloudColorByPoint ColorByPoint_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option decides which algorithm is used for placement, and rotationof a word. The choice of algorith is therefore a crucial part of theresulting layout of the wordcloud.It is possible for users to add their own custom placement strategiesfor use in word cloud. Read more about it in our[documentation](https://www.highcharts.com/docs/chart-and-series-types/word-cloud-series#custom-placement-strategies)
		/// </summary>
		public PlotOptionsWordcloudPlacementStrategy PlacementStrategy { get; set; }
		private PlotOptionsWordcloudPlacementStrategy PlacementStrategy_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation options for the words in the wordcloud.
		/// </summary>
		public PlotOptionsWordcloudRotation Rotation { get; set; }
		private PlotOptionsWordcloudRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The smallest degree of rotation for a word.
		/// </summary>
		public PlotOptionsWordcloudFrom From { get; set; }
		private PlotOptionsWordcloudFrom From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of possible orientations for a word, within the range of`rotation.from` and `rotation.to`.
		/// </summary>
		public PlotOptionsWordcloudOrientations Orientations { get; set; }
		private PlotOptionsWordcloudOrientations Orientations_DefaultValue { get; set; }
		 

		/// <summary>
		/// The largest degree of rotation for a word.
		/// </summary>
		public PlotOptionsWordcloudTo To { get; set; }
		private PlotOptionsWordcloudTo To_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudShowInLegend ShowInLegend { get; set; }
		private PlotOptionsWordcloudShowInLegend ShowInLegend_DefaultValue { get; set; }
		 

		/// <summary>
		/// Spiral used for placing a word after the inital position experienced acollision with either another word or the borders.It is possible for users to add their own custom spiralling algorithmsfor use in word cloud. Read more about it in our[documentation](https://www.highcharts.com/docs/chart-and-series-types/word-cloud-series#custom-spiralling-algorithm)
		/// </summary>
		public PlotOptionsWordcloudSpiral Spiral { get; set; }
		private PlotOptionsWordcloudSpiral Spiral_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the words.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The font family to use for the word cloud.
		/// </summary>
		public PlotOptionsWordcloudFontFamily FontFamily { get; set; }
		private PlotOptionsWordcloudFontFamily FontFamily_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudTooltip Tooltip { get; set; }
		private PlotOptionsWordcloudTooltip Tooltip_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsWordcloudFollowPointer FollowPointer { get; set; }
		private PlotOptionsWordcloudFollowPointer FollowPointer_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Clip != Clip_DefaultValue) h.Add("clip",Clip);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (PlacementStrategy != PlacementStrategy_DefaultValue) h.Add("placementStrategy",PlacementStrategy);
			if (Rotation.IsDirty()) h.Add("rotation",Rotation.ToHashtable());
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Spiral != Spiral_DefaultValue) h.Add("spiral",Spiral);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (Duration != Duration_DefaultValue) h.Add("duration",Duration);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (ColorByPoint != ColorByPoint_DefaultValue) h.Add("colorByPoint",ColorByPoint);
			if (PlacementStrategy != PlacementStrategy_DefaultValue) h.Add("placementStrategy",PlacementStrategy);
			if (Rotation.IsDirty()) h.Add("rotation",Rotation.ToHashtable());
			if (From != From_DefaultValue) h.Add("from",From);
			if (Orientations != Orientations_DefaultValue) h.Add("orientations",Orientations);
			if (To != To_DefaultValue) h.Add("to",To);
			if (ShowInLegend != ShowInLegend_DefaultValue) h.Add("showInLegend",ShowInLegend);
			if (Spiral != Spiral_DefaultValue) h.Add("spiral",Spiral);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (FontFamily != FontFamily_DefaultValue) h.Add("fontFamily",FontFamily);
			if (Tooltip.IsDirty()) h.Add("tooltip",Tooltip.ToHashtable());
			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			

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