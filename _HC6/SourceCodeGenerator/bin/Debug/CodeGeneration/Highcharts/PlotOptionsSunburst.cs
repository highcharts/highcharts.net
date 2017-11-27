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
	public partial class PlotOptionsSunburst  : BaseObject
	{
		public PlotOptionsSunburst()
		{
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			RootId = RootId_DefaultValue = "undefined";
			LevelIsConstant = LevelIsConstant_DefaultValue = True;
			Levels = Levels_DefaultValue = null;
			AllowDrillToNode = AllowDrillToNode_DefaultValue = false;
			DataLabels = DataLabels_DefaultValue = "";
			Defer = Defer_DefaultValue = True;
			Style = Style_DefaultValue = "";
			TextOverflow = TextOverflow_DefaultValue = ellipsis;
			RotationMode = RotationMode_DefaultValue = perpendicular;
			RootId = RootId_DefaultValue = "undefined";
			LevelIsConstant = LevelIsConstant_DefaultValue = True;
			Levels = Levels_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = null;
			BorderDashStyle = BorderDashStyle_DefaultValue = "";
			Color = Color_DefaultValue = "";
			ColorVariation = ColorVariation_DefaultValue = "";
			Key = Key_DefaultValue = "";
			To = To_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = "";
			Rotation = Rotation_DefaultValue = null;
			RotationMode = RotationMode_DefaultValue = "";
			AllowDrillToNode = AllowDrillToNode_DefaultValue = false;
			Defer = Defer_DefaultValue = True;
			Style = Style_DefaultValue = "";
			TextOverflow = TextOverflow_DefaultValue = ellipsis;
			RotationMode = RotationMode_DefaultValue = perpendicular;
			
		}	
		

		/// <summary>
		/// The center of the sunburst chart relative to the plot area. Can bepercentages or pixel values.
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// Which point to use as a root in the visualization.
		/// </summary>
		public string RootId { get; set; }
		private string RootId_DefaultValue { get; set; }
		 

		/// <summary>
		/// Used together with the levels and `allowDrillToNode` options. Whenset to false the first level visible when drilling is consideredto be level one. Otherwise the level will be the same as the treestructure.
		/// </summary>
		public PlotOptionsSunburstLevelIsConstant LevelIsConstant { get; set; }
		private PlotOptionsSunburstLevelIsConstant LevelIsConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not point options.
		/// </summary>
		public List<object> Levels { get; set; }
		private List<object> Levels_DefaultValue { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children.
		/// </summary>
		public bool? AllowDrillToNode { get; set; }
		private bool? AllowDrillToNode_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabels DataLabels { get; set; }
		private PlotOptionsSunburstDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDefer Defer { get; set; }
		private PlotOptionsSunburstDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstStyle Style { get; set; }
		private PlotOptionsSunburstStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstTextOverflow TextOverflow { get; set; }
		private PlotOptionsSunburstTextOverflow TextOverflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides how the data label will be rotated according to the perimeterof the sunburst. It can either be parallel or perpendicular to theperimeter.`series.rotation` takes precedence over `rotationMode`.
		/// </summary>
		public PlotOptionsSunburstRotationMode RotationMode { get; set; }
		private PlotOptionsSunburstRotationMode RotationMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// Which point to use as a root in the visualization.
		/// </summary>
		public string RootId { get; set; }
		private string RootId_DefaultValue { get; set; }
		 

		/// <summary>
		/// Used together with the levels and `allowDrillToNode` options. Whenset to false the first level visible when drilling is consideredto be level one. Otherwise the level will be the same as the treestructure.
		/// </summary>
		public PlotOptionsSunburstLevelIsConstant LevelIsConstant { get; set; }
		private PlotOptionsSunburstLevelIsConstant LevelIsConstant_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set options on specific levels. Takes precedence over series options,but not point options.
		/// </summary>
		public List<object> Levels { get; set; }
		private List<object> Levels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderColor` on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderWidth` on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `borderDashStyle` on all points which lies on the same level.
		/// </summary>
		public string BorderDashStyle { get; set; }
		private string BorderDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `color` on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `colorVariation` on all points which lies on the same level.
		/// </summary>
		public PlotOptionsSunburstColorVariation ColorVariation { get; set; }
		private PlotOptionsSunburstColorVariation ColorVariation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The key of a color variation. Currently supports `brightness` only.
		/// </summary>
		public string Key { get; set; }
		private string Key_DefaultValue { get; set; }
		 

		/// <summary>
		/// The ending value of a color variation. The last sibling will receive thisvalue.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `dataLabels` on all points which lies on the same level.
		/// </summary>
		public PlotOptionsSunburstDataLabels DataLabels { get; set; }
		private PlotOptionsSunburstDataLabels DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `rotation` on all points which lies on the same level.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a `rotationMode` on all points which lies on the same level.
		/// </summary>
		public string RotationMode { get; set; }
		private string RotationMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// When enabled the user can click on a point which is a parent andzoom in on its children.
		/// </summary>
		public bool? AllowDrillToNode { get; set; }
		private bool? AllowDrillToNode_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDefer Defer { get; set; }
		private PlotOptionsSunburstDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstStyle Style { get; set; }
		private PlotOptionsSunburstStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstTextOverflow TextOverflow { get; set; }
		private PlotOptionsSunburstTextOverflow TextOverflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides how the data label will be rotated according to the perimeterof the sunburst. It can either be parallel or perpendicular to theperimeter.`series.rotation` takes precedence over `rotationMode`.
		/// </summary>
		public PlotOptionsSunburstRotationMode RotationMode { get; set; }
		private PlotOptionsSunburstRotationMode RotationMode_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (RootId != RootId_DefaultValue) h.Add("rootId",RootId);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant",LevelIsConstant);
			if (Levels.IsDirty()) h.Add("levels",Levels.ToHashtable());
			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode",AllowDrillToNode);
			if (DataLabels.IsDirty()) h.Add("dataLabels",DataLabels.ToHashtable());
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (TextOverflow != TextOverflow_DefaultValue) h.Add("textOverflow",TextOverflow);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode",RotationMode);
			if (RootId != RootId_DefaultValue) h.Add("rootId",RootId);
			if (LevelIsConstant != LevelIsConstant_DefaultValue) h.Add("levelIsConstant",LevelIsConstant);
			if (Levels.IsDirty()) h.Add("levels",Levels.ToHashtable());
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorVariation.IsDirty()) h.Add("colorVariation",ColorVariation.ToHashtable());
			if (Key != Key_DefaultValue) h.Add("key",Key);
			if (To != To_DefaultValue) h.Add("to",To);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode",RotationMode);
			if (AllowDrillToNode != AllowDrillToNode_DefaultValue) h.Add("allowDrillToNode",AllowDrillToNode);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (TextOverflow != TextOverflow_DefaultValue) h.Add("textOverflow",TextOverflow);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode",RotationMode);
			

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