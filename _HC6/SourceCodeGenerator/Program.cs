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
            TypeService typeService = new TypeService();

            JsonParser jsonParserHc = new JsonParser("highcharts", fileService, filterService, updateService, typeService);
            HighchartsGenerator hcg = new HighchartsGenerator(jsonParserHc, fileService);
            hcg.GenerateCode();

            //JsonParser jsonParserHs = new JsonParser("highstock", fileService, filterService, updateService, typeService);
            //HighstockGenerator hsg = new HighstockGenerator(jsonParserHs, fileService);
            //hsg.GenerateCode();

            Console.WriteLine("THE END");
            Console.ReadLine();

        }
    }
}
