using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeneratorData.Services.JsonReaderServices
{
    public class JsonReader<T> : IJsonReader<T>
    {
        public T ConvertToModel(string url)
        {
            // Đọc tệp JSON
            string json = File.ReadAllText(url);

            // Chuyển đổi JSON thành mô hình riêng của bạn
            T models = JsonConvert.DeserializeObject<T>(json);

            return models;
        }
    }
}