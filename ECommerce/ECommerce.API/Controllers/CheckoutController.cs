using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    public class CheckoutController : Controller
    {
        private static readonly Random rnd = new Random(DateTime.UtcNow.Second);
        public IActionResult Index()
        {
            return View();
        }
    }
}