using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class ShopsRepository : IShopsRepository
    {
        private readonly ShopsContext _shopsContext;

        public ShopsRepository(ShopsContext shopsContext)
        {
            _shopsContext = shopsContext;
        }
        public async Task<int> getId(int? shopNumber)
        {
            int id = await _shopsContext.Shops.Where(x => x.ShopNumber == shopNumber && x.StatusId == 25).Select(x => x.Id).FirstOrDefaultAsync();

            return id;
        }
    }
}
