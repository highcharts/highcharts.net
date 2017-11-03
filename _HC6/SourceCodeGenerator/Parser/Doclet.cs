using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Parser
{
    public class Doclet
    {
        public string Description { get; set; }
        public string Extends { get; set; }
        public string Since { get; set; }
        public string[] Products { get; set; }
        public bool Deprecated { get; set; }
        public JsonType Type { get; set; }
        public string DefaultValue { get; set; }
    }
}
