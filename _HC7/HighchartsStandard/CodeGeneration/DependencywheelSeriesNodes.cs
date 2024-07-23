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
	public partial class DependencywheelSeriesNodes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DependencywheelSeriesNodes()
		{
			
			CustomFields = new Hashtable();
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
		/// An optional column index of where to place the node. The default behaviour isto place it next to the preceding node. Note that this option name iscounter intuitive in inverted charts, like for example an organization chartrendered top down. In this case the "columns" are horizontal.
		/// </summary>
		public double? Column { get; set; }
		 

		/// <summary>
		/// Individual data label for each node. The options are the same asthe ones for [series.sankey.dataLabels](#series.sankey.dataLabels).
		/// </summary>
		public DependencywheelSeriesNodesDataLabels DataLabels { get; set; }
		 

		/// <summary>
		/// The height of the node.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, referring to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// An optional level index of where to place the node. The default behaviour isto place it next to the preceding node. Alias of `nodes.column`, but ininverted sankeys and org charts, the levels are laid out as rows.
		/// </summary>
		public double? Level { get; set; }
		 

		/// <summary>
		/// The name to display for the node in data labels and tooltips. Use this whenthe name is different from the `id`. Where the id must be unique for eachnode, this is not necessary for the name.
		/// </summary>
		public string Name { get; set; }
		 

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
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Color != null) h.Add("color",Color);
			if (ColorIndex != null) h.Add("colorIndex",ColorIndex);
			if (Column != null) h.Add("column",Column);
			if (DataLabels != null) h.Add("dataLabels",DataLabels.ToHashtable(highcharts));
			if (Height != null) h.Add("height",Height);
			if (Id != null) h.Add("id",Id);
			if (Level != null) h.Add("level",Level);
			if (Name != null) h.Add("name",Name);
			if (OffsetHorizontal != null) h.Add("offsetHorizontal",OffsetHorizontal);
			if (OffsetHorizontalNumber != null) h.Add("offsetHorizontal",OffsetHorizontalNumber);
			if (OffsetVertical != null) h.Add("offsetVertical",OffsetVertical);
			if (OffsetVerticalNumber != null) h.Add("offsetVertical",OffsetVerticalNumber);
			if (CustomFields.Count > 0)
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