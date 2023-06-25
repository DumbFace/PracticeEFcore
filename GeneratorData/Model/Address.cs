using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeneratorData.Model
{
    public class AddressModelJson
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
    }

    public class RootAddressJson 
    {
        public List<AddressModelJson> Addressess { get; set; }
    }
}