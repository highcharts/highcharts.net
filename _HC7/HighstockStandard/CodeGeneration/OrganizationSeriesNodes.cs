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
	public partial class OrganizationSeriesNodes  : BaseObject
	{
		public OrganizationSeriesNodes()
		{
			Description = Description_DefaultValue = "";
			Image = Image_DefaultValue = "";
			Layout = Layout_DefaultValue = "normal";
			Title = Title_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// The job description for the node card, will be inserted by the default`dataLabel.nodeFormatter`.
		/// </summary>
		public string Description { get; set; }
		private string Description_DefaultValue { get; set; }
		 

		/// <summary>
		/// An image for the node card, will be inserted by the default`dataLabel.nodeFormatter`.
		/// </summary>
		public string Image { get; set; }
		private string Image_DefaultValue { get; set; }
		 

		/// <summary>
		/// Layout for the node's children. If `hanging`, this node's children will hangbelow their parent, allowing a tighter packing of nodes in the diagram.
		/// </summary>
		public string Layout { get; set; }
		private string Layout_DefaultValue { get; set; }
		 

		/// <summary>
		/// The job title for the node card, will be inserted by the default`dataLabel.nodeFormatter`.
		/// </summary>
		public string Title { get; set; }
		private string Title_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Description != Description_DefaultValue) h.Add("description",Description);
			if (Image != Image_DefaultValue) h.Add("image",Image);
			if (Layout != Layout_DefaultValue) h.Add("layout",Layout);
			if (Title != Title_DefaultValue) h.Add("title",Title);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();

			if (h.Count > 0)
				return JsonConvert.SerializeObject(ToHashtable());
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