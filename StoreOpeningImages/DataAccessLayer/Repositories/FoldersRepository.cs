using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FoldersRepository : IFoldersRepository
    {
        private readonly ShopsContext _shopContext;

        public FoldersRepository(ShopsContext shopContext)
        {
            _shopContext = shopContext;
        }

        public async Task<int> getId()
        {
            int id = await _shopContext.Folders.Where(x=>x.Name == "ОТКРЫТИЕ").Select(x=>x.Id).FirstOrDefaultAsync();

            return id;
        }
    }
}
