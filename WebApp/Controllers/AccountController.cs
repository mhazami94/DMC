using DTO;
using Microsoft.AspNetCore.Mvc;
using Services.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.AppCode;

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
            try
            {
                var mail = new MailSender();
                if (mail.SendFormToSupport(customer, Consts.ReceiverMail, "Register Account Transfer"))
                {
                    ViewBag.Status = true;
                    return View();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                ViewBag.Status = false;
                return View();
            }
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
            try
            {
                var mail = new MailSender();
                if (mail.SendFormToSupport(customer, Consts.ReceiverMail, "Register Mom Account"))
                {
                    ViewBag.Status = true;
                    return View();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                ViewBag.Status = false;
                return View();
            }
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
            try
            {
                var mail = new MailSender();
                if (mail.SendFormToSupport(customer, Consts.ReceiverMail, "Register IB Account"))
                {
                    ViewBag.Status = true;
                    return View();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                ViewBag.Status = false;
                return View();
            }
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
            try
            {
                var mail = new MailSender();
                if (mail.SendFormToSupport(customer, Consts.ReceiverMail, "Register Real Account"))
                {
                    ViewBag.Status = true;
                    return View();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                ViewBag.Status = false;
                return View();
            }
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
            try
            {
                var mail = new MailSender();
                if (mail.SendFormToSupport(customer, Consts.ReceiverMail, "Register Demo Account"))
                {
                    ViewBag.Status = true;
                    return View();
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                ViewBag.Status = false;
                return View();
            }

        }
    }
}
