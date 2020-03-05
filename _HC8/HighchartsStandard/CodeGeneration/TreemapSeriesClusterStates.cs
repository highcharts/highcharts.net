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
	public partial class TreemapSeriesClusterStates  : BaseObject
	{
		Hashtable h = new Hashtable();

		public TreemapSeriesClusterStates()
		{
			Hover = Hover_DefaultValue = new TreemapSeriesClusterStatesHover();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public TreemapSeriesClusterStatesHover Hover { get; set; }
		private TreemapSeriesClusterStatesHover Hover_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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