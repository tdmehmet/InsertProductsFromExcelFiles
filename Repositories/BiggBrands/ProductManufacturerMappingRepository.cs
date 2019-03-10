using System.Linq;
using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class ProductManufacturerMappingRepository : GenericRepository<ProductManufacturerMapping>, IProductManufacturerMappingRepository
    {
        public ProductManufacturerMappingRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public ProductManufacturerMapping FindByProductId(int productId) {
            return this._entities.ProductManufacturerMapping.
                       Where(productManufacturerMapping => productManufacturerMapping.ProductId == productId).FirstOrDefault();
        }
    }
}
