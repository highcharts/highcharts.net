using SourceCodeGenerator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SourceCodeGenerator.Services
{
    public class ComparisonService : IComparisonService
    {
        Dictionary<string, string> _chanages = new Dictionary<string, string>();
        Dictionary<string, string> _previousValues = new Dictionary<string, string>();
        Dictionary<string, string> _valuesFromUpdateFile = new Dictionary<string, string>();
        Dictionary<string, string> _changesNotInUpdateFile = new Dictionary<string, string>();

        bool _makeManualUpdate = false;
        bool _makeAutoUpdate = true;

        public void SetValuesFromFile(string filePath)
        {
            _valuesFromUpdateFile.Clear();
            foreach (var item in File.ReadAllLines(filePath))
            {
                var parts = item.Split(':');
                _valuesFromUpdateFile.Add(parts[0], parts[1]);
            }
        }

        public void SaveChanges(string filePath, string filePathPreviousValues, string filePathToNewChanges, IFileService fileService)
        {
            StringBuilder content = new StringBuilder();
            StringBuilder contentPreviousValues = new StringBuilder();
            StringBuilder contentNewChanges = new StringBuilder();

            foreach (var item in _chanages)
                content.AppendLine($"{item.Key}:{item.Value}");

            foreach (var item in _previousValues)
                contentPreviousValues.AppendLine($"{item.Key}:{item.Value}");

            foreach (var item in _changesNotInUpdateFile)
                contentNewChanges.AppendLine($"{item.Key}:{item.Value}");

            fileService.SaveFile(filePath, content.ToString());
            content.Clear();
            _chanages.Clear();

            fileService.SaveFile(filePathPreviousValues, contentPreviousValues.ToString());
            contentPreviousValues.Clear();
            _previousValues.Clear();

            fileService.SaveFile(filePathToNewChanges, contentNewChanges.ToString());
            contentNewChanges.Clear();
            _changesNotInUpdateFile.Clear();
        }

        public void Compare(IList<ApiItem> items = null, IList<ApiItem> previousItems = null, List<string> pathToItem = null)
        {
            foreach (var item in items)
            {
                ApiItem prevItem = null;
                if (pathToItem == null || !pathToItem.Any())
                    prevItem = previousItems.FirstOrDefault(p => p.FullName.Equals(item.FullName));
                else
                {
                    prevItem = previousItems.FirstOrDefault(p => p.FullName.Equals(pathToItem[0]));

                    for (int i = 1; i < pathToItem.Count; i++)
                    {
                        prevItem = prevItem.Children.FirstOrDefault(p => p.FullName.Equals(pathToItem[i]));
                    }

                    prevItem = prevItem.Children.FirstOrDefault(p => p.FullName.Equals(item.FullName));
                }

                if (prevItem == null)
                {
                    Console.WriteLine("          " + item.FullName + ": Extra Item");
                    continue;
                }

                ChangedItem changedItem = ChangedItem.None;
                StringBuilder sb = new StringBuilder();

                if (string.IsNullOrWhiteSpace(item.ReturnType))
                {
                    sb.AppendLine("!MISSING: " + item.FullName + " missing ReturnType!");
                    changedItem = ChangedItem.ReturnType;
                }

                if (!item.ReturnType.Equals(prevItem.ReturnType))
                {
                    sb.AppendLine("!CHANGE:  " + item.FullName + ": ReturnType - " + item.ReturnType + "| WAS: " + prevItem.ReturnType);
                    changedItem = ChangedItem.ReturnType;
                }
                //else
                //    sb.AppendLine(item.FullName + ": ReturnType - OK");

                if (prevItem.Values.Except(item.Values).Any() || item.Values.Except(prevItem.Values).Any())
                {
                    sb.AppendLine("!CHANGE:  " + item.FullName + ": Values - " + string.Join(",", item.Values) + "| WAS: " + string.Join(",", prevItem.Values));
                    changedItem = ChangedItem.Values;
                }

                if (prevItem.Extends.Except(item.Extends).Any() || item.Extends.Except(prevItem.Extends).Any())
                {
                    sb.AppendLine("!CHANGE:  " + item.FullName + ": Extends - " + string.Join(",", item.Extends) + "| WAS: " + string.Join(",", prevItem.Extends));
                    changedItem = ChangedItem.Extends;
                }

                if (prevItem.Exclude.Except(item.Exclude).Any() || item.Exclude.Except(prevItem.Exclude).Any())
                {
                    sb.AppendLine("!CHANGE:  " + item.FullName + ": Exclude - " + string.Join(",", item.Exclude) + "| WAS: " + string.Join(",", prevItem.Exclude));
                    changedItem = ChangedItem.Exclude;
                }

                if (prevItem.Types.Except(item.Types).Any() || item.Types.Except(prevItem.Types).Any())
                {
                    sb.AppendLine("!CHANGE:  " + item.FullName + ": Types - " + string.Join(",", item.Types) + "| WAS: " + string.Join(",", prevItem.Types));
                    changedItem = ChangedItem.Types;
                }

                if (sb.Length > 0)
                    Console.Write(sb.ToString());


                if (changedItem == ChangedItem.ReturnType)
                {
                    if (_makeAutoUpdate)
                        if (_valuesFromUpdateFile.ContainsKey(item.FullName + "." + changedItem))
                            item.ReturnType = string.Copy(_valuesFromUpdateFile[item.FullName + "." + changedItem]);
                        else
                            _changesNotInUpdateFile.Add(item.FullName + "." + changedItem, prevItem.ReturnType);


                    if (_makeManualUpdate)
                        UpdateReturnType(item, prevItem);

                    _chanages.Add(item.FullName + "." + changedItem, item.ReturnType);
                    _previousValues.Add(item.FullName + "." + changedItem, prevItem.ReturnType);
                }

                if (changedItem == ChangedItem.Values)
                {
                    if (_makeAutoUpdate)
                    {
                        item.Values.Clear();

                        if (_valuesFromUpdateFile.ContainsKey(item.FullName + "." + changedItem))
                            foreach (var value in string.Copy(_valuesFromUpdateFile[item.FullName + "." + changedItem]).Split(','))
                                item.Values.Add(value);
                        else
                            _changesNotInUpdateFile.Add(item.FullName + "." + changedItem, string.Join(",",prevItem.Values));
                    }

                    if (_makeManualUpdate)
                        UpdateValues(item, prevItem);

                    _chanages.Add(item.FullName + "." + changedItem, string.Join(",", item.Values));
                    _previousValues.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Values));
                }

                if (changedItem == ChangedItem.Types)
                {
                    if (_makeAutoUpdate)
                    {
                        item.Types.Clear();

                        if (_valuesFromUpdateFile.ContainsKey(item.FullName + "." + changedItem))
                            foreach (var value in string.Copy(_valuesFromUpdateFile[item.FullName + "." + changedItem]).Split(','))
                                item.Types.Add(value);
                        else
                            _changesNotInUpdateFile.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Types));
                    }

                    if (_makeManualUpdate)
                        UpdateTypes(item, prevItem);

                    _chanages.Add(item.FullName + "." + changedItem, string.Join(",", item.Types));
                    _previousValues.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Types));
                }


                //remove after fix
                if (item.FullName.Equals("plotOptions.boxplot"))
                    changedItem = ChangedItem.Exclude;

                if (changedItem == ChangedItem.Exclude)
                {
                    if (_makeAutoUpdate)
                    {
                        item.Exclude.Clear();

                        if (_valuesFromUpdateFile.ContainsKey(item.FullName + "." + changedItem))
                            foreach (var value in string.Copy(_valuesFromUpdateFile[item.FullName + "." + changedItem]).Split(','))
                                item.Exclude.Add(value);
                        else
                            _changesNotInUpdateFile.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Exclude));
                    }

                    if (_makeManualUpdate)
                        UpdateExclude(item, prevItem);

                    _chanages.Add(item.FullName + "." + changedItem, string.Join(",", item.Exclude));
                    _previousValues.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Exclude));
                }

                if (changedItem == ChangedItem.Extends)
                {
                    if (_makeAutoUpdate)
                    {
                        item.Extends.Clear();

                        if (_valuesFromUpdateFile.ContainsKey(item.FullName + "." + changedItem))
                            foreach (var value in string.Copy(_valuesFromUpdateFile[item.FullName + "." + changedItem]).Split(','))
                                item.Extends.Add(value);
                        else
                            _changesNotInUpdateFile.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Extends));
                    }

                    if (_makeManualUpdate)
                        UpdateExtends(item, prevItem);

                    _chanages.Add(item.FullName + "." + changedItem, string.Join(",", item.Extends));
                    _previousValues.Add(item.FullName + "." + changedItem, string.Join(",", prevItem.Extends));
                }


                if (pathToItem == null)
                    pathToItem = new List<string>();

                if (item.Children.Any())
                {
                    pathToItem.Add(item.FullName);
                    Compare(item.Children, previousItems, pathToItem);
                    pathToItem.Remove(item.FullName);
                }

            }
        }

        private void UpdateValues(ApiItem item, ApiItem prevItem)
        {
            Console.WriteLine("Do you want to copy values from previous version (Y/N)?");
            var answer = Console.ReadKey();
            if (char.ToLower(answer.KeyChar).Equals('y'))
                item.Values = prevItem.Values;
            else
            {
                Console.WriteLine("Do you want to change value?");
                var answer2 = Console.ReadKey();
                if (char.ToLower(answer2.KeyChar).Equals('y'))
                {
                    Console.WriteLine("Type new value : ");
                    var value = Console.ReadLine();
                    item.Values.Clear();
                    item.Values.Add(value);
                }
            }

            Console.WriteLine();
            Console.WriteLine(item.FullName + ".Values - " + string.Join(",", item.Values));
        }

        private void UpdateTypes(ApiItem item, ApiItem prevItem)
        {
            Console.WriteLine("Do you want to copy values from previous version (Y/N)?");
            var answer = Console.ReadKey();
            if (char.ToLower(answer.KeyChar).Equals('y'))
                item.Types = prevItem.Types;
            else
            {
                Console.WriteLine("Do you want to change value?");
                var answer2 = Console.ReadKey();
                if (char.ToLower(answer2.KeyChar).Equals('y'))
                {
                    Console.WriteLine("Type new value: ");
                    var value = Console.ReadLine();
                    item.Types.Clear();
                    item.Types.Add(value);
                }
            }

            Console.WriteLine();
            Console.WriteLine(item.FullName + ".Types - " + string.Join(",", item.Types));
        }

        private void UpdateExtends(ApiItem item, ApiItem prevItem)
        {
            Console.WriteLine("Do you want to copy values from previous version (Y/N)?");
            var answer = Console.ReadKey();
            if (char.ToLower(answer.KeyChar).Equals('y'))
                item.Extends = prevItem.Extends;
            else
            {
                Console.WriteLine("Do you want to change value?");
                var answer2 = Console.ReadKey();
                if (char.ToLower(answer2.KeyChar).Equals('y'))
                {
                    Console.WriteLine("Type new value: ");
                    var value = Console.ReadLine();
                    item.Extends.Clear();
                    item.Extends.Add(value);
                }
            }

            Console.WriteLine();
            Console.WriteLine(item.FullName + ".Extends - " + string.Join(",", item.Extends));
        }

        private void UpdateExclude(ApiItem item, ApiItem prevItem)
        {
            Console.WriteLine("Do you want to copy values from previous version (Y/N)?");
            var answer = Console.ReadKey();
            if (char.ToLower(answer.KeyChar).Equals('y'))
                item.Exclude = prevItem.Exclude;
            else
            {
                Console.WriteLine("Do you want to change value?");
                var answer2 = Console.ReadKey();
                if (char.ToLower(answer2.KeyChar).Equals('y'))
                {
                    Console.WriteLine("Type new value: ");
                    var value = Console.ReadLine();
                    item.Exclude.Clear();
                    item.Exclude.Add(value);
                }
            }

            Console.WriteLine();
            Console.WriteLine(item.FullName + ".Exclude - " + string.Join(",", item.Exclude));
        }

        private void UpdateReturnType(ApiItem item, ApiItem prevItem)
        {
            Console.WriteLine("Do you want to copy values from previous version (Y/N)?");
            var answer = Console.ReadKey();
            if (char.ToLower(answer.KeyChar).Equals('y'))
            {
                item.ReturnType = string.Copy(prevItem.ReturnType);
                Console.WriteLine();
                Console.WriteLine(item.FullName + ".ReturnType=" + item.ReturnType);
            }

            if (char.ToLower(answer.KeyChar).Equals('n') || string.IsNullOrWhiteSpace(item.ReturnType))
            {
                Console.WriteLine();
                Console.WriteLine("Choose correct type: ");
                Console.WriteLine("1. String");
                Console.WriteLine("2. Object");
                Console.WriteLine("3. Boolean");
                Console.WriteLine("4. Number");
                Console.WriteLine("5. function");
                Console.WriteLine("Choose correct type: ");

                var correctAnswers = new List<char> { '1', '2', '3', '4', '5' };
                ConsoleKeyInfo typeNumber;

                do
                {
                    typeNumber = Console.ReadKey();
                } while (!correctAnswers.Contains(typeNumber.KeyChar));

                switch (typeNumber.KeyChar)
                {
                    case '1':
                        item.ReturnType = TypeService.StringType;
                        break;
                    case '2':
                        item.ReturnType = TypeService.ObjectType;
                        break;
                    case '3':
                        item.ReturnType = TypeService.BoolType;
                        break;
                    case '4':
                        item.ReturnType = TypeService.NumberType;
                        break;
                    case '5':
                        item.ReturnType = TypeService.FunctionType;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine(item.FullName + ".ReturnType=" + item.ReturnType);
            }
        }
    }

    public interface IComparisonService
    {
        void SetValuesFromFile(string filePath);
        void Compare(IList<ApiItem> item = null, IList<ApiItem> prevItem = null, List<string> pathToItem = null);
        void SaveChanges(string filePath, string filePathPreviousValues, string filePathToNewChanges, IFileService fileService);
    }
}
