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
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public CreditsPositionAlign Align { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public CreditsPositionVerticalAlign VerticalAlign { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Y { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Align != CreditsPositionAlign.Null) h.Add("align", highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != CreditsPositionVerticalAlign.Null) h.Add("verticalAlign", highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}