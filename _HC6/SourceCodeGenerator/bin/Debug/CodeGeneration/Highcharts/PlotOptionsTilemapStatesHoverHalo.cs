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
	public partial class PlotOptionsTilemapStatesHoverHalo  : BaseObject
	{
		public PlotOptionsTilemapStatesHoverHalo()
		{
			Enabled = Enabled_DefaultValue = True;
			Size = Size_DefaultValue = 2;
			Opacity = Opacity_DefaultValue = 0.5;
			Attributes = Attributes_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHoverHaloEnabled Enabled { get; set; }
		private PlotOptionsTilemapStatesHoverHaloEnabled Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHoverHaloSize Size { get; set; }
		private PlotOptionsTilemapStatesHoverHaloSize Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHoverHaloOpacity Opacity { get; set; }
		private PlotOptionsTilemapStatesHoverHaloOpacity Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHoverHaloAttributes Attributes { get; set; }
		private PlotOptionsTilemapStatesHoverHaloAttributes Attributes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Attributes.IsDirty()) h.Add("attributes",Attributes.ToHashtable());
			

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