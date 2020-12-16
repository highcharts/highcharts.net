using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsTreemapStatesHover  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreemapStatesHover()
		{
			BorderColor = BorderColor_DefaultValue = "";
			Brightness = Brightness_DefaultValue = new Hashtable();
			Opacity = Opacity_DefaultValue = null;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The border color for the hovered state.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// Brightness for the hovered point. Defaults to 0 if theheatmap series is loaded first, otherwise 0.1.
		/// </summary>
		public Hashtable Brightness { get; set; }
		private Hashtable Brightness_DefaultValue { get; set; }
		 

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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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