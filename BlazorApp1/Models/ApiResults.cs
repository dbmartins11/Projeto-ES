using BlazorApp1.Data;
using System.Text.Json.Serialization;

namespace BlazorApp1.Models
{
    public class ApiResults
    {
      
        [JsonPropertyName("results")]
        public List<Movie> Results { get; set; }

    }
}
