using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public interface IFoldersRepository
    {
        public Task<int> getId();
    }
}
