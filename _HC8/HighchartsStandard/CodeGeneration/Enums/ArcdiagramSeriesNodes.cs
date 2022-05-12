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
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Id = Id_DefaultValue = "";
			Name = Name_DefaultValue = "";
			Offset = Offset_DefaultValue = "0";
			OffsetNumber = OffsetNumber_DefaultValue = null;
			OffsetHorizontal = OffsetHorizontal_DefaultValue = "";
			OffsetHorizontalNumber = OffsetHorizontalNumber_DefaultValue = null;
			OffsetVertical = OffsetVertical_DefaultValue = "";
			OffsetVerticalNumber = OffsetVerticalNumber_DefaultValue = null;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// The color of the auto generated node.
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// The color index of the auto generated node, especially for use in styledmode.
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, refering to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name to display for the node in data labels and tooltips. Use this whenthe name is different from the `id`. Where the id must be unique for eachnode, this is not necessary for the name.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated, use[offsetHorizontal](#series.sankey.nodes.offsetHorizontal) and[offsetVertical](#series.sankey.nodes.offsetVertical) instead.In a horizontal layout, the vertical offset of a node in terms of weight.Positive values shift the node downwards, negative shift it upwards. In avertical layout, like organization chart, the offset is horizontal.If a percantage string is given, the node is offset by the percentage of thenode size plus `nodePadding`.
		/// </summary>
		public string Offset { get; set; }
		private string Offset_DefaultValue { get; set; }
		 

		/// <summary>
		/// This option is deprecated, use[offsetHorizontal](#series.sankey.nodes.offsetHorizontal) and[offsetVertical](#series.sankey.nodes.offsetVertical) instead.In a horizontal layout, the vertical offset of a node in terms of weight.Positive values shift the node downwards, negative shift it upwards. In avertical layout, like organization chart, the offset is horizontal.If a percantage string is given, the node is offset by the percentage of thenode size plus `nodePadding`.
		/// </summary>
		public double? OffsetNumber { get; set; }
		private double? OffsetNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal offset of a node. Positive values shift the node right,negative shift it left.If a percantage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public string OffsetHorizontal { get; set; }
		private string OffsetHorizontal_DefaultValue { get; set; }
		 

		/// <summary>
		/// The horizontal offset of a node. Positive values shift the node right,negative shift it left.If a percantage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public double? OffsetHorizontalNumber { get; set; }
		private double? OffsetHorizontalNumber_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of a node. Positive values shift the node down,negative shift it up.If a percantage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public string OffsetVertical { get; set; }
		private string OffsetVertical_DefaultValue { get; set; }
		 

		/// <summary>
		/// The vertical offset of a node. Positive values shift the node down,negative shift it up.If a percantage string is given, the node is offset by the percentage of thenode size.
		/// </summary>
		public double? OffsetVerticalNumber { get; set; }
		private double? OffsetVerticalNumber_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(ref Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			if (OffsetNumber != OffsetNumber_DefaultValue) h.Add("offset",OffsetNumber);
			if (OffsetHorizontal != OffsetHorizontal_DefaultValue) h.Add("offsetHorizontal",OffsetHorizontal);
			if (OffsetHorizontalNumber != OffsetHorizontalNumber_DefaultValue) h.Add("offsetHorizontal",OffsetHorizontalNumber);
			if (OffsetVertical != OffsetVertical_DefaultValue) h.Add("offsetVertical",OffsetVertical);
			if (OffsetVerticalNumber != OffsetVerticalNumber_DefaultValue) h.Add("offsetVertical",OffsetVerticalNumber);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(ref Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(ref Highcharts highcharts)
		{
			return ToHashtable(ref highcharts).Count > 0;
		}
	}
}