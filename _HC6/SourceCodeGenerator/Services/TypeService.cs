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

        public void SetReturnType(ApiItem item)
        {
            if (string.IsNullOrWhiteSpace(item.Defaults))
                return;

            if(string.IsNullOrWhiteSpace(item.ReturnType))
                item.ReturnType = GetType(item);
        }
        private string GetType(ApiItem item)
        {
            if (IsBool(item))
                return BoolType;

            if (IsNumber(item))
                return NumberType;

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
    }

    public interface ITypeService
    {
        void SetReturnType(ApiItem item);
    }
}
