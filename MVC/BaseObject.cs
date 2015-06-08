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
	public partial class BaseObject
	{
        public BaseObject();

        abstract internal Hashtable ToHashtable();
        abstract internal string ToJSON();
        abstract internal bool IsDirty();
	}
}