using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    public class MultiplicationService : IMultiplicationService
    {
        public List<ApiItem> MultiplyObject(ApiItem item)
        {
            if (item.Types.Count < 2)
                return new List<ApiItem>();

            var counter = 0;
            var clonedObjects = new List<ApiItem>();

            if (IsObject(item))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "Object";
                clone.Defaults = "null";
                clone.Suffix = string.Empty;
                clonedObjects.Add(clone);
                counter++;
            }

            if (IsString(item))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "String";

                if (counter > 0)
                {
                    clone.Suffix = "String";
                    clone.Defaults = "null";
                }
                else
                    clone.Suffix = string.Empty;

                ClearLists(clone);

                clonedObjects.Add(clone);
                counter++;
            }

            if (IsNumber(item))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "Number";
                
                if (counter > 0)
                {
                    clone.Suffix = "Number";
                    clone.Defaults = "null";
                }
                else
                    clone.Suffix = string.Empty;

                ClearLists(clone);

                clonedObjects.Add(clone);
                counter++;
            }

            if (IsBoolean(item))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "Boolean";
                
                if (counter > 0)
                {
                    clone.Suffix = "Bool";

                    if (bool.TryParse(item.Defaults, out bool defaultValue))
                        clone.Defaults = defaultValue.ToString().ToLower();
                    else
                        clone.Defaults = "null";
                }
                else
                    clone.Suffix = string.Empty;

                ClearLists(clone);

                clonedObjects.Add(clone);
                counter++;
            }

            //place for arrrays

            return clonedObjects;
        }

        //private bool IsCss(ApiItem item)
        //{
        //    if (item.Types.Contains(TypeService.CSSRawType))
        //        return true;
        //}

        private bool IsObject(ApiItem item)
        {
            if (item.Types.Contains("Object") || item.Types.Contains("*"))
                return true;

            foreach (var type in item.Types)
                if (type.Contains("Option"))
                    return true;

            return false;
        }

        private bool IsString(ApiItem item)
        {
            if (item.Types.Contains("String") || item.Types.Contains("string") || item.Types.Contains("ColorString") || item.Types.Contains("Highcharts.HTMLDOMElement")
                || item.Types.Contains("\'auto\'"))
                return true;

            return false;
        }

        private bool IsNumber(ApiItem item)
        {
            if (item.Types.Contains("Number") || item.Types.Contains("number"))
                return true;

            return false;
        }

        private bool IsBoolean(ApiItem item)
        {
            if (item.Types.Contains("Boolean") || item.Types.Contains("boolean"))
                return true;

            return false;
        }

        private void ClearLists(ApiItem item)
        {
            if (item.Children.Any())
                item.Children.Clear();

            if (item.Extends.Any())
                item.Extends.Clear();
        }
    }

    public interface IMultiplicationService
    {
        List<ApiItem> MultiplyObject(ApiItem item);            
    }
}
