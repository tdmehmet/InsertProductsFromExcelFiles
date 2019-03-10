using InsertProductsFromExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface ISpecificationAttributeOptionService
    {
        List<SpecificationAttributeOption> FindAllSpecificationAttributeOptions();
    }
}
