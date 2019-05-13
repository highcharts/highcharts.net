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
	public partial class DrilldownDrillUpButtonPosition  : BaseObject
	{
		public DrilldownDrillUpButtonPosition()
		{
			Align = Align_DefaultValue = "right";
			VerticalAlign = VerticalAlign_DefaultValue = "top";
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 10;
			
		}	
		

		/// <summary>
		/// Horizontal alignment.
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public string VerticalAlign { get; set; }
		private string VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// The X offset of the button.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// The Y offset of the button.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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