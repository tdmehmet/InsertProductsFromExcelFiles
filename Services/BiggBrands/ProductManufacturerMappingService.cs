using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;
using InsertProductsFromExcelFiles.Utils;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
	public class ProductManufacturerMappingService : IProductManufacturerMappingService
    {
        private readonly IProductManufacturerMappingRepository _thyMenaProductManufacturerMappingRepository;
        
        public ProductManufacturerMappingService(
            IProductManufacturerMappingRepository thyMenaProductManufacturerMappingRepository
            )
        {
            _thyMenaProductManufacturerMappingRepository = thyMenaProductManufacturerMappingRepository;
        }

        public List<ProductManufacturerMapping> FindAllProductManufacturerMappings()
        {
            return _thyMenaProductManufacturerMappingRepository.FindAllItems();
        }

        public void AddProductManufacturerMapping(ProductManufacturerMapping productManufacturerMapping)
        {
            _thyMenaProductManufacturerMappingRepository.Add(productManufacturerMapping);
            _thyMenaProductManufacturerMappingRepository.Save();
        }
    }
}
