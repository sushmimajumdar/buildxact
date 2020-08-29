using System;

namespace SupplierPriceLister.Models
{
    public class Partner
    {
        public string Name { get; set; }
        public string PartnerType { get; set; }
        public string PartnerAddress { get; set; }

        public SupplyItem[] Supplies { get; set; }
    }
}
