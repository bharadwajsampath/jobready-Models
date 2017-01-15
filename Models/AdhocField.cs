using Newtonsoft.Json;

namespace App.Models.Models
{
    public class AdHocField
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
