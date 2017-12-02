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
	public partial class PyramidSeriesWordcloudStatesSelect  : BaseObject
	{
		public PyramidSeriesWordcloudStatesSelect()
		{
			Color = Color_DefaultValue = #cccccc;
			BorderColor = BorderColor_DefaultValue = #000000;
			Shadow = Shadow_DefaultValue = new Shadow() { Enabled = false };
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PyramidSeriesWordcloudStatesSelectColor Color { get; set; }
		private PyramidSeriesWordcloudStatesSelectColor Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PyramidSeriesWordcloudStatesSelectBorderColor BorderColor { get; set; }
		private PyramidSeriesWordcloudStatesSelectBorderColor BorderColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public Shadow Shadow { get; set; }
		private Shadow Shadow_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (BorderColor != BorderColor_DefaultValue) h.Add("borderColor",BorderColor);
			if (Shadow != Shadow_DefaultValue) h.Add("shadow",Shadow);
			

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