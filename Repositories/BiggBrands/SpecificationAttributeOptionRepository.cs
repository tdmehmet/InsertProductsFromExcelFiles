using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class SpecificationAttributeOptionRepository : GenericRepository<SpecificationAttributeOption>, ISpecificationAttributeOptionRepository
    {
        public SpecificationAttributeOptionRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
