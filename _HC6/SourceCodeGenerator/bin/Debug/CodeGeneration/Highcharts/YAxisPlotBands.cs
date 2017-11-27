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
	public partial class YAxisPlotBands  : BaseObject
	{
		public YAxisPlotBands()
		{
			InnerRadius = InnerRadius_DefaultValue = null;
			OuterRadius = OuterRadius_DefaultValue = 100%;
			Thickness = Thickness_DefaultValue = 10;
			InnerRadius = InnerRadius_DefaultValue = null;
			OuterRadius = OuterRadius_DefaultValue = 100%;
			Thickness = Thickness_DefaultValue = 10;
			InnerRadius = InnerRadius_DefaultValue = null;
			OuterRadius = OuterRadius_DefaultValue = 100%;
			Thickness = Thickness_DefaultValue = 10;
			InnerRadius = InnerRadius_DefaultValue = null;
			OuterRadius = OuterRadius_DefaultValue = 100%;
			Thickness = Thickness_DefaultValue = 10;
			
		}	
		

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public double? OuterRadius { get; set; }
		private double? OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretchingalong the perimeter. It can be given as a percentage string, like`"10%"`, or as a pixel number, like `10`. The default value 10 isthe same as the default [tickLength](#yAxis.tickLength), thus makingthe plot band act as a background for the tick markers.
		/// </summary>
		public double? Thickness { get; set; }
		private double? Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public double? OuterRadius { get; set; }
		private double? OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretchingalong the perimeter. It can be given as a percentage string, like`"10%"`, or as a pixel number, like `10`. The default value 10 isthe same as the default [tickLength](#yAxis.tickLength), thus makingthe plot band act as a background for the tick markers.
		/// </summary>
		public double? Thickness { get; set; }
		private double? Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public double? OuterRadius { get; set; }
		private double? OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretchingalong the perimeter. It can be given as a percentage string, like`"10%"`, or as a pixel number, like `10`. The default value 10 isthe same as the default [tickLength](#yAxis.tickLength), thus makingthe plot band act as a background for the tick markers.
		/// </summary>
		public double? Thickness { get; set; }
		private double? Thickness_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the inner radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.By default, the inner radius is controlled by the [thickness](#yAxis.plotBands.thickness) option.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option determines the outer radius of theplot band that stretches along the perimeter. It can be given asa percentage string, like `"100%"`, or as a pixel number, like `100`.
		/// </summary>
		public double? OuterRadius { get; set; }
		private double? OuterRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a gauge chart, this option sets the width of the plot band stretchingalong the perimeter. It can be given as a percentage string, like`"10%"`, or as a pixel number, like `10`. The default value 10 isthe same as the default [tickLength](#yAxis.tickLength), thus makingthe plot band act as a background for the tick markers.
		/// </summary>
		public double? Thickness { get; set; }
		private double? Thickness_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (OuterRadius != OuterRadius_DefaultValue) h.Add("outerRadius",OuterRadius);
			if (Thickness != Thickness_DefaultValue) h.Add("thickness",Thickness);
			

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