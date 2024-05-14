using System.Text.Json.Serialization;

namespace SkaiMovies.Models
{
	public class Genres
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}
