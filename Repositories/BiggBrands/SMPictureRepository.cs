using System.Linq;
using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class SMPictureRepository : GenericRepository<Picture_SMProductDb>, ISMPictureRepository
    {
        public SMPictureRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }
    }
}
