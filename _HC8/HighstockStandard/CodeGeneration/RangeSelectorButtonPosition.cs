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
	public partial class RangeSelectorButtonPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public RangeSelectorButtonPosition()
		{
			Align = Align_DefaultValue = RangeSelectorButtonPositionAlign.Left;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// The alignment of the input box. Allowed properties are `left`,`center`, `right`.
		/// </summary>
		public RangeSelectorButtonPositionAlign Align { get; set; }
		private RangeSelectorButtonPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// X offset of the button row.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Y offset of the button row.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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