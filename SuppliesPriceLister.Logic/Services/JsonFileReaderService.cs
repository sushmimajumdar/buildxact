using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using SupplierPriceLister.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace SuppliesPriceLister.Logic
{
    public class JsonFileReaderService : IFileReaderService
    {
        private readonly IConfiguration _config;

        public JsonFileReaderService(IConfiguration config)
        {
            _config = config;
        }
    
        public IEnumerable<SupplyItem> ReadFromFile(string path)
        {
            var jsonFilePath = _config.GetValue<string>("pathToJson");
            var items = JsonConvert.DeserializeObject<SupplyItem>(File.ReadAllText(jsonFilePath));
            return items;

        }
    }
}
