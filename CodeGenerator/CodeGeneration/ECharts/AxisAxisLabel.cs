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
	public partial class AxisAxisLabel  : BaseObject
	{
		public AxisAxisLabel()
		{
			Show = Show_DefaultValue = null;
			Interval = Interval_DefaultValue = auto;
			Rotate = Rotate_DefaultValue = null;
			Margin = Margin_DefaultValue = new string[] {};
			Clickable = Clickable_DefaultValue = null;
			Formatter = Formatter_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show axisLabel. Defaults to true, which is a prerequisite for the following properties.
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// specifies the interval between axisLabels. Defaults to 'auto'. Valid values are:                                <br>'auto' (automatically hide those that cannot be displayed) | 0 (unhide all) |                                <br><b>{number}</b>(specified by the user).                                <br><b>{function}</b>callback, paramater is [index,data[index]], return true to show and false to hide
		/// </summary>
		public string Interval { get; set; }
		private string Interval_DefaultValue { get; set; }
		 

		/// <summary>
		/// The angle of rotation, defaults to 0 (not rotate). Positive value for counterclockwise rotation, negative value for clockwise rotation. Valid values are: -90 ~ 90.
		/// </summary>
		public number Rotate { get; set; }
		private number Rotate_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pixel distance between the axisLabel and the axis.Defaults to 8.
		/// </summary>
		public new string[] Margin { get; set; }
		private new string[] Margin_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the axisLabel is clickable.
		/// </summary>
		public boolean Clickable { get; set; }
		private boolean Clickable_DefaultValue { get; set; }
		 

		/// <summary>
		/// split name formatter: <b>{string}</b> (Template) | <b>{Function}</b>
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// text style. If the axis is value or time axis, color accepts method callback to achieve custom color definition, support <a href="https://github.com/ecomfe/echarts/issues/226" target="_blank">#226 �</a>
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Interval != Interval_DefaultValue) h.Add("interval",Interval);
			if (Rotate != Rotate_DefaultValue) h.Add("rotate",Rotate);
			if (Margin != Margin_DefaultValue) h.Add("margin",Margin);
			if (Clickable != Clickable_DefaultValue) h.Add("clickable",Clickable);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			

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