using System.Text.Json.Serialization;

namespace NIB_Test_Server.DAL.Model
{
    public class Location
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
