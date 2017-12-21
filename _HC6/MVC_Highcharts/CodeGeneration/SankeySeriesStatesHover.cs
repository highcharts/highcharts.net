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
	public partial class SankeySeriesStatesHover  : BaseObject
	{
		public SankeySeriesStatesHover()
		{
			LinkOpacity = LinkOpacity_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// Opacity for the links between nodes in the sankey diagram inhover mode.
		/// </summary>
		public SankeySeriesStatesHoverLinkOpacity LinkOpacity { get; set; }
		private SankeySeriesStatesHoverLinkOpacity LinkOpacity_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (LinkOpacity != LinkOpacity_DefaultValue) h.Add("linkOpacity",LinkOpacity);
			

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