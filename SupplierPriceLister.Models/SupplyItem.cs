using System;
using System.Collections.Generic;
using System.Text;

namespace SupplierPriceLister.Models
{
    public class SupplyItem
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string UOM { get; set; }
        public double PriceInCents { get; set; }

        public string ProviderId { get; set; }
        public string MaterialType { get; set; }

    }
}
