using AkademiqNetRapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Configuration;

namespace AkademiqNetRapidApi.Controllers
{
    public class FilmController : Controller
    {
        private readonly IConfiguration _configuration;

        public FilmController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
                {
                    { "x-rapidapi-key", _configuration["ApiKeys:RapidApiKey"] },
                    { "x-rapidapi-host", "imdb-top-100-movies.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<MovieViewModel>>(body);
                return View(values.ToList());
            }
        }
    }
}
