using SupplierPriceLister.Models;
using System.Collections.Generic;

namespace SuppliesPriceLister.Logic
{
    public interface IFileReaderService
    {
        IEnumerable<SupplyItem> ReadFromFile(string path);
    }
}