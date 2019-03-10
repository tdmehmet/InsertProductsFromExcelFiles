using InsertProductsFromExcelFiles.AppModels;
using System.IO;

namespace InsertProductsFromExcelFiles.Services.SpecificationServices
{
    public interface IAllExcelProductService
    {
        void TransferProductsFromExcelFile(AppConfiguration appConfiguration, FileInfo fileInfo);
    }
}
