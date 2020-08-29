using SupplierPriceLister.Models;
using System;
using System.Collections.Generic;

namespace SuppliesPriceLister.Logic
{
    public class CsvFileReaderService : IFileReaderService
    {
        public IEnumerable<SupplyItem> ReadFromFile(string path)
        {
            List<SupplyItem> items = new List<SupplyItem>();
            
            //read form Csv file

            return items;

        }
    }
}
