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
            string[] lines = File.ReadAllLines(filePath);

            int index = GetVersionLineIndex(lines, filePath);

            lines[index] = $"<version>{version}</version>";

            File.WriteAllLines(filePath, lines);
        }

        void UpdateBatchFile(string filePath, string version, string wrapper)
        {
            string[] lines = File.ReadAllLines(filePath);

            string[] options = lines[1].Split(' ');

            options[2] = $"Highsoft.{wrapper}.{version}.nupkg";
            lines[1] = options[0] + " " + options[1] + " " + options[2] + " " + options[3] + " " + options[4] + " " + options[5] + " " + options[6] + " " + options[7];
            
            File.WriteAllLines(filePath, lines);
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
