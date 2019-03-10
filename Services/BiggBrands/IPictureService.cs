using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IPictureService
    {
        List<Picture> FindAllPictures();
        void InsertOrUpdatePictureProductMapping(Product product, string pictures);
    }
}
