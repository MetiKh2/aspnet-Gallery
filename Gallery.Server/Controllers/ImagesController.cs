using Microsoft.AspNetCore.Mvc;

namespace Gallery.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ImagesController : ControllerBase
    {
        

        [HttpGet]
        public IActionResult GetImages()
        {
            string domain = "https://localhost:7029/";
            List<string> result=new List<string>();
            string[] filePaths = Directory
                .GetFiles(Path
                .Combine(Directory
                .GetCurrentDirectory(), "wwwroot"));
            foreach (string file in filePaths)
                result.Add(domain+Path.GetFileName(file));
            return Ok(result);
        }
    }
}