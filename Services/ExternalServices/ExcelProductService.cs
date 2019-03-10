using InsertProductsFromExcelFiles.Repositories.ExternalRepositories;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.AppModels;
using System.IO;

namespace InsertProductsFromExcelFiles.Services.ExternalServices
{
    public class ExcelProductService : IExcelProductService
    {
        private readonly IExcelProductRepository _excelProductRepository;

        public ExcelProductService(IExcelProductRepository excelProductRepository)
        {
            _excelProductRepository = excelProductRepository;
        }

        public List<ExcelProduct> FindAllProductsFromExcelFile(FileInfo fileInfo)
        {
            return _excelProductRepository.FindAllExcelProducts(fileInfo);
        }
    }
}
