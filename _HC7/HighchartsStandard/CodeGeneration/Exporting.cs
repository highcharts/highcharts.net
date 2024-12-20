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
	public partial class Exporting  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Exporting()
		{
		}	
		

		/// <summary>
		/// Accessibility options for the exporting menu. Requires theAccessibility module.
		/// </summary>
		public ExportingAccessibility Accessibility { get; set; }
		 

		/// <summary>
		/// Experimental setting to allow HTML inside the chart (added throughthe `useHTML` options), directly in the exported image. This allowsyou to preserve complicated HTML structures like tables or bi-directionaltext in exported charts.Disclaimer: The HTML is rendered in a `foreignObject` tag in thegenerated SVG. The official export server is based on PhantomJS,which supports this, but other SVG clients, like Batik, does notsupport it. This also applies to downloaded SVG that you want toopen in a desktop client.
		/// </summary>
		public bool? AllowHTML { get; set; }
		 

		/// <summary>
		/// Allows the end user to sort the data table by clicking on column headers.
		/// </summary>
		public bool? AllowTableSorting { get; set; }
		 

		/// <summary>
		/// Options for the export related buttons, print and export. In additionto the default buttons listed here, custom buttons can be added.See [navigation.buttonOptions](#navigation.buttonOptions) for generaloptions.
		/// </summary>
		public ExportingButtons Buttons { get; set; }
		 

		/// <summary>
		/// Additional chart options to be merged into the chart before exporting toan image format. This does not apply to printing the chart via the exportmenu.For example, a common use case is to add data labels to improvereadability of the exported chart, or to add a printer-friendly colorscheme to exported PDFs.
		/// </summary>
		public Object ChartOptions { get; set; }
		 

		/// <summary>
		/// Options for exporting data to CSV or ExCel, or displaying the datain a HTML table or a JavaScript structure.This module adds data export options to the export menu and providesfunctions like `Chart.getCSV`, `Chart.getTable`, `Chart.getDataRows`and `Chart.viewData`.The XLS converter is limited and only creates a HTML string that ispassed for download, which works but creates a warning beforeopening. The workaround for this is to use a third party XLSXconverter, as demonstrated in the sample below.
		/// </summary>
		public ExportingCsv Csv { get; set; }
		 

		/// <summary>
		/// Whether to enable the exporting module. Disabling the module willhide the context button, but API methods will still be available.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Function to call if the offline-exporting module fails to exporta chart on the client side, and [fallbackToExportServer](#exporting.fallbackToExportServer) is disabled. If left undefined, anexception is thrown instead. Receives two parameters, the exportingoptions, and the error from the module.
		/// </summary>
		public string Error { get; set; }
		 

		/// <summary>
		/// Whether or not to fall back to the export server if the offline-exportingmodule is unable to export the chart on the client side. This happens forcertain browsers, and certain features (e.g.[allowHTML](#exporting.allowHTML)), depending on the image type exportingto. For very complex charts, it is possible that export can fail inbrowsers that don't support Blob objects, due to data URL length limits.It is recommended to define the [exporting.error](#exporting.error)handler if disabling fallback, in order to notify users in case exportfails.
		/// </summary>
		public bool? FallbackToExportServer { get; set; }
		 

		/// <summary>
		/// Options for the fetch request used when sending the SVG to the exportserver.See [MDN](https://developer.mozilla.org/en-US/docs/Web/API/fetch)for more information
		/// </summary>
		public Object FetchOptions { get; set; }
		 

		/// <summary>
		/// The filename, without extension, to use for the exported chart.
		/// </summary>
		public string Filename { get; set; }
		 

		/// <summary>
		/// Highcharts v11.2.0 and older. An object containing additional key valuedata for the POST form that sends the SVG to the export server. Forexample, a `target` can be set to make sure the generated image isreceived in another frame, or a custom `enctype` or `encoding` can beset.With Highcharts v11.3.0, the `fetch` API replaced the old HTML form. Tomodify the request, now use [fetchOptions](#exporting.fetchOptions)instead.
		/// </summary>
		public Object FormAttributes { get; set; }
		 

		/// <summary>
		/// Path where Highcharts will look for export module dependencies toload on demand if they don't already exist on `window`. Should currentlypoint to location of [CanVG](https://github.com/canvg/canvg) library,[jsPDF](https://github.com/parallax/jsPDF) and[svg2pdf.js](https://github.com/yWorks/svg2pdf.js), required for clientside export in certain browsers.
		/// </summary>
		public string LibURL { get; set; }
		 

		/// <summary>
		/// An object consisting of definitions for the menu items in the contextmenu. Each key value pair has a `key` that is referenced in the[menuItems](#exporting.buttons.contextButton.menuItems) setting,and a `value`, which is an object with the following properties:- **onclick:** The click handler for the menu item- **text:** The text for the menu item- **textKey:** If internationalization is required, the key to a language  stringCustom text for the "exitFullScreen" can be set only in lang options(it is not a separate button).
		/// </summary>
		public Dictionary<string,ExportingMenuItemDefinitions> MenuItemDefinitions { get; set; }
		 

		/// <summary>
		/// Settings for a custom font for the exported PDF, when using the`offline-exporting` module. This is used for languages containingnon-ASCII characters, like Chinese, Russian, Japanese etc.As described in the [jsPDFdocs](https://github.com/parallax/jsPDF#use-of-unicode-characters--utf-8),the 14 standard fonts in PDF are limited to the ASCII-codepage.Therefore, in order to support other text in the exported PDF, one ormore TTF font files have to be passed on to the exporting module.See more in [thedocs](https://www.highcharts.com/docs/export-module/client-side-export).
		/// </summary>
		public ExportingPdfFont PdfFont { get; set; }
		 

		/// <summary>
		/// When printing the chart from the menu item in the burger menu, ifthe on-screen chart exceeds this width, it is resized. After printingor cancelled, it is restored. The default width makes the chartfit into typical paper format. Note that this does not affect thechart when printing the web page as a whole.
		/// </summary>
		public double? PrintMaxWidth { get; set; }
		 

		/// <summary>
		/// Defines the scale or zoom factor for the exported image comparedto the on-screen display. While for instance a 600px wide chartmay look good on a website, it will look bad in print. The defaultscale of 2 makes this chart export to a 1200px PNG or JPG.
		/// </summary>
		public double? Scale { get; set; }
		 

		/// <summary>
		/// Display a message when export is in progress.Uses [Chart.setLoading()](/class-reference/Highcharts.Chart#setLoading)The message can be altered by changing [](#lang.exporting.exportInProgress)
		/// </summary>
		public bool? ShowExportInProgress { get; set; }
		 

		/// <summary>
		/// Show a HTML table below the chart with the chart's current data.
		/// </summary>
		public bool? ShowTable { get; set; }
		 

		/// <summary>
		/// Analogous to [sourceWidth](#exporting.sourceWidth).
		/// </summary>
		public double? SourceHeight { get; set; }
		 

		/// <summary>
		/// The width of the original chart when exported, unless an explicit[chart.width](#chart.width) is set, or a pixel width is set on thecontainer. The width exported raster image is then multiplied by[scale](#exporting.scale).
		/// </summary>
		public double? SourceWidth { get; set; }
		 

		/// <summary>
		/// Caption for the data table. Same as chart title by default. Set to`false` to disable.
		/// </summary>
		public string TableCaption { get; set; }
		 

		/// <summary>
		/// Caption for the data table. Same as chart title by default. Set to`false` to disable.
		/// </summary>
		public bool? TableCaptionBool { get; set; }
		 

		/// <summary>
		/// Default MIME type for exporting if `chart.exportChart()` is calledwithout specifying a `type` option. Possible values are `image/png`, `image/jpeg`, `application/pdf` and `image/svg+xml`.
		/// </summary>
		public string Type { get; set; }
		 

		/// <summary>
		/// The URL for the server module converting the SVG string to an imageformat. By default this points to Highchart's free web service.
		/// </summary>
		public string Url { get; set; }
		 

		/// <summary>
		/// Use multi level headers in data table. If [csv.columnHeaderFormatter](#exporting.csv.columnHeaderFormatter) is defined, it has to returnobjects in order for multi level headers to work.
		/// </summary>
		public bool? UseMultiLevelHeaders { get; set; }
		 

		/// <summary>
		/// If using multi level table headers, use rowspans for headers thathave only one level.
		/// </summary>
		public bool? UseRowspanHeaders { get; set; }
		 

		/// <summary>
		/// The pixel width of charts exported to PNG or JPG. As of Highcharts3.0, the default pixel width is a function of the [chart.width](#chart.width) or [exporting.sourceWidth](#exporting.sourceWidth) and the[exporting.scale](#exporting.scale).
		/// </summary>
		public double? Width { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Accessibility != null) h.Add("accessibility",Accessibility.ToHashtable(highcharts));
			if (AllowHTML != null) h.Add("allowHTML",AllowHTML);
			if (AllowTableSorting != null) h.Add("allowTableSorting",AllowTableSorting);
			if (Buttons != null) h.Add("buttons",Buttons.ToHashtable(highcharts));
			if (ChartOptions != null) h.Add("chartOptions",ChartOptions);
			if (Csv != null) h.Add("csv",Csv.ToHashtable(highcharts));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Error != null) { h.Add("error",Error); highcharts.AddFunction("error", Error); }  
			if (FallbackToExportServer != null) h.Add("fallbackToExportServer",FallbackToExportServer);
			if (FetchOptions != null) h.Add("fetchOptions",FetchOptions);
			if (Filename != null) h.Add("filename",Filename);
			if (FormAttributes != null) h.Add("formAttributes",FormAttributes);
			if (LibURL != null) h.Add("libURL",LibURL);
			if (MenuItemDefinitions != null) h.Add("menuItemDefinitions", HashifyDictionary(highcharts,MenuItemDefinitions));
			if (PdfFont != null) h.Add("pdfFont",PdfFont.ToHashtable(highcharts));
			if (PrintMaxWidth != null) h.Add("printMaxWidth",PrintMaxWidth);
			if (Scale != null) h.Add("scale",Scale);
			if (ShowExportInProgress != null) h.Add("showExportInProgress",ShowExportInProgress);
			if (ShowTable != null) h.Add("showTable",ShowTable);
			if (SourceHeight != null) h.Add("sourceHeight",SourceHeight);
			if (SourceWidth != null) h.Add("sourceWidth",SourceWidth);
			if (TableCaption != null) h.Add("tableCaption",TableCaption);
			if (TableCaptionBool != null) h.Add("tableCaption",TableCaptionBool);
			if (Type != null) h.Add("type",Type);
			if (Url != null) h.Add("url",Url);
			if (UseMultiLevelHeaders != null) h.Add("useMultiLevelHeaders",UseMultiLevelHeaders);
			if (UseRowspanHeaders != null) h.Add("useRowspanHeaders",UseRowspanHeaders);
			if (Width != null) h.Add("width",Width);
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