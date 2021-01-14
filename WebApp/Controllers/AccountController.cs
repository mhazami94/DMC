using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class AccountController : Controller
    {
        [Route("/open-new-account-transfer")]
        public IActionResult AccountTransfer()
        {
            return View(new Customer());
        }

        [Route("/open-new-account-transfer")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult AccountTransfer(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Register Account Transfer");
            return View();
        }

        [Route("/open-new-mam")]
        public IActionResult OpenNewMam()
        {
            return View(new Customer());
        }



        [Route("/open-new-mam")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult OpenNewMam(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Register Mom Account");
            return View();
        }



        [Route("/open-new-ib")]
        public IActionResult OpenNewIB()
        {
            return View(new Customer());
        }



        [Route("/open-new-ib")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult OpenNewIB(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Register IB Account");
            return View();
        }


        [Route("/open-new-real")]
        public IActionResult OpenNewReal()
        {
            return View(new Customer());
        }

        [Route("/open-new-real")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult OpenNewReal(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Register Real Account");
            return View();
        }

        [Route("/open-new-demo")]
        public IActionResult OpenNewDemo()
        {
            return View(new Customer());
        }

        [Route("/open-new-demo")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult OpenNewDemo(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Register Demo Account");
            return View();
        }
    }
}
