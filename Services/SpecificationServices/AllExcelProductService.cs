using System;
using System.Linq;
using System.Collections.Generic;
using log4net;
using InsertProductsFromExcelFiles.Services.ExternalServices;
using InsertProductsFromExcelFiles.Services.BiggBrands;
using InsertProductsFromExcelFiles.Utils;
using InsertProductsFromExcelFiles.BiggBrands;
using InsertProductsFromExcelFiles.AppModels;
using System.IO;

namespace InsertProductsFromExcelFiles.Services.SpecificationServices
{
    public class AllExcelProductService : GenericService, IAllExcelProductService
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));

        private readonly IExcelProductService _excelProductService;
        private readonly IProductService _productService;
        private readonly IManufacturerService _manufacturerService;
        private readonly IProductPictureMappingService _productPictureMappingService;

        public AllExcelProductService(IExcelProductService excelProductService,
            IManufacturerService manufacturerService,
            IProductService productService,
            IProductPictureMappingService productPictureMappingService)
        {
            _excelProductService = excelProductService;
            _productService = productService;
            _manufacturerService = manufacturerService;
            _productPictureMappingService = productPictureMappingService;
        }

        public void TransferProductsFromExcelFile(AppConfiguration appConfiguration, FileInfo fileInfo)
        {
            log.Info("Getting List of Products from " + fileInfo.Name);
            List<ExcelProduct> excelProducts = _excelProductService.FindAllProductsFromExcelFile(fileInfo);
            log.Info("List of Products are Gathered");

            log.Info("Generating Products List for Update");
            List<ProductPictureMapping> productPictureMappingsToUpdate = new List<ProductPictureMapping>();
            
            foreach (ExcelProduct excelProduct in excelProducts)
            {
                log.Info("Product " + excelProduct.PartnerSKUUnique + "is being processed " );
                Product product = products.Where(p => p.Sku == excelProduct.PartnerSKUUnique).FirstOrDefault();
                if (product == null)
                {
                    continue;

                }
                
                if (product.ProductPictureMapping == null || product.ProductPictureMapping.Count == 0)
                {
                    List<ProductPictureMapping> productPictureMappings = new List<ProductPictureMapping>();

                    List<ProductPictureMapping> tmpProductPictureMappings = ProductPictureMappingUtil
                        .GenerateProductPictureMappings(excelProduct.ImageURL1, pictures, product);
                    if(tmpProductPictureMappings != null && tmpProductPictureMappings.Count > 0)
                    {
                        productPictureMappings.AddRange(tmpProductPictureMappings);
                        tmpProductPictureMappings.Clear();
                        tmpProductPictureMappings = ProductPictureMappingUtil
                            .GenerateProductPictureMappings(excelProduct.ImageURL2, pictures, product);
                        if(tmpProductPictureMappings != null && tmpProductPictureMappings.Count > 0)
                        {
                            productPictureMappings.AddRange(tmpProductPictureMappings);
                            tmpProductPictureMappings.Clear();
                            tmpProductPictureMappings = ProductPictureMappingUtil
                            .GenerateProductPictureMappings(excelProduct.ImageURL3, pictures, product);
                            if (tmpProductPictureMappings != null && tmpProductPictureMappings.Count > 0)
                            {
                                productPictureMappings.AddRange(tmpProductPictureMappings);
                            }
                        }
                    }

                    productPictureMappingsToUpdate.AddRange(productPictureMappings);
                }
            }
            log.Info("Updating Products For " + fileInfo.FullName);
            _productPictureMappingService.AddProductPictureMappingRange(productPictureMappingsToUpdate);
        }

    }
}
