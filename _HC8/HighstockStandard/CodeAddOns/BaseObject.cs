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
	public abstract class BaseObject
	{
        abstract internal Hashtable ToHashtable(ref Highstock highcharts);
        abstract internal string ToJSON(ref Highstock highcharts);
        abstract internal bool IsDirty(ref Highstock highcharts);

        internal List<Hashtable> HashifyList(ref Highstock highcharts, IEnumerable list)
        {
            List<Hashtable> result = new List<Hashtable>();

            foreach (BaseObject baseObject in list)
            {
                result.Add(baseObject.ToHashtable(ref highcharts));
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