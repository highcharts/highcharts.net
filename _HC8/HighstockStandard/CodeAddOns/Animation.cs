using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace Highsoft.Web.Mvc.Stocks
{
	public partial class Animation : BaseObject
	{        
		
        public Animation() {
            Enabled = true;
            Duration = 0;
            Easing = "";            
		}

        /// <summary>
        /// If a shadow with default values should be enabled
        /// </summary>
        public bool Enabled { get; set; }

        /// <summary>
        /// The duration of the animation in milliseconds
        /// </summary>
        public int Duration { get; set; }

        /// <summary>
        /// >When using jQuery as the general framework, the easing can be set to <code>linear</code> or <code>swing</code>. 
        //  More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite.
        /// </summary>
        public string Easing { get; set; }

        internal override Hashtable ToHashtable(ref Highstock highcharts)
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Easing)) h.Add("easing", Easing);
            if (Duration > 0) h.Add("duration", Duration);

            return h;
        }

        internal override string ToJSON(ref Highstock highcharts)
        {
            Hashtable h = ToHashtable(ref highcharts);
            if (h.Count > 0)
                return JsonConvert.SerializeObject(h);
            else
                return Enabled.ToString().ToLower();
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty(ref Highstock highcharts)
        {
            return (Enabled != true || ToHashtable(ref highcharts).Count > 0);
        }
	}
}