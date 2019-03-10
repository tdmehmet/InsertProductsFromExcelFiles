using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class SpecificationAttributeRepository : GenericRepository<SpecificationAttribute>, ISpecificationAttributeRepository
    {
        public SpecificationAttributeRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
