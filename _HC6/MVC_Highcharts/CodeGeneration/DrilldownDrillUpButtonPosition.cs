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
	public partial class DrilldownDrillUpButtonPosition  : BaseObject
	{
		public DrilldownDrillUpButtonPosition()
		{
			Align = Align_DefaultValue = "right";
			X = X_DefaultValue = null;
			Y = Y_DefaultValue = null;
			VerticalAlign = VerticalAlign_DefaultValue = DrilldownDrillUpButtonPositionVerticalAlign.Top;
			
		}	
		

		/// <summary>
		/// <p>Horizontal alignment.</p>
		/// </summary>
		public string Align { get; set; }
		private string Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The X offset of the button.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The Y offset of the button.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical alignment of the button.</p>
		/// </summary>
		public DrilldownDrillUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		private DrilldownDrillUpButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align",Align);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (VerticalAlign != VerticalAlign_DefaultValue) h.Add("verticalAlign", Highcharts.FirstCharacterToLower(VerticalAlign.ToString()));
			

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