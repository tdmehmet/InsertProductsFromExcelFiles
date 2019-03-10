using InsertProductsFromExcelFiles.BiggBrands;
using InsertProductsFromExcelFiles.Config;
using System.Linq;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class ManufacturerRepository : GenericRepository<Manufacturer>, IManufacturerRepository
    {
        public ManufacturerRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public Manufacturer FindManufacturerByName(string manufacturerName) {
            return this._entities.Manufacturer.Where(manufacturer => manufacturer.Name == manufacturerName).FirstOrDefault();
        }
    }
}
