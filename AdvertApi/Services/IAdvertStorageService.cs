using System.Threading.Tasks;
using AdvertApi.Models;

namespace AdvertApi.Services
{
    public interface IAdvertStorageService
    {
        Task<string> AddAsync(AdvertModel model);

        Task ConfirmAsync(ConfirmAdvertModel model);
    }
}
