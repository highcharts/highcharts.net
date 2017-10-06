using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Pane  : BaseObject
	{
		public Pane()
		{
			Center = Center_DefaultValue = new string[] { "50%", "50%" };
			Size = Size_DefaultValue = "85%";
			StartAngle = StartAngle_DefaultValue = null;
			Background = Background_DefaultValue = new List<PaneBackground>();
			EndAngle = EndAngle_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>The center of a polar chart or angular gauge, given as an arrayof [x, y] positions. Positions can be given as integers that transformto pixels, or as percentages of the plot area size.</p>
		/// </summary>
		public string[] Center { get; set; }
		private string[] Center_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The size of the pane, either as a number defining pixels, or apercentage defining a percentage of the plot are.</p>
		/// </summary>
		public string Size { get; set; }
		private string Size_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The start angle of the polar X axis or gauge axis, given in degreeswhere 0 is north. Defaults to 0.</p>
		/// </summary>
		public double? StartAngle { get; set; }
		private double? StartAngle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of background items for the pane.</p>
		/// </summary>
		public List<PaneBackground> Background { get; set; }
		private List<PaneBackground> Background_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The end angle of the polar X axis or gauge value axis, given in degreeswhere 0 is north. Defaults to <a href="#pane.startAngle">startAngle</a> + 360.</p>
		/// </summary>
		public double? EndAngle { get; set; }
		private double? EndAngle_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Center != Center_DefaultValue) h.Add("center",Center);
			if (Size != Size_DefaultValue) h.Add("size",Size);
			if (StartAngle != StartAngle_DefaultValue) h.Add("startAngle",StartAngle);
			if (Background != Background_DefaultValue) h.Add("background", HashifyList(Background));
			if (EndAngle != EndAngle_DefaultValue) h.Add("endAngle",EndAngle);
			

			return h;
		}

		internal override string ToJSON()
		{            
			Hashtable h = ToHashtable();
			JavaScriptSerializer serializer = new JavaScriptSerializer();
            serializer.MaxJsonLength = Int32.MaxValue;

			if (h.Count > 0)
				return serializer.Serialize(ToHashtable());
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