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
	public partial class SeriesSankeyData  : BaseObject
	{
		public SeriesSankeyData()
		{
			From = From_DefaultValue = null;
			To = To_DefaultValue = null;
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			From = From_DefaultValue = "";
			To = To_DefaultValue = "";
			Outgoing = Outgoing_DefaultValue = false;
			Weight = Weight_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs from.
		/// </summary>
		public string From { get; set; }
		private string From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The node that the link runs to.
		/// </summary>
		public string To { get; set; }
		private string To_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the link goes out of the system.
		/// </summary>
		public bool? Outgoing { get; set; }
		private bool? Outgoing_DefaultValue { get; set; }
		 

		/// <summary>
		/// The weight of the link.
		/// </summary>
		public double? Weight { get; set; }
		private double? Weight_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			if (From != From_DefaultValue) h.Add("from",From);
			if (To != To_DefaultValue) h.Add("to",To);
			if (Outgoing != Outgoing_DefaultValue) h.Add("outgoing",Outgoing);
			if (Weight != Weight_DefaultValue) h.Add("weight",Weight);
			

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