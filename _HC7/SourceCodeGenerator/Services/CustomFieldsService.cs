using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    public static class CustomFieldsService
    {
        public static string GetProperty()
        {
            return "\n\n\t\tpublic Hashtable CustomFields { get; set; }";
        }

        public static string GetInit()
        {
            return "\n\t\t\tCustomFields = new Hashtable();";
        }

        public static string GetCopyLogic()
        {
            return "if (CustomFields != null && CustomFields.Count > 0)\n\t\t\t\tforeach (var key in CustomFields.Keys)\n\t\t\t\t{\n\t\t\t\t\tif (h.ContainsKey(key))\n\t\t\t\t\t\tcontinue;\n\n\t\t\t\t\th.Add(key, CustomFields[key]);\n\t\t\t\t}";
        }
    }
}
