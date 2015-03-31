using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc
{
	public partial class Animation
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
	}
}