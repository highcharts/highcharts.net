using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class AnnotationsMeasureTypeOptionsLabel  : BaseObject
	{
		public AnnotationsMeasureTypeOptionsLabel()
		{
			Enabled = Enabled_DefaultValue = true;
			Formatter = Formatter_DefaultValue = "";
			Style = Style_DefaultValue = new AnnotationsMeasureTypeOptionsLabelStyle();
			
		}	
		

		/// <summary>
		/// Enable or disable the label text (min, max, average,bins values).Defaults to true.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Formatter function for the label text.Available data are:<table><tbody><tr><td>`this.min`</td><td>The mininimum value of the points in the selectedrange.</td></tr><tr><td>`this.max`</td><td>The maximum value of the points in the selectedrange.</td></tr><tr><td>`this.average`</td><td>The average value of the points in the selectedrange.</td></tr><tr><td>`this.bins`</td><td>The amount of the points in the selected range.</td></tr></table>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the measure label.
		/// </summary>
		public AnnotationsMeasureTypeOptionsLabelStyle Style { get; set; }
		private AnnotationsMeasureTypeOptionsLabelStyle Style_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Formatter != Formatter_DefaultValue) { h.Add("formatter",Formatter); Highstock.AddFunction("AnnotationsMeasureTypeOptionsLabelFormatter.formatter", Formatter); }  
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			

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