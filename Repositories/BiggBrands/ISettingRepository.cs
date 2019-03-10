using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface ISettingRepository : IGenericRepository<Setting>
    {
        Setting FindSettingByName(string settingName);
    }

    
}
