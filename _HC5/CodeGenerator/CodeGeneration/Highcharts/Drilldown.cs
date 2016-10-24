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
	public partial class Drilldown  : BaseObject
	{
		public Drilldown()
		{
			ActiveAxisLabelStyle = ActiveAxisLabelStyle_DefaultValue = new NameValueCollection{{ "cursor", "pointer"},{ "color", "#003399"},{ "fontWeight", "bold"},{ "textDecoration", "underline" }};
			ActiveDataLabelStyle = ActiveDataLabelStyle_DefaultValue = new NameValueCollection{{ "cursor", "pointer"},{ "color", "#003399"},{ "fontWeight", "bold"},{ "textDecoration", "underline" }};
			AllowPointDrilldown = AllowPointDrilldown_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			DrillUpButton = DrillUpButton_DefaultValue = new DrilldownDrillUpButton();
			Series = Series_DefaultValue = null;
			
		}	
		

		/// <summary>
		/// Additional styles to apply to the X axis label for a point that has drilldown data. By default it is underlined and blue to invite to interaction.
		/// </summary>
		public NameValueCollection ActiveAxisLabelStyle { get; set; }
		private NameValueCollection ActiveAxisLabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional styles to apply to the data label of a point that has drilldown data. By default it is underlined and blue to invite to interaction.
		/// </summary>
		public NameValueCollection ActiveDataLabelStyle { get; set; }
		private NameValueCollection ActiveDataLabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this option is false, clicking a single point will drill down all points in the same category, equivalent to clicking the X axis label.
		/// </summary>
		public bool? AllowPointDrilldown { get; set; }
		private bool? AllowPointDrilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the animation for all drilldown animations. Animation of a drilldown occurs when drilling between a column point and a column series, or a pie slice and a full pie series. Drilldown can still be used between series and points of different types, but animation will not occur.</p>  <p>The animation can either be set as a boolean or a configuration object. If <code>true</code>, it will use the 'swing' jQuery easing and a duration of 500 ms. If used as a configuration object, the following properties are supported:  </p><dl> <dt>duration</dt> <dd>The duration of the animation in milliseconds.</dd>  <dt>easing</dt> <dd>A string reference to an easing function set on the <code>Math</code> object. See <a href="http://jsfiddle.net/gh/get/jquery/1.7.2/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/">the easing demo</a>.</dd> </dl>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the drill up button that appears when drilling down on a series. The text for the button is defined in <a href="#lang.drillUpText">lang.drillUpText</a>.
		/// </summary>
		public DrilldownDrillUpButton DrillUpButton { get; set; }
		private DrilldownDrillUpButton DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of series configurations for the drill down. Each series configuration uses the same syntax as the <a href="#series">series</a> option set. These drilldown series are hidden by default. The drilldown series is linked to the parent series' point by its <code>id</code>.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ActiveAxisLabelStyle != ActiveAxisLabelStyle_DefaultValue) h.Add("activeAxisLabelStyle",ActiveAxisLabelStyle);
			if (ActiveDataLabelStyle != ActiveDataLabelStyle_DefaultValue) h.Add("activeDataLabelStyle",ActiveDataLabelStyle);
			if (AllowPointDrilldown != AllowPointDrilldown_DefaultValue) h.Add("allowPointDrilldown",AllowPointDrilldown);
			if (Animation.IsDirty()) h.Add("animation",Animation.ToJSON());
			if (DrillUpButton.IsDirty()) h.Add("drillUpButton",DrillUpButton.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			

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