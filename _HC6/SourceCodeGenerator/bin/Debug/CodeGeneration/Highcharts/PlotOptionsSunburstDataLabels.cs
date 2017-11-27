using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsSunburstDataLabels  : BaseObject
	{
		public PlotOptionsSunburstDataLabels()
		{
			Defer = Defer_DefaultValue = True;
			Style = Style_DefaultValue = null;
			RotationMode = RotationMode_DefaultValue = perpendicular;
			Defer = Defer_DefaultValue = True;
			Style = Style_DefaultValue = "";
			TextOverflow = TextOverflow_DefaultValue = ellipsis;
			RotationMode = RotationMode_DefaultValue = perpendicular;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsDefer Defer { get; set; }
		private PlotOptionsSunburstDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsStyle Style { get; set; }
		private PlotOptionsSunburstDataLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides how the data label will be rotated according to the perimeterof the sunburst. It can either be parallel or perpendicular to theperimeter.`series.rotation` takes precedence over `rotationMode`.
		/// </summary>
		public PlotOptionsSunburstDataLabelsRotationMode RotationMode { get; set; }
		private PlotOptionsSunburstDataLabelsRotationMode RotationMode_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsDefer Defer { get; set; }
		private PlotOptionsSunburstDataLabelsDefer Defer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsStyle Style { get; set; }
		private PlotOptionsSunburstDataLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsSunburstDataLabelsTextOverflow TextOverflow { get; set; }
		private PlotOptionsSunburstDataLabelsTextOverflow TextOverflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// Decides how the data label will be rotated according to the perimeterof the sunburst. It can either be parallel or perpendicular to theperimeter.`series.rotation` takes precedence over `rotationMode`.
		/// </summary>
		public PlotOptionsSunburstDataLabelsRotationMode RotationMode { get; set; }
		private PlotOptionsSunburstDataLabelsRotationMode RotationMode_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode",RotationMode);
			if (Defer != Defer_DefaultValue) h.Add("defer",Defer);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (TextOverflow != TextOverflow_DefaultValue) h.Add("textOverflow",TextOverflow);
			if (RotationMode != RotationMode_DefaultValue) h.Add("rotationMode",RotationMode);
			

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