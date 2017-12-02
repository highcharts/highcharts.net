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
	public partial class TreemapSeriesDrillUpButtonPosition  : BaseObject
	{
		public TreemapSeriesDrillUpButtonPosition()
		{
			Align = Align_DefaultValue = right;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = 10;
			VerticalAlign = VerticalAlign_DefaultValue = top;
			
		}	
		

		/// <summary>
		/// Horizontal alignment of the button.
		/// </summary>
		public TreemapSeriesDrillUpButtonPositionAlign Align { get; set; }
		private TreemapSeriesDrillUpButtonPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// Horizontal offset of the button.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical offset of the button.
		/// </summary>
		public TreemapSeriesDrillUpButtonPositionY Y { get; set; }
		private TreemapSeriesDrillUpButtonPositionY Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// Vertical alignment of the button.
		/// </summary>
		public TreemapSeriesDrillUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		private TreemapSeriesDrillUpButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign",VerticalAlign);
			

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