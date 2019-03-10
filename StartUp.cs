using Microsoft.Extensions.Configuration;
using InsertProductsFromExcelFiles.AppModels;
using InsertProductsFromExcelFiles.Services;
using System.Net;
using log4net;
using InsertProductsFromExcelFiles.Services.BiggBrands;
using InsertProductsFromExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles
{
    public class StartUp
    {
        private readonly ICommonService _commonService;
        private readonly ISMPictureService _smPictureService;
        private static readonly ILog log = LogManager.GetLogger(typeof(CommonService));
        public StartUp(ICommonService commonService,
            ISMPictureService smPictureService)
        {
            _commonService = commonService;
            _smPictureService = smPictureService;
        }

        public void Run(IConfiguration configuration) 
        {
            AppConfiguration appConfiguration = new AppConfiguration
            {
                WarehouseID = configuration.GetValue<int>("AppConfiguration:WarehouseID"),
            };
            
            _commonService.TransferProductsFromExcelFiles(appConfiguration);
        }
    }
}
