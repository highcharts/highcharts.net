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
	public partial class XAxisTitle  : BaseObject
	{
		public XAxisTitle()
		{
			Align = Align_DefaultValue = XAxisTitleAlign.Middle;
			Style = Style_DefaultValue = new XAxisTitleStyle();
			Margin = Margin_DefaultValue = null;
			Offset = Offset_DefaultValue = null;
			ReserveSpace = ReserveSpace_DefaultValue = true;
			Rotation = Rotation_DefaultValue = 0;
			Text = Text_DefaultValue = "null";
			UseHTML = UseHTML_DefaultValue = false;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Alignment of the title relative to the axis values. Possiblevalues are &quot;low&quot;, &quot;middle&quot; or &quot;high&quot;.</p>
		/// </summary>
		public XAxisTitleAlign Align { get; set; }
		private XAxisTitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>CSS styles for the title. If the title text is longer than theaxis length, it will wrap to multiple lines by default. This canbe customized by setting <code>textOverflow: &#39;ellipsis&#39;</code>, by setting a specific <code>width</code> or by setting <code>wordSpace: &#39;nowrap&#39;</code>.</p><p>In styled mode, the stroke width is given in the<code>.highcharts-axis-title</code> class.</p>
		/// </summary>
		public XAxisTitleStyle Style { get; set; }
		private XAxisTitleStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical</p>
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The distance of the axis title from the axis line. By default, thisdistance is computed from the offset width of the labels, the labels&#39;distance from the axis and the title&#39;s margin. However when the offsetoption is set, it overrides all this.</p>
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to reserve space for the title when laying out the axis.</p>
		/// </summary>
		public bool? ReserveSpace { get; set; }
		private bool? ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The rotation of the text in degrees. 0 is horizontal, 270 is verticalreading from bottom to top.</p>
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The actual text of the axis title. It can contain basic HTML textmarkup like <b>, <i> and spans with style.</p>
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the axis title.</p>
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Horizontal pixel offset of the title position.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical pixel offset of the title position.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (ReserveSpace != ReserveSpace_DefaultValue) h.Add("reserveSpace",ReserveSpace);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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