using InsertProductsFromExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IProductPictureMappingRepository : IGenericRepository<ProductPictureMapping>
    {
        List<ProductPictureMapping> FindAllProductPictureMappingsByProductId(int productId);
    }
}
