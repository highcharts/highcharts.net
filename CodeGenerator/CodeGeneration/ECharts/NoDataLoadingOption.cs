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
	public partial class NoDataLoadingOption  : BaseObject
	{
		public NoDataLoadingOption()
		{
			Text = Text_DefaultValue = ????;
			X = X_DefaultValue = center;
			Y = Y_DefaultValue = center;
			TextStyle = TextStyle_DefaultValue = null;
			Effect = Effect_DefaultValue = bubble;
			EffectOption = EffectOption_DefaultValue = null;
			Progress = Progress_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// The loading text that appears when the chart is set into the loading state. \n' represents a line feed.
		/// </summary>
		public string Text { get; set; }
		private string Text_DefaultValue { get; set; }
		 

		/// <summary>
		/// horizontal position. Defaults to center. Valid values are: 'center' | 'left' | 'right' | <b>{number}</b>(x-coordinate, in px).
		/// </summary>
		public string X { get; set; }
		private string X_DefaultValue { get; set; }
		 

		/// <summary>
		/// vertical position. Defaults to center. Valid values are: 'center' | 'bottom' | 'top' | <b>{number}</b>(y-coordinate, in px).
		/// </summary>
		public string Y { get; set; }
		private string Y_DefaultValue { get; set; }
		 

		/// <summary>
		/// style for the loading text.
		/// </summary>
		public Object TextStyle { get; set; }
		private Object TextStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// loading effect. Valid values are: 'spin' | 'bar' | 'ring' | 'whirling' | 'dynamicLine' | 'bubble'. Supports external loading.
		/// </summary>
		public string Effect { get; set; }
		private string Effect_DefaultValue { get; set; }
		 

		/// <summary>
		/// option for loading effect, see zrender.
		/// </summary>
		public Object EffectOption { get; set; }
		private Object EffectOption_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies the current progress [0~1]. Applicable to specific effects.
		/// </summary>
		public number Progress { get; set; }
		private number Progress_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Text != Text_DefaultValue) h.Add("text",Text);
			if (X != X_DefaultValue) h.Add("x",X);
			if (Y != Y_DefaultValue) h.Add("y",Y);
			if (TextStyle != TextStyle_DefaultValue) h.Add("textStyle",TextStyle);
			if (Effect != Effect_DefaultValue) h.Add("effect",Effect);
			if (EffectOption != EffectOption_DefaultValue) h.Add("effectOption",EffectOption);
			if (Progress != Progress_DefaultValue) h.Add("progress",Progress);
			

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