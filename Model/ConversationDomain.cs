using System.Text.Json.Serialization;

namespace Dashboard_metric.Model
{
    public class ConversationDomain
    {
        [JsonPropertyName("nameOfDomain")]
        public string NameOfDomain { get; set; }
        [JsonPropertyName("countOfTargetAction")]
        public int CountOfTargetAction { get; set; }
        [JsonPropertyName("conversionRateOfDomain")]
        public int ConversionRateOfDomain { get; set; }
        [JsonPropertyName("conversionPageList")]
        public List<ConversationPage> ListConversationPage { get; set; }
    }
}
