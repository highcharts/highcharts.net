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
	public partial class PlotOptionsTreegraphCollapseButton  : BaseObject
	{
		Hashtable h = new Hashtable();

		public PlotOptionsTreegraphCollapseButton()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Whether the button should be visible.
		/// </summary>
		public bool? Enabled { get; set; }
		 

		/// <summary>
		/// Height of the button.
		/// </summary>
		public double? Height { get; set; }
		 

		/// <summary>
		/// The line width of the button in pixels
		/// </summary>
		public double? LineWidth { get; set; }
		 

		/// <summary>
		/// Whether the button should be visible only when the node ishovered. When set to true, the button is hidden for nodes,which are not collapsed, and shown for the collapsed ones.
		/// </summary>
		public bool? OnlyOnHover { get; set; }
		 

		/// <summary>
		/// The symbol of the collapse button.
		/// </summary>
		public string Shape { get; set; }
		 

		/// <summary>
		/// CSS styles for the collapse button.In styled mode, the collapse button style is given in the`.highcharts-collapse-button` class.
		/// </summary>
		public Hashtable Style { get; set; }
		 

		/// <summary>
		/// Width of the button.
		/// </summary>
		public double? Width { get; set; }
		 

		/// <summary>
		/// Offset of the button in the x direction.
		/// </summary>
		public double? X { get; set; }
		 

		/// <summary>
		/// Offset of the button in the y direction.
		/// </summary>
		public double? Y { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (Enabled != null) h.Add("enabled",Enabled);
			if (Height != null) h.Add("height",Height);
			if (LineWidth != null) h.Add("lineWidth",LineWidth);
			if (OnlyOnHover != null) h.Add("onlyOnHover",OnlyOnHover);
			if (Shape != null) h.Add("shape",Shape);
			if (Style != null) h.Add("style",Style);
			if (Width != null) h.Add("width",Width);
			if (X != null) h.Add("x",X);
			if (Y != null) h.Add("y",Y);
			if (CustomFields.Count > 0)
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