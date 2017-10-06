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
	public partial class Exporting  : BaseObject
	{
		public Exporting()
		{
			Csv = Csv_DefaultValue = new ExportingCsv();
			ShowTable = ShowTable_DefaultValue = null;
			Type = Type_DefaultValue = ExportingType.Imagepng;
			Url = Url_DefaultValue = "https://export.highcharts.com/";
			PrintMaxWidth = PrintMaxWidth_DefaultValue = 780;
			Scale = Scale_DefaultValue = null;
			Buttons = Buttons_DefaultValue = new ExportingButtons();
			MenuItemDefinitions = MenuItemDefinitions_DefaultValue = null;
			AllowHTML = AllowHTML_DefaultValue = false;
			ChartOptions = ChartOptions_DefaultValue = null;
			Enabled = Enabled_DefaultValue = true;
			Error = Error_DefaultValue = "";
			FallbackToExportServer = FallbackToExportServer_DefaultValue = true;
			Filename = Filename_DefaultValue = "chart";
			FormAttributes = FormAttributes_DefaultValue = null;
			LibURL = LibURL_DefaultValue = null;
			SourceHeight = SourceHeight_DefaultValue = null;
			SourceWidth = SourceWidth_DefaultValue = null;
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Options for exporting data to CSV or ExCel, or displaying the datain a HTML table or a JavaScript structure. Requires the<code>export-data.js</code> module. This module adds data export options to theexport menu and provides functions like <code>Chart.getCSV</code>,<code>Chart.getTable</code>, <code>Chart.getDataRows</code> and <code>Chart.viewData</code>.</p>
		/// </summary>
		public ExportingCsv Csv { get; set; }
		private ExportingCsv Csv_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Export-data module required. Show a HTML table below the chart with the chart&#39;s current data.</p>
		/// </summary>
		public bool? ShowTable { get; set; }
		private bool? ShowTable_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Default MIME type for exporting if <code>chart.exportChart()</code> is calledwithout specifying a <code>type</code> option. Possible values are <code>image/png</code>, <code>image/jpeg</code>, <code>application/pdf</code> and <code>image/svg+xml</code>.</p>
		/// </summary>
		public ExportingType Type { get; set; }
		private ExportingType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The URL for the server module converting the SVG string to an imageformat. By default this points to Highchart&#39;s free web service.</p>
		/// </summary>
		public string Url { get; set; }
		private string Url_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When printing the chart from the menu item in the burger menu, ifthe on-screen chart exceeds this width, it is resized. After printingor cancelled, it is restored. The default width makes the chartfit into typical paper format. Note that this does not affect thechart when printing the web page as a whole.</p>
		/// </summary>
		public double? PrintMaxWidth { get; set; }
		private double? PrintMaxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Defines the scale or zoom factor for the exported image comparedto the on-screen display. While for instance a 600px wide chartmay look good on a website, it will look bad in print. The defaultscale of 2 makes this chart export to a 1200px PNG or JPG.</p>
		/// </summary>
		public double? Scale { get; set; }
		private double? Scale_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the export related buttons, print and export. In additionto the default buttons listed here, custom buttons can be added.See <a href="#navigation.buttonOptions">navigation.buttonOptions</a> for generaloptions.</p>
		/// </summary>
		public ExportingButtons Buttons { get; set; }
		private ExportingButtons Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An object consisting of definitions for the menu items in the contextmenu. Each key value pair has a <code>key</code> that is referenced in the<a href="#exporting.buttons.contextButton.menuItems">menuItems</a> setting,and a <code>value</code>, which is an object with the following properties:</p><dl><dt>onclick</dt><dd>The click handler for the menu item</dd><dt>text</dt><dd>The text for the menu item</dd><dt>textKey</dt><dd>If internationalization is required, the key to a language string</dd></dl>
		/// </summary>
		public Object MenuItemDefinitions { get; set; }
		private Object MenuItemDefinitions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Experimental setting to allow HTML inside the chart (added throughthe <code>useHTML</code> options), directly in the exported image. This allowsyou to preserve complicated HTML structures like tables or bi-directionaltext in exported charts.</p><p>Disclaimer: The HTML is rendered in a <code>foreignObject</code> tag in thegenerated SVG. The official export server is based on PhantomJS,which supports this, but other SVG clients, like Batik, does notsupport it. This also applies to downloaded SVG that you want toopen in a desktop client.</p>
		/// </summary>
		public bool? AllowHTML { get; set; }
		private bool? AllowHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional chart options to be merged into an exported chart. Forexample, a common use case is to add data labels to improve readabilityof the exported chart, or to add a printer-friendly color scheme.</p>
		/// </summary>
		public Object ChartOptions { get; set; }
		private Object ChartOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to enable the exporting module. Disabling the module willhide the context button, but API methods will still be available.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Function to call if the offline-exporting module fails to exporta chart on the client side, and <a href="#exporting.fallbackToExportServer">fallbackToExportServer</a> is disabled. If left undefined, an exceptionis thrown instead.</p>
		/// </summary>
		public string Error { get; set; }
		private string Error_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether or not to fall back to the export server if the offline-exportingmodule is unable to export the chart on the client side.</p>
		/// </summary>
		public bool? FallbackToExportServer { get; set; }
		private bool? FallbackToExportServer_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The filename, without extension, to use for the exported chart.</p>
		/// </summary>
		public string Filename { get; set; }
		private string Filename_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An object containing additional attributes for the POST form thatsends the SVG to the export server. For example, a <code>target</code> can beset to make sure the generated image is received in another frame, or a custom <code>enctype</code> or <code>encoding</code> can be set.</p>
		/// </summary>
		public Object FormAttributes { get; set; }
		private Object FormAttributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Path where Highcharts will look for export module dependencies toload on demand if they don&#39;t already exist on <code>window</code>. Should currentlypoint to location of <a href="https://github.com/canvg/canvg">CanVG</a> library,<a href="https://github.com/canvg/canvg">RGBColor.js</a>, <a href="https://github.com/yWorks/jsPDF">jsPDF</a> and <a href="https://github.com/yWorks/svg2pdf.js">svg2pdf.js</a>, required for client side export in certain browsers.</p>
		/// </summary>
		public string LibURL { get; set; }
		private string LibURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Analogous to <a href="#exporting.sourceWidth">sourceWidth</a>.</p>
		/// </summary>
		public double? SourceHeight { get; set; }
		private double? SourceHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width of the original chart when exported, unless an explicit<a href="#chart.width">chart.width</a> is set. The width exported raster imageis then multiplied by <a href="#exporting.scale">scale</a>.</p>
		/// </summary>
		public double? SourceWidth { get; set; }
		private double? SourceWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel width of charts exported to PNG or JPG. As of Highcharts3.0, the default pixel width is a function of the <a href="#chart.width">chart.width</a> or <a href="#exporting.sourceWidth">exporting.sourceWidth</a> and the<a href="#exporting.scale">exporting.scale</a>.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Csv.IsDirty()) h.Add("csv",Csv.ToHashtable());
			if (ShowTable != ShowTable_DefaultValue) h.Add("showTable",ShowTable);
			if (Type != Type_DefaultValue) h.Add("type", Highstock.FirstCharacterToLower(Type.ToString()));
			if (Url != Url_DefaultValue) h.Add("url",Url);
			if (PrintMaxWidth != PrintMaxWidth_DefaultValue) h.Add("printMaxWidth",PrintMaxWidth);
			if (Scale != Scale_DefaultValue) h.Add("scale",Scale);
			if (Buttons.IsDirty()) h.Add("buttons",Buttons.ToHashtable());
			if (MenuItemDefinitions != MenuItemDefinitions_DefaultValue) h.Add("menuItemDefinitions",MenuItemDefinitions);
			if (AllowHTML != AllowHTML_DefaultValue) h.Add("allowHTML",AllowHTML);
			if (ChartOptions != ChartOptions_DefaultValue) h.Add("chartOptions",ChartOptions);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Error != Error_DefaultValue) h.Add("error",Error);
			if (FallbackToExportServer != FallbackToExportServer_DefaultValue) h.Add("fallbackToExportServer",FallbackToExportServer);
			if (Filename != Filename_DefaultValue) h.Add("filename",Filename);
			if (FormAttributes != FormAttributes_DefaultValue) h.Add("formAttributes",FormAttributes);
			if (LibURL != LibURL_DefaultValue) h.Add("libURL",LibURL);
			if (SourceHeight != SourceHeight_DefaultValue) h.Add("sourceHeight",SourceHeight);
			if (SourceWidth != SourceWidth_DefaultValue) h.Add("sourceWidth",SourceWidth);
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