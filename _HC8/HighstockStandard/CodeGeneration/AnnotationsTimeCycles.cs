using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class AnnotationsTimeCycles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsTimeCycles()
		{
			ControlPointOptions = ControlPointOptions_DefaultValue = new AnnotationsTimeCyclesControlPointOptions();
			ShapeOptions = ShapeOptions_DefaultValue = new AnnotationsTimeCyclesShapeOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsTimeCyclesTypeOptions();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTimeCyclesControlPointOptions ControlPointOptions { get; set; }
		private AnnotationsTimeCyclesControlPointOptions ControlPointOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTimeCyclesShapeOptions ShapeOptions { get; set; }
		private AnnotationsTimeCyclesShapeOptions ShapeOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsTimeCyclesTypeOptions TypeOptions { get; set; }
		private AnnotationsTimeCyclesTypeOptions TypeOptions_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty(highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(highstock));
			if (ShapeOptions.IsDirty(highstock)) h.Add("shapeOptions",ShapeOptions.ToHashtable(highstock));
			if (TypeOptions.IsDirty(highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(highstock));
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}