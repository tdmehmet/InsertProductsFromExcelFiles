using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IProductManufacturerMappingRepository : IGenericRepository<ProductManufacturerMapping>
    {
        ProductManufacturerMapping FindByProductId(int productId);
    }
}
