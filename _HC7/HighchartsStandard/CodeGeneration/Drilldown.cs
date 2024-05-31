using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Drilldown  : BaseObject
	{
		Hashtable h = new Hashtable();

		public Drilldown()
		{
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Additional styles to apply to the X axis label for a point thathas drilldown data. By default it is underlined and blue to inviteto interaction.In styled mode, active label styles can be set with the`.highcharts-drilldown-axis-label` class.
		/// </summary>
		public Hashtable ActiveAxisLabelStyle { get; set; }
		 

		/// <summary>
		/// Additional styles to apply to the data label of a point that hasdrilldown data. By default it is underlined and blue to invite tointeraction.In styled mode, active data label styles can be applied with the`.highcharts-drilldown-data-label` class.
		/// </summary>
		public Hashtable ActiveDataLabelStyle { get; set; }
		 

		/// <summary>
		/// When this option is false, clicking a single point will drill downall points in the same category, equivalent to clicking the X axislabel.
		/// </summary>
		public bool? AllowPointDrilldown { get; set; }
		 

		/// <summary>
		/// Set the animation for all drilldown animations. Animation of a drilldownoccurs when drilling between a column point and a column series,or a pie slice and a full pie series. Drilldown can still be usedbetween series and points of different types, but animation willnot occur.The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and a durationof 500 ms. If used as a configuration object, the following propertiesare supported:- `duration`: The duration of the animation in milliseconds.- `easing`: A string reference to an easing function set on the `Math`  object. See  [the easing demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).
		/// </summary>
		public Animation Animation { get; set; }
		 

		/// <summary>
		/// Set the animation for all drilldown animations. Animation of a drilldownoccurs when drilling between a column point and a column series,or a pie slice and a full pie series. Drilldown can still be usedbetween series and points of different types, but animation willnot occur.The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and a durationof 500 ms. If used as a configuration object, the following propertiesare supported:- `duration`: The duration of the animation in milliseconds.- `easing`: A string reference to an easing function set on the `Math`  object. See  [the easing demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).
		/// </summary>
		public bool? AnimationBool { get; set; }
		 

		/// <summary>
		/// Options for the breadcrumbs, the navigation at the top leading the wayup through the drilldown levels.
		/// </summary>
		public DrilldownBreadcrumbs Breadcrumbs { get; set; }
		 

		/// <summary>
		/// Options for the drill up button that appears when drilling down on aseries. The text for the button is defined in[lang.drillUpText](#lang.drillUpText).This option is deprecated since 9.3.2, use `drilldown.breadcrumbs`instead.
		/// </summary>
		public DrilldownDrillUpButton DrillUpButton { get; set; }
		 

		/// <summary>
		/// Enable or disable zooming into a region of clicked map point you want todrill into. If mapZooming is set to false the drilldown/drillupanimations only fade in/fade out without zooming to a specific map point.
		/// </summary>
		public bool? MapZooming { get; set; }
		 

		/// <summary>
		/// An array of series configurations for the drill down. Each seriesconfiguration uses the same syntax as the [series](#series) option set.These drilldown series are hidden by default. The drilldown series islinked to the parent series' point by its `id`.
		/// </summary>
		public List<Series> Series { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			if (ActiveAxisLabelStyle != null) h.Add("activeAxisLabelStyle",ActiveAxisLabelStyle);
			if (ActiveDataLabelStyle != null) h.Add("activeDataLabelStyle",ActiveDataLabelStyle);
			if (AllowPointDrilldown != null) h.Add("allowPointDrilldown",AllowPointDrilldown);
			if (Animation != null) h.Add("animation",Animation.ToHashtable(highcharts));
			if (AnimationBool != null) h.Add("animation",AnimationBool);
			if (Breadcrumbs != null) h.Add("breadcrumbs",Breadcrumbs.ToHashtable(highcharts));
			if (DrillUpButton != null) h.Add("drillUpButton",DrillUpButton.ToHashtable(highcharts));
			if (MapZooming != null) h.Add("mapZooming",MapZooming);
			if (Series != null) h.Add("series",Series);
			if (CustomFields.Count > 0)
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