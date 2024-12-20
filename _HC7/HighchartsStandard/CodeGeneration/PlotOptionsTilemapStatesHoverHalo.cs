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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Object Attributes { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Opacity { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Size { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Attributes != null) h.Add("attributes",Attributes);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Opacity != null) h.Add("opacity",Opacity);
			if (Size != null) h.Add("size",Size);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}