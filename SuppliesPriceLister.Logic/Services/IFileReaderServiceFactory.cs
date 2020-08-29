using SuppliesPriceLister.Logic.Enums;

namespace SuppliesPriceLister.Logic.Services
{
    public interface IFileReaderServiceFactory
    {
        IFileReaderService GetFileReaderService(FileFormat format);
    }
}