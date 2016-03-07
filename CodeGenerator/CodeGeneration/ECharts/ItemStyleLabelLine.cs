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
	public partial class ItemStyleLabelLine  : BaseObject
	{
		public ItemStyleLabelLine()
		{
			Show = Show_DefaultValue = null;
			Length = Length_DefaultValue = null;
			LineStyle = LineStyle_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Specifies whether to show labelLine. Valid values are: true (show) | false (hide).
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// length of the line. Starts from the outer edge. Can be negative. In funnel, length can be 'auto'
		/// </summary>
		public number Length { get; set; }
		private number Length_DefaultValue { get; set; }
		 

		/// <summary>
		/// line style.
		/// </summary>
		public Object LineStyle { get; set; }
		private Object LineStyle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Length != Length_DefaultValue) h.Add("length",Length);
			if (LineStyle != LineStyle_DefaultValue) h.Add("lineStyle",LineStyle);
			

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