using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public class ProductCategoryMappingService : IProductCategoryMappingService
    {
        private readonly IProductCategoryMappingRepository _thyMenaProductCategoryMappingRepository;

        public ProductCategoryMappingService(
                                      IProductCategoryMappingRepository thyMenaProductCategoryMappingRepository
                                     )
        {
            _thyMenaProductCategoryMappingRepository = thyMenaProductCategoryMappingRepository;
        }

        public List<ProductCategoryMapping> FindAllProductCategoryMappings()
        {
            return _thyMenaProductCategoryMappingRepository.FindAllProductCategoryMappings();
        }

        public ProductCategoryMapping SaveProductCategoryMapping(ProductCategoryMapping productCategoryMapping)
        {
            ProductCategoryMapping savedProductCategoryMapping = _thyMenaProductCategoryMappingRepository.Add(productCategoryMapping);
            _thyMenaProductCategoryMappingRepository.Save();
            return savedProductCategoryMapping;
        }
    }
}
