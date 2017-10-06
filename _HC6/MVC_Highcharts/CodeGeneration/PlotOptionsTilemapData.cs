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
	public partial class PlotOptionsTilemapData  : BaseObject
	{
		public PlotOptionsTilemapData()
		{
			Color = Color_DefaultValue = null;
			X = X_DefaultValue = double.MinValue;
			Y = Y_DefaultValue = double.MinValue;
			
		}	
		

		/// <summary>
		/// <p>The color of the point. In tilemaps the point color is rarely setexplicitly, as we use the color to denote the <code>value</code>. Options forthis are set in the <a href="#colorAxis">colorAxis</a> configuration.</p>
		/// </summary>
		public string Color { get; set; }
		private string Color_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The x coordinate of the point.</p><p>Note that for some <a href="#plotOptions.tilemap.tileShape">tileShapes</a> the gridcoordinates are offset.</p>
		/// </summary>
		public double? X { get; set; }
		private double? X_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>The y coordinate of the point.</p><p>Note that for some <a href="#plotOptions.tilemap.tileShape">tileShapes</a> the gridcoordinates are offset.</p>
		/// </summary>
		public double? Y { get; set; }
		private double? Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Color != Color_DefaultValue) h.Add("color",Color);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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