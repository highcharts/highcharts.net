using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System;

namespace Highsoft.Web.Mvc.Charts
{
	public partial class Stop : BaseObject, IObjectList
	{
		public Stop() {
            Position = 0;
            Color = "";
		}

        /// <summary>
        /// The text of the menu item
        /// </summary>
        public double Position { get; set; }

        /// <summary>
        /// OnClick javascript event to fire
        /// </summary>
        public string Color { get; set; }

        internal override Hashtable ToHashtable()
        {
            Hashtable h = new Hashtable();

            if (!String.IsNullOrEmpty(Color)) h.Add("color", Color);
            if (Position != 0) h.Add("position", Position);

            return h;
        }

        internal override string ToJSON()
        {
            return JsonConvert.SerializeObject(ToHashtable());
        }

        public List<object> ToList()
        {
            if (!string.IsNullOrWhiteSpace(Color))
                return new List<object> { Position, Color };

            return new List<object>();
        }

        // checks if the state of the object is different from the default
        // and therefore needs to be serialized
        internal override bool IsDirty()
        {
            return ToHashtable().Count > 0;
        }   
	}
}