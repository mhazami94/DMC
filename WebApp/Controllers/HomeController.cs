using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using DTO.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Services.Mail;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/aboutus")]
        public IActionResult AboutUs()
        {
            return View();
        }

        [Route("/career")]
        public IActionResult Career()
        {
            return View();
        }

        [Route("/Certificates")]
        public IActionResult Certificates()
        {
            return View();
        }

        [Route("/Crypto-currencies")]
        public IActionResult Cryptocurrencies()
        {
            return View();
        }


        [Route("/Energy")]
        public IActionResult Energy()
        {
            return View();
        }


        [Route("/Forex")]
        public IActionResult Forex()
        {
            return View();
        }

        [Route("/Indexes")]
        public IActionResult Indexes()
        {
            return View();
        }


        [Route("/Metals")]
        public IActionResult Metals()
        {
            return View();
        }

        [Route("/Android-Meta-Trader")]
        public IActionResult MTAndroid()
        {
            return View();
        }


        [Route("/Desktop-Meta-Trader")]
        public IActionResult MTDesktop()
        {
            return View();
        }

        [Route("/IOS-Meta-Trader")]
        public IActionResult MTIOS()
        {
            return View();
        }


        [Route("/Terminal-Meta-Trader")]
        public IActionResult MTTerminal()
        {
            return View();
        }


        [Route("/Stock")]
        public IActionResult Stock()
        {
            return View();
        }

        [Route("/Campaigns")]
        public IActionResult Campaigns()
        {
            return View(new Customer());
        }


        [Route("/Campaigns")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public IActionResult Campaigns(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Apple Kampanyası Form");
            return View();
        }



        [Route("/Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("/Daily-Bulletin")]
        public IActionResult DailyBulletin()
        {
            return View();
        }

        [Route("/Economic-Calendar")]
        public IActionResult EconomicCalendar()
        {
            return View();
        }

        [Route("/Glossary")]
        public IActionResult Glossary()
        {
            return View();
        }


     
        [Route("/News-Register")]
        [HttpPost]
        public IActionResult NewsPost(string mail)
        {
            try
            {
                var mailSender = new MailSender();
                if (mail.IsMailAddress())
                {
                    var news = new Newsletter
                    {
                        Email = mail
                    };
                    if (mailSender.SendFormToNewsletter(news, "info@dmcfx.com", "Newsletter Form"))
                        return Ok(200);
                }
                return Ok(500);

            }
            catch (Exception ex)
            {
                return Ok(500);
            }
        }
    }
}
