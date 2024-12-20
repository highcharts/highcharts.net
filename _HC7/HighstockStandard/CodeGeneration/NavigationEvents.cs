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
	public partial class NavigationEvents  : BaseObject
	{
		Hashtable h = new Hashtable();

		public NavigationEvents()
		{
		}	
		

		/// <summary>
		/// A `closePopup` event. Fired when Popup should be hidden, for examplewhen clicking on an annotation again.
		/// </summary>
		public string ClosePopup { get; set; }
		 

		/// <summary>
		/// Event fired when button state should change, for example afteradding an annotation.
		/// </summary>
		public string DeselectButton { get; set; }
		 

		/// <summary>
		/// Event fired on a button click.
		/// </summary>
		public string SelectButton { get; set; }
		 

		/// <summary>
		/// A `showPopup` event. Fired when selecting for example an annotation.
		/// </summary>
		public string ShowPopup { get; set; }
		  

		internal override Hashtable ToHashtable(Highstock highstock)
		{
			if (ClosePopup != null) { h.Add("closePopup",ClosePopup); highstock.AddFunction("closePopup", ClosePopup); }  
			if (DeselectButton != null) { h.Add("deselectButton",DeselectButton); highstock.AddFunction("deselectButton", DeselectButton); }  
			if (SelectButton != null) { h.Add("selectButton",SelectButton); highstock.AddFunction("selectButton", SelectButton); }  
			if (ShowPopup != null) { h.Add("showPopup",ShowPopup); highstock.AddFunction("showPopup", ShowPopup); }  
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