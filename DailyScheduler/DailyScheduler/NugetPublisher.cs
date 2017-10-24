using System;
using System.Diagnostics;
using System.IO;
using System.Linq;


namespace DailyScheduler
{
    public class NugetPublisher
    {
        public void UpdateFiles(string wrapperFilePath, string nuspecFilePath, string batchFilePath, string wrapper)
        {
            string version = GetWrapperVersion(wrapperFilePath);

            UpdateNuspecFile(nuspecFilePath, version);
            UpdateBatchFile(batchFilePath, version, wrapper);
        }

        string GetWrapperVersion(string filePath)
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filePath);
            return versionInfo.FileVersion;
        }

        void UpdateNuspecFile(string filePath, string version)
        {
            Console.WriteLine("Updating: " + filePath);
            string[] lines = File.ReadAllLines(filePath);

            int index = GetVersionLineIndex(lines, filePath);

            lines[index] = $"<version>{version}</version>";

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Updated: "+filePath);
        }

        void UpdateBatchFile(string filePath, string version, string wrapper)
        {
            Console.WriteLine("Updating: " + filePath);
            string[] lines = File.ReadAllLines(filePath);

            string[] options = lines[1].Split(' ');

            //Console.WriteLine("line0: " + lines[0]);
            ////Console.WriteLine("line1: " + lines[1]);

            options[2] = $"Highsoft.{wrapper}.{version}.nupkg";
            lines[1] = options[0] + " " + options[1] + " " + options[2] + " " + options[3] + " " + options[4] + " " + options[5] + " " + options[6] + " " + options[7];
            
            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Updated: "+filePath);
        }


        int GetVersionLineIndex(string[] lines, string filePath)
        {
            for (int index = 0; index < lines.Length; index++)
                if (lines[index].Contains("<version>"))
                    return index;

            throw new Exception($"There is no <version> inside {filePath}");
        }
    }
}
