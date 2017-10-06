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
			Id = Id_DefaultValue = null;
			Color = Color_DefaultValue = null;
			ColorIndex = ColorIndex_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The id of the auto-generated node, refering to the <code>from</code> or <code>to</code> setting ofthe link.</p>
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color of the auto generated node.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The color index of the auto generated node, especially for use in styledmode.</p>
		/// </summary>
		public double? ColorIndex { get; set; }
		private double? ColorIndex_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (ColorIndex != ColorIndex_DefaultValue) h.Add("colorIndex",ColorIndex);
			

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