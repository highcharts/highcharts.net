using System.IO;

namespace SourceCodeGenerator.Services
{
    public class FileService : IFileService
    {
        private string _assemblyFolderPath;
        private string _jsonFileName;

        

        private string TemplatesFolderPath
        {
            get
            {
                return _assemblyFolderPath + "\\CodeTemplates";
            }
        }
        private string RootClassTemplatePath
        {
            get
            {
                return TemplatesFolderPath + "\\RootClass.tpl";
            }
        }
        private string RootClassTemplatePathNETStandard
        {
            get
            {
                return TemplatesFolderPath + "\\RootClass_NETStandard.tpl";
            }
        }
        private string ClassTemplatePath
        {
            get
            {
                return TemplatesFolderPath + "\\Class.tpl";
            }
        }
        private string ClassTemplatePathNETStandard
        {
            get
            {
                return TemplatesFolderPath + "\\Class_NETStandard_new1.tpl";
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
                return _assemblyFolderPath + "\\JsonFiles";
            }
        }

        private string JsonFilePath
        {
            get
            {
                return JsonFolderPath + "\\" + _jsonFileName;// highcharts.json";
            }
        }

        private string SourceCodeFolder
        {
            get
            {
                return _assemblyFolderPath + "\\CodeGeneration";
            }
        }

        //public FileService()
        //{
        //    _assemblyFolderPath = Directory.GetCurrentDirectory();
        //}

        public FileService(string jsonFileName)
        {
            _assemblyFolderPath = Directory.GetCurrentDirectory();
            _jsonFileName = jsonFileName;
        }

        public string GetRootClassTemplate(bool isNETStandard = false)
        {
            if (isNETStandard)
                return GetFileContent(RootClassTemplatePathNETStandard);
            else
                return GetFileContent(RootClassTemplatePath);
        }
        public string GetClassTemplate(bool isNETStandard = false)
        {
            if (isNETStandard)
                return GetFileContent(ClassTemplatePathNETStandard);
            else
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
        public void SaveFile(string filePath, string content)
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
        string GetRootClassTemplate(bool isNETStandard = false);
        string GetClassTemplate(bool isNETStandard = false);
        string GetPropertyTemplate();
        string GetEnumTemplate();
        string GetJsonContent();
        void SaveClass(string product, string className, string content);
        void SaveEnum(string product, string enumName, string content);
        void SaveFile(string filePath, string content);
        void PrepareFolder(string product);

    }
}
