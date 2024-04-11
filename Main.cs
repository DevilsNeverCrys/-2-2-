// UsersService/Controllers/UsersController.cs
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace UsersService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public UsersController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUser(int id)
        {
            var response = await _httpClient.GetAsync($"https://localhost:5001/subscriptions/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var subscription = JsonConvert.DeserializeObject(content);
                return Ok(subscription);
            }
            else
            {
                return StatusCode((int)response.StatusCode);
            }
        }
    }
}
