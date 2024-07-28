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
	public partial class Series  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Series()
		{
		}	
		

		/// <summary>
		/// An id for the series. This can be used after render time to get a pointerto the series object through `chart.get()`.
		/// </summary>
		public virtual string Id { get; set; }
		 

		/// <summary>
		/// The index of the series in the chart, affecting the internal index in the`chart.series` array, the visible Z index as well as the order in thelegend.
		/// </summary>
		public virtual double? Index { get; set; }
		 

		/// <summary>
		/// The sequential index of the series in the legend.
		/// </summary>
		public virtual double? LegendIndex { get; set; }
		 

		/// <summary>
		/// The name of the series as shown in the legend, tooltip etc.
		/// </summary>
		public virtual string Name { get; set; }
		 

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack optioncan be a string or anything else, as long as the grouped series' stackoptions match each other after conversion into a string.
		/// </summary>
		public virtual string Stack { get; set; }
		 

		/// <summary>
		/// This option allows grouping series in a stacked chart. The stack optioncan be a string or anything else, as long as the grouped series' stackoptions match each other after conversion into a string.
		/// </summary>
		public virtual double? StackNumber { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis theparticular series is connected to. It refers to either the{@link #xAxis.id|axis id}or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public virtual string XAxis { get; set; }
		 

		/// <summary>
		/// When using dual or multiple x axes, this number defines which xAxis theparticular series is connected to. It refers to either the{@link #xAxis.id|axis id}or the index of the axis in the xAxis array, with 0 being the first.
		/// </summary>
		public virtual double? XAxisNumber { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis theparticular series is connected to. It refers to either the{@link #yAxis.id|axis id}or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public virtual string YAxis { get; set; }
		 

		/// <summary>
		/// When using dual or multiple y axes, this number defines which yAxis theparticular series is connected to. It refers to either the{@link #yAxis.id|axis id}or the index of the axis in the yAxis array, with 0 being the first.
		/// </summary>
		public virtual double? YAxisNumber { get; set; }
		 

		/// <summary>
		/// Define the visual z index of the series.
		/// </summary>
		public virtual double? ZIndex { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Id != null) h.Add("id",Id);
			if (Index != null) h.Add("index",Index);
			if (LegendIndex != null) h.Add("legendIndex",LegendIndex);
			if (Name != null) h.Add("name",Name);
			if (Stack != null) h.Add("stack",Stack);
			if (StackNumber != null) h.Add("stack",StackNumber);
			if (XAxis != null) h.Add("xAxis",XAxis);
			if (XAxisNumber != null) h.Add("xAxis",XAxisNumber);
			if (YAxis != null) h.Add("yAxis",YAxis);
			if (YAxisNumber != null) h.Add("yAxis",YAxisNumber);
			if (ZIndex != null) h.Add("zIndex",ZIndex);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}