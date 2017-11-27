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
	public partial class PlotOptionsVariwide  : BaseObject
	{
		public PlotOptionsVariwide()
		{
			PointPadding = PointPadding_DefaultValue = 0;
			GroupPadding = GroupPadding_DefaultValue = 0;
			PointPadding = PointPadding_DefaultValue = 0;
			GroupPadding = GroupPadding_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// In a variwide chart, the point padding is 0 in order to express the horizontal stacking of items.
		/// </summary>
		public PlotOptionsVariwidePointPadding PointPadding { get; set; }
		private PlotOptionsVariwidePointPadding PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a variwide chart, the group padding is 0 in order to express the horizontal stacking of items.
		/// </summary>
		public PlotOptionsVariwideGroupPadding GroupPadding { get; set; }
		private PlotOptionsVariwideGroupPadding GroupPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a variwide chart, the point padding is 0 in order to express the horizontal stacking of items.
		/// </summary>
		public PlotOptionsVariwidePointPadding PointPadding { get; set; }
		private PlotOptionsVariwidePointPadding PointPadding_DefaultValue { get; set; }
		 

		/// <summary>
		/// In a variwide chart, the group padding is 0 in order to express the horizontal stacking of items.
		/// </summary>
		public PlotOptionsVariwideGroupPadding GroupPadding { get; set; }
		private PlotOptionsVariwideGroupPadding GroupPadding_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			if (PointPadding != PointPadding_DefaultValue) h.Add("pointPadding",PointPadding);
			if (GroupPadding != GroupPadding_DefaultValue) h.Add("groupPadding",GroupPadding);
			

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