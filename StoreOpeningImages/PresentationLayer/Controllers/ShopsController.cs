using BusinessLogicLayer.Models.Response;
using BusinessLogicLayer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopsController : ControllerBase
    {
        private readonly IShopsService _shopsService;

        public ShopsController(IShopsService shopsService)
        {
            _shopsService = shopsService;
        }

        [HttpGet("getImages")]
        public async Task<FileContentResponseModel> getImages([FromQuery] int shopId)
        {
            FileContentResponseModel fileContentResponseModel = await _shopsService.getImages(shopId);

            return fileContentResponseModel;
        }
    }
}
