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
	public partial class DefsArrow  : BaseObject
	{
		Hashtable h = new Hashtable();

		public DefsArrow()
		{
			Children = Children_DefaultValue = new List<object>();
			Id = Id_DefaultValue = "arrow";
			MarkerHeight = MarkerHeight_DefaultValue = 10;
			MarkerWidth = MarkerWidth_DefaultValue = 10;
			RefX = RefX_DefaultValue = 9;
			RefY = RefY_DefaultValue = 5;
			Render = Render_DefaultValue = false;
			TagName = TagName_DefaultValue = "marker";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public List<object> Children { get; set; }
		private List<object> Children_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string Id { get; set; }
		private string Id_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MarkerHeight { get; set; }
		private double? MarkerHeight_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? MarkerWidth { get; set; }
		private double? MarkerWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? RefX { get; set; }
		private double? RefX_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public double? RefY { get; set; }
		private double? RefY_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? Render { get; set; }
		private bool? Render_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string TagName { get; set; }
		private string TagName_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (Children != Children_DefaultValue) h.Add("children",Children);
			if (Id != Id_DefaultValue) h.Add("id",Id);
			if (MarkerHeight != MarkerHeight_DefaultValue) h.Add("markerHeight",MarkerHeight);
			if (MarkerWidth != MarkerWidth_DefaultValue) h.Add("markerWidth",MarkerWidth);
			if (RefX != RefX_DefaultValue) h.Add("refX",RefX);
			if (RefY != RefY_DefaultValue) h.Add("refY",RefY);
			if (Render != Render_DefaultValue) h.Add("render",Render);
			if (TagName != TagName_DefaultValue) h.Add("tagName",TagName);
			

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