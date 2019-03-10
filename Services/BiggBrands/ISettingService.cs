using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Services.BiggBrands
{
    public interface ISettingService
    {
        Setting FindSettingByName(string settingName);
        decimal FindTaxCategoryFactorBySettingName(string settingName);
    }
}
