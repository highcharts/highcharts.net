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
			Enabled = Enabled_DefaultValue = true;
			Height = Height_DefaultValue = 18;
			LineWidth = LineWidth_DefaultValue = 1;
			OnlyOnHover = OnlyOnHover_DefaultValue = true;
			Shape = Shape_DefaultValue = "circle";
			Style = Style_DefaultValue = new Hashtable();
			Width = Width_DefaultValue = 18;
			X = X_DefaultValue = 0;
			Y = Y_DefaultValue = 0;
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Whether the button should be visible.
		/// </summary>
		public bool? Enabled { get; set; }
		private bool? Enabled_DefaultValue { get; set; }
		 

		/// <summary>
		/// Height of the button.
		/// </summary>
		public double? Height { get; set; }
		private double? Height_DefaultValue { get; set; }
		 

		/// <summary>
		/// The line width of the button in pixels
		/// </summary>
		public double? LineWidth { get; set; }
		private double? LineWidth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Whether the button should be visible only when the node ishovered. When set to true, the button is hidden for nodes,which are not collapsed, and shown for the collapsed ones.
		/// </summary>
		public bool? OnlyOnHover { get; set; }
		private bool? OnlyOnHover_DefaultValue { get; set; }
		 

		/// <summary>
		/// The symbol of the collapse button.
		/// </summary>
		public string Shape { get; set; }
		private string Shape_DefaultValue { get; set; }
		 

		/// <summary>
		/// CSS styles for the collapse button.In styled mode, the collapse button style is given in the`.highcharts-collapse-button` class.
		/// </summary>
		public Hashtable Style { get; set; }
		private Hashtable Style_DefaultValue { get; set; }
		 

		/// <summary>
		/// Width of the button.
		/// </summary>
		public double? Width { get; set; }
		private double? Width_DefaultValue { get; set; }
		 

		/// <summary>
		/// Offset of the button in the x direction.
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// Offset of the button in the y direction.
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (h.Count > 0)
				return h;

			if (Enabled != Enabled_DefaultValue) h.Add("enabled",Enabled);
			if (Height != Height_DefaultValue) h.Add("height",Height);
			if (LineWidth != LineWidth_DefaultValue) h.Add("lineWidth",LineWidth);
			if (OnlyOnHover != OnlyOnHover_DefaultValue) h.Add("onlyOnHover",OnlyOnHover);
			if (Shape != Shape_DefaultValue) h.Add("shape",Shape);
			if (Style != Style_DefaultValue) h.Add("style",Style);
			if (Width != Width_DefaultValue) h.Add("width",Width);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON(Highcharts highcharts)
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
			else 
				return "";
		}       

		// checks if the state of the object is different from the default
		// and therefore needs to be serialized
		internal override bool IsDirty(Highcharts highcharts)
		{
			return ToHashtable(highcharts).Count > 0;
		}
	}
}