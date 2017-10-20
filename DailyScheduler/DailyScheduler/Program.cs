using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace DailyScheduler
{
    

    class Program
    {
        private const string FILE_PATH = @"c:\Users\PC\Documents\highcharts.net\Build\new\demo_builder.bat";
        private const string SERVER_FILE_PATH = @"c:\highcharts.net\Build\new\demo_builder.bat";
        private const string SERVER_HC_WRAPPER_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highcharts\bin\Release\Highcharts.Web.Mvc.dll";
        private const string SERVER_HS_WRAPPER_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highstock\bin\Release\Highstock.Web.Mvc.dll";
        private const string SERVER_HC_NUSPEC_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highcharts\MVC_Highcharts.nuspec";
        private const string SERVER_HS_NUSPEC_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highstock\MVC_Highstock.nuspec";
        private const string SERVER_HC_NUGET_PACK_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highcharts\nuget_pack_highcharts.bat";
        private const string SERVER_HS_NUGET_PACK_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highstock\nuget_pack_highstock.bat";
        private const string SERVER_HC_NUGET_PUSH_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highcharts\nuget_push_highcharts.bat";
        private const string SERVER_HS_NUGET_PUSH_FILE_PATH = @"C:\highcharts.net\_HC6\MVC_Highstock\nuget_push_highstock.bat";

        static void Main()
        {
            //HandleWrapperBuilder(null, null);
            HandleNuget(null, null);
            StartTimer();
            
            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }

        private static void StartTimer()
        {
            System.Timers.Timer timer = new System.Timers.Timer(86400000);
            timer.Elapsed += HandleWrapperBuilder;
            timer.Elapsed += HandleNuget;
            timer.Start();
        }


        private static void HandleWrapperBuilder(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Wrapper: "+DateTime.Now);
            try
            {
                Process p1 = System.Diagnostics.Process.Start(SERVER_FILE_PATH);
                p1.WaitForExit();
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No file: "+ SERVER_FILE_PATH);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }

        static void HandleNuget(object sender, ElapsedEventArgs args)
        {
            //Thread.Sleep(3600000);

            Console.WriteLine("NuGet: "+DateTime.Now);
            try
            {
                NugetPublisher publisher = new NugetPublisher();

                publisher.UpdateFiles(SERVER_HC_WRAPPER_FILE_PATH, SERVER_HC_NUSPEC_FILE_PATH, SERVER_HC_NUGET_PUSH_FILE_PATH, "Highcharts");
                publisher.UpdateFiles(SERVER_HS_WRAPPER_FILE_PATH, SERVER_HS_NUSPEC_FILE_PATH, SERVER_HS_NUGET_PUSH_FILE_PATH, "Highstock");

                Process p1 = Process.Start(SERVER_HC_NUGET_PACK_FILE_PATH);
                p1.WaitForExit();
                Process p2 = Process.Start(SERVER_HC_NUGET_PUSH_FILE_PATH);
                p2.WaitForExit();

                Process p3 = Process.Start(SERVER_HS_NUGET_PACK_FILE_PATH);
                p3.WaitForExit();
                Process p4 = Process.Start(SERVER_HS_NUGET_PUSH_FILE_PATH);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("No file: " + SERVER_FILE_PATH);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.ReadLine();
            }
        }

        private static void HandleTimer2(object sender, ElapsedEventArgs e)
        {
            //int ExitCode;
            Console.WriteLine("2");
            Console.WriteLine(DateTime.Now);


            ProcessStartInfo ProcessInfo;
            Process process;
            string command = @"c:\demo_builder.bat";

            ProcessInfo = new ProcessStartInfo("cmd.exe", "/c " + command);
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = false;
            ProcessInfo.WorkingDirectory = "c:\\";
            // *** Redirect the output ***
            ProcessInfo.RedirectStandardError = true;
            ProcessInfo.RedirectStandardOutput = true;

            process = Process.Start(ProcessInfo);
            process.WaitForExit();
        }
    }
}
