using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Helpers;

namespace WebApp.Controllers
{
    public class WinningTraderController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("/Winning-Trader")]
        public IActionResult WinningTrader()
        {
            return View();
        }

        [Route("/Winning-Trader-SignUp")]
        public IActionResult SignUp()
        {
            MessageHandler.ShowMessage("Message Test", MessageType.Success);
            return View();
        }
    }
}
