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
	public partial class PlotOptionsWindbarbDragDropGuideBox  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsWindbarbDragDropGuideBox()
		{
			Default = Default_DefaultValue = new PlotOptionsWindbarbDragDropGuideBoxDefault();
			
		}	
		

		/// <summary>
		/// Style options for the guide box default state.
		/// </summary>
		public PlotOptionsWindbarbDragDropGuideBoxDefault Default { get; set; }
		private PlotOptionsWindbarbDragDropGuideBoxDefault Default_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Default.IsDirty()) h.Add("default",Default.ToHashtable());
			

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