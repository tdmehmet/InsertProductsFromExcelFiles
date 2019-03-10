using InsertProductsFromExcelFiles.BiggBrands;
using System.Collections.Generic;

namespace InsertProductsFromExcelFiles.Repositories.BiggBrands
{
    public interface IUrlRecordRepository : IGenericRepository<UrlRecord>
    {
        UrlRecord FindUrlRecordByEntityIdEntityName(int entityId, string entityName);
        List<UrlRecord> FindSameUrlRecordsForDifferentProducts(string slug, string entityName, int entityId);
        List<UrlRecord> FindUrlRecordsByEntityIdEntityName(int entityId, string entityName);
        UrlRecord FindUrlRecordBySlugEntityName(string slug, string entityName);
    }
}
