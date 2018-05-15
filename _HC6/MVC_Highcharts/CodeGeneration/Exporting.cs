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
			Csv = Csv_DefaultValue = new ExportingCsv();
			Enabled = Enabled_DefaultValue = true;
			Error = Error_DefaultValue = "";
			FallbackToExportServer = FallbackToExportServer_DefaultValue = true;
			Filename = Filename_DefaultValue = "chart";
			FormAttributes = FormAttributes_DefaultValue = null;
			LibURL = LibURL_DefaultValue = "";
			MenuItemDefinitions = MenuItemDefinitions_DefaultValue = null;
			PrintMaxWidth = PrintMaxWidth_DefaultValue = 780;
			Scale = Scale_DefaultValue = 2;
			ShowTable = ShowTable_DefaultValue = false;
			SourceHeight = SourceHeight_DefaultValue = null;
			SourceWidth = SourceWidth_DefaultValue = null;
			TableCaption = TableCaption_DefaultValue = "null";
			TableCaptionBool = TableCaptionBool_DefaultValue = null;
			Type = Type_DefaultValue = ExportingType.Imagepng;
			Url = Url_DefaultValue = "https://export.highcharts.com/";
			UseMultiLevelHeaders = UseMultiLevelHeaders_DefaultValue = true;
			UseRowspanHeaders = UseRowspanHeaders_DefaultValue = true;
			Width = Width_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Experimental setting to allow HTML inside the chart (added throughthe `useHTML` options), directly in the exported image. This allowsyou to preserve complicated HTML structures like tables or bi-directionaltext in exported charts.Disclaimer: The HTML is rendered in a `foreignObject` tag in thegenerated SVG. The official export server is based on PhantomJS,which supports this, but other SVG clients, like Batik, does notsupport it. This also applies to downloaded SVG that you want toopen in a desktop client.
		/// </summary>
		public bool? AllowHTML { get; set; }
		private bool? AllowHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the export related buttons, print and export. In additionto the default buttons listed here, custom buttons can be added.See [navigation.buttonOptions](#navigation.buttonOptions) for generaloptions.
		/// </summary>
		public ExportingButtons Buttons { get; set; }
		private ExportingButtons Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional chart options to be merged into an exported chart. Forexample, a common use case is to add data labels to improve readabilityof the exported chart, or to add a printer-friendly color scheme.
		/// </summary>
		public Object ChartOptions { get; set; }
		private Object ChartOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for exporting data to CSV or ExCel, or displaying the datain a HTML table or a JavaScript structure. Requires the`export-data.js` module. This module adds data export options to theexport menu and provides functions like `Chart.getCSV`,`Chart.getTable`, `Chart.getDataRows` and `Chart.viewData`.
		/// </summary>
		public ExportingCsv Csv { get; set; }
		private ExportingCsv Csv_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to enable the exporting module. Disabling the module willhide the context button, but API methods will still be available.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Function to call if the offline-exporting module fails to exporta chart on the client side, and [fallbackToExportServer](#exporting.fallbackToExportServer) is disabled. If left undefined, anexception is thrown instead.
		/// </summary>
		public string Error { get; set; }
		private string Error_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether or not to fall back to the export server if the offline-exportingmodule is unable to export the chart on the client side.
		/// </summary>
		public bool? FallbackToExportServer { get; set; }
		private bool? FallbackToExportServer_DefaultValue { get; set; }
		 

		/// <summary>
		/// The filename, without extension, to use for the exported chart.
		/// </summary>
		public string Filename { get; set; }
		private string Filename_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object containing additional attributes for the POST form thatsends the SVG to the export server. For example, a `target` can beset to make sure the generated image is received in another frame, or a custom `enctype` or `encoding` can be set.
		/// </summary>
		public Object FormAttributes { get; set; }
		private Object FormAttributes_DefaultValue { get; set; }
		 

		/// <summary>
		/// Path where Highcharts will look for export module dependencies toload on demand if they don't already exist on `window`. Should currentlypoint to location of [CanVG](https://github.com/canvg/canvg) library,[RGBColor.js](https://github.com/canvg/canvg), [jsPDF](https://github.com/yWorks/jsPDF) and [svg2pdf.js](https://github.com/yWorks/svg2pdf.js), required for client side export in certain browsers.
		/// </summary>
		public string LibURL { get; set; }
		private string LibURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// An object consisting of definitions for the menu items in the contextmenu. Each key value pair has a `key` that is referenced in the[menuItems](#exporting.buttons.contextButton.menuItems) setting,and a `value`, which is an object with the following properties:<dl><dt>onclick</dt><dd>The click handler for the menu item</dd><dt>text</dt><dd>The text for the menu item</dd><dt>textKey</dt><dd>If internationalization is required, the key to a language string</dd></dl>
		/// </summary>
		public Object MenuItemDefinitions { get; set; }
		private Object MenuItemDefinitions_DefaultValue { get; set; }
		 

		/// <summary>
		/// When printing the chart from the menu item in the burger menu, ifthe on-screen chart exceeds this width, it is resized. After printingor cancelled, it is restored. The default width makes the chartfit into typical paper format. Note that this does not affect thechart when printing the web page as a whole.
		/// </summary>
		public double? PrintMaxWidth { get; set; }
		private double? PrintMaxWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines the scale or zoom factor for the exported image comparedto the on-screen display. While for instance a 600px wide chartmay look good on a website, it will look bad in print. The defaultscale of 2 makes this chart export to a 1200px PNG or JPG.
		/// </summary>
		public double? Scale { get; set; }
		private double? Scale_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module required. Show a HTML table below the chart withthe chart's current data.
		/// </summary>
		public bool? ShowTable { get; set; }
		private bool? ShowTable_DefaultValue { get; set; }
		 

		/// <summary>
		/// Analogous to [sourceWidth](#exporting.sourceWidth).
		/// </summary>
		public double? SourceHeight { get; set; }
		private double? SourceHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The width of the original chart when exported, unless an explicit[chart.width](#chart.width) is set. The width exported raster imageis then multiplied by [scale](#exporting.scale).
		/// </summary>
		public double? SourceWidth { get; set; }
		private double? SourceWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module required. Caption for the data table. Same aschart title by default. Set to `false` to disable.
		/// </summary>
		public string TableCaption { get; set; }
		private string TableCaption_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module required. Caption for the data table. Same aschart title by default. Set to `false` to disable.
		/// </summary>
		public bool? TableCaptionBool { get; set; }
		private bool? TableCaptionBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Default MIME type for exporting if `chart.exportChart()` is calledwithout specifying a `type` option. Possible values are `image/png`, `image/jpeg`, `application/pdf` and `image/svg+xml`.
		/// </summary>
		public ExportingType Type { get; set; }
		private ExportingType Type_DefaultValue { get; set; }
		 

		/// <summary>
		/// The URL for the server module converting the SVG string to an imageformat. By default this points to Highchart's free web service.
		/// </summary>
		public string Url { get; set; }
		private string Url_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module required. Use multi level headers in data table.If [csv.columnHeaderFormatter](#exporting.csv.columnHeaderFormatter)is defined, it has to return objects in order for multi level headersto work.
		/// </summary>
		public bool? UseMultiLevelHeaders { get; set; }
		private bool? UseMultiLevelHeaders_DefaultValue { get; set; }
		 

		/// <summary>
		/// Export-data module required. If using multi level table headers, userowspans for headers that have only one level.
		/// </summary>
		public bool? UseRowspanHeaders { get; set; }
		private bool? UseRowspanHeaders_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel width of charts exported to PNG or JPG. As of Highcharts3.0, the default pixel width is a function of the [chart.width](#chart.width) or [exporting.sourceWidth](#exporting.sourceWidth) and the[exporting.scale](#exporting.scale).
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (AllowHTML != AllowHTML_DefaultValue) h.Add("allowHTML",AllowHTML);
			if (Buttons.IsDirty()) h.Add("buttons",Buttons.ToHashtable());
			if (ChartOptions != ChartOptions_DefaultValue) h.Add("chartOptions",ChartOptions);
			if (Csv.IsDirty()) h.Add("csv",Csv.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Error != Error_DefaultValue) { h.Add("error",Error); Highcharts.AddFunction("ExportingError.error", Error); }  
			if (FallbackToExportServer != FallbackToExportServer_DefaultValue) h.Add("fallbackToExportServer",FallbackToExportServer);
			if (Filename != Filename_DefaultValue) h.Add("filename",Filename);
			if (FormAttributes != FormAttributes_DefaultValue) h.Add("formAttributes",FormAttributes);
			if (LibURL != LibURL_DefaultValue) h.Add("libURL",LibURL);
			if (MenuItemDefinitions != MenuItemDefinitions_DefaultValue) h.Add("menuItemDefinitions",MenuItemDefinitions);
			if (PrintMaxWidth != PrintMaxWidth_DefaultValue) h.Add("printMaxWidth",PrintMaxWidth);
			if (Scale != Scale_DefaultValue) h.Add("scale",Scale);
			if (ShowTable != ShowTable_DefaultValue) h.Add("showTable",ShowTable);
			if (SourceHeight != SourceHeight_DefaultValue) h.Add("sourceHeight",SourceHeight);
			if (SourceWidth != SourceWidth_DefaultValue) h.Add("sourceWidth",SourceWidth);
			if (TableCaption != TableCaption_DefaultValue) h.Add("tableCaption",TableCaption);
			if (TableCaptionBool != TableCaptionBool_DefaultValue) h.Add("tableCaption",TableCaptionBool);
			if (Type != Type_DefaultValue) h.Add("type", Highcharts.FirstCharacterToLower(Type.ToString()));
			if (Url != Url_DefaultValue) h.Add("url",Url);
			if (UseMultiLevelHeaders != UseMultiLevelHeaders_DefaultValue) h.Add("useMultiLevelHeaders",UseMultiLevelHeaders);
			if (UseRowspanHeaders != UseRowspanHeaders_DefaultValue) h.Add("useRowspanHeaders",UseRowspanHeaders);
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