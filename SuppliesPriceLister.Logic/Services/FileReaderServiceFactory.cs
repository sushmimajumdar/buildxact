using SuppliesPriceLister.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuppliesPriceLister.Logic.Services
{
    public class FileReaderServiceFactory : IFileReaderServiceFactory
    {
        public IFileReaderService GetFileReaderService(FileFormat format)
        {
            IFileReaderService reader;

            if (format == FileFormat.Csv)
            {

                reader = new CsvFileReaderService();
            }
            else
            {
                reader = new JsonFileReaderService();

            }

            return reader;

        }
    }
}
