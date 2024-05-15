using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using SkaiMovies.Data;

namespace SkaiMovies.Models
{
    public class MovieApi
    {
        private readonly String key;
        private readonly HttpClient httpClient;
        private readonly string url;
        public MovieApi()
        {
            key = "b120c1c2af7b0fd69272ca950c166cfd";
            httpClient = new HttpClient();
            url = $"https://api.themoviedb.org/3/";
        }
        public async Task<List<Movie>> GetMovie(String title)
        {
			String url = $"{this.url}search/movie?api_key={key}&query={title}&sort_by=popularity.desc";
            string responseMessage;
            try
            {
                JsonSerializerOptions options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true, // Caso insensível para os nomes das propriedades
                    IgnoreNullValues = true // Ignora valores nulos ao deserializar
                };
                HttpResponseMessage response = await httpClient.GetAsync(url);
                if (response != null) {
                    responseMessage = await response.Content.ReadAsStringAsync();
                    //var results = responseMessage;
                    var apiResults = JsonSerializer.Deserialize<ApiResults>(responseMessage);
                    return apiResults.Results;
                }
                else
                {
                    Console.WriteLine($"Failed to get an response. Status code: {response.StatusCode}");
                    return null;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Movie> GetMovieById(int Id)
        {
            Movie movie;
			String url = $"{this.url}movie/{Id}?api_key={key}";
			string responseMessage;
			try
			{
				HttpResponseMessage response = await httpClient.GetAsync(url);
				if (response != null)
				{
					responseMessage = await response.Content.ReadAsStringAsync();
					//var results = responseMessage;
					movie = JsonSerializer.Deserialize<Movie>(responseMessage);
					return movie;
				}
				else
				{
					Console.WriteLine($"Failed to get an response. Status code: {response.StatusCode}");
					return null;
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
		public async Task<List<Movie>> GetPopular()
		{
			String url = $"{this.url}/movie/popular?api_key={key}";
			string responseMessage;
			try
			{
				JsonSerializerOptions options = new JsonSerializerOptions
				{
					PropertyNameCaseInsensitive = true, // Caso insensível para os nomes das propriedades
					IgnoreNullValues = true // Ignora valores nulos ao deserializar
				};
				HttpResponseMessage response = await httpClient.GetAsync(url);
				if (response != null)
				{
					responseMessage = await response.Content.ReadAsStringAsync();
					//var results = responseMessage;
					var apiResults = JsonSerializer.Deserialize<ApiResults>(responseMessage);
					return apiResults.Results;
				}
				else
				{
					Console.WriteLine($"Failed to get an response. Status code: {response.StatusCode}");
					return null;
				}

			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
