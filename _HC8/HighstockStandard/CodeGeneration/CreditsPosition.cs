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
	public partial class CreditsPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public CreditsPosition()
		{
			Align = Align_DefaultValue = CreditsPositionAlign.Right;
			VerticalAlign = VerticalAlign_DefaultValue = CreditsPositionVerticalAlign.Bottom;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = -5;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public CreditsPositionAlign Align { get; set; }
		private CreditsPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public CreditsPositionVerticalAlign VerticalAlign { get; set; }
		private CreditsPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (h.Count > 0)
				return h;

			if (Align != Align_DefaultValue) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

			return h;
		}

		internal override string ToJSON(Highstock highstock)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highstock highstock)
		{
			return ToHashtable(highstock).Count > 0;
		}
	}
}