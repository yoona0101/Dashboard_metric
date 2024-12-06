using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dashboard_metric.Model
{
    public class Metric
    {
        [JsonPropertyName("countOfSessions")]
        public int CountOfSessions { get; set; }

        [JsonPropertyName("avgViewingDepth")]
        public double AvgViewingDepth { get; set; }

        [JsonPropertyName("uniqueClients")]
        public List<string> UniqueClients { get; set; } 

        [JsonPropertyName("SessionIndicator")]
        public SessionIndicator SessionIndicator { get; set; }

        [JsonPropertyName("ConversionDomainList")]
        public List<ConversationDomain> ListConversationDomain { get; set; }
    }
}
