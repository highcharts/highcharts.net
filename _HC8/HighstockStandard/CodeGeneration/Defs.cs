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
	public partial class Defs  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Defs()
		{
			Arrow = Arrow_DefaultValue = new DefsArrow();
			ReverseArrow = ReverseArrow_DefaultValue = new DefsReverse_arrow();
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public DefsArrow Arrow { get; set; }
		private DefsArrow Arrow_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public DefsReverse_arrow ReverseArrow { get; set; }
		private DefsReverse_arrow ReverseArrow_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Arrow.IsDirty()) h.Add("arrow",Arrow.ToHashtable());
			if (ReverseArrow.IsDirty()) h.Add("reverseArrow",ReverseArrow.ToHashtable());
			

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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