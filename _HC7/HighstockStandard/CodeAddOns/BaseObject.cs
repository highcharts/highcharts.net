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
        public Hashtable CustomFields { get; set; }

        abstract internal Hashtable ToHashtable(Highstock highcharts);

        internal Dictionary<string, Hashtable> HashifyDictionary(Highstock highcharts, Dictionary<string, ExportingMenuItemDefinitions> dictionary)
        {
            var result = new Dictionary<string, Hashtable>();

            foreach (var key in dictionary.Keys)
            {
                result.Add(key, dictionary[key].ToHashtable(highcharts));
            }

            return result;
        }

        internal List<Hashtable> HashifyList(Highstock highcharts, IEnumerable list)
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