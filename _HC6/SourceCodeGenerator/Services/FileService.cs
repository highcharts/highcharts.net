using System.IO;

namespace SourceCodeGenerator.Services
{
    public class FileService : IFileService
    {
        private string AssemblyFolderPath { get; set; }

        private string TemplatesFolderPath
        {
            get
            {
                return AssemblyFolderPath + "\\CodeTemplates";
            }
        }
        private string RootClassTemplatePath
        {
            get
            {
                return TemplatesFolderPath + "\\RootClass.tpl";
            }
        }
        private string ClassTemplatePath
        {
            get
            {
                return TemplatesFolderPath + "\\Class.tpl";
            }
        }
        private string EnumTemplatePath
        {
            get
            {
                return TemplatesFolderPath + "\\Enum.tpl";
            }
        }

        private string PropertyTemplatePath
        {
            get
            {
                return TemplatesFolderPath + "\\Property.tpl";
            }
        }

        private string JsonFolderPath
        {
            get
            {
                return AssemblyFolderPath + "\\JsonFiles";
            }
        }

        private string JsonFilePath
        {
            get
            {
                return JsonFolderPath + "\\highcharts.json";
            }
        }

        private string SourceCodeFolder
        {
            get
            {
                return AssemblyFolderPath + "\\CodeGeneration";
            }
        }

        public FileService()
        {
            AssemblyFolderPath = Directory.GetCurrentDirectory();
        }

        public string GetRootClassTemplate()
        {
            return GetFileContent(RootClassTemplatePath);
        }
        public string GetClassTemplate()
        {
            return GetFileContent(ClassTemplatePath);
        }
        public string GetPropertyTemplate()
        {
            return GetFileContent(PropertyTemplatePath);
        }
        public string GetEnumTemplate()
        {
            return GetFileContent(EnumTemplatePath);
        }
        public string GetJsonContent()
        {
            return GetFileContent(JsonFilePath);
        }
        public void SaveClass(string product, string className, string content)
        {
            string sourceClassFilePath = SourceCodeFolder + "\\" + product + "\\" + className + ".cs";
            SaveFile(sourceClassFilePath, content);
        }
        public void SaveEnum(string product, string enumName, string content)
        {
            string sourceEnumFolderPath = SourceCodeFolder + "\\" + product + "\\Enums\\" + enumName + ".cs";
            SaveFile(sourceEnumFolderPath, content);
        }
        public void PrepareFolder(string product)
        {
            string sourceClassFolderPath = SourceCodeFolder + "\\" + product;
            string sourceEnumFolderPath = SourceCodeFolder + "\\" + product + "\\Enums";

            if (Directory.Exists(sourceClassFolderPath))
                DeleteAllFilesInFolder(sourceClassFolderPath);
            else
                Directory.CreateDirectory(sourceClassFolderPath);

            if (Directory.Exists(sourceEnumFolderPath))
                DeleteAllFilesInFolder(sourceEnumFolderPath);
            else
                Directory.CreateDirectory(sourceEnumFolderPath);
        }
        private string GetFileContent(string filePath)
        {
            return File.ReadAllText(filePath);
        }
        private void SaveFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
        }
        private void DeleteAllFilesInFolder(string folderPath)
        {
            string[] files = Directory.GetFiles(folderPath);
            foreach (var file in files)
                File.Delete(file);
        }
    }

    public interface IFileService
    {
        string GetRootClassTemplate();
        string GetClassTemplate();
        string GetPropertyTemplate();
        string GetEnumTemplate();
        string GetJsonContent();
        void SaveClass(string product, string className, string content);
        void SaveEnum(string product, string enumName, string content);
        void PrepareFolder(string product);

    }
}
