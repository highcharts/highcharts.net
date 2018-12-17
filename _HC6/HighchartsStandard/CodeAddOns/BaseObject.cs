using System.Collections.Generic;
using System.Collections;

namespace Highsoft.Web.Mvc.Charts
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

        internal List<List<object>> GetLists(IEnumerable list)
        {
            List<List<object>> result = new List<List<object>>();

            foreach (IObjectList baseObject in list)
            {
                result.Add(baseObject.ToList());
            }

            return result;
        }
	}
}