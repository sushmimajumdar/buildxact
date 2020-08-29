using CsvHelper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using SupplierPriceLister.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace SuppliesPriceLister
{
    class Program
    {
        static void Main(string[] args)
        {
            //add configuration
            AddServiceCollection();

            //read from json and csv and process 
            ProcessSupplyItemData();

        }

        private static void ProcessSupplyItemData()
        {
            SupplierPriceListerService service = new SupplierPriceListerService();
        }

        private static void AddServiceCollection()
        {
            IConfiguration _configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
              .AddEnvironmentVariables()
              .Build();


            var serviceProvider = new ServiceCollection();
            serviceProvider.AddSingleton<IConfiguration>(_configuration);
            serviceProvider.BuildServiceProvider();
            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }

    }
}
