using SupplierPriceLister.Models;
using SuppliesPriceLister.Logic.Enums;
using SuppliesPriceLister.Logic.Services;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace SuppliesPriceLister
{
    public class SupplierPriceListerService
    {
        private string pathJson = @"C:\My Projects\CODE TESTS\Buildxact\buildxact-supplies-price-lister-830fc692c659\SampleData\megacorp.json";
        private string pathCsv = @"C:\My Projects\CODE TESTS\Buildxact\buildxact-supplies-price-lister-830fc692c659\SampleData\humphries.csv";

        private FileReaderServiceFactory fileReaderFactory = new FileReaderServiceFactory();

        private  readonly IConfiguration _config;

        public SupplierPriceListerService(IConfiguration config)
        {
            _config = config;
        }

        public void ReadAndListSupplyItems()
        {
            //Read items from file
            IEnumerable<SupplyItem> magacorp = GetJsonRecords();
            IEnumerable<SupplyItem> humphries = GetCsvRecords();

            //////Combine the two lists of supply items
            IEnumerable<SupplyItem> allItems = magacorp.Union(humphries);

            //List in descending order of price
            var rate = _config.GetValue("audUsdExchangeRate");
            allItems.OrderByDescending(si => si.PriceInCents).Select(x => x.PriceInCents = CurrencyConverterService.ConvertUsdToAUD(x.PriceInCents, rate)).ToList();


        }

        private IEnumerable<SupplyItem> GetCsvRecords()
        {
            var csvReader = fileReaderFactory.GetFileReaderService(FileFormat.Csv);        
            return csvReader.ReadFromFile(pathJson);
            
        }

        private IEnumerable<SupplyItem> GetJsonRecords()
        {
            var jsonReader = fileReaderFactory.GetFileReaderService(FileFormat.Json);
            return jsonReader.ReadFromFile(pathJson);
        }
    }
}
