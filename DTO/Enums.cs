using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DTO
{
    public class Enums
    {
        public enum CalculatorType : byte
        {
            [Description("Seçiniz")]
            None = 0,
            [Description("Alış")]
            Buy = 1,
            [Description("Satış")]
            Sell = 2
        }
  
    }
}


