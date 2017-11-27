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
	public partial class PlotOptionsHeatmapStatesHover  : BaseObject
	{
		public PlotOptionsHeatmapStatesHover()
		{
			Halo = Halo_DefaultValue = False;
			Brightness = Brightness_DefaultValue = 0.2;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapStatesHoverHalo Halo { get; set; }
		private PlotOptionsHeatmapStatesHoverHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsHeatmapStatesHoverBrightness Brightness { get; set; }
		private PlotOptionsHeatmapStatesHoverBrightness Brightness_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Halo != Halo_DefaultValue) h.Add("halo",Halo);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			

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