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
			ActiveAxisLabelStyle = ActiveAxisLabelStyle_DefaultValue = new Hashtable();
			ActiveDataLabelStyle = ActiveDataLabelStyle_DefaultValue = new Hashtable();
			AllowPointDrilldown = AllowPointDrilldown_DefaultValue = true;
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			AnimationBool = AnimationBool_DefaultValue = null;
			DrillUpButton = DrillUpButton_DefaultValue = new DrilldownDrillUpButton();
			Series = Series_DefaultValue = new List<Series>();
			
			CustomFields = new Hashtable();
		}	
		

		/// <summary>
		/// Additional styles to apply to the X axis label for a point thathas drilldown data. By default it is underlined and blue to inviteto interaction.In styled mode, active label styles can be set with the`.highcharts-drilldown-axis-label` class.
		/// </summary>
		public Hashtable ActiveAxisLabelStyle { get; set; }
		private Hashtable ActiveAxisLabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// Additional styles to apply to the data label of a point that hasdrilldown data. By default it is underlined and blue to invite tointeraction.In styled mode, active data label styles can be applied with the`.highcharts-drilldown-data-label` class.
		/// </summary>
		public Hashtable ActiveDataLabelStyle { get; set; }
		private Hashtable ActiveDataLabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// When this option is false, clicking a single point will drill downall points in the same category, equivalent to clicking the X axislabel.
		/// </summary>
		public bool? AllowPointDrilldown { get; set; }
		private bool? AllowPointDrilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the animation for all drilldown animations. Animation of a drilldownoccurs when drilling between a column point and a column series,or a pie slice and a full pie series. Drilldown can still be usedbetween series and points of different types, but animation willnot occur.The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and a durationof 500 ms. If used as a configuration object, the following propertiesare supported:- `duration`: The duration of the animation in milliseconds.- `easing`: A string reference to an easing function set on the `Math`  object. See  [the easing demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// Set the animation for all drilldown animations. Animation of a drilldownoccurs when drilling between a column point and a column series,or a pie slice and a full pie series. Drilldown can still be usedbetween series and points of different types, but animation willnot occur.The animation can either be set as a boolean or a configurationobject. If `true`, it will use the 'swing' jQuery easing and a durationof 500 ms. If used as a configuration object, the following propertiesare supported:- `duration`: The duration of the animation in milliseconds.- `easing`: A string reference to an easing function set on the `Math`  object. See  [the easing demo](https://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/).
		/// </summary>
		public bool? AnimationBool { get; set; }
		private bool? AnimationBool_DefaultValue { get; set; }
		 

		/// <summary>
		/// Options for the drill up button that appears when drilling down on aseries. The text for the button is defined in[lang.drillUpText](#lang.drillUpText).
		/// </summary>
		public DrilldownDrillUpButton DrillUpButton { get; set; }
		private DrilldownDrillUpButton DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// An array of series configurations for the drill down. Each seriesconfiguration uses the same syntax as the [series](#series) option set.These drilldown series are hidden by default. The drilldown series islinked to the parent series' point by its `id`.
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		 

		public Hashtable CustomFields { get; set; } 

		internal override Hashtable ToHashtable()
		{
			if (h.Count > 0)
				return h;

			if (ActiveAxisLabelStyle != ActiveAxisLabelStyle_DefaultValue) h.Add("activeAxisLabelStyle",ActiveAxisLabelStyle);
			if (ActiveDataLabelStyle != ActiveDataLabelStyle_DefaultValue) h.Add("activeDataLabelStyle",ActiveDataLabelStyle);
			if (AllowPointDrilldown != AllowPointDrilldown_DefaultValue) h.Add("allowPointDrilldown",AllowPointDrilldown);
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (AnimationBool != AnimationBool_DefaultValue) h.Add("animation",AnimationBool);
			if (DrillUpButton.IsDirty()) h.Add("drillUpButton",DrillUpButton.ToHashtable());
			if (Series != Series_DefaultValue) h.Add("series",Series);
			if (CustomFields.Count > 0)
				foreach (var key in CustomFields.Keys)
				{
					if (h.ContainsKey(key))
						continue;

					h.Add(key, CustomFields[key]);
				}

			return h;
		}

		internal override string ToJSON()
		{            
			if (h.Count > 0)
				return JsonConvert.SerializeObject(h);
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