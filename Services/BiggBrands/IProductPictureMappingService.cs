using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IProductPictureMappingService
    {
        List<ProductPictureMapping> FindAllProductPictureMappings();
        void AddProductPictureMappingRange(List<ProductPictureMapping> productPictureMappings);
    }
}
