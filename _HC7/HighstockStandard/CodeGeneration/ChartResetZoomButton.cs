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
	public partial class ChartResetZoomButton  : BaseObject
	{
		public ChartResetZoomButton()
		{
			Position = Position_DefaultValue = new Hashtable();
			RelativeTo = RelativeTo_DefaultValue = "plot";
			Theme = Theme_DefaultValue = new ChartResetZoomButtonTheme();
			
		}	
		

		/// <summary>
		/// The position of the button.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What frame the button placement should be related to. Can beeither `plotBox` or `spacingBox`.
		/// </summary>
		public string RelativeTo { get; set; }
		private string RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVGattributes like `fill`, `stroke`, `stroke-width` or `r`, theborder radius. The theme also supports `style`, a collection ofCSS properties for the text. Equivalent attributes for the hoverstate are given in `theme.states.hover`.
		/// </summary>
		public ChartResetZoomButtonTheme Theme { get; set; }
		private ChartResetZoomButtonTheme Theme_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo",RelativeTo);
			if (Theme.IsDirty()) h.Add("theme",Theme.ToHashtable());
			

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