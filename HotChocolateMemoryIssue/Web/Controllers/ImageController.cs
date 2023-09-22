using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers;

[ApiController]
[Route("[controller]")]
public class ImageController : ControllerBase
{
    public ActionResult Get()
    {
        return Ok(new 
        {
            Image = ImageService.GetImage()
        });
    }
}