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
	public partial class PlotOptionsBubbleStatesHover  : BaseObject
	{
		public PlotOptionsBubbleStatesHover()
		{
			Halo = Halo_DefaultValue = new PlotOptionsBubbleStatesHoverHalo();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsBubbleStatesHoverHalo Halo { get; set; }
		private PlotOptionsBubbleStatesHoverHalo Halo_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Halo.IsDirty()) h.Add("halo",Halo.ToHashtable());
			

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