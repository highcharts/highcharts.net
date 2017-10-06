using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsErrorbarStatesHover  : BaseObject
	{
		public PlotOptionsErrorbarStatesHover()
		{
			Brightness = Brightness_DefaultValue = null;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			Enabled = Enabled_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// <p>How much to brighten the point on interaction. Requires the maincolor to be defined in hex or rgb(a) format.</p><p>In styled mode, the hover brightening is by default replacedwith a fill-opacity set in the <code>.highcharts-point:hover</code> rule.</p>
		/// </summary>
		public double? Brightness { get; set; }
		private double? Brightness_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Enable separate styles for the hovered series to visualize that theuser hovers either the series itself or the legend. .</p>
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Brightness != Brightness_DefaultValue) h.Add("brightness",Brightness);
			if (Shadow.IsDirty()) h.Add("shadow",Shadow.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			

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