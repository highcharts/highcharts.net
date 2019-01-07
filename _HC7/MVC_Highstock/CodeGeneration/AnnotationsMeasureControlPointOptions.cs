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
	public partial class AnnotationsMeasureControlPointOptions  : BaseObject
	{
		public AnnotationsMeasureControlPointOptions()
		{
			Events = Events_DefaultValue = new AnnotationsMeasureControlPointOptionsEvents();
			Height = Height_DefaultValue = 10;
			Positioner = Positioner_DefaultValue = "";
			Style = Style_DefaultValue = new AnnotationsMeasureControlPointOptionsStyle();
			Symbol = Symbol_DefaultValue = "circle";
			Visible = Visible_DefaultValue = false;
			Width = Width_DefaultValue = 10;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public AnnotationsMeasureControlPointOptionsEvents Events { get; set; }
		private AnnotationsMeasureControlPointOptionsEvents Events_DefaultValue { get; set; }
		 

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
		public AnnotationsMeasureControlPointOptionsStyle Style { get; set; }
		private AnnotationsMeasureControlPointOptionsStyle Style_DefaultValue { get; set; }
		 

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
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Events.IsDirty()) h.Add("events",Events.ToHashtable());
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (Positioner != Positioner_DefaultValue) h.Add("positioner",Positioner);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (Visible != Visible_DefaultValue) h.Add("visible",Visible);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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