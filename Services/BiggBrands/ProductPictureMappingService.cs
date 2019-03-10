using System.Collections.Generic;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
	public class ProductPictureMappingService : IProductPictureMappingService
    {
        private readonly IProductPictureMappingRepository _thyMenaProductPictureMappingRepository;
        
        public ProductPictureMappingService(
            IProductPictureMappingRepository thyMenaProductPictureMappingRepository
            )
        {
            _thyMenaProductPictureMappingRepository = thyMenaProductPictureMappingRepository;
        }

        public List<ProductPictureMapping> FindAllProductPictureMappings()
        {
            return _thyMenaProductPictureMappingRepository.FindAllItems();
        }

        public void AddProductPictureMappingRange(List<ProductPictureMapping> productPictureMappings)
        {
            _thyMenaProductPictureMappingRepository.AddRange(productPictureMappings);
            _thyMenaProductPictureMappingRepository.Save();
        }
    }
}
