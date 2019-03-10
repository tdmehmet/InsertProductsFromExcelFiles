﻿using InsertProductsFromExcelFiles.BiggBrands;
using InsertProductsFromExcelFiles.Config;
using System.Linq;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public Category FindCategoryByName(string categoryName) {
            return this._entities.Category.Where(category => category.Name == categoryName).FirstOrDefault();
        }

        public Category FindCategoryById(int categoryId) {
            return this._entities.Category.Where(category => category.Id == categoryId).FirstOrDefault();
        }
    }
}
