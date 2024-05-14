using SkaiMovies.Data;
using System.Text.Json.Serialization;

namespace SkaiMovies.Models
{
    public class ApiResults
    {
      
        [JsonPropertyName("results")]
        public List<Movie> Results { get; set; }

    }
}
