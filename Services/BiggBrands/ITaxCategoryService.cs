using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface ITaxCategoryService
    {
        List<TaxCategory> FindAllTaxCategories();        
    }
}
