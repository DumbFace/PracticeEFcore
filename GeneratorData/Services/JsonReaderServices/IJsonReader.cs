using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorData.Services.JsonReaderServices
{
    public interface IJsonReader<T>
    {
        T ConvertToModel(string url);
    }
}