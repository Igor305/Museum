using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MediaFoldersRepository : IMediaFoldersRepository
    {
        private readonly ShopsContext _shopsContext;

        public MediaFoldersRepository(ShopsContext shopsContext)
        {
            _shopsContext = shopsContext;
        }

        public async Task<int> getId(int? shopId, int? folderId)
        {
            int id = await _shopsContext.MediaFolders.Where(x => x.ShopId == shopId && x.FolderId == folderId).Select(x => x.Id).FirstOrDefaultAsync();

            return id;
        }
    }
}
