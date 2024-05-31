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
	public partial class {HighTemplate.Classname}
	{
		public {HighTemplate.ClassName}()
		{
			{HighTemplate.ConstrutorInitializers}
		}	
		{HighTemplate.Properties} 

		internal Hashtable ToHashtable()
		{
			var highcharts = this;
			Hashtable h = new Hashtable();

			{HighTemplate.HashtableInit}

			return h;
		}
	}
}