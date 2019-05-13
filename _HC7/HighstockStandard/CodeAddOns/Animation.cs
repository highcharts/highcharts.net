using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

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

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Easing)) h.Add("easing", Easing);
            if (Duration > 0) h.Add("duration", Duration);

            return h;
        }

        internal override string ToJSON()
        {
            Hashtable h = ToHashtable();

            if (h.Count > 0)
                return JsonConvert.SerializeObject(ToHashtable());
            else
                return "";
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return (Enabled != true || ToHashtable().Count > 0);
        }
	}
}