using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceCodeGenerator.Services
{
    public class TypeService : ITypeService
    {
        public static readonly string CSSRawType = "Highcharts.CSSObject";
        public static readonly string CSSType = "CSSObject";
        public static readonly string StringType = "String";
        public static readonly string ObjectType = "Object";
        public static readonly string BoolType = "Boolean";
        public static readonly string NumberType = "Number";
        public static readonly string FunctionType = "function";
        public static readonly string EnumType = "Enum";

        private static ISet<string> FunctionTypes = new HashSet<string> { "Function", "HTMLDOMElement", "Highcharts.XAxisCrosshairLabelFormatterCallbackFunction", "Highcharts.FormatterCallbackFunction", "Highcharts.DataGroupingApproximationValue", "Highcharts.AccessibilityAnnouncementFormatter" };//Highcharts.FormatterCallbackFunction.<Highcharts.Point>
        private static IEnumerable<string> UniqueStringTypesNames = new List<string> { /*"Highcharts.CSSObject",*/ "Highcharts.ColorString","Highcharts.ColorType", "Highcharts.StockToolsBindingsObject", "Highcharts.ButtonRelativeToValue", "Highcharts.SeriesOrganizationNodesLayoutValue", "Highcharts.PaneBackgroundShapeValue", "Highcharts.TilemapShapeValue", "Highcharts.VariablePieSizeByValue", "Highcharts.TooltipShapeValue", "Highcharts.DashStyleValue", "Highcharts.VerticalAlignValue", "Highcharts.ColorAxisTypeValue",
        "Highcharts.PathfinderTypeValue", "Highcharts.SymbolKeyValue", "Highcharts.ExportingMimeTypeValue", "Highcharts.BubbleSizeByValue", "Highcharts.AxisTypeValue", "Highcharts.FlagShapeValue",
        "Highcharts.SeriesLinecapValue", "Highcharts.AxisTitleAlignValue", "Highcharts.RangeSelectorButtonTypeValue", "Highcharts.AnnotationDraggableValue", "Highcharts.FlagsShapeValue", "Highcharts.DataGroupingAnchor","Highcharts.DataGroupingAnchorExtremes",
        "Highcharts.OrganizationHangingIndentTranslationValue", "Highcharts.SVGPathArray", "Highcharts.Dictionary.<function()>", "Brightness"};//, "Highcharts.HTMLDOMElement" 
        private static ISet<string> UniqueStringTypes = new HashSet<string>(UniqueStringTypesNames);

        private static IEnumerable<string> UniqueObjectTypeNames = new List<string> { "Highcharts.PlotNetworkDataLabelsOptionsObject", "Highcharts.DataLabelsOptionsObject", "Highcharts.NavigationBindingsOptionsObject", "Highcharts.SVGAttributes", "Highcharts.SeriesSankeyDataLabelsOptionsObject"
        , "Highcharts.SeriesArcDiagramDataLabelsOptionsObject", "Highcharts.SeriesTreegraphDataLabelsOptionsObject", "Highcharts.SeriesPackedBubbleDataLabelsOptionsObject", "Highcharts.SeriesNetworkgraphDataLabelsOptionsObject", "Highcharts.SeriesOrganizationDataLabelsOptionsObject", "Highcharts.SeriesSunburstDataLabelsOptionsObject"};
        private static ISet<string> UniqueObjectTypes = new HashSet<string>(UniqueObjectTypeNames);

        private static IEnumerable<string> UniqueEnumTypeNames = new List<string> { "Highcharts.DataLabelsOverflowValue", "Highcharts.AlignValue"};
        private static ISet<string> UniqueEnumTypes = new HashSet<string>(UniqueEnumTypeNames);

        public void SetReturnType(ApiItem item)
        {
            item.ReturnType = SetUpperFirstChar(item.ReturnType);

            if (UniqueStringTypes.Contains(item.ReturnType))
                item.ReturnType = StringType;

            if (IsFunction(item))
                item.ReturnType = FunctionType;

            if (IsEnum(item))
                item.ReturnType = EnumType;

            if (item.ReturnType.Contains(CSSRawType))
                item.ReturnType = CSSType;

            if (item.Defaults != null && string.IsNullOrWhiteSpace(item.ReturnType))
                item.ReturnType = GetType(item);

            if (IsObject(item))
            {
                if (!item.Types.Contains(ObjectType))
                    item.Types.Add(ObjectType);

                item.Types.Remove("*");
                item.ReturnType = ObjectType;
            }

            if(IsHiddenEnum(item))
            {
                item.Values = item.Types;
                item.Types = new List<string> { EnumType };
                item.ReturnType = EnumType;
            }
            //else if(IsHiddenString(item))
            //{
            //    item.ReturnType = StringType;
            //}
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
            if (item.ReturnType == "*" || UniqueObjectTypes.Contains(item.ReturnType) || item.Extends.Any())
                return true;

            return false;
        }

        private bool IsEnum(ApiItem item)
        {
            if (UniqueEnumTypes.Contains(item.ReturnType))
                return true;

            return false;
        }

        private bool IsHiddenEnum(ApiItem item)
        {
            if (item.Types.Count > 1 && !item.Values.Any() && !item.ReturnType.Equals(CSSRawType) && !item.ReturnType.Equals(CSSType)
                && !item.ReturnType.Equals(StringType) && !item.ReturnType.Equals(ObjectType)
                && !item.ReturnType.Equals(BoolType) && !item.ReturnType.Equals(NumberType)
                && !item.ReturnType.Equals(FunctionType) && !item.ReturnType.Equals(EnumType))
                return true;

            return false;
        }

        //private bool IsHiddenString(ApiItem item)
        //{
        //    if (item.Types.Count == 1 && !item.Values.Any() && !item.ReturnType.Equals(CSSRawType) && !item.ReturnType.Equals(CSSType)
        //        && !item.ReturnType.Equals(StringType) && !item.ReturnType.Equals(ObjectType)
        //        && !item.ReturnType.Equals(BoolType) && !item.ReturnType.Equals(NumberType)
        //        && !item.ReturnType.Equals(FunctionType) && !item.ReturnType.Equals(EnumType))
        //        return true;

        //    return false;
        //}

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
