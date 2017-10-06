using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class NoDataPosition  : BaseObject
	{
		public NoDataPosition()
		{
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			Align = Align_DefaultValue = NoDataPositionAlign.Center;
			VerticalAlign = VerticalAlign_DefaultValue = NoDataPositionVerticalAlign.Middle;
			
		}	
		

		/// <summary>
		/// <p>Horizontal offset of the label, in pixels.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical offset of the label, in pixels.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Horizontal alignment of the label.</p>
		/// </summary>
		public NoDataPositionAlign Align { get; set; }
		private NoDataPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical alignment of the label.</p>
		/// </summary>
		public NoDataPositionVerticalAlign VerticalAlign { get; set; }
		private NoDataPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (Align != Align_DefaultValue) h.Add("align", Highstock.FirstCharacterToLower(Align.ToString()));
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highstock.FirstCharacterToLower(VerticalAlign.ToString()));
			

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