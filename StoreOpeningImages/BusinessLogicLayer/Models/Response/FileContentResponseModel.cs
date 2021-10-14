using System.Collections.Generic;

namespace BusinessLogicLayer.Models.Response
{
    public class FileContentResponseModel
    {
        public List<FileContentModel> fileContentModels { get; set; }
        public int Status { get; set; }
        public string Message { get; set; }

        public FileContentResponseModel()
        {
            fileContentModels = new List<FileContentModel>();
        }
    }
}
