﻿using InsertProductsFromExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IProductWarehouseInventoryService
    {
        List<ProductWarehouseInventory> FindAllProductWarehouseInventories();
        ProductWarehouseInventory FindProductWarehouseInventoryByProductIdWarehouseId(int productId, int warehouseId);
        void InsertProductWarehouseInventories(List<ProductWarehouseInventory> productWarehouseInventories);
        void UpdateProductWarehouseInventories(List<ProductWarehouseInventory> productWarehouseInventories);
    }
}
