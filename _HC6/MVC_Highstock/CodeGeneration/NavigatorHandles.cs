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
	public partial class NavigatorHandles  : BaseObject
	{
		public NavigatorHandles()
		{
			Width = Width_DefaultValue = 7;
			Height = Height_DefaultValue = 15;
			Symbols = Symbols_DefaultValue = new List<string>();
			Enabled = Enabled_DefaultValue = true;
			LineWidth = LineWidth_DefaultValue = 7;
			BackgroundColor = BackgroundColor_DefaultValue = "#f2f2f2";
			BorderColor = BorderColor_DefaultValue = "#999999";
			
		}	
		

		/// <summary>
		/// <p>Width for handles.</p>
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Height for handles.</p>
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Array to define shapes of handles. 0-index for left, 1-index forright.</p><p>Additionally, the URL to a graphic can be given on this form:<code>url(graphic.png)</code>. Note that for the image to be applied toexported charts, its URL needs to be accessible by the exportserver.</p><p>Custom callbacks for symbol path generation can also be added to<code>Highcharts.SVGRenderer.prototype.symbols</code>. The callback is thenused by its method name, as shown in the demo.</p>
		/// </summary>
		public List<string> Symbols { get; set; }
		private List<string> Symbols_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Allows to enable/disable handles.</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The width for the handle border and the stripes inside.</p>
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The fill for the handle.</p>
		/// </summary>
		public string BackgroundColor { get; set; }
		private string BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The stroke for the handle border and the stripes inside.</p>
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Symbols != Symbols_DefaultValue) h.Add("symbols", HashifyList(Symbols));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			

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