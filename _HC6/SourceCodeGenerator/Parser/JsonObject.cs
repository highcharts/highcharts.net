using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SourceCodeGenerator.Parser
{
    public class JsonObject
    {
        public Doclet Doclet { get; set; }
        public JsonObjectAttribute Children { get; set; }
        public Meta Meta { get; set; }
    }
}
