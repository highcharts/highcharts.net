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
	public partial class ItemStyleItem  : BaseObject
	{
		public ItemStyleItem()
		{
			Color = Color_DefaultValue = "";
			LineStyle = LineStyle_DefaultValue = "";
			AreaStyle = AreaStyle_DefaultValue = "";
			TextStyle = TextStyle_DefaultValue = "";
			ChordStyle = ChordStyle_DefaultValue = "";
			NodeStyle = NodeStyle_DefaultValue = "";
			LinkStyle = LinkStyle_DefaultValue = "";
			BorderColor = BorderColor_DefaultValue = "";
			BorderWidth = BorderWidth_DefaultValue = "";
			BarBorderColor = BarBorderColor_DefaultValue = #fff;
			BarBorderRadius = BarBorderRadius_DefaultValue = null;
			BarBorderWidth = BarBorderWidth_DefaultValue = null;
			Label = Label_DefaultValue = null;
			LabelLine = LabelLine_DefaultValue = null;
			Breadcrumb = Breadcrumb_DefaultValue = new ItemStyleItemBreadcrumb();
			ChildBorderWidth = ChildBorderWidth_DefaultValue = null;
			ChildBorderColor = ChildBorderColor_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// color, dominant color, function paramater is <br>{seriesIndex:x, series:xxx, dataIndex:y, data:yyy}
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// line style.
		/// </summary>
		public Object LineStyle { get; set; }
		private Object LineStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// area style.
		/// </summary>
		public Object AreaStyle { get; set; }
		private Object AreaStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// text style.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// chord style.
		/// </summary>
		public Object ChordStyle { get; set; }
		private Object ChordStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// node style.
		/// </summary>
		public Object NodeStyle { get; set; }
		private Object NodeStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// link style.
		/// </summary>
		public Object LinkStyle { get; set; }
		private Object LinkStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// color of border.
		/// </summary>
		public string BorderColor { get; set; }
		private string BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// width of column border, in px.
		/// </summary>
		public number BorderWidth { get; set; }
		private number BorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// color of border.
		/// </summary>
		public string BarBorderColor { get; set; }
		private string BarBorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// radius of bar (column) border, in px, defaults to 0. can be Array to assign a radius to the 4 corners, such as [5, 5, 0, 0](clockwise as left-top, right-top, right-bottom, left-bottom)
		/// </summary>
		public string BarBorderRadius { get; set; }
		private string BarBorderRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// width of bar (column) border, in px, defaults to 0.
		/// </summary>
		public number BarBorderWidth { get; set; }
		private number BarBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// In pie, displayed on the outside by default. labelLine.length controls the label's distance from the pie.                                <br>In funnel, displayed on the right by default. labelLine.length controls the label's distance from the funnel.                                <br>In map, the location of labels cannot be specified.                                <br> position can be specified in line, column, candlestick, scatter. See below.
		/// </summary>
		public Object Label { get; set; }
		private Object Label_DefaultValue { get; set; }
		 

		/// <summary>
		/// the visual guide of labels in pie. Defaults to show.
		/// </summary>
		public Object LabelLine { get; set; }
		private Object LabelLine_DefaultValue { get; set; }
		 

		/// <summary>
		/// breadcrumb
		/// </summary>
		public ItemStyleItemBreadcrumb Breadcrumb { get; set; }
		private ItemStyleItemBreadcrumb Breadcrumb_DefaultValue { get; set; }
		 

		/// <summary>
		/// width of second level border.
		/// </summary>
		public number ChildBorderWidth { get; set; }
		private number ChildBorderWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// color of second level border.
		/// </summary>
		public color ChildBorderColor { get; set; }
		private color ChildBorderColor_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (LineStyle != LineStyle_DefaultValue) h.Add("lineStyle",LineStyle);
			if (AreaStyle != AreaStyle_DefaultValue) h.Add("areaStyle",AreaStyle);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			if (ChordStyle != ChordStyle_DefaultValue) h.Add("chordStyle",ChordStyle);
			if (NodeStyle != NodeStyle_DefaultValue) h.Add("nodeStyle",NodeStyle);
			if (LinkStyle != LinkStyle_DefaultValue) h.Add("linkStyle",LinkStyle);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (BorderWidth != BorderWidth_DefaultValue) h.Add("borderWidth",BorderWidth);
			if (BarBorderColor != BarBorderColor_DefaultValue) h.Add("barBorderColor",BarBorderColor);
			if (BarBorderRadius != BarBorderRadius_DefaultValue) h.Add("barBorderRadius",BarBorderRadius);
			if (BarBorderWidth != BarBorderWidth_DefaultValue) h.Add("barBorderWidth",BarBorderWidth);
			if (Label != Label_DefaultValue) h.Add("label",Label);
			if (LabelLine != LabelLine_DefaultValue) h.Add("labelLine",LabelLine);
			if (Breadcrumb.IsDirty()) h.Add("breadcrumb",Breadcrumb.ToHashtable());
			if (ChildBorderWidth != ChildBorderWidth_DefaultValue) h.Add("childBorderWidth",ChildBorderWidth);
			if (ChildBorderColor != ChildBorderColor_DefaultValue) h.Add("childBorderColor",ChildBorderColor);
			

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