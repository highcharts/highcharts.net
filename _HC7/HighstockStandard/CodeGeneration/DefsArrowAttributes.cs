using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class DefsArrowAttributes  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DefsArrowAttributes()
		{
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public string Id { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MarkerHeight { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MarkerWidth { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? RefX { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? RefY { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Id != null) h.Add("id",Id);
			if (MarkerHeight != null) h.Add("markerHeight",MarkerHeight);
			if (MarkerWidth != null) h.Add("markerWidth",MarkerWidth);
			if (RefX != null) h.Add("refX",RefX);
			if (RefY != null) h.Add("refY",RefY);
			if (CustomFields != null && CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}
	}
}