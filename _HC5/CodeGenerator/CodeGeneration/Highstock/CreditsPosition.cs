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
	public partial class CreditsPosition  : BaseObject
	{
		public CreditsPosition()
		{
			Align = Align_DefaultValue = CreditsPositionAlign.Right;
			VerticalAlign = VerticalAlign_DefaultValue = CreditsPositionVerticalAlign.Bottom;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = -5;
			
		}	
		

		/// <summary>
		/// Horizontal alignment of the credits.
		/// </summary>
		public CreditsPositionAlign Align { get; set; }
		private CreditsPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the credits.
		/// </summary>
		public CreditsPositionVerticalAlign VerticalAlign { get; set; }
		private CreditsPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal pixel offset of the credits.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical pixel offset of the credits.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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