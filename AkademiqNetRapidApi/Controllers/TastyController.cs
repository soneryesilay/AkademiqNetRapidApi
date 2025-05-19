using AkademiqNetRapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

namespace AkademiqNetRapidApi.Controllers
{
    public class TastyController : Controller
    {
        private readonly IConfiguration _configuration;

        public TastyController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://tasty.p.rapidapi.com/recipes/list?from=0&size=20&tags=under_30_minutes"),
                Headers =
                {
                    { "x-rapidapi-key", _configuration["ApiKeys:RapidApiKey"] },
                    { "x-rapidapi-host", "tasty.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var root = JsonConvert.DeserializeObject<RootTastyApi>(body);
                var values = root.Results;
                return View(values.ToList());
            }
          
        }
    }
}
