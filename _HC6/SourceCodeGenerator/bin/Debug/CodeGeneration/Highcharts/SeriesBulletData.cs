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
	public partial class SeriesBulletData  : BaseObject
	{
		public SeriesBulletData()
		{
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = null;
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			Target = Target_DefaultValue = null;
			TargetOptions = TargetOptions_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletDataTargetOptions TargetOptions { get; set; }
		private SeriesBulletDataTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletDataTargetOptions TargetOptions { get; set; }
		private SeriesBulletDataTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletDataTargetOptions TargetOptions { get; set; }
		private SeriesBulletDataTargetOptions TargetOptions_DefaultValue { get; set; }
		 

		/// <summary>
		/// The target value of a point.
		/// </summary>
		public double? Target { get; set; }
		private double? Target_DefaultValue { get; set; }
		 

		/// <summary>
		/// Individual target options for each point.
		/// </summary>
		public SeriesBulletDataTargetOptions TargetOptions { get; set; }
		private SeriesBulletDataTargetOptions TargetOptions_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			if (Target != Target_DefaultValue) h.Add("target",Target);
			if (TargetOptions != TargetOptions_DefaultValue) h.Add("targetOptions",TargetOptions);
			

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