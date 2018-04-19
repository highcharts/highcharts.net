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
            var updatedVersion = GetUpdatedVersion(GetWrapperVersion(wrapperFilePath), GetLastVersionInNuspec(nuspecFilePath));

            UpdateNuspecFile(nuspecFilePath, updatedVersion);
            UpdateBatchFile(batchFilePath, updatedVersion, wrapper);
        }

        string GetWrapperVersion(string filePath)
        {
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(filePath);
            return versionInfo.FileVersion;
        }

        string GetUpdatedVersion(string version, string lastNuspecVersion)
        {
            var updatedVersion = string.Empty;
            var tabVersion = version.Split('.');
            var tabLastNuspecVersion = lastNuspecVersion.Split('.');

            for (int i = 0; i < 3; i++)
                if (tabVersion[i] != tabLastNuspecVersion[i])
                    return version + ".1";

            var revision = Convert.ToInt64(tabLastNuspecVersion[3]);

            return string.Join(".", tabLastNuspecVersion, 0, 3) + "." + revision;
        }

        string GetLastVersionInNuspec(string filePath)
        {
            Console.WriteLine("Updating: " + filePath);
            string[] lines = File.ReadAllLines(filePath);

            int index = GetVersionLineIndex(lines, filePath);
            return lines[index].Replace("<version>", "").Replace("</version>", "");
        }

        void UpdateNuspecFile(string filePath, string version)
        {
            Console.WriteLine("Updating: " + filePath);
            string[] lines = File.ReadAllLines(filePath);

            int index = GetVersionLineIndex(lines, filePath);

            lines[index] = $"<version>{version}</version>";

            File.WriteAllLines(filePath, lines);
            Console.WriteLine("Updated: " + filePath);
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
            Console.WriteLine("Updated: " + filePath);
        }

        int GetVersionLineIndex(string[] lines, string filePath)
        {
            for (int index = 0; index < lines.Length; index++)
                if (lines[index].Contains("<version>"))
                    return index;

            throw new Exception($"There is no <version> inside {filePath}");
        }

        void UpdateVersion(string version)
        {

        }
    }
}
