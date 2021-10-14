using AutoMapper;
using BusinessLogicLayer.Models;
using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using DataAccessLayer.Entities.Shops;
using DataAccessLayer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class ShopsService : IShopsService
    {
        private readonly IFoldersRepository _foldersRepository;
        private readonly IMediaFoldersRepository _mediaFoldersRepository;
        private readonly IFilesRepository _filesRepository;
        private readonly IFileContentsRepository _fileContentsRepository;

        private readonly IMapper _mapper;

        public ShopsService(IFoldersRepository foldersRepository, IMediaFoldersRepository mediaFoldersRepository, IFilesRepository filesRepository, IFileContentsRepository fileContentsRepository, IMapper mapper)
        {
            _foldersRepository = foldersRepository;
            _mediaFoldersRepository = mediaFoldersRepository;
            _filesRepository = filesRepository;
            _fileContentsRepository = fileContentsRepository;

            _mapper = mapper;
        }

        public async Task<FileContentResponseModel> getImages(int? shopId)
        {
            FileContentResponseModel fileContentResponseModel = new FileContentResponseModel();

            if (shopId == null)
            {
                fileContentResponseModel.Status = 1;
                fileContentResponseModel.Message = $"ShopId = null";
                return fileContentResponseModel;
            }

            int? folderId = await _foldersRepository.getId();

            if (folderId == null)
            {
                fileContentResponseModel.Status = 2;
                fileContentResponseModel.Message = $"FolderId = null";
                return fileContentResponseModel;
            }

            int? mediaFolderId = await _mediaFoldersRepository.getId(shopId, folderId);

            if (mediaFolderId == null)
            {
                fileContentResponseModel.Status = 3;
                fileContentResponseModel.Message = $"MediaFolderId = null";
                return fileContentResponseModel;
            }

            List<int> filesIds = await _filesRepository.getIds(mediaFolderId);

            if (filesIds.Count == 0)
            {
                fileContentResponseModel.Status = 4;
                fileContentResponseModel.Message = $"Count filesIds = zero";
                return fileContentResponseModel;
            }

            List<FileContent> fileContents = await _fileContentsRepository.getImages(filesIds);

            fileContentResponseModel.fileContentModels = _mapper.Map<List<FileContent>, List<FileContentModel>>(fileContents);
            fileContentResponseModel.Status = 0;
            fileContentResponseModel.Message = $"Successfully get {fileContentResponseModel.fileContentModels.Count} images";

            return fileContentResponseModel;
        }
    }
}
