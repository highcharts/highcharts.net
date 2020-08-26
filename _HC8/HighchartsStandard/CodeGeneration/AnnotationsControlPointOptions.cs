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
	public partial class AnnotationsControlPointOptions  : BaseObject
	{
		Hashtable h = new Hashtable();

		public AnnotationsControlPointOptions()
		{
			Height = Height_DefaultValue = 10;
			Positioner = Positioner_DefaultValue = "";
			Style = Style_DefaultValue = new Hashtable();
			Symbol = Symbol_DefaultValue = "circle";
			Visible = Visible_DefaultValue = false;
			Width = Width_DefaultValue = 10;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Positioner { get; set; }
		private string Positioner_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Visible { get; set; }
		private bool? Visible_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Positioner != Positioner_DefaultValue) { h.Add("positioner",Positioner); Highcharts.AddFunction("13d85827-e398-481e-abf4-efedd282c810.positioner", Positioner); }  
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

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