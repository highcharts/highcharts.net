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
	public partial class PlotOptionsScatter3dJitter  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsScatter3dJitter()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The maximal X offset for the random jitter effect.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// The maximal Y offset for the random jitter effect.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
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