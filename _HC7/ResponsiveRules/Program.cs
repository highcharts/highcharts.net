using System;
using System.Collections.Generic;
using Highsoft.Web.Mvc.Charts;
using Highsoft.Web.Mvc.Charts.Rendering;

namespace ResponsiveRules
{
    class Program
    {
        static void Main(string[] args)
        {
            //Responsive responsiveRules = new Responsive() { Rules = new List<Highsoft.Web.Mvc.Charts.ResponsiveRules> {  } };
            var responsiveRules = new Highsoft.Web.Mvc.Charts.ResponsiveRules
            {
                ChartOptions = (new Legend() { X = -15, Y = 260, Floating = true })
            };

            string json = responsiveRules.ToString();

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
                Console.WriteLine(json);
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 

            Responsive responsive = new Responsive()
            {
                Rules = new List<Highsoft.Web.Mvc.Charts.ResponsiveRules>()
                {
                    new Highsoft.Web.Mvc.Charts.ResponsiveRules
                    {
                        ChartOptions = new { chart = new { className = "small-chart" } },
                        Condition = new ResponsiveRulesCondition() { MaxWidth = 500 }
                    }
                }
            };
        }
    }
}
