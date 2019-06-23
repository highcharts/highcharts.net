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

            FileService fileService = new FileService("highcharts.json");
            FileService previousFileService = new FileService("highcharts_old.json");
            FilterService filterService = new FilterService();
            JsonUpdateService updateService = new JsonUpdateService();
            TypeService typeService = new TypeService();
            MultiplicationService multiplicationService = new MultiplicationService();
            ComparisonService comparisonService = new ComparisonService();

            try
            {
                DateTime hcStartTime = DateTime.Now;
                JsonParser jsonParserHc = new JsonParser("highcharts", fileService, filterService, updateService, typeService);
                JsonParser jsonPaserHC2 = new JsonParser("highcharts", previousFileService, filterService, updateService, typeService);
                               
                //HighchartsGenerator hcg = new HighchartsGenerator(jsonParserHc, jsonPaserHC2, fileService, multiplicationService, comparisonService);
                //hcg.GenerateCode(true);
                //Console.WriteLine($"Highcharts.NET has been generated. {DateTime.Now - hcStartTime}");
                //Console.WriteLine("-------------------------------------------------------------------");



                DateTime hsStartTime = DateTime.Now;
                JsonParser jsonParserHS = new JsonParser("highstock", fileService, filterService, updateService, typeService);
                JsonParser jsonParserHS2 = new JsonParser("highstock", previousFileService, filterService, updateService, typeService);
                HighstockGenerator hsg = new HighstockGenerator(jsonParserHS, jsonParserHS2, fileService, multiplicationService, comparisonService);
                hsg.GenerateCode(true);
                Console.WriteLine($"Highstock.NET has been generated. {DateTime.Now - hsStartTime}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString() + "\n" + ex.InnerException ?? "");
            }

            Console.WriteLine($"Execution Time: {DateTime.Now - startTime}");
            Console.WriteLine("THE END");
            Console.ReadLine();

        }
    }
}
