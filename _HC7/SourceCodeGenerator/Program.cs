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
            DateTime startTime = DateTime.Now;

            FileService fileService = new FileService();
            FilterService filterService = new FilterService();
            JsonUpdateService updateService = new JsonUpdateService();
            TypeService typeService = new TypeService();
            MultiplicationService multiplicationService = new MultiplicationService();

            try
            {
                DateTime hcStartTime = DateTime.Now;
                JsonParser jsonParserHc = new JsonParser("highcharts", fileService, filterService, updateService, typeService);
                HighchartsGenerator hcg = new HighchartsGenerator(jsonParserHc, fileService, multiplicationService);
                hcg.GenerateCode(true);
                Console.WriteLine($"Highcharts.NET has been generated. {DateTime.Now - hcStartTime}");

                DateTime hsStartTime = DateTime.Now;
                JsonParser jsonParserHs = new JsonParser("highstock", fileService, filterService, updateService, typeService);
                HighstockGenerator hsg = new HighstockGenerator(jsonParserHs, fileService, multiplicationService);
                hsg.GenerateCode();
                Console.WriteLine($"Highstock.NET has been generated. {DateTime.Now - hsStartTime}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString() + "\n" + ex.InnerException ?? "");
            }

            Console.WriteLine($"Execution Time: {DateTime.Now - startTime}");
            Console.WriteLine("THE END");
            Console.ReadLine();

        }
    }
}
