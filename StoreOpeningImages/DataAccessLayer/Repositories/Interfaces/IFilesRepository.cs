using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IFilesRepository
    {
        public Task<List<int>> getIds(int? mediaFolderId);
    }
}
