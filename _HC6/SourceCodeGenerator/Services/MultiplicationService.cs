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

            if (item.Types.Contains("Object"))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "Object";
                clone.Defaults = "null";
                clone.Suffix = string.Empty;
                clonedObjects.Add(clone);
                counter++;
            }

            if (item.Types.Contains("String"))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "String";
                clone.Defaults = "null";
                if (counter > 0)
                    clone.Suffix = "String";
                else
                    clone.Suffix = string.Empty;

                if (clone.Children.Any())
                    clone.Children.Clear();

                clonedObjects.Add(clone);
                counter++;
            }

            if (item.Types.Contains("Number"))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "Number";
                clone.Defaults = "null";
                if (counter > 0)
                    clone.Suffix = "Number";
                else
                    clone.Suffix = string.Empty;

                if (clone.Children.Any())
                    clone.Children.Clear();

                clonedObjects.Add(clone);
                counter++;
            }

            if (item.Types.Contains("Boolean"))
            {
                var clone = item.Clone();
                clone.Types.Clear();
                clone.ReturnType = "Boolean";
                clone.Defaults = "null";
                if (counter > 0)
                    clone.Suffix = "Bool";
                else
                    clone.Suffix = string.Empty;

                if (clone.Children.Any())
                    clone.Children.Clear();

                clonedObjects.Add(clone);
                counter++;
            }

            //place for arrrays

            return clonedObjects;
        }
    }

    public interface IMultiplicationService
    {
        List<ApiItem> MultiplyObject(ApiItem item);            
    }
}
