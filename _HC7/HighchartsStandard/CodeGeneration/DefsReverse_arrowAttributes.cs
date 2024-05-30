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
	public partial class DefsReverse_arrowAttributes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DefsReverse_arrowAttributes()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MarkerHeight { get; set; }
		private double? MarkerHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MarkerWidth { get; set; }
		private double? MarkerWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? RefX { get; set; }
		private double? RefX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? RefY { get; set; }
		private double? RefY_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Id != null) h.Add("id",Id);
			if (MarkerHeight != null) h.Add("markerHeight",MarkerHeight);
			if (MarkerWidth != null) h.Add("markerWidth",MarkerWidth);
			if (RefX != null) h.Add("refX",RefX);
			if (RefY != null) h.Add("refY",RefY);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}