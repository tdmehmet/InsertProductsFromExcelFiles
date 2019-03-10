using InsertProductsFromExcelFiles.AppModels;
using System.Collections.Generic;
using System.IO;

namespace InsertProductsFromExcelFiles.Repositories.ExternalRepositories
{
    public interface IExcelProductRepository
    {
        List<ExcelProduct> FindAllExcelProducts(FileInfo fileInfo);
    }
}
