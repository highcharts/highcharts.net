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
	public partial class PlotOptionsWordcloudRotation  : BaseObject
	{
		public PlotOptionsWordcloudRotation()
		{
			From = From_DefaultValue = null;
			Orientations = Orientations_DefaultValue = null;
			To = To_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The smallest degree of rotation for a word.</p>
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The number of possible orientations for a word, within the range of<code>rotation.from</code> and <code>rotation.to</code>.</p>
		/// </summary>
		public double? Orientations { get; set; }
		private double? Orientations_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The largest degree of rotation for a word.</p>
		/// </summary>
		public double? To { get; set; }
		private double? To_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (From != From_DefaultValue) h.Add("from",From);
			if (Orientations != Orientations_DefaultValue) h.Add("orientations",Orientations);
			if (To != To_DefaultValue) h.Add("to",To);
			

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