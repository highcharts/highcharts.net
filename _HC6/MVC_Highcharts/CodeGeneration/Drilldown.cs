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
			ActiveAxisLabelStyle = ActiveAxisLabelStyle_DefaultValue = new DrilldownActiveAxisLabelStyle();
			ActiveDataLabelStyle = ActiveDataLabelStyle_DefaultValue = new DrilldownActiveDataLabelStyle();
			Animation = Animation_DefaultValue = new Animation() { Enabled = true };
			DrillUpButton = DrillUpButton_DefaultValue = new DrilldownDrillUpButton();
			AllowPointDrilldown = AllowPointDrilldown_DefaultValue = true;
			Series = Series_DefaultValue = new List<Series>();
			
		}	
		

		/// <summary>
		/// <p>Additional styles to apply to the X axis label for a point thathas drilldown data. By default it is underlined and blue to inviteto interaction.</p>
		/// </summary>
		public DrilldownActiveAxisLabelStyle ActiveAxisLabelStyle { get; set; }
		private DrilldownActiveAxisLabelStyle ActiveAxisLabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Additional styles to apply to the data label of a point that hasdrilldown data. By default it is underlined and blue to invite tointeraction.</p>
		/// </summary>
		public DrilldownActiveDataLabelStyle ActiveDataLabelStyle { get; set; }
		private DrilldownActiveDataLabelStyle ActiveDataLabelStyle_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Set the animation for all drilldown animations. Animation of a drilldownoccurs when drilling between a column point and a column series,or a pie slice and a full pie series. Drilldown can still be usedbetween series and points of different types, but animation willnot occur.</p><p>The animation can either be set as a boolean or a configurationobject. If <code>true</code>, it will use the &#39;swing&#39; jQuery easing and a durationof 500 ms. If used as a configuration object, the following propertiesare supported:</p><dl><dt>duration</dt><dd>The duration of the animation in milliseconds.</dd><dt>easing</dt><dd>A string reference to an easing function set on the <code>Math</code> object.See <a href="http://jsfiddle.net/gh/get/library/pure/highcharts/highcharts/tree/master/samples/highcharts/plotoptions/series-animation-easing/">the easing demo</a>.</dd></dl>
		/// </summary>
		public Animation Animation { get; set; }
		private Animation Animation_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>Options for the drill up button that appears when drilling downon a series. The text for the button is defined in <a href="#lang.drillUpText">lang.drillUpText</a>.</p>
		/// </summary>
		public DrilldownDrillUpButton DrillUpButton { get; set; }
		private DrilldownDrillUpButton DrillUpButton_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>When this option is false, clicking a single point will drill downall points in the same category, equivalent to clicking the X axislabel.</p>
		/// </summary>
		public bool? AllowPointDrilldown { get; set; }
		private bool? AllowPointDrilldown_DefaultValue { get; set; }
		 

		/// <summary>
		/// <p>An array of series configurations for the drill down. Each seriesconfiguration uses the same syntax as the <a href="#series">series</a> optionset. These drilldown series are hidden by default. The drilldownseries is linked to the parent series&#39; point by its <code>id</code>.</p>
		/// </summary>
		public List<Series> Series { get; set; }
		private List<Series> Series_DefaultValue { get; set; }
		  

		internal override Hashtable ToHashtable()
		{
			Hashtable h = new Hashtable();

			if (ActiveAxisLabelStyle.IsDirty()) h.Add("activeAxisLabelStyle",ActiveAxisLabelStyle.ToHashtable());
			if (ActiveDataLabelStyle.IsDirty()) h.Add("activeDataLabelStyle",ActiveDataLabelStyle.ToHashtable());
			if (Animation != Animation_DefaultValue) h.Add("animation",Animation);
			if (DrillUpButton.IsDirty()) h.Add("drillUpButton",DrillUpButton.ToHashtable());
			if (AllowPointDrilldown != AllowPointDrilldown_DefaultValue) h.Add("allowPointDrilldown",AllowPointDrilldown);
			if (Series != Series_DefaultValue) h.Add("series",Series);
			

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