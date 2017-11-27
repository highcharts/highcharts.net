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
	public partial class ColorAxisLabels  : BaseObject
	{
		public ColorAxisLabels()
		{
			Overflow = Overflow_DefaultValue = "justify";
			Rotation = Rotation_DefaultValue = 0;
			Overflow = Overflow_DefaultValue = "justify";
			Rotation = Rotation_DefaultValue = 0;
			Overflow = Overflow_DefaultValue = "justify";
			Rotation = Rotation_DefaultValue = 0;
			Overflow = Overflow_DefaultValue = "justify";
			Rotation = Rotation_DefaultValue = 0;
			
		}	
		

		/// <summary>
		/// How to handle overflowing labels on horizontal color axis. Can beundefined or "justify". If "justify", labels will not renderoutside the legend area. If there is room to move it, it will bealigned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisLabelsRotation Rotation { get; set; }
		private ColorAxisLabelsRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal color axis. Can beundefined or "justify". If "justify", labels will not renderoutside the legend area. If there is room to move it, it will bealigned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisLabelsRotation Rotation { get; set; }
		private ColorAxisLabelsRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal color axis. Can beundefined or "justify". If "justify", labels will not renderoutside the legend area. If there is room to move it, it will bealigned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisLabelsRotation Rotation { get; set; }
		private ColorAxisLabelsRotation Rotation_DefaultValue { get; set; }
		 

		/// <summary>
		/// How to handle overflowing labels on horizontal color axis. Can beundefined or "justify". If "justify", labels will not renderoutside the legend area. If there is room to move it, it will bealigned to the edge, else it will be removed.
		/// </summary>
		public string Overflow { get; set; }
		private string Overflow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public ColorAxisLabelsRotation Rotation { get; set; }
		private ColorAxisLabelsRotation Rotation_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			if (Overflow != Overflow_DefaultValue) h.Add("overflow",Overflow);
			if (Rotation != Rotation_DefaultValue) h.Add("rotation",Rotation);
			

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