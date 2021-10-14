using DataAccessLayer.Entities.Shops;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IFileContentsRepository
    {
        public Task<List<FileContent>> getImages(List<int> ids);
    }
}
