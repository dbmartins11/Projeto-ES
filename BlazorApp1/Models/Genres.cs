using System.Text.Json.Serialization;

namespace BlazorApp1.Models
{
	public class Genres
	{
		[JsonPropertyName("id")]
		public int Id { get; set; }

		[JsonPropertyName("name")]
		public string Name { get; set; }
	}
}
