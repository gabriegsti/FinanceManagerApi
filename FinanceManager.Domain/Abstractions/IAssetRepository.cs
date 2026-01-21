using FinanceManager.Domain.Entities;

namespace FinanceManager.Domain.Abstractions
{
    public interface IAssetRepository
    {
        Task<Asset> AddAssetAsync(Asset asset);
        Task<IEnumerable<Asset>> GetAllAssetsAsync();
        Task<Asset> GetAssetByIdAsync(Guid id);
        Task<Asset> UpdateAssetAsync(Asset asset);
        Task<Asset> DeleteAssetAsync(Guid id);
        

    }
}
