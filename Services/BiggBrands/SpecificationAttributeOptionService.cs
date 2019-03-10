using InsertProductsFromExcelFiles.BiggBrands;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public class SpecificationAttributeOptionService : ISpecificationAttributeOptionService
    {
        private readonly ISpecificationAttributeOptionRepository _specificationAttributeOptionRepository;

        public SpecificationAttributeOptionService(
                                      ISpecificationAttributeOptionRepository specificationAttributeOptionRepository
                                     )
        {
            _specificationAttributeOptionRepository = specificationAttributeOptionRepository;
        }

        public List<SpecificationAttributeOption> FindAllSpecificationAttributeOptions()
        {
            return _specificationAttributeOptionRepository.FindAllItems();
        }
    }
}
