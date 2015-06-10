using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class Pane  : BaseObject
	{
		public Pane()
		{
			Background = Background_DefaultValue = null;
			Center = Center_DefaultValue = new string[] { null, null };
			EndAngle = EndAngle_DefaultValue = null;
			Size = Size_DefaultValue = "85%";
			StartAngle = StartAngle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// An object, or array of objects, for backgrounds. Sub options include <code>backgroundColor</code> (can be solid or gradient), <code>shape</code> ("solid" or "arc"), <code>innerWidth</code>, <code>outerWidth</code>, <code>borderWidth</code>, <code>borderColor</code>.
		/// </summary>
		public List<Background> Background { get; set; }
		private List<Background> Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// The center of a polar chart or angular gauge, given as an array of [x, y] positions. Positions can be given as integers that transform to pixels, or as percentages of the plot area size.
		/// </summary>
		public new string[] Center { get; set; }
		private new string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// The end angle of the polar X axis or gauge value axis, given in degrees where 0 is north. Defaults to <a href="#pane.startAngle">startAngle</a> + 360.
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// The size of the pane, either as a number defining pixels, or a percentage defining a percentage of the plot are.
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// The start angle of the polar X axis or gauge axis, given in degrees where 0 is north. Defaults to 0.
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Background != Background_DefaultValue) h.Add("background", HashifyList(Background));
			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			if (h.Count > 0)
				return new JavaScriptSerializer().Serialize(ToHashtable());
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