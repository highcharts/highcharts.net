using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class CreditsPosition  : BaseObject
	{
		Hashtable h = new Hashtable();

		public CreditsPosition()
		{
			
			CustomFields = new Hashtable();
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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Align != CreditsPositionAlign.Null) h.Add("align", highcharts.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != CreditsPositionVerticalAlign.Null) h.Add("verticalAlign", highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields.Count > 0)
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