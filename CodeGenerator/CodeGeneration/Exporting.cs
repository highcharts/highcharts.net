using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Highcharts
{
	public partial class Exporting  : BaseObject
	{
		public Exporting()
		{
			Buttons = Buttons_DefaultValue = new ExportingButtons();
			ChartOptions = ChartOptions_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Filename = Filename_DefaultValue = "chart";
			FormAttributes = FormAttributes_DefaultValue = "";
			Scale = Scale_DefaultValue = 2;
			SourceHeight = SourceHeight_DefaultValue = null;
			SourceWidth = SourceWidth_DefaultValue = null;
			Type = Type_DefaultValue = ExportingType.Imagepng;
			Url = Url_DefaultValue = "http://export.highcharts.com";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Options for the export related buttons, print and export. In addition to the default buttons listed here, custom buttons can be added. See <a href="#navigation.buttonOptions">navigation.buttonOptions</a> for general options.
		/// </summary>
		public ExportingButtons Buttons { get; set; }
		private ExportingButtons Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional chart options to be merged into an exported chart. For example, the exported chart can be given a specific width and height, or a printer-friendly color scheme.
		/// </summary>
		public Object ChartOptions { get; set; }
		private Object ChartOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable the exporting module. Disabling the module will hide the context button, but API methods will still be available.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The filename, without extension, to use for the exported chart.
		/// </summary>
		public string Filename { get; set; }
		private string Filename_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object containing additional attributes for the POST form that sends the SVG to the export server. For example, a <code>target</code> can be set to make sure the generated image is received in another frame, or a custom <code>enctype</code> or <code>encoding</code> can be set.
		/// </summary>
		public Object FormAttributes { get; set; }
		private Object FormAttributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the scale or zoom factor for the exported image compared to the on-screen display. While for instance a 600px wide chart may look good on a website, it will look bad in print. The default scale of 2 makes this chart export to a 1200px PNG or JPG. 
		/// </summary>
		public double? Scale { get; set; }
		private double? Scale_DefaultValue { get; set; }
		 

		/// <summary>
		/// Analogous to <a href="#exporting.sourceWidth">sourceWidth</a>
		/// </summary>
		public double? SourceHeight { get; set; }
		private double? SourceHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the original chart when exported, unless an explicit <a href="#chart.width">chart.width</a> is set. The width exported raster image is then multiplied by <a href="#exporting.scale">scale</a>.
		/// </summary>
		public double? SourceWidth { get; set; }
		private double? SourceWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default MIME type for exporting if <code>chart.exportChart()</code> is called without specifying a <code>type</code> option. Possible values are <code>image/png</code>, <code>image/jpeg</code>, <code>application/pdf</code> and <code>image/svg+xml</code>.
		/// </summary>
		public ExportingType Type { get; set; }
		private ExportingType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL for the server module converting the SVG string to an image format. By default this points to Highslide Software's free web service.
		/// </summary>
		public string Url { get; set; }
		private string Url_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of charts exported to PNG or JPG. As of Highcharts 3.0, the default pixel width is a function of the <a href="#chart.width">chart.width</a> or <a href="#exporting.sourceWidth">exporting.sourceWidth</a> and the <a href="#exporting.scale">exporting.scale</a>.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Buttons.IsDirty()) h.Add("buttons",Buttons.ToHashtable());
			if (ChartOptions != ChartOptions_DefaultValue) h.Add("chartOptions",ChartOptions);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Filename != Filename_DefaultValue) h.Add("filename",Filename);
			if (FormAttributes != FormAttributes_DefaultValue) h.Add("formAttributes",FormAttributes);
			if (Scale != Scale_DefaultValue) h.Add("scale",Scale);
			if (SourceHeight != SourceHeight_DefaultValue) h.Add("sourceHeight",SourceHeight);
			if (SourceWidth != SourceWidth_DefaultValue) h.Add("sourceWidth",SourceWidth);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (Url != Url_DefaultValue) h.Add("url",Url);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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