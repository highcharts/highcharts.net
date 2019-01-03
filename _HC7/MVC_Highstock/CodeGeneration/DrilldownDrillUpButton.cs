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
	public partial class DrilldownDrillUpButton  : BaseObject
	{
		public DrilldownDrillUpButton()
		{
			Position = Position_DefaultValue = new Hashtable();
			RelativeTo = RelativeTo_DefaultValue = DrilldownDrillUpButtonRelativeTo.PlotBox;
			Theme = Theme_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Positioning options for the button within the `relativeTo` box.Available properties are `x`, `y`, `align` and `verticalAlign`.
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// What box to align the button to. Can be either `plotBox` or`spacingBox`.
		/// </summary>
		public DrilldownDrillUpButtonRelativeTo RelativeTo { get; set; }
		private DrilldownDrillUpButtonRelativeTo RelativeTo_DefaultValue { get; set; }
		 

		/// <summary>
		/// A collection of attributes for the button. The object takes SVGattributes like `fill`, `stroke`, `stroke-width` or `r`, the borderradius. The theme also supports `style`, a collection of CSSproperties for the text. Equivalent attributes for the hover stateare given in `theme.states.hover`.
		/// </summary>
		public Object Theme { get; set; }
		private Object Theme_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (RelativeTo != RelativeTo_DefaultValue) h.Add("relativeTo", Highstock.FirstCharacterToLower(RelativeTo.ToString()));
			if (Theme != Theme_DefaultValue) h.Add("theme",Theme);
			

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