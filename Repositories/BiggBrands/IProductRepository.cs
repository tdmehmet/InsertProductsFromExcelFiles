using InsertProductsFromExcelFiles.AppModels;
using InsertProductsFromExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IProductRepository: IGenericRepository<Product>
    {
        void SetProductsAsUpdatedFalse();
        bool ProductExistsOnDB(AppProduct appProduct);
        Product FindProductByLogoCode(string logoCode);
        List<Product> FindAllProducts();
    }
}
