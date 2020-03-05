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
	public partial class PlotOptionsPackedBubbleDataLabels  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsPackedBubbleDataLabels()
		{
			Attributes = Attributes_DefaultValue = null;
			Format = Format_DefaultValue = "";
			ParentNodeFormat = ParentNodeFormat_DefaultValue = "";
			TextPath = TextPath_DefaultValue = new PlotOptionsPackedBubbleDataLabelsTextPath();
			
		}	
		

		/// <summary>
		/// Presentation attributes for the text path.
		/// </summary>
		public Object Attributes { get; set; }
		private Object Attributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// The[format string](https://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting)specifying what to show for _node_ in the networkgraph. In v7.0defaults to `{key}`, since v7.1 defaults to `undefined` and`formatter` is used instead.
		/// </summary>
		public string Format { get; set; }
		private string Format_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string ParentNodeFormat { get; set; }
		private string ParentNodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for a _node_ label text which should follow marker'sshape.**Note:** Only SVG-based renderer supports this option.
		/// </summary>
		public PlotOptionsPackedBubbleDataLabelsTextPath TextPath { get; set; }
		private PlotOptionsPackedBubbleDataLabelsTextPath TextPath_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Attributes != Attributes_DefaultValue) h.Add("attributes",Attributes);
			if (Format != Format_DefaultValue) h.Add("format",Format);
			if (ParentNodeFormat != ParentNodeFormat_DefaultValue) h.Add("parentNodeFormat",ParentNodeFormat);
			if (TextPath != TextPath_DefaultValue) h.Add("textPath",TextPath);
			

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