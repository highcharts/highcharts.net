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
	public partial class PlotOptionsTilemap  : BaseObject
	{
		public PlotOptionsTilemap()
		{
			States = States_DefaultValue = null;
			PointPadding = PointPadding_DefaultValue = 2;
			TileShape = TileShape_DefaultValue = hexagon;
			Colsize = Colsize_DefaultValue = 1;
			Rowsize = Rowsize_DefaultValue = 1;
			Data = Data_DefaultValue = new List<PlotOptionsTilemapData>();
			States = States_DefaultValue = "";
			Hover = Hover_DefaultValue = "";
			Halo = Halo_DefaultValue = "";
			Enabled = Enabled_DefaultValue = True;
			Size = Size_DefaultValue = 2;
			Opacity = Opacity_DefaultValue = 0.5;
			Attributes = Attributes_DefaultValue = "";
			ZIndex = ZIndex_DefaultValue = 3;
			PointPadding = PointPadding_DefaultValue = 2;
			TileShape = TileShape_DefaultValue = hexagon;
			Colsize = Colsize_DefaultValue = 1;
			Rowsize = Rowsize_DefaultValue = 1;
			Color = Color_DefaultValue = "";
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStates States { get; set; }
		private PlotOptionsTilemapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// The padding between points in the tilemap.
		/// </summary>
		public PlotOptionsTilemapPointPadding PointPadding { get; set; }
		private PlotOptionsTilemapPointPadding PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shape of the tiles in the tilemap. Possible values are `hexagon`,`circle`, `diamond`, and `square`.
		/// </summary>
		public PlotOptionsTilemapTileShape TileShape { get; set; }
		private PlotOptionsTilemapTileShape TileShape_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column size - how many X axis units each column in the tilemapshould span. Works as in [Heatmaps](#plotOptions.heatmap.colsize).
		/// </summary>
		public double? Colsize { get; set; }
		private double? Colsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The row size - how many Y axis units each tilemap row should span.Analogous to [colsize](#plotOptions.tilemap.colsize).
		/// </summary>
		public double? Rowsize { get; set; }
		private double? Rowsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<PlotOptionsTilemapData> Data { get; set; }
		private List<PlotOptionsTilemapData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStates States { get; set; }
		private PlotOptionsTilemapStates States_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapHover Hover { get; set; }
		private PlotOptionsTilemapHover Hover_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapHalo Halo { get; set; }
		private PlotOptionsTilemapHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapEnabled Enabled { get; set; }
		private PlotOptionsTilemapEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapSize Size { get; set; }
		private PlotOptionsTilemapSize Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapOpacity Opacity { get; set; }
		private PlotOptionsTilemapOpacity Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapAttributes Attributes { get; set; }
		private PlotOptionsTilemapAttributes Attributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapZIndex ZIndex { get; set; }
		private PlotOptionsTilemapZIndex ZIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The padding between points in the tilemap.
		/// </summary>
		public PlotOptionsTilemapPointPadding PointPadding { get; set; }
		private PlotOptionsTilemapPointPadding PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shape of the tiles in the tilemap. Possible values are `hexagon`,`circle`, `diamond`, and `square`.
		/// </summary>
		public PlotOptionsTilemapTileShape TileShape { get; set; }
		private PlotOptionsTilemapTileShape TileShape_DefaultValue { get; set; }
		 

		/// <summary>
		/// The column size - how many X axis units each column in the tilemapshould span. Works as in [Heatmaps](#plotOptions.heatmap.colsize).
		/// </summary>
		public double? Colsize { get; set; }
		private double? Colsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The row size - how many Y axis units each tilemap row should span.Analogous to [colsize](#plotOptions.tilemap.colsize).
		/// </summary>
		public double? Rowsize { get; set; }
		private double? Rowsize_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color of the point. In tilemaps the point color is rarely setexplicitly, as we use the color to denote the `value`. Options forthis are set in the [colorAxis](#colorAxis) configuration.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x coordinate of the point.Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y coordinate of the point.Note that for some [tileShapes](#plotOptions.tilemap.tileShape) the gridcoordinates are offset.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (TileShape != TileShape_DefaultValue) h.Add("tileShape",TileShape);
			if (Colsize != Colsize_DefaultValue) h.Add("colsize",Colsize);
			if (Rowsize != Rowsize_DefaultValue) h.Add("rowsize",Rowsize);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (States.IsDirty()) h.Add("states",States.ToHashtable());
			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Attributes.IsDirty()) h.Add("attributes",Attributes.ToHashtable());
			if (ZIndex != ZIndex_DefaultValue) h.Add("zIndex",ZIndex);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (TileShape != TileShape_DefaultValue) h.Add("tileShape",TileShape);
			if (Colsize != Colsize_DefaultValue) h.Add("colsize",Colsize);
			if (Rowsize != Rowsize_DefaultValue) h.Add("rowsize",Rowsize);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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