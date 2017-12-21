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
	public partial class PlotOptionsSankeyTooltipDateTimeLabelFormats  : BaseObject
	{
		public PlotOptionsSankeyTooltipDateTimeLabelFormats()
		{
			Millisecond = Millisecond_DefaultValue = %A, %b %e, %H:%M:%S.%L;
			Second = Second_DefaultValue = %A, %b %e, %H:%M:%S;
			Minute = Minute_DefaultValue = %A, %b %e, %H:%M;
			Hour = Hour_DefaultValue = %A, %b %e, %H:%M;
			Day = Day_DefaultValue = %A, %b %e, %Y;
			Week = Week_DefaultValue = Week from %A, %b %e, %Y;
			Month = Month_DefaultValue = %B %Y;
			Year = Year_DefaultValue = %Y;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsMillisecond Millisecond { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsMillisecond Millisecond_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsSecond Second { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsSecond Second_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsMinute Minute { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsMinute Minute_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsHour Hour { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsHour Hour_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsDay Day { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsDay Day_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsWeek Week { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsWeek Week_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsMonth Month { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsMonth Month_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSankeyTooltipDateTimeLabelFormatsYear Year { get; set; }
		private PlotOptionsSankeyTooltipDateTimeLabelFormatsYear Year_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Millisecond != Millisecond_DefaultValue) h.Add("millisecond",Millisecond);
			if (Second != Second_DefaultValue) h.Add("second",Second);
			if (Minute != Minute_DefaultValue) h.Add("minute",Minute);
			if (Hour != Hour_DefaultValue) h.Add("hour",Hour);
			if (Day != Day_DefaultValue) h.Add("day",Day);
			if (Week != Week_DefaultValue) h.Add("week",Week);
			if (Month != Month_DefaultValue) h.Add("month",Month);
			if (Year != Year_DefaultValue) h.Add("year",Year);
			

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