using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public class ProductSpecificationAttributeMappingService : IProductSpecificationAttributeMappingService
    {
        private readonly IProductSpecificationAttributeMappingRepository _productSpecificationAttributeMappingRepository;

        public ProductSpecificationAttributeMappingService(
                                      IProductSpecificationAttributeMappingRepository productSpecificationAttributeMappingRepository
                                     )
        {
            _productSpecificationAttributeMappingRepository = productSpecificationAttributeMappingRepository;
        }

        public List<ProductSpecificationAttributeMapping> FindAllProductSpecificationAttributeMappings()
        {
            return _productSpecificationAttributeMappingRepository.FindAllItems();
        }
    }
}
