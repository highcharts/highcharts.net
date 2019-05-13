using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsIkhSenkouSpan  : BaseObject
	{
		public PlotOptionsIkhSenkouSpan()
		{
			Color = Color_DefaultValue = "";
			NegativeColor = NegativeColor_DefaultValue = "";
			Styles = Styles_DefaultValue = new PlotOptionsIkhSenkouSpanStyles();
			
		}	
		

		/// <summary>
		/// Color of the area between Senkou Span A and B,when Senkou Span A is above Senkou Span B. Note that ifa `style.fill` is defined, the `color` takes precedence andthe `style.fill` is ignored.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// Color of the area between Senkou Span A and B,when Senkou Span A is under Senkou Span B.
		/// </summary>
		public string NegativeColor { get; set; }
		private string NegativeColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsIkhSenkouSpanStyles Styles { get; set; }
		private PlotOptionsIkhSenkouSpanStyles Styles_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (NegativeColor != NegativeColor_DefaultValue) h.Add("negativeColor",NegativeColor);
			if (Styles.IsDirty()) h.Add("styles",Styles.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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