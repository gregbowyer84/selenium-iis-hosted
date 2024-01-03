using Microsoft.AspNetCore.Mvc;

namespace iis_hosted.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        [Obsolete]
        public IActionResult Index()
        {
            return Redirect("~/swagger");
        }
    }
}
