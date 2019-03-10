using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface ITaxCategoryRepository : IGenericRepository<TaxCategory>
    {
        TaxCategory FindTaxCategoryByName(string name);
    }
}
