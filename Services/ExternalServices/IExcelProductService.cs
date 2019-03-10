using InsertProductsFromExcelFiles.AppModels;
using InsertProductsFromExcelFiles.BiggBrands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InsertProductsFromExcelFiles.Services.ExternalServices
{
    public interface IExcelProductService
    {
        List<ExcelProduct> FindAllProductsFromExcelFile(FileInfo fileInfo);
    }
}
