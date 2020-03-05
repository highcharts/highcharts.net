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
	public partial class LoadingLabelStyle  : BaseObject
	{
		Hashtable h = new Hashtable();

		public LoadingLabelStyle()
		{
			FontWeight = FontWeight_DefaultValue = "bold";
			Position = Position_DefaultValue = new Hashtable();
			Top = Top_DefaultValue = "45%";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string FontWeight { get; set; }
		private string FontWeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Top { get; set; }
		private string Top_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (FontWeight != FontWeight_DefaultValue) h.Add("fontWeight",FontWeight);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Top != Top_DefaultValue) h.Add("top",Top);
			

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