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
	public partial class WordcloudSeriesRotation  : BaseObject
	{
		public WordcloudSeriesRotation()
		{
			From = From_DefaultValue = 0;
			Orientations = Orientations_DefaultValue = 2;
			To = To_DefaultValue = 90;
			
		}	
		

		/// <summary>
		/// The smallest degree of rotation for a word.
		/// </summary>
		public double? From { get; set; }
		private double? From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of possible orientations for a word, within the range of`rotation.from` and `rotation.to`.
		/// </summary>
		public double? Orientations { get; set; }
		private double? Orientations_DefaultValue { get; set; }
		 

		/// <summary>
		/// The largest degree of rotation for a word.
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