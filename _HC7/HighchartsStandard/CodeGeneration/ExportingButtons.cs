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
	public partial class ExportingButtons  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ExportingButtons()
		{
		}	
		

		/// <summary>
		/// Options for the export button.In styled mode, export button styles can be applied with the`.highcharts-contextbutton` class.
		/// </summary>
		public ExportingButtonsContextButton ContextButton { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ContextButton != null) h.Add("contextButton",ContextButton.ToHashtable(highcharts));
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