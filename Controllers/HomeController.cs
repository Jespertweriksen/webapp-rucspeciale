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
using Microsoft.AspNetCore.Http;
using System.Dynamic;

namespace webapp_rucspeciale.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISession session;

        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor httpContextAccessor)
        {
            _logger = logger;
            this.session = httpContextAccessor.HttpContext.Session;
        }


        [HttpPost]
        public async Task<ActionResult> CreateBooking(UserModel person, ReservationViewModel reservationViewModel)
        {
            string email = person.Email;

            string First_Name = person.First_Name;
            string Last_Name = person.Last_Name;
            int Postal = person.Postal;
            int Phone = person.Phone;




            using (var client = new HttpClient())
            {
                try
                {
                  
                    var httpResponseMessage = await client.PostAsync("http://localhost:7071/api/UserHandler?email=" + email + "&first_name=" + First_Name + "&last_name=" + Last_Name +  "&phone=" + Phone + "&postal=" + Postal,null);

                    if (httpResponseMessage.StatusCode == HttpStatusCode.OK)
                    {
                        //OKAY - WE GET USER INFO FROM DB
                        return View("CreateBooking", person);
                    }

                    if (httpResponseMessage.StatusCode == HttpStatusCode.BadRequest)
                    {
                        //WE NEED MORE INFO FROM USER
                        return View("CreateUser", person);
                    }
                }
                catch (OperationCanceledException) { }
            }
            return View(person);
        }

        [HttpPost]
        public ActionResult UserHandler(UserModel person, ReservationViewModel reservationViewModel)
        {
            return View("CreateBooking");
        }


        [HttpPost]
        public ActionResult Placement(ReservationViewModel reservationViewModel)
        {
            var amountofguests = reservationViewModel.AmountOfGuests;
            Debug.WriteLine("Amount of Guests: " + amountofguests);
            session.SetInt32("AmountOfGuests", (int)amountofguests);


            reservationViewModel.AvailablePlacements.Add("Bord indendørs til spisning");
            reservationViewModel.AvailablePlacements.Add("Høje stole i baren/ akvariet");
            reservationViewModel.AvailablePlacements.Add("Udendørs til spisning");

            //Debug.WriteLine(reservationViewModel.AmountOfGuests);
            return View("Placement", reservationViewModel);
        }



        [HttpPost]
        public ActionResult Calender(ReservationViewModel reservationViewModel, string Placement)
        {
            reservationViewModel.ChosenPlacement = Placement;
            reservationViewModel.AmountOfGuests = session.GetInt32("AmountOfGuests");
            session.SetString("Placement", Placement);
            Debug.WriteLine("Placement " + Placement);

            return View("Calender", reservationViewModel);
        }



        public IActionResult Index(ReservationViewModel reservationViewModel)
        {
            return View("GuestAmount", reservationViewModel);
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
