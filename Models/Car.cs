using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace Web_AppCars.Models
{
    public class Car
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("make")]
        public string Make { get; set; }
        [JsonPropertyName("model")]
        public string Model { get; set; }
        [JsonPropertyName("estimatedate")]
        public string Estimatedate { get; set; }
        [JsonPropertyName("km")]
        public int Km { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("image")]
        public string Image { get; set; }
        

    }
}
