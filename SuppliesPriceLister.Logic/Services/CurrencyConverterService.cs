using System;
using System.Collections.Generic;
using System.Text;

namespace SuppliesPriceLister.Logic.Services
{
    public class CurrencyConverterService
    {
        public static  double ConvertUsdToAUD(double value, double rate)
        {
            return value * rate;
        }
    }
}
