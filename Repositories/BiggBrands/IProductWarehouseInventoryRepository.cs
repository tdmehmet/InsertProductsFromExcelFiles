
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IProductWarehouseInventoryRepository : IGenericRepository<ProductWarehouseInventory>
    {
        ProductWarehouseInventory FindProductWarehouseInventoryByProductIdWarehouseId(int productId, int warehouseId);
    }
}
