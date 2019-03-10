using System;
using System.Linq;
using System.Collections.Generic;
using log4net;
using InsertProductsFromExcelFiles.Services.ExternalServices;
using InsertProductsFromExcelFiles.Services.BiggBrands;
using InsertProductsFromExcelFiles.Utils;
using InsertProductsFromExcelFiles.BiggBrands;
using InsertProductsFromExcelFiles.AppModels;
using InsertProductsFromExcelFiles.Services.SpecificationServices;
using InsertProductsFromExcelFiles.Repositories.ExternalRepositories;
using System.IO;

namespace InsertProductsFromExcelFiles.Services
{
    public class CommonService : ICommonService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));

        private readonly IAllExcelProductService _allExcelProductService;
        private readonly IProductService _productService;
        private readonly IUrlRecordService _urlRecordService;
        private readonly IPictureService _pictureService;
        private readonly IProductPictureMappingService _productPictureMappingService;
        private readonly ICategoryService _categoryService;
        private readonly IProductCategoryMappingService _productCategoryMappingService;
        private readonly ITaxCategoryService _taxCategoryService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductManufacturerMappingService _productManufacturerMappingService;
        private readonly ISettingService _settingService;
        private readonly IProductWarehouseInventoryService _biggBrandsProductWarehouseInventoryService;
        private readonly IProductSpecificationAttributeMappingService _productSpecificationAttributeMappingService;
        private readonly ISpecificationAttributeOptionService _specificationAttributeOptionService;
        private readonly ISpecificationAttributeService _specificationAttributeService;

        public CommonService(
            IProductService productService,
            IUrlRecordService urlRecordService,
            IPictureService pictureService,
            ICategoryService categoryService,
            ITaxCategoryService taxCategoryService,
            IManufacturerService manufacturerService,
            IProductManufacturerMappingService productManufacturerMappingService,
            IProductPictureMappingService productPictureMappingService,
            IProductCategoryMappingService productCategoryMappingService,
            ISettingService settingService,
            IProductWarehouseInventoryService biggBrandsProductWarehouseInventoryService,
            IProductSpecificationAttributeMappingService productSpecificationAttributeMappingService,
            ISpecificationAttributeOptionService specificationAttributeOptionService,
            ISpecificationAttributeService specificationAttributeService,            
            IAllExcelProductService allExcelProductService
            )
        {
            _productService = productService;
            _urlRecordService = urlRecordService;
            _pictureService = pictureService;
            _productPictureMappingService = productPictureMappingService;
            _categoryService = categoryService;
            _productCategoryMappingService = productCategoryMappingService;
            _taxCategoryService = taxCategoryService;
            _manufacturerService = manufacturerService;
            _productManufacturerMappingService = productManufacturerMappingService;
            _settingService = settingService;
            _biggBrandsProductWarehouseInventoryService = biggBrandsProductWarehouseInventoryService;
            _productSpecificationAttributeMappingService = productSpecificationAttributeMappingService;
            _specificationAttributeOptionService = specificationAttributeOptionService;
            _specificationAttributeService = specificationAttributeService;
            _allExcelProductService = allExcelProductService;

        }

        public void TransferProductsFromExcelFiles(AppConfiguration appConfiguration)
        {
             log.Info("Getting List of Products from Nop DB");
             GenericService.products = _productService.FindAllProducts();
             log.Info("List of Products from Nop DB are Gathered");

            log.Info("Getting List of Products from Nop DB");
            GenericService.pictures = _pictureService.FindAllPictures();
            log.Info("List of Products from Nop DB are Gathered");

            log.Info("Getting List of Manufacturers from Nop DB");
             GenericService.manufacturers = _manufacturerService.FindAllManufacturers();
             log.Info("List of Manufacturers from Nop DB are Gathered");

             log.Info("Getting List of ProductManufacturerMappings from Nop DB");
             GenericService.productManufacturerMappings =
                 _productManufacturerMappingService.FindAllProductManufacturerMappings();
             log.Info("List of ProductManufacturerMappings from Nop DB are Gathered");

             log.Info("Getting List of Categories from Nop DB");
             GenericService.categories = _categoryService.FindAllCategories();
             log.Info("List of Categories from Nop DB are Gathered");

             log.Info("Getting List of ProductCategoryMappings from Nop DB");
             GenericService.productCategoryMappings = _productCategoryMappingService.FindAllProductCategoryMappings();
             log.Info("List of ProductCategoryMappings from Nop DB are Gathered");

             log.Info("Getting List of Specification Attribute Values from Nop DB");
             SpecificationAttributeOptionUtil.specificationAttributes = _specificationAttributeService.FindAllSpecificationAttributes();
             log.Info("List of Specification Attributes from Nop DB are Gathered");

             log.Info("Getting List of Specification Attribute Option Values from Nop DB");
             SpecificationAttributeOptionUtil.specificationAttributeOptions = _specificationAttributeOptionService.FindAllSpecificationAttributeOptions();
             log.Info("List of Specification Attribute Options from Nop DB are Gathered");
             
            string[] files = Directory.GetFiles(@"C:\winservices\InsertProducts\ExcelFiles");
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(Path.Combine(file));
                _allExcelProductService.TransferProductsFromExcelFile(appConfiguration, fileInfo);
            }
        }

    }
}
