using System.Text.Json.Serialization;

namespace NIB_Test_Server.DAL.Model
{
    public class Job
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

    }
}
