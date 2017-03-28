using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Exporting  : BaseObject
	{
		public Exporting()
		{
			AllowHTML = AllowHTML_DefaultValue = false;
			Buttons = Buttons_DefaultValue = new ExportingButtons();
			ChartOptions = ChartOptions_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Error = Error_DefaultValue = "";
			FallbackToExportServer = FallbackToExportServer_DefaultValue = true;
			Filename = Filename_DefaultValue = "chart";
			FormAttributes = FormAttributes_DefaultValue = "";
			LibURL = LibURL_DefaultValue = "https://code.highcharts.com/{version}/lib";
			PrintMaxWidth = PrintMaxWidth_DefaultValue = 780;
			Scale = Scale_DefaultValue = 2;
			SourceHeight = SourceHeight_DefaultValue = null;
			SourceWidth = SourceWidth_DefaultValue = null;
			Type = Type_DefaultValue = ExportingType.Imagepng;
			Url = Url_DefaultValue = "https://export.highcharts.com";
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Experimental setting to allow HTML inside the chart (added through the <code>useHTML</code> options), directly in the exported image. This allows you to preserve complicated HTML structures like tables or bi-directional text in exported charts.</p><p>Disclaimer: The HTML is rendered in a <code>foreignObject</code> tag in the generated SVG. The official export server is based on PhantomJS, which supports this, but other SVG clients, like Batik, does not support it. This also applies to downloaded SVG that you want to open in a desktop client.</p>
		/// </summary>
		public bool? AllowHTML { get; set; }
		private bool? AllowHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the export related buttons, print and export. In addition to the default buttons listed here, custom buttons can be added. See <a href="#navigation.buttonOptions">navigation.buttonOptions</a> for general options.
		/// </summary>
		public ExportingButtons Buttons { get; set; }
		private ExportingButtons Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional chart options to be merged into an exported chart. For example, a common use case is to add data labels to improve readaility of the exported chart, or to add a printer-friendly color scheme.
		/// </summary>
		public Object ChartOptions { get; set; }
		private Object ChartOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable the exporting module. Disabling the module will hide the context button, but API methods will still be available.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to call if the offline-exporting module fails to export a chart on the client side, and <a href="#exporting.fallbackToExportServer">fallbackToExportServer</a> is disabled. If left undefined, an exception is thrown instead.
		/// </summary>
		public string Error { get; set; }
		private string Error_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to fall back to the export server if the offline-exporting module is unable to export the chart on the client side.
		/// </summary>
		public bool? FallbackToExportServer { get; set; }
		private bool? FallbackToExportServer_DefaultValue { get; set; }
		 

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
		/// Path where Highcharts will look for export module dependencies to load on demand if they don't already exist on <code>window</code>.Should currently point to location of <a href="https://github.com/canvg/canvg">CanVG</a> library, <a href="https://github.com/canvg/canvg">RGBColor.js</a>, <a href="https://github.com/yWorks/jsPDF">jsPDF</a> and <a href="https://github.com/yWorks/svg2pdf.js">svg2pdf.js</a>, required for client side export in certain browsers.
		/// </summary>
		public string LibURL { get; set; }
		private string LibURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// When printing the chart from the menu item in the burger menu, if the on-screen chart exceeds this width, it is resized. After printing or cancelled, it is restored. The default width makes the chart fit into typical paper format. Note that this does not affect the chart when printing the web page as a whole.
		/// </summary>
		public double? PrintMaxWidth { get; set; }
		private double? PrintMaxWidth_DefaultValue { get; set; }
		 

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
		/// The URL for the server module converting the SVG string to an image format. By default this points to Highchart's free web service.
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

			if (AllowHTML != AllowHTML_DefaultValue) h.Add("allowHTML",AllowHTML);
			if (Buttons.IsDirty()) h.Add("buttons",Buttons.ToHashtable());
			if (ChartOptions != ChartOptions_DefaultValue) h.Add("chartOptions",ChartOptions);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Error != Error_DefaultValue) { h.Add("error",Error); Highcharts.AddFunction("ExportingError.error", Error); }  
			if (FallbackToExportServer != FallbackToExportServer_DefaultValue) h.Add("fallbackToExportServer",FallbackToExportServer);
			if (Filename != Filename_DefaultValue) h.Add("filename",Filename);
			if (FormAttributes != FormAttributes_DefaultValue) h.Add("formAttributes",FormAttributes);
			if (LibURL != LibURL_DefaultValue) h.Add("libURL",LibURL);
			if (PrintMaxWidth != PrintMaxWidth_DefaultValue) h.Add("printMaxWidth",PrintMaxWidth);
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