using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorization.Orders.Api.Controllers
{
    [Route("[controller]")]
    public class SiteController : Controller
    {
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[action]")]
        public string GetSecrets()
        {
             return "Secret string from Order api";
        }
    }
}
