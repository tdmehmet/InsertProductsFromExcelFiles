using InsertProductsFromExcelFiles.AppModels;

namespace InsertProductsFromExcelFiles.Services
{
    public interface ICommonService
    {
        void TransferProductsFromExcelFiles(AppConfiguration appConfiguration);
    }
}
