using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GeneratorData.ReadJson
{
    public class AddressServiceJson<T> : IReadJson<T>
    {
        public T ReadJson(string urlJson)
        {
            // Đọc tệp JSON
            string json = File.ReadAllText(urlJson);

            // Chuyển đổi JSON thành mô hình riêng của bạn
            T models = JsonConvert.DeserializeObject<T>(json);

            return models;
        }
    }
}