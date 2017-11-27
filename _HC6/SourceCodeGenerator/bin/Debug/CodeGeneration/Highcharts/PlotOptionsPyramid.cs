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
	public partial class PlotOptionsPyramid  : BaseObject
	{
		public PlotOptionsPyramid()
		{
			NeckWidth = NeckWidth_DefaultValue = "0%";
			NeckHeight = NeckHeight_DefaultValue = "0%";
			Reversed = Reversed_DefaultValue = true;
			NeckWidth = NeckWidth_DefaultValue = "0%";
			NeckHeight = NeckHeight_DefaultValue = "0%";
			Reversed = Reversed_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// The pyramid neck width is zero by default, as opposed to the funnel, which shares the same layout logic.
		/// </summary>
		public string NeckWidth { get; set; }
		private string NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pyramid neck width is zero by default, as opposed to the funnel, which shares the same layout logic.
		/// </summary>
		public string NeckHeight { get; set; }
		private string NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pyramid is reversed by default, as opposed to the funnel, whichshares the layout engine, and is not reversed.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pyramid neck width is zero by default, as opposed to the funnel, which shares the same layout logic.
		/// </summary>
		public string NeckWidth { get; set; }
		private string NeckWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pyramid neck width is zero by default, as opposed to the funnel, which shares the same layout logic.
		/// </summary>
		public string NeckHeight { get; set; }
		private string NeckHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The pyramid is reversed by default, as opposed to the funnel, whichshares the layout engine, and is not reversed.
		/// </summary>
		public bool? Reversed { get; set; }
		private bool? Reversed_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			if (NeckWidth != NeckWidth_DefaultValue) h.Add("neckWidth",NeckWidth);
			if (NeckHeight != NeckHeight_DefaultValue) h.Add("neckHeight",NeckHeight);
			if (Reversed != Reversed_DefaultValue) h.Add("reversed",Reversed);
			

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