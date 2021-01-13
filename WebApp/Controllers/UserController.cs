using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class UserController : Controller
    {
        [Route("/login")]
        public IActionResult Login()
        {
            return View();
        }

        [Route("/register")]
        public IActionResult Register()
        {
            return View(new Customer());
        }

        [Route("/register")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Register(Customer customer)
        {
            var mail = new MailSender();
            mail.SendFormToSupport(customer, "info@dmcfx.com", "Register Form");
            return View();
        }

        [Route("/ForgotPassword")]
        public IActionResult ForgotPassword()
        {
            return View();
        }


        [Route("/ForgotPassword")]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult ForgotPassword(string email)
        {
            var mail = new MailSender();
            mail.SendForForgotPassword(email, "info@dmcfx.com", "Forgot Password");
            return View();
        }


    }
}
