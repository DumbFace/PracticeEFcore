using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorData.ReadJson
{
    public interface IReadJson<T>
    {
        T ReadJson(string urlJson);
    }
}