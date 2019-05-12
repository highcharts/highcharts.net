using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class PlotOptionsOrganizationDataLabels  : BaseObject
	{
		public PlotOptionsOrganizationDataLabels()
		{
			NodeFormatter = NodeFormatter_DefaultValue = "";
			Style = Style_DefaultValue = new PlotOptionsOrganizationDataLabelsStyle();
			UseHTML = UseHTML_DefaultValue = true;
			
		}	
		

		/// <summary>
		/// A callback for defining the format for _nodes_ in theorganization chart. The `nodeFormat` option takes precedence over`nodeFormatter`.In an organization chart, the `nodeFormatter` is a quite complexfunction of the available options, striving for a good defaultlayout of cards with or without images. In organization chart,the data labels come with `useHTML` set to true, meaning theywill be rendered as true HTML above the SVG.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public PlotOptionsOrganizationDataLabelsStyle Style { get; set; }
		private PlotOptionsOrganizationDataLabelsStyle Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public bool? UseHTML { get; set; }
		private bool? UseHTML_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (NodeFormatter != NodeFormatter_DefaultValue) h.Add("nodeFormatter",NodeFormatter);
			if (Style.IsDirty()) h.Add("style",Style.ToHashtable());
			if (UseHTML != UseHTML_DefaultValue) h.Add("useHTML",UseHTML);
			

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