using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Dashboard_metric.Model;

namespace Dashboard_metric.Controller
{
    public class MainWindowController
    {
        private readonly string _metrics_url = "https://metrics.adygnet.ru/metrics/details";
        
        public async Task<Metric> GetMetrics(IntervalData interval)
        {
            try
            {
                using (HttpClient client = new())
                {
                    var jsonObject = JsonSerializer.Serialize(interval);
                  

                    client.DefaultRequestHeaders.Add("Accept", "application/json");
                    client.DefaultRequestHeaders.Add("x-api-key", "f-9lMny8f8yRRCNuq0MIW4uIxvdENg3qMtlkojMSlypQtUEfRC9-a7G1-g");

                    var content = new StringContent(jsonObject, Encoding.UTF8, "application/json");
                    content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                    var result = await client.PostAsync(_metrics_url, content);
                    

                    if (result.IsSuccessStatusCode)
                    {
                        var endResult = await JsonSerializer.DeserializeAsync<Metric>(await result.Content.ReadAsStreamAsync());

                        return endResult;
                    }

                    else
                    {
                        return null;
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
