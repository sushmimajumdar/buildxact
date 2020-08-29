using CsvHelper;
using Microsoft.Extensions.Configuration;
using SupplierPriceLister.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace SuppliesPriceLister.Logic
{
    public class CsvFileReaderService : IFileReaderService
    {
        private readonly IConfiguration _config;

        public CsvFileReaderService(IConfiguration config)
        {
            _config = config;
        }
        public IEnumerable<SupplyItem> ReadFromFile(string path)
        {
            IEnumerable<SupplyItem> items;

            var csvFilePath = _config.GetValue<string>("pathToCsv");

            //read form Csv file
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<CsvRecord>();
                items = ConvertFromCsv(records);
            }

            return items;

        }

        private IEnumerable<SupplyItem> ConvertFromCsv(IEnumerable<CsvRecord> records)
        {
            return records.Select(x => new SupplyItem {
                            Id = x.identifier, 
                            Description = x.desc, 
                            UOM = x.unit, 
                            PriceInCents = x.costAUD 
                        }).ToList();
        }
    }
}
