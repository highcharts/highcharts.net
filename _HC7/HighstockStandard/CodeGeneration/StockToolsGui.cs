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
		Hashtable h = new Hashtable();

		public StockToolsGui()
		{
		}	
		

		/// <summary>
		/// A collection of strings pointing to config options for thetoolbar items. Each name refers to a unique key from thedefinitions object.
		/// </summary>
		public List<string> Buttons { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the stocktools' div,allowing unique CSS styling for each chart.
		/// </summary>
		public string ClassName { get; set; }
		 

		/// <summary>
		/// An options object of the buttons definitions. Each name refers tounique key from buttons array.
		/// </summary>
		public StockToolsGuiDefinitions Definitions { get; set; }
		 

		/// <summary>
		/// Enable or disable the stockTools gui.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Path where Highcharts will look for icons. Change this to useicons from a different server.Since 7.1.3 use [iconsURL](#navigation.iconsURL) for popup andstock tools.
		/// </summary>
		public string IconsURL { get; set; }
		 

		/// <summary>
		/// A CSS class name to apply to the container of buttons,allowing unique CSS styling for each chart.
		/// </summary>
		public string ToolbarClassName { get; set; }
		 

		/// <summary>
		/// Whether the stock tools toolbar is visible.
		/// </summary>
		public bool? Visible { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (Buttons != null) h.Add("buttons",Buttons);
			if (ClassName != null) h.Add("className",ClassName);
			if (Definitions != null) h.Add("definitions",Definitions.ToHashtable(highstock));
			if (Enabled != null) h.Add("enabled",Enabled);
			if (IconsURL != null) h.Add("iconsURL",IconsURL);
			if (ToolbarClassName != null) h.Add("toolbarClassName",ToolbarClassName);
			if (Visible != null) h.Add("visible",Visible);
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