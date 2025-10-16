using Microsoft.AspNetCore.Mvc;

namespace BlazorVideoPreviewForSyncfusionFileUpload.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        [HttpPost("[action]")]
        public async Task<IActionResult> Save(IFormFile UploadFiles) // Save the uploaded file here
        {
            // Your file saving logic here!
            return Ok();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Remove(IFormFile UploadFiles) // Delete the uploaded file here
        {
            // Your file deleting logic here!
            return Ok();
        }
    }
}
