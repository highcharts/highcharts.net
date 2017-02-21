using System;
using System.Diagnostics;
using System.IO;


namespace DailyScheduler
{
    public class NugetPublisher
    {
        public void UpdateNuspecFile(string wrapperFilePath)
        {
            string version = GetWrapperVersion(wrapperFilePath);

            UpdateNuspecFile(wrapperFilePath, version);
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


        int GetVersionLineIndex(string[] lines, string filePath)
        {
            for (int index = 0; index < lines.Length; index++)
                if (lines[index].Contains("<version>"))
                    return index;

            throw new Exception($"There is no <version> inside {filePath}");
        }
    }
}
