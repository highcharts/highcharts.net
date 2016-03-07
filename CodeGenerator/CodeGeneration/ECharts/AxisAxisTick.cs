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
	public partial class AxisAxisTick  : BaseObject
	{
		public AxisAxisTick()
		{
			Show = Show_DefaultValue = "";
			Interval = Interval_DefaultValue = auto;
			OnGap = OnGap_DefaultValue = null;
			Inside = Inside_DefaultValue = null;
			Length = Length_DefaultValue = null;
			LineStyle = LineStyle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Specifies whether to show axisTick. Defaults to false. The following properties will be set by default values When it is true.
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// specifies the interval between axisTicks. Defaults to 'auto'. Valid values are:                                 <br>'auto' (automatically hide those that cannot be displayed) | 0 (unhide all) |                                 <br><b>{number}</b>(specified by the user).                                 <br><b>{function}</b>callback, paramater is [index,data[index]], return true to show and false to hide
		/// </summary>
		public string Interval { get; set; }
		private string Interval_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the axisTick will be positioned at regular intervals. Defaults to boundaryGap.
		/// </summary>
		public boolean OnGap { get; set; }
		private boolean OnGap_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the axisTick will be displayed inside the grid. Defaults to outside.
		/// </summary>
		public boolean Inside { get; set; }
		private boolean Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// controls the length of the line.
		/// </summary>
		public number Length { get; set; }
		private number Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// controls the line style.
		/// </summary>
		public Object LineStyle { get; set; }
		private Object LineStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Interval != Interval_DefaultValue) h.Add("interval",Interval);
			if (OnGap != OnGap_DefaultValue) h.Add("onGap",OnGap);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (LineStyle != LineStyle_DefaultValue) h.Add("lineStyle",LineStyle);
			

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