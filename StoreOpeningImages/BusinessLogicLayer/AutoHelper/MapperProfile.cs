using AutoMapper;
using BusinessLogicLayer.Models;
using DataAccessLayer.Entities.Shops;

namespace BusinessLogicLayer.AutoHelper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<FileContent, FileContentModel>();
        }
    }
}
