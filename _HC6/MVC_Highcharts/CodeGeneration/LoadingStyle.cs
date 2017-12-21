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
	public partial class LoadingStyle  : BaseObject
	{
		public LoadingStyle()
		{
			Position = Position_DefaultValue = new Hashtable();
			BackgroundColor = BackgroundColor_DefaultValue = #ffffff;
			Opacity = Opacity_DefaultValue = 0.5;
			TextAlign = TextAlign_DefaultValue = center;
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public Hashtable Position { get; set; }
		private Hashtable Position_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LoadingStyleBackgroundColor BackgroundColor { get; set; }
		private LoadingStyleBackgroundColor BackgroundColor_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LoadingStyleOpacity Opacity { get; set; }
		private LoadingStyleOpacity Opacity_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public LoadingStyleTextAlign TextAlign { get; set; }
		private LoadingStyleTextAlign TextAlign_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Position != Position_DefaultValue) h.Add("position",Position);
			if (BackgroundColor != BackgroundColor_DefaultValue) h.Add("backgroundColor",BackgroundColor);
			if (Opacity != Opacity_DefaultValue) h.Add("opacity",Opacity);
			if (TextAlign != TextAlign_DefaultValue) h.Add("textAlign",TextAlign);
			

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