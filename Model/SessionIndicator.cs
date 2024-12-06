using System.Text.Json.Serialization;

namespace Dashboard_metric.Model
{
    public class SessionIndicator
    {
        [JsonPropertyName("numberOfPositive")]
        public int NumberOfPositive { get; set; }

        [JsonPropertyName("numberOfNegative")]
        public int NumberOfNegative { get; set; }
    }
}
