using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UtilDateReplacer
{
    class Program
    {
        private static string text = @"using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace {3}
{{
    internal static class CompiledOn
    {{
        internal static DateTime CompilationDate = new DateTime({0}, {1}, {2});
    }}
}}";

        static void Main(string[] args)
        {
            if (args.Length > 2)
            {
                text = String.Format(text, "2099", "1", "1", args[1]);
            }
            else
            {
                text = String.Format(text,
                                            DateTime.Now.Year.ToString(),
                                            DateTime.Now.Month.ToString(),
                                            DateTime.Now.Day.ToString(),
                                            args[1]);
            }

            // Write the string to a file.
            System.IO.StreamWriter file = new System.IO.StreamWriter(args[0]);
            file.WriteLine(text);

            file.Close();
        }
    }
}
