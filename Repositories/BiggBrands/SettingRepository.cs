using System.Linq;
using InsertProductsFromExcelFiles.Config;
using InsertProductsFromExcelFiles.BiggBrands;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public class SettingRepository : GenericRepository<Setting>, ISettingRepository
    {
        public SettingRepository(BiggBrandsContext biggBrandsContext) : base(biggBrandsContext)
        {
        }

        public Setting FindSettingByName(string settingName)
        {
            return this._entities.Setting.Where(setting => setting.Name == settingName).FirstOrDefault();
        }
    }
}
