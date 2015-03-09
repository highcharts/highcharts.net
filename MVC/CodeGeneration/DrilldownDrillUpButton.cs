using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace HighSoft.Web.Mvc
{
	public partial class DrilldownDrillUpButton
	{
		public DrilldownDrillUpButton()
		{
			Position = Position_DefaultValue = new NameValueCollection();
			RelativeTo = RelativeTo_DefaultValue = "plotBox";
			Theme = Theme_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Positioning options for the button within the <code>relativeTo</code> box. Available properties are <code>x</code>, <code>y</code>, <code>align</code> and <code>verticalAlign</code>.
		/// </summary>
		public NameValueCollection Position { get; set; }
		private NameValueCollection Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What box to align the button to. Can be either "plotBox" or "spacingBox".
		/// </summary>
		public string RelativeTo { get; set; }
		private string RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVG attributes like  <code>fill</code>, <code>stroke</code>, <code>stroke-width</code> or <code>r</code>, the border radius. The theme also supports <code>style</code>, a collection of CSS properties for the text. Equivalent attributes for the hover state are given in <code>theme.states.hover</code>.
		/// </summary>
		public Object Theme { get; set; }
		private Object Theme_DefaultValue { get; set; }
		  

		internal Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo",RelativeTo);
			if (Theme != Theme_DefaultValue) h.Add("theme",Theme);
			

			return h;
		}

		internal string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal bool IsDirty()
		{
			return ToHashtable().Count > 0;
		}
	}
}