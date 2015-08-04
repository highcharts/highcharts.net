using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highstock.Web.Mvc
{
	public partial class YAxisPlotBandsLabel  : BaseObject
	{
		public YAxisPlotBandsLabel()
		{
			Align = Align_DefaultValue = "'center'";
			Rotation = Rotation_DefaultValue = 0;
			Style = Style_DefaultValue = new NameValueCollection();
			TextAlign = TextAlign_DefaultValue = "";
			UseHTML = UseHTML_DefaultValue = false;
			VerticalAlign = VerticalAlign_DefaultValue = "'top'";
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Horizontal alignment of the label. Can be one of "left", "center" or "right".
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Rotation of the text label in degrees .
		/// </summary>
		public double? Rotation { get; set; }
		private double? Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the text label.
		/// </summary>
		public NameValueCollection Style { get; set; }
		private NameValueCollection Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// The text alignment for the label. While <code>align</code> determines where the texts anchor point is placed within the plot band, <code>textAlign</code> determines how the text is aligned against its anchor point. Possible values are "left", "center" and "right". Defaults to the same as the <code>align</code> option.
		/// </summary>
		public string TextAlign { get; set; }
		private string TextAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Whether to <a href="http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting#html">use HTML</a> to render the labels.
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the label relative to the plot band. Can be one of "top", "middle" or "bottom".
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal position relative the alignment. Default varies by orientation.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical position of the text baseline relative to the alignment. Default varies by orientation.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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