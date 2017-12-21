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
	public partial class HeatmapSeriesStatesHover  : BaseObject
	{
		public HeatmapSeriesStatesHover()
		{
			Halo = Halo_DefaultValue = false;
			Brightness = Brightness_DefaultValue = 0.2;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public HeatmapSeriesStatesHoverHalo Halo { get; set; }
		private HeatmapSeriesStatesHoverHalo Halo_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public HeatmapSeriesStatesHoverBrightness Brightness { get; set; }
		private HeatmapSeriesStatesHoverBrightness Brightness_DefaultValue { get; set; }
		  

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