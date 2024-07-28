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
	public partial class ArcdiagramSeriesNodes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public ArcdiagramSeriesNodes()
		{
		}	
		

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		 

		/// <summary>
		/// Individual data label for each node. The options are the same as the ones for[series.arcdiagram.dataLabels](#series.arcdiagram.dataLabels).
		/// </summary>
		public Object DataLabels { get; set; }
		 

		/// <summary>
		/// The height of the node.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, referring to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// The name to display for the node in data labels and tooltips. Use this whenthe name is different from the `id`. Where the id must be unique for eachnode, this is not necessary for the name.
		/// </summary>
		public string Name { get; set; }
		 

		/// <summary>
		/// This option is deprecated, use[offsetHorizontal](#series.sankey.nodes.offsetHorizontal) and[offsetVertical](#series.sankey.nodes.offsetVertical) instead.In a horizontal layout, the vertical offset of a node in terms of weight.Positive values shift the node downwards, negative shift it upwards. In avertical layout, like organization chart, the offset is horizontal.If a percentage string is given, the node is offset by the percentage of thenode size plus `nodePadding`.
		/// </summary>
		public string Offset { get; set; }
		 

		/// <summary>
		/// This option is deprecated, use[offsetHorizontal](#series.sankey.nodes.offsetHorizontal) and[offsetVertical](#series.sankey.nodes.offsetVertical) instead.In a horizontal layout, the vertical offset of a node in terms of weight.Positive values shift the node downwards, negative shift it upwards. In avertical layout, like organization chart, the offset is horizontal.If a percentage string is given, the node is offset by the percentage of thenode size plus `nodePadding`.
		/// </summary>
		public double? OffsetNumber { get; set; }
		 

		/// <summary>
		/// The horizontal offset of a node. Positive values shift the node right,negative shift it left.If a percentage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public string OffsetHorizontal { get; set; }
		 

		/// <summary>
		/// The horizontal offset of a node. Positive values shift the node right,negative shift it left.If a percentage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public double? OffsetHorizontalNumber { get; set; }
		 

		/// <summary>
		/// The vertical offset of a node. Positive values shift the node down,negative shift it up.If a percentage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public string OffsetVertical { get; set; }
		 

		/// <summary>
		/// The vertical offset of a node. Positive values shift the node down,negative shift it up.If a percentage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public double? OffsetVerticalNumber { get; set; }
		  

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (DataLabels != null) h.Add("dataLabels",DataLabels);
			if (Height != null) h.Add("height",Height);
			if (Id != null) h.Add("id",Id);
			if (Name != null) h.Add("name",Name);
			if (Offset != null) h.Add("offset",Offset);
			if (OffsetNumber != null) h.Add("offset",OffsetNumber);
			if (OffsetHorizontal != null) h.Add("offsetHorizontal",OffsetHorizontal);
			if (OffsetHorizontalNumber != null) h.Add("offsetHorizontal",OffsetHorizontalNumber);
			if (OffsetVertical != null) h.Add("offsetVertical",OffsetVertical);
			if (OffsetVerticalNumber != null) h.Add("offsetVertical",OffsetVerticalNumber);
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