using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using webapp_rucspeciale.Models;
using Newtonsoft.Json;
using System.Net;
using System.Web;

namespace webapp_rucspeciale.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        [HttpPost]
        public async Task<ActionResult> IndexAsync(UserModel person)
        {
            string email = person.Email;
            using (var client = new HttpClient())
            {
                try
                {
                    var httpResponseMessage = await client.PostAsync("http://localhost:7071/api/CreateBooking?email=" + email, null);

                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        Debug.WriteLine(httpResponseMessage.Content.ReadAsStringAsync().Result);
                    }

                    if (httpResponseMessage.StatusCode == HttpStatusCode.BadRequest)
                    {
                        return View(person);
                    }
                }
                catch (OperationCanceledException) { }
            }
            return View(person);
        }

        public IActionResult Index()
        {
            return View(new UserModel());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
