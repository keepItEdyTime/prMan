using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrGer.Models
{
    internal class ProductModelJson
    {
            [JsonProperty("id")]
            public int id { get; set; }

            [JsonProperty("identifier")]
            public string identifier { get; set; }

            [JsonProperty("description")]
            public string description { get; set; }

            [JsonProperty("descriptionEN")]
            public string descriptionEN { get; set; }

            [JsonProperty("price")]
            public double price { get; set; }

            [JsonProperty("unit")]
            public string unit { get; set; }

            [JsonProperty("availableSTK")]
            public double availableSTK { get; set; }

            [JsonProperty("vat")]
            public double vat { get; set; }

            [JsonProperty("inactive")]
            public bool inactive { get; set; }

            [JsonProperty("componentType")]
            public int componentType { get; set; }
        }

    internal class ProductModelRoot
    {
        public ProductModelJson productModelJson { get; set; }
    }
   
}
