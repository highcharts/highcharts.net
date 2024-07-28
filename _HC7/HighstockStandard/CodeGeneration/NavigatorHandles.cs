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
	public partial class NavigatorHandles  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigatorHandles()
		{
		}	
		

		/// <summary>
		/// The fill for the handle.
		/// </summary>
		public string BackgroundColor { get; set; }
		 

		/// <summary>
		/// The stroke for the handle border and the stripes inside.
		/// </summary>
		public string BorderColor { get; set; }
		 

		/// <summary>
		/// Border radius of the handles.
		/// </summary>
		public double? BorderRadius { get; set; }
		 

		/// <summary>
		/// Allows to enable/disable handles.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Height for handles.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The width for the handle border and the stripes inside.
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// Array to define shapes of handles. 0-index for left, 1-index forright.Additionally, the URL to a graphic can be given on this form:`url(graphic.png)`. Note that for the image to be applied toexported charts, its URL needs to be accessible by the exportserver.Custom callbacks for symbol path generation can also be added to`Highcharts.SVGRenderer.prototype.symbols`. The callback is thenused by its method name, as shown in the demo.
		/// </summary>
		public List<string> Symbols { get; set; }
		 

		/// <summary>
		/// Width for handles.
		/// </summary>
		public double? Width { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (BackgroundColor != null) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != null) h.Add("borderColor",BorderColor);
			if (BorderRadius != null) h.Add("borderRadius",BorderRadius);
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Height != null) h.Add("height",Height);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (Symbols != null) h.Add("symbols", HashifyList(highstock,Symbols));
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