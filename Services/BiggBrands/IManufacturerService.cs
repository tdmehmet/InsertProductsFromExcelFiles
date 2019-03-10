using System.Collections.Generic;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface IManufacturerService
    {
        Manufacturer AddManuFacturer(Manufacturer manufacturer);
        void InsertOrUpdateProductManufacturerMapping(Product product, string marka);
        List<Manufacturer> FindAllManufacturers();
    }
}
