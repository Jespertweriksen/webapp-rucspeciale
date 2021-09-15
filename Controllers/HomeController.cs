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

            var values = new Dictionary<string, string>();
            values.Add("email", email);
            var content = new StringContent("email?=" + email, Encoding.UTF8, "application/x-www-form-urlencoded");
            Debug.WriteLine(content.ReadAsStringAsync().Result);

            using (var client = new HttpClient())
            {
                try
                {
                    var httpResponseMessage = await client.PostAsync("http://localhost:7071", content);

                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        // Do something...
                    }
                }
                catch (OperationCanceledException) { }
            }

            /*
            using (HttpClient httpClient = new HttpClient { BaseAddress = uri1 })
            {

                var values = new Dictionary<string, string>();
                values.Add("email", email);
                var content = new FormUrlEncodedContent(values);

                string uri = "/api/CreateBooking";
                var response = httpClient.PostAsync(uri, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    Console.Write("Success");
                }
                else
                    Console.Write("Error");

            }*/
            return View();
        }

        public IActionResult Index()
        {
            return View();
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
