using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace Highsoft.Web.Mvc.Maps
{
	public abstract class BaseObject
	{
        abstract internal Hashtable ToHashtable();
        abstract internal string ToJSON();
        abstract internal bool IsDirty();

        internal List<Hashtable> HashifyList(IEnumerable list)
        {
            List<Hashtable> result = new List<Hashtable>();

            foreach (BaseObject baseObject in list)
            {
                result.Add(baseObject.ToHashtable());
            }

            return result;
        }
	}
}