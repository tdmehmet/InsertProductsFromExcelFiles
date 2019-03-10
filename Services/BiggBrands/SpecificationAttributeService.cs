using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public class SpecificationAttributeService : ISpecificationAttributeService
    {
        private readonly ISpecificationAttributeRepository _specificationAttributeRepository;

        public SpecificationAttributeService(
                                      ISpecificationAttributeRepository specificationAttributeRepository
                                     )
        {
            _specificationAttributeRepository = specificationAttributeRepository;
        }

        public List<SpecificationAttribute> FindAllSpecificationAttributes()
        {
            return _specificationAttributeRepository.FindAllItems();
        }
    }
}
