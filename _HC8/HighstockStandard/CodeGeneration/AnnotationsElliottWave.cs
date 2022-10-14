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
	public partial class AnnotationsElliottWave  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsElliottWave()
		{
			LabelOptions = LabelOptions_DefaultValue = new AnnotationsElliottWaveLabelOptions();
			TypeOptions = TypeOptions_DefaultValue = new AnnotationsElliottWaveTypeOptions();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveLabelOptions LabelOptions { get; set; }
		private AnnotationsElliottWaveLabelOptions LabelOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveTypeOptions TypeOptions { get; set; }
		private AnnotationsElliottWaveTypeOptions TypeOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (LabelOptions.IsDirty(highstock)) h.Add("labelOptions",LabelOptions.ToHashtable(highstock));
			if (TypeOptions.IsDirty(highstock)) h.Add("typeOptions",TypeOptions.ToHashtable(highstock));
			

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