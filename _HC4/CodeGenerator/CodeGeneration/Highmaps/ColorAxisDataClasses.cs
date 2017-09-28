using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public partial class ColorAxisDataClasses  : BaseObject
	{
		public ColorAxisDataClasses()
		{
			Color = Color_DefaultValue = "";
			From = From_DefaultValue = null;
			Name = Name_DefaultValue = "";
			To = To_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The color of each data class. If not set, the color is pulled from the global or chart-specific <a href="#colors">colors</a> array.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start of the value range that the data class represents, relating to the point value.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name of the data class as it appears in the legend. If no name is given, it is automatically created based on the <code>from</code> and <code>to</code> values. For full programmatic control, <a href="#legend.labelFormatter">legend.labelFormatter</a> can be used. In the formatter, <code>this.from</code> and <code>this.to</code> can be accessed.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end of the value range that the data class represents, relating to the point value.
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (From != From_DefaultValue) h.Add("from",From);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (To != To_DefaultValue) h.Add("to",To);
			

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