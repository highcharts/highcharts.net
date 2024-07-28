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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveLabelOptions LabelOptions { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsElliottWaveTypeOptions TypeOptions { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (LabelOptions != null) h.Add("labelOptions",LabelOptions.ToHashtable(highstock));
			if (TypeOptions != null) h.Add("typeOptions",TypeOptions.ToHashtable(highstock));
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