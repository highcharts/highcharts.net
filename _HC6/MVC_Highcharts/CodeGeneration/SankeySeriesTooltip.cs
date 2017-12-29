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
	public partial class SankeySeriesTooltip  : BaseObject
	{
		public SankeySeriesTooltip()
		{
			FollowPointer = FollowPointer_DefaultValue = true;
			HeaderFormat = HeaderFormat_DefaultValue = "<span class='highcharts-header'>{series.name}</span><br/>";
			PointFormat = PointFormat_DefaultValue = "{point.fromNode.name} → {point.toNode.name}: <b>{point.weight}</b><br/>";
			NodeFormat = NodeFormat_DefaultValue = {point.name}: <b>{point.sum}</b><br/>;
			NodeFormatter = NodeFormatter_DefaultValue = "";
			
		}	
		

		/// <summary>
		/// 
		/// </summary>
		public SankeySeriesTooltipFollowPointer FollowPointer { get; set; }
		private SankeySeriesTooltipFollowPointer FollowPointer_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string HeaderFormat { get; set; }
		private string HeaderFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// 
		/// </summary>
		public string PointFormat { get; set; }
		private string PointFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// The [format string](http://www.highcharts.com/docs/chart-concepts/labels-and-string-formatting) specifying what to show for _nodes_ in tooltipof a sankey diagram series, as opposed to links.
		/// </summary>
		public SankeySeriesTooltipNodeFormat NodeFormat { get; set; }
		private SankeySeriesTooltipNodeFormat NodeFormat_DefaultValue { get; set; }
		 

		/// <summary>
		/// A callback for defining the format for _nodes_ in the sankey chart'stooltip, as opposed to links.
		/// </summary>
		public string NodeFormatter { get; set; }
		private string NodeFormatter_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (FollowPointer != FollowPointer_DefaultValue) h.Add("followPointer",FollowPointer);
			if (HeaderFormat != HeaderFormat_DefaultValue) h.Add("headerFormat",HeaderFormat);
			if (PointFormat != PointFormat_DefaultValue) h.Add("pointFormat",PointFormat);
			if (NodeFormat != NodeFormat_DefaultValue) h.Add("nodeFormat",NodeFormat);
			if (NodeFormatter != NodeFormatter_DefaultValue) h.Add("nodeFormatter",NodeFormatter);
			

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