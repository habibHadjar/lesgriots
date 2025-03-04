using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesgriots.Domain.Entities;

namespace Lesgriots.Application.Interfaces
{
    public interface IAssetService
    {
        Task<List<Asset>> GetAllAssetsAsync();
        Task<Asset> GetAssetByIdAsync(int id);
    }
}
