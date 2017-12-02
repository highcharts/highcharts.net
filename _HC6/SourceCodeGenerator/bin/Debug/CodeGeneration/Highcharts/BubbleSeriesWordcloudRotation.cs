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
	public partial class BubbleSeriesWordcloudRotation  : BaseObject
	{
		public BubbleSeriesWordcloudRotation()
		{
			From = From_DefaultValue = 0;
			Orientations = Orientations_DefaultValue = 2;
			To = To_DefaultValue = 90;
			
		}	
		

		/// <summary>
		/// The smallest degree of rotation for a word.
		/// </summary>
		public BubbleSeriesWordcloudRotationFrom From { get; set; }
		private BubbleSeriesWordcloudRotationFrom From_DefaultValue { get; set; }
		 

		/// <summary>
		/// The number of possible orientations for a word, within the range of`rotation.from` and `rotation.to`.
		/// </summary>
		public BubbleSeriesWordcloudRotationOrientations Orientations { get; set; }
		private BubbleSeriesWordcloudRotationOrientations Orientations_DefaultValue { get; set; }
		 

		/// <summary>
		/// The largest degree of rotation for a word.
		/// </summary>
		public BubbleSeriesWordcloudRotationTo To { get; set; }
		private BubbleSeriesWordcloudRotationTo To_DefaultValue { get; set; }
		  

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