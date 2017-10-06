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
	public partial class BbSeriesIkhStates  : BaseObject
	{
		public BbSeriesIkhStates()
		{
			Hover = Hover_DefaultValue = new BbSeriesIkhStatesHover();
			
		}	
		

		/// <summary>
		/// <p>Options for the hovered series. These settings override the normalstate options when a series is moused over or touched.</p>
		/// </summary>
		public BbSeriesIkhStatesHover Hover { get; set; }
		private BbSeriesIkhStatesHover Hover_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Hover.IsDirty()) h.Add("hover",Hover.ToHashtable());
			

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