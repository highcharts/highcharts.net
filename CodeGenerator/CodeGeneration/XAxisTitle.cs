using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class XAxisTitle
	{
		public XAxisTitle()
		{
			Align = Align_DefaultValue = "middle";
			Enabled = Enabled_DefaultValue = "middle";
			Margin = Margin_DefaultValue = null;
			Offset = Offset_DefaultValue = null;
			Rotation = Rotation_DefaultValue = 0;
			Style = Style_DefaultValue = new NameValueCollection{{ "color", "#707070"},{ "fontWeight", "bold" }};
			Text = Text_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Alignment of the title relative to the axis values. Possible values are "low", "middle" or "high".
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. Set the <code>text</code> to <code>null</code> to disable the title.
		/// </summary>
		public string Enabled { get; set; }
		private string Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the axis title from the axis line. By default, this distance is  computed from the offset width of the labels, the labels' distance from  the axis and the title's margin. However when the offset option is set, it overrides all this.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 is vertical reading from bottom to top.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. When titles are rotated they are rendered using vector graphic techniques and not all styles are applicable.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The actual text of the axis title. It can contain basic HTML text markup like &lt;b&gt;, &lt;i&gt; and spans with style.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}