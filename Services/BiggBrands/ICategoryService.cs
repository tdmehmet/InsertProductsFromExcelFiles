using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface ICategoryService
    {
        List<Category> FindAllCategories();
        void InsertOrUpdateCategoryProductMapping(Product product, int? categoryId);
    }
}
