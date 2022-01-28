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
		  

		internal override Hashtable ToHashtable(ref Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (ControlPointOptions.IsDirty(ref highstock)) h.Add("controlPointOptions",ControlPointOptions.ToHashtable(ref highstock));
			if (ShapeOptions.IsDirty(ref highstock)) h.Add("shapeOptions",ShapeOptions.ToHashtable(ref highstock));
			if (TypeOptions.IsDirty(ref highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(ref highstock));
			

			return h;
		}

		internal override string ToJSON(ref Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highstock highstock)
		{
			return ToHashtable(ref highstock).Count > 0;
		}
	}
}