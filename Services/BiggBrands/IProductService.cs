using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.AppModels;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IProductService
    {
        void SetProductsAsUpdatedFalse();
        bool ProductExistsOnDB(AppProduct appProduct);
        Product AddProduct(Product product);
        Product FindProductByLogoCode(string logoCode);
        List<Product> FindAllProducts();
        void UpdateProduct(Product product);
        void UpdateProductRange(List<Product> products);
        void AddProductRange(List<Product> products);
    }
}
