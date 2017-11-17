using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Parser
{
    public interface IJsonParser
    {
        List<ApiItem> Get();
    }
}
