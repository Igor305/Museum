using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Interfaces
{
    public  interface IShopsRepository
    {
        public Task<int> getId(int? shopNumber);
    }
}
