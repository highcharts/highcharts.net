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
	public partial class SeriesBellcurve  : BaseObject
	{
		public SeriesBellcurve()
		{
			BaseSeries = BaseSeries_DefaultValue = null;
			Data = Data_DefaultValue = new List<SeriesBellcurveData>();
			BaseSeries = BaseSeries_DefaultValue = null;
			BaseSeries = BaseSeries_DefaultValue = null;
			BaseSeries = BaseSeries_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An integer identifying the index to use for the base series, or a stringrepresenting the id of the series.
		/// </summary>
		public double? BaseSeries { get; set; }
		private double? BaseSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of data points for the series. For the `bellcurve` series type,points are calculated dynamically.
		/// </summary>
		public List<SeriesBellcurveData> Data { get; set; }
		private List<SeriesBellcurveData> Data_DefaultValue { get; set; }
		 

		/// <summary>
		/// An integer identifying the index to use for the base series, or a stringrepresenting the id of the series.
		/// </summary>
		public double? BaseSeries { get; set; }
		private double? BaseSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// An integer identifying the index to use for the base series, or a stringrepresenting the id of the series.
		/// </summary>
		public double? BaseSeries { get; set; }
		private double? BaseSeries_DefaultValue { get; set; }
		 

		/// <summary>
		/// An integer identifying the index to use for the base series, or a stringrepresenting the id of the series.
		/// </summary>
		public double? BaseSeries { get; set; }
		private double? BaseSeries_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (BaseSeries != BaseSeries_DefaultValue) h.Add("baseSeries",BaseSeries);
			if (Data.Any()) h.Add("data",HashifyList(Data));
			if (BaseSeries != BaseSeries_DefaultValue) h.Add("baseSeries",BaseSeries);
			if (BaseSeries != BaseSeries_DefaultValue) h.Add("baseSeries",BaseSeries);
			if (BaseSeries != BaseSeries_DefaultValue) h.Add("baseSeries",BaseSeries);
			

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