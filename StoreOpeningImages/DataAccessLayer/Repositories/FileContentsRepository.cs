using DataAccessLayer.AppContext;
using DataAccessLayer.Entities.Shops;
using DataAccessLayer.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class FileContentsRepository : IFileContentsRepository
    {
        public readonly ShopsContext _shopsContext;

        public FileContentsRepository(ShopsContext shopsContext)
        {
            _shopsContext = shopsContext;
        }

        public async Task<List<FileContent>> getImages(List<int> ids)
        {

            List<FileContent> fileContents = await _shopsContext.FileContents.Where(x=>ids.Contains(x.FileId)).ToListAsync();

            return fileContents;
        }
    }
}
