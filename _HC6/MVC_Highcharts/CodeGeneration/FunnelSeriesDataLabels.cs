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
	public partial class FunnelSeriesDataLabels  : BaseObject
	{
		public FunnelSeriesDataLabels()
		{
			ConnectorWidth = ConnectorWidth_DefaultValue = 1;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public FunnelSeriesDataLabelsConnectorWidth ConnectorWidth { get; set; }
		private FunnelSeriesDataLabelsConnectorWidth ConnectorWidth_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ConnectorWidth != ConnectorWidth_DefaultValue) h.Add("connectorWidth",ConnectorWidth);
			

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