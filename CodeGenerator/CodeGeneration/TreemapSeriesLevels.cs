using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class TreemapSeriesLevels  : BaseObject
	{
		public TreemapSeriesLevels()
		{
			BorderColor = BorderColor_DefaultValue = null;
			BorderDashStyle = BorderDashStyle_DefaultValue = null;
			BorderWidth = BorderWidth_DefaultValue = null;
			Color = Color_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = null;
			LayoutAlgorithm = LayoutAlgorithm_DefaultValue = TreemapSeriesLevelsLayoutAlgorithm.Null;
			LayoutStartingDirection = LayoutStartingDirection_DefaultValue = TreemapSeriesLevelsLayoutStartingDirection.Null;
			Level = Level_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Can set borderColor on all points which lies on the same level.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the dash style of the border of all the point which lies on the level.See <a href"#plotOptions.scatter.dashStyle">plotOptions.scatter.dashStyle</a> for possible options.
		/// </summary>
		public string BorderDashStyle { get; set; }
		private string BorderDashStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the borderWidth on all points which lies on the same level.
		/// </summary>
		public double? BorderWidth { get; set; }
		private double? BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set a color on all points which lies on the same level.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the options of dataLabels on each point which lies on the level.<a href="#plotOptions.treemap.dataLabels">plotOptions.treemap.dataLabels</a> for possible values.
		/// </summary>
		public Object DataLabels { get; set; }
		private Object DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutAlgorithm option on a specific level. 
		/// </summary>
		public TreemapSeriesLevelsLayoutAlgorithm LayoutAlgorithm { get; set; }
		private TreemapSeriesLevelsLayoutAlgorithm LayoutAlgorithm_DefaultValue { get; set; }
		 

		/// <summary>
		/// Can set the layoutStartingDirection option on a specific level.
		/// </summary>
		public TreemapSeriesLevelsLayoutStartingDirection LayoutStartingDirection { get; set; }
		private TreemapSeriesLevelsLayoutStartingDirection LayoutStartingDirection_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides which level takes effect from the options set in the levels object.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderDashStyle != BorderDashStyle_DefaultValue) h.Add("borderDashStyle",BorderDashStyle);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (LayoutAlgorithm != LayoutAlgorithm_DefaultValue) h.Add("layoutAlgorithm",LayoutAlgorithm.ToString().ToLower());
			if (LayoutStartingDirection != LayoutStartingDirection_DefaultValue) h.Add("layoutStartingDirection",LayoutStartingDirection.ToString().ToLower());
			if (Level != Level_DefaultValue) h.Add("level",Level);
			

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