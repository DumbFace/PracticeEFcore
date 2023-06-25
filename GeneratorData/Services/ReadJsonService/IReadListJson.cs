using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorData.Services
{
    public interface IReadListJson<T>
    {
        List<T> ReadListJson(string urlJson);
    }
}