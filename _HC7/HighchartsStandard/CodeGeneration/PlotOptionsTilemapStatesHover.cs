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
	public partial class PlotOptionsTilemapStatesHover  : BaseObject
	{
		public PlotOptionsTilemapStatesHover()
		{
			Halo = Halo_DefaultValue = new PlotOptionsTilemapStatesHoverHalo();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsTilemapStatesHoverHalo Halo { get; set; }
		private PlotOptionsTilemapStatesHoverHalo Halo_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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