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
	public partial class StockToolsGui  : BaseObject
	{
		public StockToolsGui()
		{
			Buttons = Buttons_DefaultValue = new List<string>();
			ClassName = ClassName_DefaultValue = "highcharts-bindings-wrapper";
			Definitions = Definitions_DefaultValue = new StockToolsGuiDefinitions();
			Enabled = Enabled_DefaultValue = true;
			IconsURL = IconsURL_DefaultValue = "https://code.highcharts.com/@product.version@/gfx/stock-icons/";
			ToolbarClassName = ToolbarClassName_DefaultValue = " stocktools-toolbar ";
			
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options for thetoolbar items. Each name refers to unique key from definitionsobject.
		/// </summary>
		public List<string> Buttons { get; set; }
		private List<string> Buttons_DefaultValue { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the stocktools' div,allowing unique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		private string ClassName_DefaultValue { get; set; }
		 

		/// <summary>
		/// An options object of the buttons definitions. Each name refers tounique key from buttons array.
		/// </summary>
		public StockToolsGuiDefinitions Definitions { get; set; }
		private StockToolsGuiDefinitions Definitions_DefaultValue { get; set; }
		 

		/// <summary>
		/// Enable or disable the stockTools gui.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Path where Highcharts will look for icons. Change this to useicons from a different server.
		/// </summary>
		public string IconsURL { get; set; }
		private string IconsURL_DefaultValue { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the container of buttons,allowing unique CSS styling for each chart.
		/// </summary>
		public string ToolbarClassName { get; set; }
		private string ToolbarClassName_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Buttons != Buttons_DefaultValue) h.Add("buttons",Buttons);
			if (ClassName != ClassName_DefaultValue) h.Add("className",ClassName);
			if (Definitions.IsDirty()) h.Add("definitions",Definitions.ToHashtable());
			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (IconsURL != IconsURL_DefaultValue) h.Add("iconsURL",IconsURL);
			if (ToolbarClassName != ToolbarClassName_DefaultValue) h.Add("toolbarClassName",ToolbarClassName);
			

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