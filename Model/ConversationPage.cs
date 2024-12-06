using System.Text.Json.Serialization;

namespace Dashboard_metric.Model
{
    public class ConversationPage
    {
        [JsonPropertyName("nameOfPage")]
        public string NameOfPage { get; set; }
        [JsonPropertyName("countOfTargetAction")]
        public int CountOfTargetAction { get; set; }
        [JsonPropertyName("conversionRateOfPage")]
        public int ConversionRateOfPage { get; set; }
    }
}
