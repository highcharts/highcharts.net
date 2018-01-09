using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourceCodeGenerator.Services.Objects;
using SourceCodeGenerator.Enums;

namespace SourceCodeGenerator.Services
{
    public class JsonUpdateService : IJsonUpdateService
    {
        private IDictionary<string, IList<UpdateInfo>> ItemsToUpdate;

        public JsonUpdateService()
        {
            ItemsToUpdate = new Dictionary<string, IList<UpdateInfo>>();

            Add();
        }

        public void Update(ApiItem item)
        {
            //title

            if(ItemsToUpdate.ContainsKey(item.Title))
            {
                foreach (var info in ItemsToUpdate[item.Title])
                    UpdateProperty(item, info);
            }

            //fullname
            if (ItemsToUpdate.ContainsKey(item.FullName))
            {
                foreach (var info in ItemsToUpdate[item.FullName])
                    UpdateProperty(item, info);
            }
        }

        private void UpdateProperty(ApiItem item, UpdateInfo info)
        {
            switch(info.Name)
            {
                case ApiPropertyName.ReturnType:
                    item.ReturnType = info.Value;
                    break;
                case ApiPropertyName.Values:
                    item.Values.Add(info.Value);
                    break;
            }
        }

        private void Add()
        {
            ItemsToUpdate.Add("fontSize",new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("fontWeight", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("color", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("textOutline", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("cursor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("pointFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("millisecond", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("second", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("minute", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("hour", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("day", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("week", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("month", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("year", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("dateFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lineDelimiter", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("chart.options3d.frame.visible", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("chart.options3d.frame.size", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("padding", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("background", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("transition", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.bullet.targetOptions.height", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("plotOptions.bullet.targetOptions.borderWidth", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("borderColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.downloadCSV", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.downloadXLS", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("lang.viewData", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("legend.itemCheckboxStyle.width", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("legend.itemCheckboxStyle.height", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("loading.labelStyle.top", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("loading.style.backgroundColor", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("loading.style.opacity", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("loading.style.textAlign", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("navigation.menuStyle.border", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("headerFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("followPointer", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("nodeFormat", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "String" } });
            ItemsToUpdate.Add("plotOptions.columnrange.marker", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Boolean" } });
            ItemsToUpdate.Add("chart.pinchType", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.Values, Value = "null" } });
            //ItemsToUpdate.Add("dataLabels", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });

            //remove after double type solution will be implemented
            ItemsToUpdate.Add("crosshair", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
            ItemsToUpdate.Add("plotOptions.series.dataLabels.filter.value", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Number" } });
            ItemsToUpdate.Add("annotations.labels.point", new List<UpdateInfo>() { new UpdateInfo { Name = ApiPropertyName.ReturnType, Value = "Object" } });
        }
    }

    public interface IJsonUpdateService
    {
        void Update(ApiItem item);
    }
}
