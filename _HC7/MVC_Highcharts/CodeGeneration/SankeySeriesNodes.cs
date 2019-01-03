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
	public partial class SankeySeriesNodes  : BaseObject
	{
		public SankeySeriesNodes()
		{
			Color = Color_DefaultValue = "";
			ColorIndex = ColorIndex_DefaultValue = null;
			Column = Column_DefaultValue = null;
			Id = Id_DefaultValue = "";
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
		/// An optional column index of where to place the node. The default behaviour isto place it next to the preceding node.
		/// </summary>
		public double? Column { get; set; }
		private double? Column_DefaultValue { get; set; }
		 

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
		/// The vertical offset of a node in terms of weight. Positive values shift thenode downwards, negative shift it upwards.
		/// </summary>
		public double? Offset { get; set; }
		private double? Offset_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			if (Column != Column_DefaultValue) h.Add("column",Column);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Name != Name_DefaultValue) h.Add("name",Name);
			if (Offset != Offset_DefaultValue) h.Add("offset",Offset);
			

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