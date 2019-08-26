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
	public partial class SankeySeriesNodes  : BaseObject
	{
		public SankeySeriesNodes()
		{
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Column = Column_DefaultValue = null;
			DataLabels = DataLabels_DefaultValue = new object();
			Id = Id_DefaultValue = "";
			Level = Level_DefaultValue = null;
			Name = Name_DefaultValue = "";
			Offset = Offset_DefaultValue = 0;
			
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
		/// An optional column index of where to place the node. The default behaviour isto place it next to the preceding node. Note that this option name iscounter intuitive in inverted charts, like for example an organization chartrendered top down. In this case the "columns" are horizontal.
		/// </summary>
		public double? Column { get; set; }
		private double? Column_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual data label for each node. The options are the same asthe ones for [series.sankey.dataLabels](#series.sankey.dataLabels).
		/// </summary>
		public Object DataLabels { get; set; }
		private Object DataLabels_DefaultValue { get; set; }
		 

		/// <summary>
		/// The id of the auto-generated node, refering to the `from` or `to` setting ofthe link.
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// An optional level index of where to place the node. The default behaviour isto place it next to the preceding node. Alias of `nodes.column`, but ininverted sankeys and org charts, the levels are laid out as rows.
		/// </summary>
		public double? Level { get; set; }
		private double? Level_DefaultValue { get; set; }
		 

		/// <summary>
		/// The name to display for the node in data labels and tooltips. Use this whenthe name is different from the `id`. Where the id must be unique for eachnode, this is not necessary for the name.
		/// </summary>
		public string Name { get; set; }
		private string Name_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a horizontal layout, the vertical offset of a node in terms of weight.Positive values shift the node downwards, negative shift it upwards. In avertical layout, like organization chart, the offset is horizontal.If a percantage string is given, the node is offset by the percentage of thenode size plus `nodePadding`.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Column != Column_DefaultValue) h.Add("column",Column);
			if (DataLabels != DataLabels_DefaultValue) h.Add("dataLabels",DataLabels);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Level != Level_DefaultValue) h.Add("level",Level);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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