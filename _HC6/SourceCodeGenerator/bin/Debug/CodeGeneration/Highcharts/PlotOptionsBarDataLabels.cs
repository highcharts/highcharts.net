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
	public partial class PlotOptionsBarDataLabels  : BaseObject
	{
		public PlotOptionsBarDataLabels()
		{
			Align = Align_DefaultValue = "";
			VerticalAlign = VerticalAlign_DefaultValue = "";
			Y = Y_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBarDataLabelsAlign Align { get; set; }
		private PlotOptionsBarDataLabelsAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBarDataLabelsVerticalAlign VerticalAlign { get; set; }
		private PlotOptionsBarDataLabelsVerticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBarDataLabelsY Y { get; set; }
		private PlotOptionsBarDataLabelsY Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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