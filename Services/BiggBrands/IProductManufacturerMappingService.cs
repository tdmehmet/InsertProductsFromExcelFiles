using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IProductManufacturerMappingService
    {
        List<ProductManufacturerMapping> FindAllProductManufacturerMappings();
        void AddProductManufacturerMapping(ProductManufacturerMapping productManufacturerMapping);
    }
}
