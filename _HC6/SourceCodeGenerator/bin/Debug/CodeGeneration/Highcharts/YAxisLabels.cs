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
	public partial class YAxisLabels  : BaseObject
	{
		public YAxisLabels()
		{
			X = X_DefaultValue = 0;
			Align = Align_DefaultValue = null;
			Distance = Distance_DefaultValue = -25;
			Y = Y_DefaultValue = null;
			X = X_DefaultValue = 0;
			Align = Align_DefaultValue = "";
			Distance = Distance_DefaultValue = -25;
			Y = Y_DefaultValue = null;
			X = X_DefaultValue = 0;
			Align = Align_DefaultValue = "";
			Distance = Distance_DefaultValue = -25;
			Y = Y_DefaultValue = null;
			X = X_DefaultValue = 0;
			Align = Align_DefaultValue = "";
			Distance = Distance_DefaultValue = -25;
			Y = Y_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the string the given position is anchored to. Can beone of `"left"`, `"center"` or `"right"`. The exact position alsodepends on the `labels.x` setting. Angular gauges and solid gaugesdefaults to `center`.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Angular gauges and solid gauges only. The label's pixel distancefrom the perimeter of the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the string the given position is anchored to. Can beone of `"left"`, `"center"` or `"right"`. The exact position alsodepends on the `labels.x` setting. Angular gauges and solid gaugesdefaults to `center`.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Angular gauges and solid gauges only. The label's pixel distancefrom the perimeter of the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the string the given position is anchored to. Can beone of `"left"`, `"center"` or `"right"`. The exact position alsodepends on the `labels.x` setting. Angular gauges and solid gaugesdefaults to `center`.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Angular gauges and solid gauges only. The label's pixel distancefrom the perimeter of the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// The x position offset of the label relative to the tick positionon the axis. Defaults to -15 for left axis, 15 for right axis.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// What part of the string the given position is anchored to. Can beone of `"left"`, `"center"` or `"right"`. The exact position alsodepends on the `labels.x` setting. Angular gauges and solid gaugesdefaults to `center`.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Angular gauges and solid gauges only. The label's pixel distancefrom the perimeter of the plot area.
		/// </summary>
		public double? Distance { get; set; }
		private double? Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// The y position offset of the label relative to the tick positionon the axis.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X != X_DefaultValue) h.Add("x",X);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
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