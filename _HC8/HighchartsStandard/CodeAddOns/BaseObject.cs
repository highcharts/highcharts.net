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
	public abstract class BaseObject
	{
        abstract internal Hashtable ToHashtable(Highcharts highcharts);
        abstract internal string ToJSON(Highcharts highcharts);
        abstract internal bool IsDirty(Highcharts highcharts);

        internal List<Hashtable> HashifyList(Highcharts highcharts, IEnumerable list)
        {
            List<Hashtable> result = new List<Hashtable>();

            foreach (BaseObject baseObject in list)
            {
                result.Add(baseObject.ToHashtable(highcharts));
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