using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;
using System.Collections.Specialized;
using System.Web;
using System.IO;

namespace {HighTemplate.Namespace}
{
	public partial class {HighTemplate.ClassName}  {HighTemplate.ExtendsClass}
	{
		Hashtable h = new Hashtable();

		public {HighTemplate.ClassName}()
		{
		}	
		{HighTemplate.Properties} 

		internal override Hashtable ToHashtable(Highcharts highcharts)
		{
			{HighTemplate.HashtableInit}

			return h;
		}
	}
}