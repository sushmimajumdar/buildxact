using Newtonsoft.Json;
using SupplierPriceLister.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister.Logic
{
    public class JsonFileReaderService : IFileReaderService
    {
        public IEnumerable<SupplyItem> ReadFromFile(string path)
        {
            List<SupplyItem> items = new List<SupplyItem>();

            //read form Csv file

            return items;

        }
    }
}
