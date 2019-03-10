using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IManufacturerRepository : IGenericRepository<Manufacturer>
    {
        Manufacturer FindManufacturerByName(string manufacturerName);
    }
}
