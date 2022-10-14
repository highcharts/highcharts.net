using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Animation : BaseObject
	{
        Hashtable h = new Hashtable();

        public Animation() {
            Defer = -1;
            Duration = -1;
            Easing = "";            
		}

        /// <summary>
        /// The animation delay time in milliseconds.
        /// </summary>
        public int Defer { get; set; }

        /// <summary>
        /// The duration of the animation in milliseconds
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// >When using jQuery as the general framework, the easing can be set to <code>linear</code> or <code>swing</code>. 
        //  More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite.
        /// </summary>
        public string Easing { get; set; }

        internal override Hashtable ToHashtable(Highcharts highcharts)
        {
            if (h.Count > 0)
                return h;

            if (!String.IsNullOrEmpty(Easing)) h.Add("easing", Easing);
            if (Duration > -1) h.Add("duration", Duration);
            if (Defer > -1) h.Add("defer", Defer);

            return h;
        }

        internal override string ToJSON(Highcharts highcharts)
        {
            if (h.Count > 0)
                return JsonConvert.SerializeObject(h);
            else
                return String.Empty;
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty(Highcharts highcharts)
        {
            return ToHashtable(highcharts).Count > 0;
        }
	}
}