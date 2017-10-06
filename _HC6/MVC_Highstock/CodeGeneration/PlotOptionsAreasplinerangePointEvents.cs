using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class PlotOptionsAreasplinerangePointEvents  : BaseObject
	{
		public PlotOptionsAreasplinerangePointEvents()
		{
			Click = Click_DefaultValue = null;
			MouseOut = MouseOut_DefaultValue = null;
			MouseOver = MouseOver_DefaultValue = null;
			Remove = Remove_DefaultValue = null;
			Select = Select_DefaultValue = null;
			Unselect = Unselect_DefaultValue = null;
			Update = Update_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// <p>Fires when a point is clicked. One parameter, <code>event</code>, is passedto the function, containing common event information.</p><p>If the <code>series.allowPointSelect</code> option is true, the default actionfor the point&#39;s click event is to toggle the point&#39;s select state. Returning <code>false</code> cancels this action.</p>
		/// </summary>
		public function Click { get; set; }
		private function Click_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the mouse leaves the area close to the point. One parameter,<code>event</code>, is passed to the function, containing common event information.</p>
		/// </summary>
		public function MouseOut { get; set; }
		private function MouseOut_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the mouse enters the area close to the point. One parameter,<code>event</code>, is passed to the function, containing common event information.</p>
		/// </summary>
		public function MouseOver { get; set; }
		private function MouseOver_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the point is removed using the <code>.remove()</code> method. Oneparameter, <code>event</code>, is passed to the function. Returning <code>false</code>cancels the operation.</p>
		/// </summary>
		public function Remove { get; set; }
		private function Remove_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the point is selected either programmatically or followinga click on the point. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation.</p>
		/// </summary>
		public function Select { get; set; }
		private function Select_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the point is unselected either programmatically or followinga click on the point. One parameter, <code>event</code>, is passed to the function. Returning <code>false</code> cancels the operation.</p>
		/// </summary>
		public function Unselect { get; set; }
		private function Unselect_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Fires when the point is updated programmatically through the <code>.update()</code>method. One parameter, <code>event</code>, is passed to the function. The newpoint options can be accessed through <code>event.options</code>. Returning<code>false</code> cancels the operation.</p>
		/// </summary>
		public function Update { get; set; }
		private function Update_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Click != Click_DefaultValue) h.Add("click",Click);
			if (MouseOut != MouseOut_DefaultValue) h.Add("mouseOut",MouseOut);
			if (MouseOver != MouseOver_DefaultValue) h.Add("mouseOver",MouseOver);
			if (Remove != Remove_DefaultValue) h.Add("remove",Remove);
			if (Select != Select_DefaultValue) h.Add("select",Select);
			if (Unselect != Unselect_DefaultValue) h.Add("unselect",Unselect);
			if (Update != Update_DefaultValue) h.Add("update",Update);
			

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