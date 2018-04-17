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
	public partial class XAxisTitle  : BaseObject
	{
		public XAxisTitle()
		{
			Align = Align_DefaultValue = XAxisTitleAlign.Middle;
			Style = Style_DefaultValue = new XAxisTitleStyle();
			Position3d = Position3d_DefaultValue = XAxisTitlePosition3d.Offset;
			Skew3d = Skew3d_DefaultValue = XAxisTitleSkew3d.False;
			Enabled = Enabled_DefaultValue = "middle";
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
		/// Alignment of the title relative to the axis values. Possiblevalues are "low", "middle" or "high".
		/// </summary>
		public XAxisTitleAlign Align { get; set; }
		private XAxisTitleAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the title. If the title text is longer than theaxis length, it will wrap to multiple lines by default. This canbe customized by setting `textOverflow: 'ellipsis'`, by setting a specific `width` or by setting `whiteSpace: 'nowrap'`.In styled mode, the stroke width is given in the`.highcharts-axis-title` class.
		/// </summary>
		public XAxisTitleStyle Style { get; set; }
		private XAxisTitleStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Defines how the title is repositioned according to the 3D chartorientation.- `'offset'`: Maintain a fixed horizontal/vertical distance from the  tick marks, despite the chart orientation. This is the backwards  compatible behavior, and causes skewing of X and Z axes.- `'chart'`: Preserve 3D position relative to the chart.  This looks nice, but hard to read if the text isn't  forward-facing.- `'flap'`: Rotated text along the axis to compensate for the chart  orientation. This tries to maintain text as legible as possible on  all orientations.- `'ortho'`: Rotated text along the axis direction so that the labels  are orthogonal to the axis. This is very similar to `'flap'`, but  prevents skewing the labels (X and Y scaling are still present).- `null`: Will use the config from `labels.position3d`
		/// </summary>
		public XAxisTitlePosition3d Position3d { get; set; }
		private XAxisTitlePosition3d Position3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// If enabled, the axis title will skewed to follow the perspective.This will fix overlapping labels and titles, but texts become lesslegible due to the distortion.The final appearance depends heavily on `title.position3d`.A `null` value will use the config from `labels.skew3d`.
		/// </summary>
		public XAxisTitleSkew3d Skew3d { get; set; }
		private XAxisTitleSkew3d Skew3d_DefaultValue { get; set; }
		 

		/// <summary>
		/// Deprecated. Set the `text` to `null` to disable the title.
		/// </summary>
		public string Enabled { get; set; }
		private string Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axis labels or line and the title. Defaults to 0 for horizontal axes, 10 for vertical
		/// </summary>
		public double? Margin { get; set; }
		private double? Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// The distance of the axis title from the axis line. By default, thisdistance is computed from the offset width of the labels, the labels'distance from the axis and the title's margin. However when the offsetoption is set, it overrides all this.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to reserve space for the title when laying out the axis.
		/// </summary>
		public bool? ReserveSpace { get; set; }
		private bool? ReserveSpace_DefaultValue { get; set; }
		 

		/// <summary>
		/// The rotation of the text in degrees. 0 is horizontal, 270 is verticalreading from bottom to top.
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// The actual text of the axis title. It can contain basic HTML textmarkup like <b>, <i> and spans with style.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether to [use HTML](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html) to render the axis title.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal pixel offset of the title position.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical pixel offset of the title position.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Position3d != Position3d_DefaultValue) h.Add("position3d", Highcharts.FirstCharacterToLower(Position3d.ToString()));
			if (Skew3d != Skew3d_DefaultValue) h.Add("skew3d", Highcharts.FirstCharacterToLower(Skew3d.ToString()));
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
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