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
	public partial class MarkLine  : BaseObject
	{
		public MarkLine()
		{
			Clickable = Clickable_DefaultValue = null;
			Symbol = Symbol_DefaultValue = null;
			SymbolSize = SymbolSize_DefaultValue = null;
			SymbolRotate = SymbolRotate_DefaultValue = null;
			Large = Large_DefaultValue = null;
			Smooth = Smooth_DefaultValue = null;
			Smoothness = Smoothness_DefaultValue = null;
			Precision = Precision_DefaultValue = null;
			Bundling = Bundling_DefaultValue = new MarkLineBundling();
			Effect = Effect_DefaultValue = new MarkLineEffect();
			ItemStyle = ItemStyle_DefaultValue = "";
			Data = Data_DefaultValue = new List<MarkLineData>();
			
		}	
		

		/// <summary>
		/// Specifies data graphic clickable or not, default to true, recommend to false when you do not have a click event handler.
		/// </summary>
		public boolean Clickable { get; set; }
		private boolean Clickable_DefaultValue { get; set; }
		 

		/// <summary>
		/// symbols of the start and end of markLine. If the two are the same, string can be directly passed in. Same as series' <a href="#series">symbol</a>.
		/// </summary>
		public string Symbol { get; set; }
		private string Symbol_DefaultValue { get; set; }
		 

		/// <summary>
		/// sizes of the start and end symbols of markLine. Half-width (radius) parameters. If the two are the same, number or function can be directly passed in. Same as series' <a href="#series">symbolSize</a>.
		/// </summary>
		public string SymbolSize { get; set; }
		private string SymbolSize_DefaultValue { get; set; }
		 

		/// <summary>
		/// angles by which the start and end markLine symbols rotate, same as series' <a href="#series">symbolRotate</a>.
		/// </summary>
		public string SymbolRotate { get; set; }
		private string SymbolRotate_DefaultValue { get; set; }
		 

		/// <summary>
		/// If enable optimization for large scale markline. Large scale means line number >= 2k.                                <br>Optimization will batch lines drawing. Lines of series will force to have same style. And symbols of two end of line will be ignore.
		/// </summary>
		public boolean Large { get; set; }
		private boolean Large_DefaultValue { get; set; }
		 

		/// <summary>
		/// smoothed line, while smooth is true, lineStyle.type can not be dashed.
		/// </summary>
		public boolean Smooth { get; set; }
		private boolean Smooth_DefaultValue { get; set; }
		 

		/// <summary>
		/// Line smoothness. Only available when smooth is true
		/// </summary>
		public number Smoothness { get; set; }
		private number Smoothness_DefaultValue { get; set; }
		 

		/// <summary>
		/// precision, use for the average markLine.
		/// </summary>
		public number Precision { get; set; }
		private number Precision_DefaultValue { get; set; }
		 

		/// <summary>
		/// Edge Bundling                                <br>                                <br>enable: If enable edge bundling.                                <br>maxTurningAngle: Max turning angle of bundled edge, ranges from 0 degree to 90 degree.                                <br>                                <br>Tip:Edge bundling use algorithm from "Multilevel Agglomerative Edge Bundling for Visualizing Large Graphs"
		/// </summary>
		public MarkLineBundling Bundling { get; set; }
		private MarkLineBundling Bundling_DefaultValue { get; set; }
		 

		/// <summary>
		/// glow effect for markLine symbol:                                <br>                                <br>show: specifies whether to show. Defaults to false.                                <br>loop: specifies whether to play the animation in a loop. Defaults to true.                                <br>period: animation period. No units. The larger the value, the slower. Defaults to 15.                                <br>scaleSize: magnification. Based on markLine lineWidth.                                <br>color: color of the glow. The default value is pulled from the markLine itemStyle array.                                <br>shadowColor: color of the shadow. The default value is pulled from the color array.                                <br>shadowBlur: blur degree of shadow. The default value is based on scaleSize.                                <br><a href="./example/map11.html#-en" target="_blank">Baidu Migration (Simulation) � </a>
		/// </summary>
		public MarkLineEffect Effect { get; set; }
		private MarkLineEffect Effect_DefaultValue { get; set; }
		 

		/// <summary>
		/// style for markLine symbol, same as series' <a href="#series">itemStyle</a>
		/// </summary>
		public Object ItemStyle { get; set; }
		private Object ItemStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public List<MarkLineData> Data { get; set; }
		private List<MarkLineData> Data_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (Clickable != Clickable_DefaultValue) h.Add("clickable",Clickable);
			if (Symbol != Symbol_DefaultValue) h.Add("symbol",Symbol);
			if (SymbolSize != SymbolSize_DefaultValue) h.Add("symbolSize",SymbolSize);
			if (SymbolRotate != SymbolRotate_DefaultValue) h.Add("symbolRotate",SymbolRotate);
			if (Large != Large_DefaultValue) h.Add("large",Large);
			if (Smooth != Smooth_DefaultValue) h.Add("smooth",Smooth);
			if (Smoothness != Smoothness_DefaultValue) h.Add("smoothness",Smoothness);
			if (Precision != Precision_DefaultValue) h.Add("precision",Precision);
			if (Bundling.IsDirty()) h.Add("bundling",Bundling.ToHashtable());
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