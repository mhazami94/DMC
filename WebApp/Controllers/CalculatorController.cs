using Azami.Utility;
using DTO;
using DTO.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Services.FXServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace WebApp.Controllers
{
    public class CalculatorController : Controller
    {
        [Route("/Calculator")]
        public async Task<IActionResult> Index()
        {
            await FillDrp();
            return View();
        }

        public async Task FillDrp()
        {
            ViewBag.CalculatorType = new SelectList(EnumUtils.ConvertEnumToIEnumerable<Enums.CalculatorType>(), "Key", "Value");
            await new FXServices().GetCalculationPrices();
            if (FXServices.UnitPrices != null && FXServices.UnitPrices.Any())
                ViewBag.Tips = new SelectList(FXServices.UnitPrices, "Title", "Title");
            else ViewBag.Tips = null;
        }

        [Route("/Calculaor/Result")]
        public async Task<IActionResult> GetResult(string type, string unit, string range, string L, string K)
        {
            double result = 0;
            await new FXServices().GetCalculationPrices();
            var price1 = FXServices.UnitPrices.FirstOrDefault(x => x.Title == $"{unit}USD");
            var price2 = FXServices.UnitPrices.FirstOrDefault(x => x.Title == $"USD{unit}");
            if (type.ToEnum<Enums.CalculatorType>() == Enums.CalculatorType.Buy)
            {
                if (price1 == null)
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * price2.BuyPrice / System.Convert.ToDouble(K);
                else
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * price1.BuyPrice / System.Convert.ToDouble(K);
            }
            else if (type.ToEnum<Enums.CalculatorType>() == Enums.CalculatorType.Sell)
            {
                if (price1 == null)
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * price2.SalePrice / System.Convert.ToDouble(K);
                else
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * price1.SalePrice / System.Convert.ToDouble(K);
            }
            return Content($"{result}");

        }
    }
}
