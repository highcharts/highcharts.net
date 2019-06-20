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
	public partial class LegendItemCheckboxStyle  : BaseObject
	{
		public LegendItemCheckboxStyle()
		{
			Height = Height_DefaultValue = "13px";
			Height = Height_DefaultValue = "13px";
			Position = Position_DefaultValue = new Hashtable();
			Width = Width_DefaultValue = "13px";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Height { get; set; }
		private string Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Width { get; set; }
		private string Width_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

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