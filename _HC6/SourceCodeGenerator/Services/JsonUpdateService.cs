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
        }

        private void UpdateProperty(ApiItem item, UpdateInfo info)
        {
            switch(info.Name)
            {
                case ApiPropertyName.ReturnType:
                    item.ReturnType = info.Value;
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
        }
    }

    public interface IJsonUpdateService
    {
        void Update(ApiItem item);
    }
}
