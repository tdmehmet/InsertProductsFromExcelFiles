using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class ProductSpecificationAttributeMappingRepository : GenericRepository<ProductSpecificationAttributeMapping>, IProductSpecificationAttributeMappingRepository
    {
        public ProductSpecificationAttributeMappingRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
