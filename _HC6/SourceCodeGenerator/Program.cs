using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodeGenerator.Parser;

namespace SourceCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonParser jsonParser = new JsonParser("highcharts", @"C:\Users\PC\Documents\highcharts.net\_HC6\SourceCodeGenerator\JsonFiles\highcharts.json");
            HighchartsGenerator hcg = new HighchartsGenerator(jsonParser);
            hcg.GenerateCode();

            Console.ReadLine();

        }
    }
}
