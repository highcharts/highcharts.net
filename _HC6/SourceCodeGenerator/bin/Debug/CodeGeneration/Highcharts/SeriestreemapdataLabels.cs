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
	public partial class SeriestreemapdataLabels  : BaseObject
	{
		public SeriestreemapdataLabels()
		{
			Formatter = Formatter_DefaultValue = "";
			Inside = Inside_DefaultValue = True;
			VerticalAlign = VerticalAlign_DefaultValue = middle;
			Crop = Crop_DefaultValue = False;
			Overflow = Overflow_DefaultValue = False;
			Padding = Padding_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public SeriestreemapdataLabelsformatter Formatter { get; set; }
		private SeriestreemapdataLabelsformatter Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriestreemapdataLabelsinside Inside { get; set; }
		private SeriestreemapdataLabelsinside Inside_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriestreemapdataLabelsverticalAlign VerticalAlign { get; set; }
		private SeriestreemapdataLabelsverticalAlign VerticalAlign_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriestreemapdataLabelscrop Crop { get; set; }
		private SeriestreemapdataLabelscrop Crop_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriestreemapdataLabelsoverflow Overflow { get; set; }
		private SeriestreemapdataLabelsoverflow Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public SeriestreemapdataLabelspadding Padding { get; set; }
		private SeriestreemapdataLabelspadding Padding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (Inside != Inside_DefaultValue) h.Add("inside",Inside);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			if (Crop != Crop_DefaultValue) h.Add("crop",Crop);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Padding != Padding_DefaultValue) h.Add("padding",Padding);
			

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