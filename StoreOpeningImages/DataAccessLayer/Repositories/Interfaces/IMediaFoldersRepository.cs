using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IMediaFoldersRepository
    {
        public Task<int> getId(int? shopId, int? folderId);
    }
}
