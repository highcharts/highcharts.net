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
			Align = Align_DefaultValue = TreemapSeriesDrillUpButtonPositionAlign.Right;
			X = X_DefaultValue = -10;
			Y = Y_DefaultValue = null;
			VerticalAlign = VerticalAlign_DefaultValue = TreemapSeriesDrillUpButtonPositionVerticalAlign.Top;
			
		}	
		

		/// <summary>
		/// <p>Horizontal alignment of the button.</p>
		/// </summary>
		public TreemapSeriesDrillUpButtonPositionAlign Align { get; set; }
		private TreemapSeriesDrillUpButtonPositionAlign Align_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Horizontal offset of the button.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical offset of the button.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Vertical alignment of the button.</p>
		/// </summary>
		public TreemapSeriesDrillUpButtonPositionVerticalAlign VerticalAlign { get; set; }
		private TreemapSeriesDrillUpButtonPositionVerticalAlign VerticalAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Align != Align_DefaultValue) h.Add("align", Highcharts.FirstCharacterToLower(Align.ToString()));
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