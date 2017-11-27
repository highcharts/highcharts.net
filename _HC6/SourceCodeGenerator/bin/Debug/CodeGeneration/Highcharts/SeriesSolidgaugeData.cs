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
	public partial class SeriesSolidgaugeData  : BaseObject
	{
		public SeriesSolidgaugeData()
		{
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			InnerRadius = InnerRadius_DefaultValue = null;
			Radius = Radius_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The inner radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? InnerRadius { get; set; }
		private double? InnerRadius_DefaultValue { get; set; }
		 

		/// <summary>
		/// The outer radius of an individual point in a solid gauge. Can begiven as a number (pixels) or percentage string.
		/// </summary>
		public double? Radius { get; set; }
		private double? Radius_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			if (InnerRadius != InnerRadius_DefaultValue) h.Add("innerRadius",InnerRadius);
			if (Radius != Radius_DefaultValue) h.Add("radius",Radius);
			

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