using System.Text.Json.Serialization;
using SkaiMovies.Models;

namespace SkaiMovies.Data
{
    public class Movie
    {
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("title")]
		public string Title { get; set; }

        [JsonPropertyName("poster_path")]
        public String Poster { get; set; }

        [JsonPropertyName("release_date")]
        public String Date { get; set; }

		[JsonPropertyName("runtime")]
		public int Runtime { get; set; }

		[JsonPropertyName("overview")]
		public String Synopsis { get; set; }

		[JsonPropertyName("genres")]
		public Genres[] Category { get; set; }
        public string Director { get; set; }
        public List<string> Cast { get; set; }

        [JsonPropertyName("origin_country")]
        public List<string> Country { get; set; }

		[JsonPropertyName("vote_average")]
        public float Voting { get; set; }

		public float Rating { get; set; }
    }
}