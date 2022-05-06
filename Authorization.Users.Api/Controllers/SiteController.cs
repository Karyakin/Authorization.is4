using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Authorization.Users.Api.Controllers
{
    [Route("[controller]")]
    public class SiteController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public SiteController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
       [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("[action]")]
        public async Task<IActionResult> GetOrders()
        {
            var authClient = _httpClientFactory.CreateClient();
            var response = await authClient.GetAsync("https://localhost:5001/site/GetSecrets");
            var message = await response.Content.ReadAsStringAsync();

            ViewBag.Message = message;
            
            return View();
        }
    }
}