using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodeGenerator.Parser;
using SourceCodeGenerator.Services;

namespace SourceCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            FileService fileService = new FileService();
            FilterService filterService = new FilterService();
            JsonUpdateService updateService = new JsonUpdateService();
            JsonParser jsonParser = new JsonParser("highcharts", fileService, filterService, updateService);
            HighchartsGenerator hcg = new HighchartsGenerator(jsonParser, fileService);
            hcg.GenerateCode();

            Console.WriteLine("THE END");
            Console.ReadLine();

        }
    }
}
