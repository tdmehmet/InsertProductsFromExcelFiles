using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category FindCategoryByName(string categoryName);
        Category FindCategoryById(int categoryId);
    }
}
