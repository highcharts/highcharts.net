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
	public partial class ChartResetZoomButton  : BaseObject
	{
		public ChartResetZoomButton()
		{
			Theme = Theme_DefaultValue = new ChartResetZoomButtonTheme();
			Position = Position_DefaultValue = new Hashtable();
			RelativeTo = RelativeTo_DefaultValue = ChartResetZoomButtonRelativeTo.Plot;
			
		}	
		

		/// <summary>
		/// <p>A collection of attributes for the button. The object takes SVGattributes like <code>fill</code>, <code>stroke</code>, <code>stroke-width</code> or <code>r</code>, the borderradius. The theme also supports <code>style</code>, a collection of CSS propertiesfor the text. Equivalent attributes for the hover state are givenin <code>theme.states.hover</code>.</p>
		/// </summary>
		public ChartResetZoomButtonTheme Theme { get; set; }
		private ChartResetZoomButtonTheme Theme_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The position of the button.</p>
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>What frame the button should be placed related to. Can be either<code>plot</code> or <code>chart</code></p>
		/// </summary>
		public ChartResetZoomButtonRelativeTo RelativeTo { get; set; }
		private ChartResetZoomButtonRelativeTo RelativeTo_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Theme.IsDirty()) h.Add("theme",Theme.ToHashtable());
			if (Position.Count > 0) h.Add("position",Position);
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo", Highstock.FirstCharacterToLower(RelativeTo.ToString()));
			

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