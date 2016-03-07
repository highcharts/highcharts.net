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
	public partial class ItemStyleLabel  : BaseObject
	{
		public ItemStyleLabel()
		{
			Show = Show_DefaultValue = null;
			Position = Position_DefaultValue = new NameValueCollection();
			Rotate = Rotate_DefaultValue = null;
			Distance = Distance_DefaultValue = null;
			Formatter = Formatter_DefaultValue = null;
			TextStyle = TextStyle_DefaultValue = null;
			X = X_DefaultValue = "";
			Y = Y_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// Specifies whether to show label. Valid values are: true (show) | false (hide).
		/// </summary>
		public boolean Show { get; set; }
		private boolean Show_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public NameValueCollection Position { get; set; }
		private NameValueCollection Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// applicable to chord. Label rotates automatically.
		/// </summary>
		public boolean Rotate { get; set; }
		private boolean Rotate_DefaultValue { get; set; }
		 

		/// <summary>
		/// In chord, Label's distance from chord after it rotates automatically.                              <br> In pie, this distance means the factor of label distance and pie radius(In ring chart, is sum of inner and outer radius), default to <b>0.5</b>.
		/// </summary>
		public number Distance { get; set; }
		private number Distance_DefaultValue { get; set; }
		 

		/// <summary>
		/// label text formatter, universal, same as <a href="#tooltip" title="">Tooltip.formatter</a>, Supports template, method callback. Does not support asynchronous callback.
		/// </summary>
		public string Formatter { get; set; }
		private string Formatter_DefaultValue { get; set; }
		 

		/// <summary>
		/// style for label text.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// only in treemap,x-coordinate in px of text
		/// </summary>
		public number X { get; set; }
		private number X_DefaultValue { get; set; }
		 

		/// <summary>
		/// only in treemap,y-coordinate in px of text
		/// </summary>
		public number Y { get; set; }
		private number Y_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Show != Show_DefaultValue) h.Add("show",Show);
			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (Rotate != Rotate_DefaultValue) h.Add("rotate",Rotate);
			if (Distance != Distance_DefaultValue) h.Add("distance",Distance);
			if (Formatter != Formatter_DefaultValue) h.Add("formatter",Formatter);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			

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