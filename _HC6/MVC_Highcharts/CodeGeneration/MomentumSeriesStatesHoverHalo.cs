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
	public partial class MomentumSeriesStatesHoverHalo  : BaseObject
	{
		public MomentumSeriesStatesHoverHalo()
		{
			Size = Size_DefaultValue = 10;
			Opacity = Opacity_DefaultValue = 0.25;
			Attributes = Attributes_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The pixel size of the halo. For point markers this is the radiusof the halo. For pie slices it is the width of the halo outsidethe slice. For bubbles it defaults to 5 and is the width of thehalo outside the bubble.</p>
		/// </summary>
		public double? Size { get; set; }
		private double? Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Opacity for the halo unless a specific fill is overridden usingthe <code>attributes</code> setting. Note that Highcharts is only able toapply opacity to colors of hex or rgb(a) formats.</p>
		/// </summary>
		public double? Opacity { get; set; }
		private double? Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>A collection of SVG attributes to override the appearance of thehalo, for example <code>fill</code>, <code>stroke</code> and <code>stroke-width</code>.</p>
		/// </summary>
		public Object Attributes { get; set; }
		private Object Attributes_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (Attributes != Attributes_DefaultValue) h.Add("attributes",Attributes);
			

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