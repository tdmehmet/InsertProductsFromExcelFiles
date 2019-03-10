using System;
using System.Collections.Generic;
using InsertProductsFromExcelFiles.Repositories.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public class TaxCategoryService : ITaxCategoryService
    {
        private readonly ITaxCategoryRepository _thyMenaTaxCategoryRepository;
        
        public TaxCategoryService(ITaxCategoryRepository thyMenaTaxCategoryRepository
                                     )
        {
            _thyMenaTaxCategoryRepository = thyMenaTaxCategoryRepository;
        }

        public List<TaxCategory> FindAllTaxCategories()
        {
            return _thyMenaTaxCategoryRepository.FindAllItems();
        }

    }
}
