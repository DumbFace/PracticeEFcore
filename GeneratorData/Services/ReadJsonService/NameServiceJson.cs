using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GeneratorData.Services;
using Newtonsoft.Json;

namespace GeneratorData.ReadJson
{
    public class NameServiceJson<T> : IReadJson<T>, IReadListJson<T>
    {
        public T ReadJson(string urlJson)
        {
            // Đọc tệp JSON
            string json = File.ReadAllText(urlJson);

            // Chuyển đổi JSON thành mô hình riêng của bạn
            T models = JsonConvert.DeserializeObject<T>(json);

            return models;
        }

        public List<T> ReadListJson(string urlJson)
        {
            string json = File.ReadAllText(urlJson);

            // Chuyển đổi JSON thành mô hình riêng của bạn
            List<T> models = JsonConvert.DeserializeObject<List<T>>(json);

            return models;
        }
    }
}