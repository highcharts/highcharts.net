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
	public partial class PlotOptionsTreemapStatesHover  : BaseObject
	{
		public PlotOptionsTreemapStatesHover()
		{
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Halo = Halo_DefaultValue = False;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			BorderColor = BorderColor_DefaultValue = #999999;
			Brightness = Brightness_DefaultValue = null;
			Opacity = Opacity_DefaultValue = 0.75;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			
		}	
		

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapStatesHoverBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapStatesHoverBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTreemapStatesHoverHalo Halo { get; set; }
		private PlotOptionsTreemapStatesHoverHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapStatesHoverBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapStatesHoverBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapStatesHoverBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapStatesHoverBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public PlotOptionsTreemapStatesHoverBorderColor BorderColor { get; set; }
		private PlotOptionsTreemapStatesHoverBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if the heatmapseries is loaded, otherwise 0.1.
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// The opacity of a point in treemap. When a point has children,the visibility of the children is determined by the opacity.
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// The shadow option for hovered state.
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Halo != Halo_DefaultValue) h.Add("halo",Halo);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			

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