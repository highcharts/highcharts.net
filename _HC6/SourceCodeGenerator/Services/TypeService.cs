using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    public class TypeService : ITypeService
    {
        private const string BoolType = "Boolean";
        private const string NumberType = "Number";
        private const string StringType = "String";
        private const string ObjectType = "Object";
        private const string FunctionType = "function";
        private static IEnumerable<string> UniqueTypesNames = new List<string> { "Highcharts.CSSObject", "Highcharts.ColorString", "Highcharts.HTMLDOMElement" };
        private static ISet<string> UniqueTypes = new HashSet<string>(UniqueTypesNames);

        public void SetReturnType(ApiItem item)
        {
            item.ReturnType = SetUpperFirstChar(item.ReturnType);

            if (UniqueTypes.Contains(item.ReturnType))
                item.ReturnType = StringType;

            if (item.Defaults != null && string.IsNullOrWhiteSpace(item.ReturnType))
                item.ReturnType = GetType(item);
        }
        private string GetType(ApiItem item)
        {
            if (IsBool(item))
                return BoolType;

            if (IsNumber(item))
                return NumberType;

            if (IsString(item))
                return StringType;

            return string.Empty;
        }

        private bool IsBool(ApiItem item)
        {
            bool result;
            return bool.TryParse(item.Defaults, out result);
        }

        private bool IsNumber(ApiItem item)
        {
            double result;
            return double.TryParse(item.Defaults, out result);
        }

        private bool IsString(ApiItem item)
        {
            return item.Defaults != null;
        }

        private string SetUpperFirstChar(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return text;

            if (text == FunctionType)
                return text;

            if (char.IsUpper(text[0]))
                return text;

            return char.ToUpperInvariant(text[0]) + text.Substring(1);
        }
    }

    public interface ITypeService
    {
        void SetReturnType(ApiItem item);
    }
}
