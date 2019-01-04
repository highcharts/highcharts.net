using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    public class TypeService : ITypeService
    {
        public static readonly string CSSObject = "Highcharts.CSSObject";
        public static readonly string StringType = "String";
        public static readonly string ObjectType = "Object";
        public static readonly string BoolType = "Boolean";
        public static readonly string NumberType = "Number";
        public static readonly string FunctionType = "function";

        private static ISet<string> FunctionTypes = new HashSet<string> { "Function" };//Highcharts.FormatterCallbackFunction.<Highcharts.Point>
        private static IEnumerable<string> UniqueStringTypesNames = new List<string> { "Highcharts.CSSObject", "Highcharts.ColorString", "Highcharts.HTMLDOMElement" };
        private static ISet<string> UniqueStringTypes = new HashSet<string>(UniqueStringTypesNames);

        public void SetReturnType(ApiItem item)
        {
            item.ReturnType = SetUpperFirstChar(item.ReturnType);

            if (UniqueStringTypes.Contains(item.ReturnType))
                item.ReturnType = StringType;

            if (IsFunction(item))
                item.ReturnType = FunctionType;

            if (item.Defaults != null && string.IsNullOrWhiteSpace(item.ReturnType))
                item.ReturnType = GetType(item);

            if (IsObject(item))
            {
                if (!item.Types.Contains(ObjectType))
                    item.Types.Add(ObjectType);

                item.Types.Remove("*");
                item.ReturnType = ObjectType;
            }
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

        private bool IsFunction(ApiItem item)
        {
            foreach (var type in FunctionTypes)
                if (item.ReturnType.Contains(type))
                    return true;

            if (FunctionTypes.Contains(item.ReturnType))
                return true;

            return false;
        }

        private bool IsObject(ApiItem item)
        {
            if (item.ReturnType == "*")
                return true;

            return false;
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
