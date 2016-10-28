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
	public partial class ChartResetZoomButton  : BaseObject
	{
		public ChartResetZoomButton()
		{
			Position = Position_DefaultValue = new Hashtable();
			RelativeTo = RelativeTo_DefaultValue = ChartResetZoomButtonRelativeTo.Plot;
			Theme = Theme_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The position of the button. This is an object that can hold the properties <code>align</code>, <code>verticalAlign</code>, <code>x</code> and <code>y</code>.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What frame the button should be placed related to. Can be either "plot" or "chart".
		/// </summary>
		public ChartResetZoomButtonRelativeTo RelativeTo { get; set; }
		private ChartResetZoomButtonRelativeTo RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVG attributes like  <code>fill</code>, <code>stroke</code>, <code>stroke-width</code> or <code>r</code>, the border radius. The theme also supports <code>style</code>, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in <code>theme.states.hover</code>.
		/// </summary>
		public Object Theme { get; set; }
		private Object Theme_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo", Highcharts.FirstCharacterToLower(RelativeTo.ToString()));
			if (Theme != Theme_DefaultValue) h.Add("theme",Theme);
			

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