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

        [Route("/Calculaor/GetTeminat")]
        public async Task<IActionResult> GetTeminat(string type, string unit, string range, string L, string K)
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

        [Route("/Calculaor/GetZarar")]
        public async Task<IActionResult> GetZarar(string type, string unit, string range, string L, string P1, string P2)
        {
            double result = 0;
            await new FXServices().GetCalculationPrices();
            var price1 = FXServices.UnitPrices.FirstOrDefault(x => x.Title == $"{unit}USD");
            var price2 = FXServices.UnitPrices.FirstOrDefault(x => x.Title == $"USD{unit}");

            if (type.ToEnum<Enums.CalculatorType>() == Enums.CalculatorType.Buy)
            {
                if (price1 == null)
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * (System.Convert.ToDouble(P2) - System.Convert.ToDouble(P1)) / price2.BuyPrice;
                else
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * (System.Convert.ToDouble(P2) - System.Convert.ToDouble(P1)) / price1.BuyPrice;
            }
            else if (type.ToEnum<Enums.CalculatorType>() == Enums.CalculatorType.Sell)
            {
                if (price1 == null)
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * (System.Convert.ToDouble(P1) - System.Convert.ToDouble(P2)) / price2.SalePrice;
                else
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * (System.Convert.ToDouble(P1) - System.Convert.ToDouble(P2)) / price1.BuyPrice;
            }
            return Content($"{result}");
        }

        [Route("/Calculaor/GetPip")]
        public async Task<IActionResult> GetPip(string type, string unit, string range, string L, string Pip)
        {
            double result = 0;
            await new FXServices().GetCalculationPrices();
            var price1 = FXServices.UnitPrices.FirstOrDefault(x => x.Title == $"{unit}USD");
            var price2 = FXServices.UnitPrices.FirstOrDefault(x => x.Title == $"USD{unit}");

            if (type.ToEnum<Enums.CalculatorType>() == Enums.CalculatorType.Buy)
            {
                if (price1 == null)
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * System.Convert.ToDouble(Pip) / price2.BuyPrice;
                else
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * System.Convert.ToDouble(Pip) / price1.BuyPrice;
            }
            else if (type.ToEnum<Enums.CalculatorType>() == Enums.CalculatorType.Sell)
            {
                if (price1 == null)
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * System.Convert.ToDouble(Pip) / price2.SalePrice;
                else
                    result = System.Convert.ToDouble(range) * System.Convert.ToDouble(L) * System.Convert.ToDouble(Pip) / price1.SalePrice;
            }
            return Content($"{result}");
        }

        [Route("/Calculaor/GetPrice")]
        public async Task<IActionResult> GetPrice(string type, string tip)
        {
            double result = 0;
            await new FXServices().GetCalculationPrices();
            var item = FXServices.UnitPrices.FirstOrDefault(x => x.Title == tip);

            switch (type.ToEnum<Enums.CalculatorType>())
            {
                case Enums.CalculatorType.None:
                    result = 0;
                    break;
                case Enums.CalculatorType.Buy:
                    result = item.BuyPrice;
                    break;
                case Enums.CalculatorType.Sell:
                    result = item.SalePrice;
                    break;
                default:
                    result = 0;
                    break;
            }
            return Content($"{result}");
        }
    }
}
