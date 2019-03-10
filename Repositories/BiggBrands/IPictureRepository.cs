using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IPictureRepository : IGenericRepository<Picture>
    {
        Picture FindPictureByResimUrl(string resimUrl);
    }
}
