using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IProductCategoryMappingService
    {
        List<ProductCategoryMapping> FindAllProductCategoryMappings();
        ProductCategoryMapping SaveProductCategoryMapping(ProductCategoryMapping productCategoryMapping);
    }
}
