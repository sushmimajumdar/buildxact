using System;
using System.Collections.Generic;
using System.Text;

namespace SupplierPriceLister.Models
{
    public class CsvRecord
    {
        public string identifier { get; set; }
        public string desc { get; set; }
        public string unit { get; set; }
        public double costAUD { get; set; }

    }
}
