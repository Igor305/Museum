using BusinessLogicLayer.Models.Response;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Interfaces
{
    public interface IShopsService
    {
        public Task<FileContentResponseModel> getImages(int? shopId);
    }
}
