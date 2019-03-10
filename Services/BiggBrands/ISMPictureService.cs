using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface ISMPictureService
    {
        List<Picture_SMProductDb> FindAllPictures();
        void DeleteSMPicture(Picture_SMProductDb picture);
    }
}
