using DTO.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Services.FXServices
{
    public class FXServices
    {
        private string _baseAddress = "https://www.ziraatfx.com.tr";
        private HttpClient client;
        public static List<Calculator> UnitPrices = new List<Calculator>();
        public FXServices()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(_baseAddress);
        }

        public async Task<string> GetCalculationPrices()
        {
            var res = await client.GetStringAsync("/handlers/CalculationPrices.ashx?get=calc");
            var json = res.XmlToJson();
            if (!string.IsNullOrEmpty(json))
            {
                Root result = JsonConvert.DeserializeObject<Root>(json);
                if (result != null)
                    UnitPrices = this.FillComplex(result);
            }
            return string.Empty;
        }

        private List<Calculator> FillComplex(Root result)
        {
            var list = new List<Calculator>();
            foreach (var item in result.datalar.data)
            {
                var obj = new Calculator
                {
                    Title = item.ad,
                    SalePrice = Convert.ToDouble(item.satis),
                    BuyPrice = Convert.ToDouble(item.alis)
                };
                list.Add(obj);
            }
            return list;
        }

    }



    public class Datum
    {
        [JsonProperty("@tip")]
        public string Tip { get; set; }
        public string ad { get; set; }
        public string satis { get; set; }
        public string alis { get; set; }
    }

    public class Datalar
    {
        public List<Datum> data { get; set; }
    }

    public class Root
    {
        public Datalar datalar { get; set; }
    }

    public class Calculator
    {
        public string Title { get; set; }
        public double SalePrice { get; set; }
        public double BuyPrice { get; set; }

    }
}
