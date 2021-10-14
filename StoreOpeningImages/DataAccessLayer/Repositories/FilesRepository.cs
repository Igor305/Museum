using DataAccessLayer.AppContext;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FilesRepository : IFilesRepository
    {
        private readonly ShopsContext _shopsContext;

        public FilesRepository(ShopsContext shopsContext)
        {
            _shopsContext = shopsContext;
        }

        public async Task<List<int>> getIds(int? mediaFolderId)
        {
            List<int> ids = await _shopsContext.Files.Where(x => x.MediaFolderId == mediaFolderId).Select(x => x.Id).ToListAsync();

            return ids;
        }
    }
}
