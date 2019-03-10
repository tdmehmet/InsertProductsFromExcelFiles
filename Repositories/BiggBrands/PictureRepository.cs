using System.Linq;
using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class PictureRepository : GenericRepository<Picture>, IPictureRepository
    {
        public PictureRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public Picture FindPictureByResimUrl(string resimUrl) {
            return this._entities.Picture.Where(picture => picture.SeoFilename == resimUrl).FirstOrDefault();
        }
    }
}
