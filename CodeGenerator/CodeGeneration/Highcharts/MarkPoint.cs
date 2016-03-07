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
	public partial class MarkPoint  : BaseObject
	{
		public MarkPoint()
		{
			Clickable = Clickable_DefaultValue = null;
			Symbol = Symbol_DefaultValue = pin;
			SymbolSize = SymbolSize_DefaultValue = null;
			SymbolRotate = SymbolRotate_DefaultValue = null;
			Large = Large_DefaultValue = null;
			Effect = Effect_DefaultValue = new MarkPointEffect();
			ItemStyle = ItemStyle_DefaultValue = "";
			Data = Data_DefaultValue = new List<MarkPointData>();
			
		}	
		

		/// <summary>
		/// Specifies data graphic clickable or not, default to true, recommend to false when you do not have a click event handler.
		/// </summary>
		public boolean Clickable { get; set; }
		private boolean Clickable_DefaultValue { get; set; }
		 

		/// <summary>
		/// the symbol of markPoint, same as series' <a href="#series">symbol</a>.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// the size of markPoint symbol, same as series' <a href="#series">symbolSize</a>.
		/// </summary>
		public string SymbolSize { get; set; }
		private string SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// the angle by which markPoint symbol rotates, same as series' <a href="#series">symbolRotate</a>.
		/// </summary>
		public number SymbolRotate { get; set; }
		private number SymbolRotate_DefaultValue { get; set; }
		 

		/// <summary>
		/// Specifies whether the large scale markPoint mode will be enabled.
		/// </summary>
		public boolean Large { get; set; }
		private boolean Large_DefaultValue { get; set; }
		 

		/// <summary>
		/// glow effect for markPoint symbol:                                <br>show: specifies whether to show glow effect or not. Defaults to false.                                <br>type effect type, default to 'scale', can be 'bounce'.                                <br>loop: specifies whether to play the animation in a loop. Defaults to true.                                <br>period: animation period. No units. The larger the value, the slower. Defaults to 15.                                <br>scaleSize: magnification. Based on markPoint symbolSize, available when type is scale.                                <br>bounceDistance bouncing distance, in px, available when type is bounce.                                <br>color: color of the glow. The default value is pulled from the markPoint itemStyle array.                                <br>shadowColor: color of the shadow. The default value is pulled from the color array.                                <br>shadowBlur: blur degree of shadow. Defaults to 0.                                <br><a href="./example/map11.html#-en" target="_blank">Baidu Migration (Simulation) �</a>
		/// </summary>
		public MarkPointEffect Effect { get; set; }
		private MarkPointEffect Effect_DefaultValue { get; set; }
		 

		/// <summary>
		/// style for markPoint symbol, same as series' <a href="#series">itemStyle</a>.
		/// </summary>
		public Object ItemStyle { get; set; }
		private Object ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<MarkPointData> Data { get; set; }
		private List<MarkPointData> Data_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Clickable != Clickable_DefaultValue) h.Add("clickable",Clickable);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (SymbolRotate != SymbolRotate_DefaultValue) h.Add("symbolRotate",SymbolRotate);
			if (Large != Large_DefaultValue) h.Add("large",Large);
			if (Effect.IsDirty()) h.Add("effect",Effect.ToHashtable());
			if (ItemStyle != ItemStyle_DefaultValue) h.Add("itemStyle",ItemStyle);
			

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