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
	public partial class PlotOptionsTilemapStatesHoverHalo  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTilemapStatesHoverHalo()
		{
			Attributes = Attributes_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Opacity = Opacity_DefaultValue = null;
			Size = Size_DefaultValue = 2;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Object Attributes { get; set; }
		private Object Attributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Attributes != Attributes_DefaultValue) h.Add("attributes",Attributes);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			

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